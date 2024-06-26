﻿// Universidade Aberta
// Licenciatura em Engenharia Informática
// Laboratório de Desenvolvimento de Software
// Projeto: GesEscala
// Grupo: 15 - ByteBrigade (Ricardo Sanches, Marco Martinho, Marcelo Bregieira, António Vieira, José Campos)

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GesEscala_LDS15
{

    // Classe Model - Responsável por gerir os dados e a implementação das funções

    public class Model
    {
        private View view;

        // Lista de funcionarios, de funcionarios escalados e dos servicos
        List<Funcionario> listaFuncionarios;
        List<Dictionary<string, object>> listaEscalados;
        List<Servico> listaServicos;

        // Definição de eventos para comunicação com a View
        public event Action<string> ConfiguracaoInicialSaved;
        public event Action<string> DadosMesUpdated;
        public event Action<string> DiaSelecionadoUpdated;
        public event Action<string> ServicoSelecionadoUpdated;
        public event Action<string> EscalaPDFGenerated;
        public delegate void NotificarListaDeFuncionariosAlterada();
        public event NotificarListaDeFuncionariosAlterada ListaDeFuncionariosAlterada;


        // Referência para a View
        private SQLiteConnection conn;

        // Construtor que recebe a View
        public Model(View v)
        {
            view = v;
            conn = CriarLigacaoSqlite();
            listaEscalados = new List<Dictionary<string, object>>();
            listaFuncionarios = new List<Funcionario>();
            listaServicos = new List<Servico>();
        }

        // Método para saber se a base de dados está vazia
        public bool IsDatabaseEmpty()
        {
            try
            {
                // Base de dados vazia significa não ter funcionários registados
                string query = "SELECT COUNT(*) FROM Funcionarios";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count == 0;
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao verificar se a base de dados está vazia: {ex.Message}");
                return false; // Retorna false para indicar que não está vazia por causa do erro
            }
        }

        // Método para ler a lista de funcionarios da base de dados
        public void GetListaFuncionarios(ref List<Funcionario> listaFuncionarios)
        {

            listaFuncionarios = new List<Funcionario>();
            try
            {
                string query = "SELECT * FROM Funcionarios";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcionario funcionario = new Funcionario
                            {
                                ID = Convert.ToInt32(reader["id_funcionario"]),
                                Numero = Convert.ToInt32(reader["numero_funcionario"]),
                                Nome = reader["nome_funcionario"].ToString(),
                                Apelido = reader["apelido_funcionario"].ToString(),
                                Morada = reader["morada_funcionario"].ToString(),
                                Contacto = Convert.ToInt32(reader["contacto_funcionario"])
                            };
                            listaFuncionarios.Add(funcionario);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Exceção
                MessageBox.Show("Problema GetListaFuncionarios" + ex.Message);
            }
        }

        //Remover utilizador pelo ID
        public void GerarPdfFuncionarios()
        {
            try
            {
                // Inicializar a lista de funcionários
                List<Funcionario> listaFuncionarios = new List<Funcionario>();

                // Chamar GetListaFuncionarios para preencher a lista
                GetListaFuncionarios(ref listaFuncionarios);

                // Verificar se a lista foi preenchida corretamente
                if (listaFuncionarios.Count > 0)
                {
                    // Iniciar a geração do PDF com a lista preenchida
                    IGeradorRelatorio geradorRelatorio = new GeradorRelatorioPDF();
                    EscalaPDF escalaPDF = new EscalaPDF(geradorRelatorio, this);
                    escalaPDF.GerarRelatorioFuncionarios(listaFuncionarios);
                }
                else
                {
                    // Se a lista estiver vazia, mostrar uma mensagem
                   MessageBox.Show("A lista de funcionários está vazia.");
                }
            }
            // Lidar com a exceção
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF de funcionários: " + ex.Message);
            }
        }

        // Método para gerar PDF de servicos
        public void GerarPdfServicos()
        {
            try
            {
                // Cria um objeto GeradorRelatorioPDF e um objeto EscalaPDF
                IGeradorRelatorio geradorRelatorio = new GeradorRelatorioPDF();
                EscalaPDF escalaPDF = new EscalaPDF(geradorRelatorio, this);
                escalaPDF.GerarRelatorioServicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF de serviços: " + ex.Message);
            }
        }

        // Método para gerar PDF de escala
        public void GerarEscala(string data)
        {
            try
            {
                // Verificar se a data está no formato correto
                DateTime dataSelecionada = DateTime.ParseExact(data, "dd/MM/yyyy", null);

                // Inicializar a escala diaria
                EscalaDeServicoDiaria escalaDiaria =null;
                    GetEscalaDiaria(ref escalaDiaria, dataSelecionada);

                    // Se a escala esta preenchida corretamente
                    if (escalaDiaria != null && escalaDiaria.ServicosComFuncionarios.Count > 0)
                    {
                        // Iniciar a geração do PDF com a escala diária
                    IGeradorRelatorio geradorRelatorio = new GeradorRelatorioPDF();
                    EscalaPDF escalaPDF = new EscalaPDF(geradorRelatorio, this);
                    escalaPDF.GerarRelatorioEscala(ref escalaDiaria);
                }
                    // Se nao tem funcionarios: 
                    else
                    {
                        MessageBox.Show("Nenhum serviço ou funcionário encontrado para a data especificada.");
                    }
                }
                // Lidar com a exceção
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar PDF da escala: " + ex.Message);
                }

        }

        // Método para remover funcionario pelo ID
        public void RemoverFuncionarioPorID(int idFuncionario)
        {
            try
            {
                string query = "DELETE FROM Funcionarios WHERE id_funcionario = @idFuncionario";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Funcionário removido com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum funcionário encontrado com o ID fornecido.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Lida com a exceção
                MessageBox.Show("Problema ao remover funcionário: " + ex.Message);
            }
        }

        // Método para verificar se o funcionario existe
        public bool FuncionarioExiste(int numeroFuncionario)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Funcionarios WHERE numero_funcionario = @numeroFuncionario";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@numeroFuncionario", numeroFuncionario);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar funcionário: " + ex.Message);
                return false;
            }
        }

        //Obter listas do serviço
        public void GetListaServicos(ref List<Servico> listaServicos)
        {
            listaServicos = new List<Servico>();
            try
            {
                string query = "SELECT * FROM Servicos";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Servico servico = new Servico
                            {
                                ID = Convert.ToInt32(reader["id_servico"]),
                                Nome = reader["nome"].ToString(),
                                Descricao = reader["descricao"].ToString(),
                                Sigla = reader["sigla_servico"].ToString(),
                                HoraInicio = reader["hora_inicio"].ToString(),
                                HoraFim = reader["hora_fim"].ToString(),
                            };
                            listaServicos.Add(servico);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Lida com a exceção
                MessageBox.Show("Problema GetListaServicos" + ex.Message);
            }
        }

        // Método para adicionar funcionario ao dia selecionado
        public void AdicionarEscala(List<(Servico, Funcionario)> escala, DateTime data)
        {
            try
            {
                using (var transaction = conn.BeginTransaction())
                {
                    string insertEscala = "INSERT INTO Escalas (Data) VALUES (@Data); SELECT last_insert_rowid();";
                    long escalaId;

                    using (var command = new SQLiteCommand(insertEscala, conn, transaction))
                    {
                        command.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));
                        escalaId = (long)command.ExecuteScalar();
                    }

                    foreach (var item in escala)
                    {
                        string insertEscalaServico = "INSERT INTO EscalaServicos (EscalaId, ServicoId) VALUES (@EscalaId, @ServicoId); SELECT last_insert_rowid();";
                        long escalaServicoId;

                        using (var command = new SQLiteCommand(insertEscalaServico, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@EscalaId", escalaId);
                            command.Parameters.AddWithValue("@ServicoId", item.Item1.ID);
                            escalaServicoId = (long)command.ExecuteScalar();
                        }

                        string insertServicoFuncionario = "INSERT INTO ServicoFuncionarios (EscalaServicoId, FuncionarioId) VALUES (@EscalaServicoId, @FuncionarioId)";

                        using (var command = new SQLiteCommand(insertServicoFuncionario, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@EscalaServicoId", escalaServicoId);
                            command.Parameters.AddWithValue("@FuncionarioId", item.Item2.ID);
                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                MessageBox.Show("Escala inserida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar escala: " + ex.Message);
            }
        }

        // Método para adicionar funcionario ao nosso sistema
        public void AdicionarFuncionario(Funcionario novoFuncionario)
        {
            if (FuncionarioExiste(novoFuncionario.Numero))
            {
                MessageBox.Show("Já existe um funcionário com este número.");
                return;
            }
            try
            {
                string sqlInsert = "INSERT INTO Funcionarios (numero_funcionario, nome_funcionario, " +
                                   "apelido_funcionario, morada_funcionario, contacto_funcionario) VALUES " +
                                   "(@Numero, @Nome, @Apelido, @Morada, @Contacto)";
                SQLiteCommand sqlite_cmd = new SQLiteCommand(sqlInsert, conn);
                sqlite_cmd.Parameters.AddWithValue("@Numero", Convert.ToInt32(novoFuncionario.Numero));
                sqlite_cmd.Parameters.AddWithValue("@Nome", novoFuncionario.Nome.ToString());
                sqlite_cmd.Parameters.AddWithValue("@Apelido", novoFuncionario.Apelido.ToString());
                sqlite_cmd.Parameters.AddWithValue("@Morada", novoFuncionario.Morada.ToString());
                sqlite_cmd.Parameters.AddWithValue("@Contacto", Convert.ToInt32(novoFuncionario.Contacto));

                sqlite_cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Método para criar a ligação à base de dados
        static SQLiteConnection CriarLigacaoSqlite()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source = database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao abrir a conexão com o banco de dados: {ex.Message}");
            }
            return sqlite_conn;
        }

        // Método para obter a escala do dia
        public void GetEscalaDiaria(ref EscalaDeServicoDiaria escala, DateTime data)
        {
            escala = new EscalaDeServicoDiaria { Data = data };

                string query = @"
                SELECT e.Data, s.id_servico AS ServicoId, s.nome AS ServicoNome, s.descricao, s.sigla_servico, s.hora_inicio, s.hora_fim,
                       f.id_funcionario AS FuncionarioId, f.numero_funcionario, f.nome_funcionario, f.apelido_funcionario, f.morada_funcionario, f.contacto_funcionario
                FROM Escalas e
                JOIN EscalaServicos es ON e.EscalaId = es.EscalaId
                JOIN Servicos s ON es.ServicoId = s.id_servico
                JOIN ServicoFuncionarios sf ON es.EscalaServicoId = sf.EscalaServicoId
                JOIN Funcionarios f ON sf.FuncionarioId = f.id_funcionario
                WHERE e.Data = @Data
                ORDER BY s.id_servico, f.id_funcionario";

                using (var command = new SQLiteCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));

                    using (var reader = command.ExecuteReader())
                    {
                        int servicoIdAtual = -1;
                        ServicoComFuncionarios servicoComFuncionariosAtual = null;

                        while (reader.Read())
                        {
                            int servicoId = int.Parse(reader["ServicoId"].ToString());
                            string servicoNome = reader["ServicoNome"].ToString();
                            string descricaoServico = reader["descricao"].ToString();
                            string sigla = reader["sigla_servico"].ToString();
                            string horaInicio = reader["hora_inicio"].ToString();
                            string horaFim = reader["hora_fim"].ToString();
                            int funcionarioId = int.Parse(reader["FuncionarioId"].ToString());
                            int numeroFuncionario = int.Parse(reader["numero_funcionario"].ToString());
                            string nomeFuncionario = reader["nome_funcionario"].ToString();
                            string apelidoFuncionario = reader["apelido_funcionario"] != DBNull.Value ? reader["apelido_funcionario"].ToString() : null;
                            string moradaFuncionario = reader["morada_funcionario"] != DBNull.Value ? reader["morada_funcionario"].ToString() : null;
                            int? contactoFuncionario = reader["contacto_funcionario"] != DBNull.Value ? (int?)int.Parse(reader["contacto_funcionario"].ToString()) : null;

                            if (servicoIdAtual != servicoId)
                            {
                                var servico = new Servico
                                {
                                    ID = servicoId,
                                    Nome = servicoNome,
                                    Descricao = descricaoServico,
                                    Sigla = sigla,
                                    HoraInicio = horaInicio,
                                    HoraFim = horaFim
                                };
                                servicoComFuncionariosAtual = new ServicoComFuncionarios(servico);
                                escala.ServicosComFuncionarios.Add(servicoComFuncionariosAtual);
                                servicoIdAtual = servicoId;
                            }

                            var funcionario = new Funcionario
                            {
                                ID = funcionarioId,
                                Numero = numeroFuncionario,
                                Nome = nomeFuncionario,
                                Apelido = apelidoFuncionario,
                                Morada = moradaFuncionario,
                                Contacto = contactoFuncionario
                            };
                            servicoComFuncionariosAtual.Funcionarios.Add(funcionario);
                        }
                    }
                }
        }

        // Método para converter string em DateTime
        public static DateTime ConvertToDateTime(string str)
        {
            string pattern = @"(\d{4})-(\d{2})-(\d{2}) (\d{2}):(\d{2}):(\d{2})\.(\d{3})";
            if (Regex.IsMatch(str, pattern))
            {
                Match match = Regex.Match(str, pattern);
                int year = Convert.ToInt32(match.Groups[1].Value);
                int month = Convert.ToInt32(match.Groups[2].Value);
                int day = Convert.ToInt32(match.Groups[3].Value);
                int hour = Convert.ToInt32(match.Groups[4].Value);
                int minute = Convert.ToInt32(match.Groups[5].Value);
                int second = Convert.ToInt32(match.Groups[6].Value);
                int millisecond = Convert.ToInt32(match.Groups[7].Value);
                return new DateTime(year, month, day, hour, minute, second, millisecond);
            }
            else
            {
                throw new Exception("Unable to parse.");
            }
        }

        // Método para adicionar serviço ao nosso sistema
        public void AdicionarServico(Servico novoServico)
        {
            try
            {
                string sqlInsert = "INSERT INTO Servicos (nome, descricao, sigla_servico, hora_inicio, hora_fim) VALUES " +
                                   "(@Nome, @Descricao, @Sigla, @HoraInicio, @HoraFim)";
                SQLiteCommand sqlite_cmd = new SQLiteCommand(sqlInsert, conn);
                sqlite_cmd.Parameters.AddWithValue("@Nome", novoServico.Nome);
                sqlite_cmd.Parameters.AddWithValue("@Descricao", novoServico.Descricao);
                sqlite_cmd.Parameters.AddWithValue("@Sigla", novoServico.Sigla);
                sqlite_cmd.Parameters.AddWithValue("@HoraInicio", novoServico.HoraInicio);
                sqlite_cmd.Parameters.AddWithValue("@HoraFim", novoServico.HoraFim);

                sqlite_cmd.ExecuteNonQuery();
                MessageBox.Show("Serviço adicionado com sucesso.");

                // Atualiza a lista de serviços na memória
                GetListaServicos(ref listaServicos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar serviço: " + ex.Message);
            }
        }

        // Método para remover serviço pelo ID
        public void RemoverServicoPorID(int idServico)
        {
            try
            {
                string query = "DELETE FROM Servicos WHERE id_servico = @idServico";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@idServico", idServico);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Serviço removido com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum serviço encontrado com o ID fornecido.");
                    }
                }

                // Atualiza a lista de serviços na memória
                GetListaServicos(ref listaServicos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover serviço: " + ex.Message);
            }
        }
    }
}

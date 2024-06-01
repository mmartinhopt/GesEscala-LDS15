﻿using System;
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
    public class Model
    {
        private View view;

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

            // CriarTabelas(conn);
        }


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
                // TODO Lidar com a exceção
                MessageBox.Show("Problema GetListaFuncionarios" + ex.Message);
            }

            //listaFuncionarios = funcionarios;
            // Notifica que a lista foi alterada.
            //ListaDeFuncionariosAlterada();
        }
        //Remover utilizador pelo ID
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
                // TODO Lidar com a exceção
                MessageBox.Show("Problema ao remover funcionário: " + ex.Message);
            }
        }

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
                // TODO Lidar com a exceção
                MessageBox.Show("Problema GetListaServicos" + ex.Message);
            }

            //listaFuncionarios = funcionarios;
            // Notifica que a lista foi alterada.
            //ListaDeFuncionariosAlterada();
        }

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

        //Convert TIME SQlite para DateTime C#
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
    }
}

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
                
                   MessageBox.Show("A lista de funcionários está vazia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF de funcionários: " + ex.Message);
            }
        }



        public void GerarPdfServicos()
        {
            try
            {
                IGeradorRelatorio geradorRelatorio = new GeradorRelatorioPDF();
                EscalaPDF escalaPDF = new EscalaPDF(geradorRelatorio, this);

                escalaPDF.GerarRelatorioServicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF de serviços: " + ex.Message);
            }
        }

        public void GerarPdfEscala(string data)
        {
            try
            {
                IGeradorRelatorio geradorRelatorio = new GeradorRelatorioPDF();
                EscalaPDF escalaPDF = new EscalaPDF(geradorRelatorio, this);

                escalaPDF.GerarRelatorioEscala(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF da escala: " + ex.Message);
            }
        }


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

        public List<Dictionary<string, object>> GetEscalados(string data)
        {

            List<Dictionary<string, object>> escalados = new List<Dictionary<string, object>>();
            try
            {
                string query = "SELECT s.nome AS Nome_Servico,\r\n" +
                    "GROUP_CONCAT(DISTINCT s.hora_inicio || '-' || s.hora_fim) AS Horario,\r\n" +
                    "(SELECT GROUP_CONCAT(f.nome_funcionario, ', ')\r\n" +
                    "FROM Funcionarios f\r\n        JOIN Escala e2 ON f.id_funcionario = e2.id_funcionario\r\n" +
                    "WHERE e2.id_servico = s.id_servico AND e2.dia_escala =" + data + ") AS Funcionarios\r\n" +
                    "FROM Escala e\r\nJOIN Servicos s ON e.id_servico = s.id_servico\r\nWHERE e.dia_escala =" + data + "\r\n" +
                    "GROUP BY s.nome;";

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Cria um dicionário para armazenar os dados de cada funcionário
                            Dictionary<string, object> escalado = new Dictionary<string, object>();
                            escalado["Nome_Servico"] = reader["Nome_Servico"].ToString();
                            escalado["Horario"] = reader["Horario"].ToString();
                            escalado["Funcionarios"] = reader["Funcionarios"].ToString();
                            // Adiciona o dicionário à lista de funcionários
                            escalados.Add(escalado);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao recuperar funcionários: {ex.Message}");
            }
            return escalados;
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


        public void PreencherServicosPadrao()
        {
            try
            {
                // Verifica se já existem registos para não inserir duplicados
                string checkQuery = "SELECT COUNT(*) FROM Servicos";
                SQLiteCommand checkCommand = new SQLiteCommand(checkQuery, conn);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count == 0) // Apenas insere se ainda não há serviços
                {
                    List<Tuple<string, string, string, string>> servicos = new List<Tuple<string, string, string, string>>
                    {
                        Tuple.Create("DS", "Descanso Semanal", "00:00", "23:59"),
                        Tuple.Create("LF", "Licença Férias", "00:00", "23:59"),
                        Tuple.Create("C", "Baixa Médica", "00:00", "23:59")
                    };

                    foreach (var servico in servicos)
                    {
                        string sqlInsert = "INSERT INTO Servicos (sigla_servico, nome, hora_inicio, hora_fim) VALUES (@Sigla, @Nome, @Inicio, @Fim)";
                        SQLiteCommand sqlite_cmd = new SQLiteCommand(sqlInsert, conn);
                        sqlite_cmd.Parameters.AddWithValue("@Sigla", servico.Item1);
                        sqlite_cmd.Parameters.AddWithValue("@Nome", servico.Item2);
                        sqlite_cmd.Parameters.AddWithValue("@Inicio", servico.Item3);
                        sqlite_cmd.Parameters.AddWithValue("@Fim", servico.Item4);
                        sqlite_cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao preencher serviços padrão: {ex.Message}");
            }
        }

        // Geração da base de dados
        public void CriarTabelas(SQLiteConnection conn)
        {
            try
            {
                SQLiteCommand sqlite_cmd;
                string sqlFuncionarios = "CREATE TABLE IF NOT EXISTS \"Funcionarios\" " +
                    "(\r\n\t\"id_funcionario\"\tINTEGER NOT NULL," +
                    "\r\n\t\"numero_funcionario\"\tINTEGER NOT NULL," +
                    "\r\n\t\"nome_funcionario\"\tTEXT NOT NULL," +
                    "\r\n\t\"morada_funcionario\"\tTEXT," +
                    "\r\n\t\"contacto_funcionario\"\tINTEGER," +
                    "\r\n\tPRIMARY KEY(\"id_funcionario\" AUTOINCREMENT)\r\n)";


                string sqlServicos = "CREATE TABLE IF NOT EXISTS \"Servicos\" " +
                    "(\r\n\t\"id_servico\"\tINTEGER NOT NULL," +
                    "\r\n\t\"nome\"\tTEXT NOT NULL," +
                    "\r\n\t\"sigla_servico\"\tTEXT NOT NULL," +
                    "\r\n\t\"hora_inicio\"\tTIME NOT NULL," +
                    "\r\n\t\"hora_fim\"\tTIME NOT NULL," +
                    "\r\n\tPRIMARY KEY(\"id_servico\" AUTOINCREMENT)\r\n)";

                string sqlEscala = "CREATE TABLE IF NOT EXISTS \"Escala\" " +
                    "(\r\n\t\"id_escala\"\tINTEGER NOT NULL," +
                    "\r\n\t\"id_funcionario\"\tINTEGER NOT NULL," +
                    "\r\n\t\"id_servico\"\tINTEGER NOT NULL," +
                    "\r\n\tFOREIGN KEY(\"id_servico\") REFERENCES \"Servicos\"(\"id_servico\")," +
                    "\r\n\tFOREIGN KEY(\"id_funcionario\") REFERENCES \"Funcionarios\"(\"id_funcionario\")," +
                    "\r\n\tPRIMARY KEY(\"id_escala\" AUTOINCREMENT)\r\n)";

                string sqlSeccao = "CREATE TABLE IF NOT EXISTS \"Seccao\" " +
                    "(\r\n\t\"id_seccao\"\tINTEGER NOT NULL," +
                    "\r\n\t\"nome_seccao\"\tTEXT NOT NULL," +
                    "\r\n\tPRIMARY KEY(\"id_seccao\" AUTOINCREMENT)\r\n)";

                sqlite_cmd = conn.CreateCommand();

                sqlite_cmd.CommandText = sqlFuncionarios;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = sqlServicos;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = sqlEscala;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = sqlSeccao;
                sqlite_cmd.ExecuteNonQuery();

                PreencherServicosPadrao();
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao criar tabelas: {ex.Message}");
            }
        }

        public void ReceberConfiguracaoInicial()
        {
            // Guarda a configuração inicial
            ConfiguracaoInicialSaved?.Invoke("Configuração inicial armazenada com sucesso");
        }

        public void GuardarNomeSeccao(string nomeSecao)
        {
            try
            {
                // Guarda o nome da secção
                string query = "INSERT INTO Seccao (nome_seccao) VALUES (@nomeSecao)";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@nomeSecao", nomeSecao);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao guardar o nome da secção: {ex.Message}");
            }
        }

        public void ReceberDadosMes()
        {
            // Procura os dados do mês selecionado
            DadosMesUpdated?.Invoke("Dados do mês atualizados");
        }

        public void ReceberDiaSelecionado()
        {
            // Calcula os mais atrasados para o serviço
            DiaSelecionadoUpdated?.Invoke("Dia selecionado atualizado");
        }

        public void ReceberServicoSelecionado()
        {
            // Verifica se o serviço selecionado é válido
            ServicoSelecionadoUpdated?.Invoke("Serviço selecionado verificado");
        }

        public void ReceberGerarPDF()
        {
            // Gera o PDF da escala
            EscalaPDFGenerated?.Invoke("PDF gerado com sucesso");
        }
    }
}

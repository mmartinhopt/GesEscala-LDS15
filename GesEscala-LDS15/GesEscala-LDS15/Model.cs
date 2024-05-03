﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GesEscala_LDS15
{
    public class Model
    {
        // Definição de eventos para comunicação com a View
        public event Action<string> ConfiguracaoInicialSaved;
        public event Action<string> DadosMesUpdated;
        public event Action<string> DiaSelecionadoUpdated;
        public event Action<string> ServicoSelecionadoUpdated;
        public event Action<string> EscalaPDFGenerated;

        // Referência para a View
        private SQLiteConnection conn;

        // Construtor que recebe a View
        public Model()
        {
           
            conn = CriarLigacaoSqlite();
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

        public List<Dictionary<string, object>> GetFuncionarios()
        {

            List<Dictionary<string, object>> funcionarios = new List<Dictionary<string, object>>();
            try
            {                 
                    string query = "SELECT * FROM Funcionarios";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Cria um dicionário para armazenar os dados de cada funcionário
                                Dictionary<string, object> funcionario = new Dictionary<string, object>();
                                funcionario["Id"] = Convert.ToInt32(reader["id_funcionario"]);
                                funcionario["Numero"] = Convert.ToInt32(reader["numero_funcionario"]);
                                funcionario["Nome"] = reader["nome_funcionario"].ToString();
                                funcionario["Morada"] = reader["morada_funcionario"].ToString();
                                funcionario["Contacto"] = Convert.ToInt32(reader["contacto_funcionario"]);
                                // Adiciona o dicionário à lista de funcionários
                                funcionarios.Add(funcionario);
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao recuperar funcionários: {ex.Message}");
            }
            return funcionarios;
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

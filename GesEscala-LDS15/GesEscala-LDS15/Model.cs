using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private View view;
        private SQLiteConnection conn;

        // Construtor que recebe a View
        public Model(View v)
        {
            view = v;
            conn = null;
            conn = CriarLigacaoSqlite();
            CriarTabelas(conn);
        }

        public bool IsDatabaseEmpty()
        {
            // Suponha que uma base de dados vazia significa não ter funcionários registrados
            string query = "SELECT COUNT(*) FROM Funcionarios";
            SQLiteCommand command = new SQLiteCommand(query, conn);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count == 0;
        }

        public void VerificarConfiguracao()
        {

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
                MessageBox.Show(ex.Message);
            }
            return sqlite_conn;
        }

        static void CriarTabelas(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string sqlFuncionarios = "CREATE TABLE IF NOT EXISTS \"Funcionarios\" " +
                "(\r\n\t\"id_funcionario\"\tINTEGER NOT NULL," +
                "\r\n\t\"numero_funcionario\"\tINTEGER NOT NULL," +
                "\r\n\t\"nome_funcionario\"\tTEXT NOT NULL," +
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

            try
            {
                sqlite_cmd = conn.CreateCommand();

                sqlite_cmd.CommandText = sqlFuncionarios;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = sqlServicos;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = sqlEscala;
                sqlite_cmd.ExecuteNonQuery();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        public void ReceberConfiguracaoInicial()
        {
            // Guarda a configuração inicial
            ConfiguracaoInicialSaved?.Invoke("Configuração inicial armazenada com sucesso");
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

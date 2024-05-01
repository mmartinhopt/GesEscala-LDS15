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

        // Construtor que recebe a View
        public Model(View v)
        {
            view = v;
            SQLiteConnection con = null;
            con = CriarLigacaoSqlite();
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

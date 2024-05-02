using System.Windows.Forms;

namespace GesEscala_LDS15
{
    class Controller
    {
        Model model;
        View view;
        bool sair;

        // Construtor que cria a View e o Model
        public Controller()
        {
            sair = false;
            model = new Model(view);
            view = new View(model);
        }

        // M�todo para iniciar o programa
        public void IniciarPrograma()
        {
            try
            {
                if (model.IsDatabaseEmpty())
                {
                    // Mostra a janela de configura��o inicial
                    view.MostrarMenuConfiguracaoInicial();
                }
                else
                {
                    // Mostra as op��es de alterar configura��o ou escalar
                    view.MostrarOpcoesConfiguracao();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void VerificarConfiguracaoInicial()
        {
            model.VerificarConfiguracao();
        }

        // M�todos para intera��o com o Model
        public void RegistarConfiguracaoInicial()
        {
            model.ReceberConfiguracaoInicial();
        }

        public void BuscarDadosMes()
        {
            model.ReceberDadosMes();
        }

        public void CalcularAtrasados()
        {
            model.ReceberDiaSelecionado();
        }

        public void VerificarEscala()
        {
            model.ReceberServicoSelecionado();
        }

        public void GerarPDF()
        {
            model.ReceberGerarPDF();
        }

        public void EncerrarPrograma()
        {
            sair = true;
            view.Encerrar();
        }
    }
}
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

        // Método para iniciar o programa
        public void IniciarPrograma()
        {
            try
            {
                view.AtivarInterface();
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

        // Métodos para interação com o Model
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
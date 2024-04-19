namespace GesEscala_LDS15
{
    class Controller
    {
        Model model;
        View view;
        //ModelLog modelLog;
        bool sair;

        public Controller()
        {
            sair = false;
            view = new View(model);
            //model = new Model(view);
        }

        public void IniciarPrograma()
        {
            try
            {
                view.AtivarInterface();
            }
            catch (Exception ex)
            {
                //Mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        public void EncerrarPrograma()
        {
            sair = true;
            view.Encerrar();
        }


        // Envia a configura��o inicial para o model para ser guardada
        public void RegistarConfiguracaoInicial()
        {
            model.ReceberConfiguracaoInicial();
            model.EnviarConfiguracaoInicial();
        }

        // Vai � base de dados buscar os dados do m�s selecionado (dias, servi�os j� escalados, etc)
        public void BuscarDadosMes()
        {
            model.ReceberDadosMes();
            model.EnviarDadosMes();
        }

        // Calcula os mais atrasados para o servi�o selecionado
        public void CalcularAtrasados()
        {
            model.ReceberDiaSelecionado();
            model.EnviarDiaSelecionado();
        }

        // Verfica se o servi�o pode ser escalado (Se tem 8 horas de intervalo, se n�o h� servi�o sobreposto, etc)
        public void VerificarEscala()
        {
            model.ReceberServicoSelecionado();
            model.EnviarServicoSelecionado();
        }

        // Gera PDF com a escala do m�s
        public void GerarPDF()
        {
            model.ReceberGerarPDF();
        }
    }
}
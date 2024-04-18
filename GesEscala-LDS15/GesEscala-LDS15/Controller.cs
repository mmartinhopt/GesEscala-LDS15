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

            /*
            //Exemplo de duas formas alternativas de fazer.
            //Para maior qualidade de homogeneidade, devia ser feito apenas
            //de uma desta formas.
            //No caso da View, considera-se que a organização interna em 
            //janelas diferentes, em classes diferentes, é uma precupação interna.
            //e por isso tudo se processa através da classe View, que é uma "façade"
            //para o componente. Por isso não existe aquim um "viewLog".
            //No caso do Model, estamos a expor a estrutura interna ao Controller.
            //Ao fazê-lo, a classe Model fica mais pequena, mas isto origina maiores dependências,
            //entre componentes, logo maior acoplamento. Mas pode ser uma solução
            //de compromisso para algumas situações.
            modelLog = new ModelLog();
            model.ModelLog = modelLog;

            //Ligar os eventos da View aos métodos do Controller e do Model, de foram desacoplada
            //porque a View não sabe quem responderá aos eventos.
            //O mesmo é feito para os eventos do Model
            view.UtilizadorClicouEmNovaForma += UtilizadorClicouEmNovaForma;
            view.UtilizadorClicouEmSair += UtilizadorClicouEmSair;
            view.PrecisoDeFormas += model.SolicitarListaFormas;
            model.ListaDeFormasAlteradas += view.AtualizarListaDeFormas;
            view.PrecisoDeLog += modelLog.SolicitarLog;
            modelLog.NotificarLogAlterado += view.NotificacaoDeLogAlterado;
            */
        }

        public void IniciarPrograma()
        {
            do
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
            } while (!sair);
            //Na verdade, nunca se chega aqui (a saída é feita noutro local)
            //mas é mais elegante do que while(true) e permite que, se necessário
            //se possa sair por aqui caso não se possa sair pelo fecho da FormMain.
            //Pode suceder tal coisa, por exemplo, devido a uma exceção que atire a execução
            //para aqui.
        }
        
        /*

       
        */
    }
}
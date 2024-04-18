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
            //No caso da View, considera-se que a organiza��o interna em 
            //janelas diferentes, em classes diferentes, � uma precupa��o interna.
            //e por isso tudo se processa atrav�s da classe View, que � uma "fa�ade"
            //para o componente. Por isso n�o existe aquim um "viewLog".
            //No caso do Model, estamos a expor a estrutura interna ao Controller.
            //Ao faz�-lo, a classe Model fica mais pequena, mas isto origina maiores depend�ncias,
            //entre componentes, logo maior acoplamento. Mas pode ser uma solu��o
            //de compromisso para algumas situa��es.
            modelLog = new ModelLog();
            model.ModelLog = modelLog;

            //Ligar os eventos da View aos m�todos do Controller e do Model, de foram desacoplada
            //porque a View n�o sabe quem responder� aos eventos.
            //O mesmo � feito para os eventos do Model
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
        
        /*

       
        */
    }
}
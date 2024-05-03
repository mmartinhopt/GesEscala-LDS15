using System;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    class Controller
    {
        private Model model;
        private View view;

        // Construtor
        public View View { get => view; }

        public Controller()
        {
            this.model = new Model();
            this.view = new View(model);
        }

        // M�todo para iniciar o programa
        public void IniciarPrograma()
        {
            view.MostrarFormInicial();
        }

        // M�todo para buscar funcion�rios
        public List<Dictionary<string, object>> BuscarFuncionarios()
        {
            return model.GetFuncionarios();
        }

        // M�todo para encerrar o programa
        public void EncerrarPrograma()
        {
            view.Encerrar();
        }
    }
}

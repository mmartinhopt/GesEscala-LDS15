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

        // Método para iniciar o programa
        public void IniciarPrograma()
        {
            view.MostrarFormInicial();
        }

        // Método para buscar funcionários
        public List<Dictionary<string, object>> BuscarFuncionarios()
        {
            return model.GetFuncionarios();
        }

        // Método para encerrar o programa
        public void EncerrarPrograma()
        {
            view.Encerrar();
        }
    }
}

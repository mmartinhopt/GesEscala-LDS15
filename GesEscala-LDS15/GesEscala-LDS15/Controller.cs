using System;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    class Controller
    {
        Model model;
        View view;

        // Construtor
        public Controller()
        {
            view = new View(model);
            model = new Model(view);


            //CONTINUAR DAQUI
            view.EventUserClicouServicos += model.GetListaServicos()

        }

        // Método para iniciar o programa
        public void IniciarPrograma()
        {
            try
            {
                view.IniciarInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // Método para buscar funcionários
        public List<Dictionary<string, object>> BuscarFuncionarios()
        {
            return model.GetFuncionarios();
        }

        // Método para encerrar o programa
        public void EncerrarPrograma()
        {
            //view.Encerrar();
        }
    }
}

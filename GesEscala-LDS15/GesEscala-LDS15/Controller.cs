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


            //view.UserAtivouTabFuncionarios += UserAtivouTabFuncionarios;
            //model.ListaDeFuncionariosAlterada += view.AtualizarListaDeFormas;
            view.PrecisoDeFuncionarios += model.GetListaFuncionarios;

        }

        // M�todo para iniciar o programa
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

        // M�todo para buscar funcion�rios
        /*public List<Dictionary<string, object>> BuscarFuncionarios()
        {
            return model.GetFuncionarios();
        }
        */

        /*
        public void CliqueEmFuncionarios(object sender, System.EventArgs e)
        {
            model.SolicitarListaFuncionarios();
        }
        */

        public void UserAtivouTabFuncionarios(object sender, EventArgs e)
        {
            //model.GetListaFuncionarios();
        }

        // M�todo para encerrar o programa
        public void EncerrarPrograma()
        {
            //view.Encerrar();
        }
    }
}

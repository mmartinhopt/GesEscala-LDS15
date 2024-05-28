using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Text.RegularExpressions;
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

            //Registio dos eventos dos Serviços

            view.PrecisoDeServicos += model.GetListaServicos;


            //Registio dos eventos dos Funcionários
            view.PrecisoDeFuncionarios += model.GetListaFuncionarios;
            view.RegistoNovoFuncionario += RegistoNovoFuncionario;
            //view.UserAtivouTabFuncionarios += UserAtivouTabFuncionarios;
            //model.ListaDeFuncionariosAlterada += view.AtualizarListaDeFormas;
            //model.ListaDeFuncionariosAlterada += view.AtualizarListaFuncionarios;

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

        public void RegistoNovoFuncionario(Funcionario novoFuncionario)
        {
            try
            {
                if (novoFuncionario.Contacto != null && novoFuncionario.Contacto.ToString().Length != 9)
                {
                    throw new Exception("O numero tem de contar exatamente 9 digitos");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            model.AdicionarFuncionario(novoFuncionario);

        }


        public void UserAtivouTabFuncionarios(object sender, EventArgs e)
        {
            //model.GetListaFuncionarios();
        }

        // Método para encerrar o programa
        public void EncerrarPrograma()
        {
            //view.Encerrar();
        }
    }
}

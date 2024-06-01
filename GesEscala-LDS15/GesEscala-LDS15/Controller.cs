using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
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
            view.RemoverFuncionario += RemoverFuncionario;


            //Registio dos eventos das Escalas
            view.PrecisoDeEscalaDiaria += model.GetEscalaDiaria;
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
        //Adicionar novo funcionario � base de dados
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

        //Remover funcionario pelo id unico
        public void RemoverFuncionario(int id_funcionario)
        {
            try
            {
                // Verificar se o ID do funcion�rio � v�lido ( maior que 0)
                if (id_funcionario <= 0)
                {
                    MessageBox.Show("ID de funcion�rio inv�lido. O ID deve ser maior que zero.");
                    return;
                }

                // Tentar remover o funcion�rio pelo ID
                model.RemoverFuncionarioPorID(id_funcionario);
            }
            catch (ArgumentException argEx)
            {
                // argumento inv�lido
                MessageBox.Show("Erro de argumento: " + argEx.Message);
            }
            catch (SQLiteException sqlEx)
            {
                // SQLite
                MessageBox.Show("Erro de banco de dados: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // outra exce��o
                MessageBox.Show("Ocorreu um erro ao tentar remover o funcion�rio: " + ex.Message);
            }
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

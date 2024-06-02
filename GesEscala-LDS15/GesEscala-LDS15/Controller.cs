// Universidade Aberta
// Licenciatura em Engenharia Informática
// Laboratório de Desenvolvimento de Software
// Projeto: GesEscala
// Grupo: 15 - ByteBrigade (Ricardo Sanches, Marco Martinho, Marcelo Bregieira, António Vieira, José Campos)

using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    // Classe Controller - Responsável por intermediar a comunicação entre a View e o Model
    class Controller
    {
        Model model; // Criação de um objeto do tipo Model
        View view; // Criação de um objeto do tipo View

        // Construtor 
        public Controller()
        {
            view = new View(model);
            model = new Model(view);

            //Registo dos eventos dos Serviços
            view.PrecisoDeServicos += model.GetListaServicos;


            //Registio dos eventos dos Funcionários
            view.PrecisoDeFuncionarios += model.GetListaFuncionarios;
            view.RegistoNovoFuncionario += RegistoNovoFuncionario;
            view.RemoverFuncionario += RemoverFuncionario;


            //Registo dos eventos das Escalas
            view.PrecisoDeEscalaDiaria += model.GetEscalaDiaria;
            view.RegistoNovaEscala += model.AdicionarEscala;
            
            //Impressao para PDF
            view.GerarPdfFuncionarios += GerarPdfFuncionarios;
            view.GerarPdfServicos += GerarPdfServicos;
            view.GerarPdfEscala += GerarPdfEscala;

            //Para criar serviço
            view.RegistoNovoServico += RegistoNovoServico;
            view.RemoverServico += RemoverServico;
        }

        // Método para remover serviço - não implementado
        private void View_RemoverServico(int id_servico)
        {
            throw new NotImplementedException();
        }

        // Método para iniciar o programa
        public void IniciarPrograma()
        {
            // Try-Catch para que o programa não pare de funcionar caso ocorra um erro
            try
            {
                view.IniciarInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //Adicionar novo funcionario na base de dados
        public void RegistoNovoFuncionario(Funcionario novoFuncionario)
        {
            // Verificar se o contacto do funcionário é válido (exemplificacao de validacao)
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

        //Adicionar novo servico na base de dados
        private void RegistoNovoServico(Servico novoServico)
        {
            model.AdicionarServico(novoServico);
        }

        //Remover funcionario pelo id unico
        public void RemoverFuncionario(int id_funcionario)
        {
            try
            {
                // Verificar se o ID do funcionario e valido (ou seja, maior que 0)
                if (id_funcionario <= 0)
                {
                    MessageBox.Show("ID de funcion�rio inv�lido. O ID deve ser maior que zero.");
                    return;
                }

                // Tentar remover o funcionario pelo ID
                model.RemoverFuncionarioPorID(id_funcionario);
            }
            catch (ArgumentException argEx)
            {
                // Argumento invalido
                MessageBox.Show("Erro de argumento: " + argEx.Message);
            }
            catch (SQLiteException sqlEx)
            {
                // SQLite
                MessageBox.Show("Erro de banco de dados: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // outra excecao
                MessageBox.Show("Ocorreu um erro ao tentar remover o funcion�rio: " + ex.Message);
            }
        }

        // Método para adicionar escala - não implementado
        public void UserAtivouTabFuncionarios(object sender, EventArgs e)
        {
            //model.GetListaFuncionarios();
            
        }
     
        // Método para gerar PDF de funcionarios
        public void GerarPdfFuncionarios()
        {
            model.GerarPdfFuncionarios(); // Chama o método GerarPdfFuncionarios do Model

        }

        // Método para gerar PDF de serviços
        public void GerarPdfServicos()
        {
            model.GerarPdfServicos(); // Chama o método GerarPdfServicos do Model
        }

        // Método para gerar PDF de escala
        public void GerarPdfEscala(string data)
        {
            model.GerarEscala(data); // Chama o método GerarEscala do Model
        }

        // Remover serviço pelo ID único
        public void RemoverServico(int id_servico)
        {
            model.RemoverServicoPorID(id_servico); // Chama o método RemoverServicoPorID do Model
        }

        // Método para encerrar o programa - não implementado
        public void EncerrarPrograma()
        {
            //view.Encerrar();
        }
    }
}

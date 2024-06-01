using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    internal class GesEscala
    {
        //Ponto de entrada para a aplicação.
        //Aqui é chamada a função IniciarPrograma do Controller()
        [STAThread]
        static void Main()
        {
            //Ativar estilos visuais par uma melhor visualização
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Instanciar o Controller
            Controller controller = new Controller();
            controller.IniciarPrograma();

            // Instanciar a implementação de IGeradorRelatorio
      //      IGeradorRelatorio geradorRelatorio = new GeradorRelatorioPDF();

            // Adicionar um serviço e um funcionário ao PDF - teste
    //        Servico servico1 = new Servico { Sigla = "AT1" };
  //          Funcionario funcionario1 = new Funcionario { Nome = "Bregieira" };
//            escalaPDF.AdicionarServicoFuncionario(servico1, funcionario1);

            // Adicionar um segundo serviço e funcionário ao PDF - teste
           // Servico servico2 = new Servico { Sigla = "AT2" };
         //   Funcionario funcionario2 = new Funcionario { Nome = "Santos" };
         //   escalaPDF.AdicionarServicoFuncionario(servico2, funcionario2);

            // Gerar o relatório
          //  escalaPDF.CriarPDF();

            // Abrir o PDF - teste
           // escalaPDF.AbrirPDF();
        }
    }
}

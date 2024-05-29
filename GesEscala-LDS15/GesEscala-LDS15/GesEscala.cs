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
            IGeradorRelatorio geradorRelatorio = new GeradorRelatorioPDF();
            Controller controller = new Controller(geradorRelatorio);
            controller.IniciarPrograma();

            // Cria o PDF - teste
            EscalaPDF escalaPDF = new EscalaPDF();
            escalaPDF.CriarPDF();

            // Adicionar um serviço e um funcionário ao PDF - teste
            Servico servico1 = new Servico { Sigla = "AT1" };
            Funcionario funcionario1 = new Funcionario { Nome = "Bregieira" };
            controller.AdicionarServicoFuncionario(servico1, funcionario1);

            // Adicionar um segundo serviço e funcionário ao PDF - teste
            Servico servico2 = new Servico { Sigla = "AT2" };
            Funcionario funcionario2 = new Funcionario { Nome = "Santos" };
            controller.AdicionarServicoFuncionario(servico2, funcionario2);

            // Gerar o relatório
            controller.ExecutarAcaoGerarRelatorio();

            // Abrir o PDF - teste
            System.Diagnostics.Process.Start("explorer.exe", "EscalaServico.pdf");
        }
    }
}

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

            // Cria o PDF - teste
            EscalaPDF escalaPDF = new EscalaPDF();
            escalaPDF.CriarPDF();

            // Adiciona um serviço e um funcionário ao PDF - teste
            Servico servico = new Servico();
            servico.Sigla = "AT1";
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Bregieira";
            escalaPDF.AdicionarServicoFuncionario(servico, funcionario);
            escalaPDF.AbrirPDF();
        }
    }
}

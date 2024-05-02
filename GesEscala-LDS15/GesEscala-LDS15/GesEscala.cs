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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controller controller = new Controller();
            controller.IniciarPrograma();
        }
    }
}

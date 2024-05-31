using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    public interface IGeradorRelatorio
    {
        void GerarRelatorio();
        void AdicionarServicoFuncionario(Servico servico, Funcionario funcionario);
    }
}

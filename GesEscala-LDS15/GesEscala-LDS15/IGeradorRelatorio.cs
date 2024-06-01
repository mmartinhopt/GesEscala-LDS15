using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    public interface IGeradorRelatorio
    {
        void GerarRelatorio(int numero_relatorio); // Método para gerar o PDF do relatório
        void AdicionarServicoFuncionario(Servico servico, Funcionario funcionario); // Método para adicionar serviço e funcionário
        void AdicionarFuncionario(Funcionario funcionario); // Método para adicionar funcionário
        void AdicionarServico(Servico servico); // Método para adicionar serviço
        void AdicionarEscala(Dictionary<string, object> escala); // Método para adicionar escala
    }

}

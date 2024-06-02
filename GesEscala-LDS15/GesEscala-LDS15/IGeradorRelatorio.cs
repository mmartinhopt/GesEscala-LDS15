// Universidade Aberta
// Licenciatura em Engenharia Informática
// Laboratório de Desenvolvimento de Software
// Projeto: GesEscala
// Grupo: 15 - ByteBrigade (Ricardo Sanches, Marco Martinho, Marcelo Bregieira, António Vieira, José Campos)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    // Interface implementada - IGeradorRelatorio
    public interface IGeradorRelatorio
    {
        void GerarRelatorio(int numero_relatorio); // Método para gerar o PDF do relatório
        void AdicionarServicoFuncionario(Servico servico, Funcionario funcionario); // Método para adicionar serviço e funcionário
        void AdicionarFuncionario(Funcionario funcionario); // Método para adicionar funcionário
        void AdicionarServico(Servico servico); // Método para adicionar serviço
        void AdicionarEscala(Servico servico, List<Funcionario> funcionarios); // Método para adicionar escala
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    public class ServicoComFuncionarios
    {
        public Servico Servico { get; set; }
        public List<Funcionario> Funcionarios { get; set; }

        public ServicoComFuncionarios(Servico servico)
        {
            Servico = servico;
            Funcionarios = new List<Funcionario>();
        }
    }

    public class EscalaDeServicoDiaria
    {
        public DateTime Data { get; set; }
        public List<ServicoComFuncionarios> ServicosComFuncionarios { get; set; }

        public EscalaDeServicoDiaria()
        {
            ServicosComFuncionarios = new List<ServicoComFuncionarios>();
        }
    }

    public class FuncionarioEscala
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string? Apelido { get; set; }
    }
}

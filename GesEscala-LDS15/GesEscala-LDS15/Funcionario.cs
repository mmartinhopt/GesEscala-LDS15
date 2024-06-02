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

    // Classe Funcionario que contém os atributos do funcionário criado
    public class Funcionario
    {
        public int ID { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string? Apelido { get; set; }
        public string? Morada { get; set; }
        public int? Contacto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    // Classe Serviço que contém os atributos do serviço criado
    public class Servico
    {  
        // ID do serviço
        public int ID { get; set; } 
        // Nome do serviço
        public string Nome { get; set; }
        // Descrição do serviço (consulta apenas)
        public string Descricao { get; set; }
        // Sigla do serviço (O que vai aparecer na escala)
        public string Sigla { get; set; }
        // Hora de início do serviço (tem de ser um valor válido - hora XX:YY)
        public string HoraInicio { get; set; }
        // Hora de fim do serviço (tem de ser um valor válido - hora XX:YY)
        public string HoraFim { get; set; }
    }
}

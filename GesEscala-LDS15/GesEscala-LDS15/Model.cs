using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    internal class Model
    {

        private View view;

        public Model(View v)
        {
            view = v;
        }

        //Model recebe do controller a configuração inicial e guarda-a
        public void ReceberConfiguracaoInicial()
        {
            //Guardar configuração inicial
        }

        //Model envia para a view a configuração inicial para ser apresentada
        public void EnviarConfiguracaoInicial()
        {
            view.ApresentarConfiguracaoInicial();
        }

        //Model recebe do controller ordem para buscar dados do mês selecionado para escalar
        public void ReceberDadosMes()
        {
            //Buscar dados do mês selecionado
        }

        //Model envia para a view os dados do mês selecionado para serem apresentados
        public void EnviarDadosMes()
        {
            view.ApresentarDadosMes();
        }

        //Model recebe do controller qual o dia selecionado para escalar e calcula os mais atrasados para os serviço
        public void ReceberDiaSelecionado()
        {
            //Calcular os mais atrasados para o serviço
        }

        //Model envia para a view os dados do dia selecionado para serem apresentados
        public void EnviarDiaSelecionado()
        {
            view.ApresentarDiaSelecionado();
        }

        //Model recebe do controller qual o serviço selecionado e identifica se pode ser escalado
        public void ReceberServicoSelecionado()
        {
            //Verificar se o serviço pode ser escalado
        }

        //Model envia para a view os dados do serviço selecionado para serem apresentados
        public void EnviarServicoSelecionado()
        {
            view.ApresentarServicoSelecionado();
        }

        //Model recebe do controller a ordem para gerar PDF com a escala
        public void ReceberGerarPDF()
        {
            //Gerar PDF com a escala
        }

        //Model envia para a view a escala em PDF para ser apresentada
        public void EnviarEscalaPDF()
        {
            view.ApresentarEscalaPDF();
        }

    }
}

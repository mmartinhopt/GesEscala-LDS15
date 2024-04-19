using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    public class View
    {
        private Model model;
        private FormMain janela;

        internal View(Model m)
        {
            model = m;
            //viewlog = new ViewLog(janela);
        }


        public void Encerrar()
        {
            janela.Encerrar();
        }


        public void AtivarInterface()
        {
            // Aqui temos duas interfaces que podem ser ativadas
            // A primeira é caso seja a primeira vez que o programa é executado apresenta interface de registo de configuração inicial
            // Caso não seja a primeira vez que o programa é executado apresenta a interface principal (modo escalador)
            janela = new FormMain();
            janela.View = this;
            janela.ShowDialog();
        }

        public void ApresentarConfiguracaoInicial()
        {
            //Apresentar configuração inicial
        }

        public void ApresentarDadosMes()
        {
            //Apresentar dados do mês
        }

        public void ApresentarDiaSelecionado()
        {
            //Apresentar dia selecionado
        }

        public void ApresentarServicoSelecionado()
        {
            //Apresentar serviço selecionado
        }

        public void ApresentarErro()
        {
            //Apresentar erro
        }

        public void ApresentarSucesso()
        {
            //Apresentar sucesso
        }

        public void ApresentarAtrasados()
        {
            //Apresentar atrasados
        }

        public void ApresentarServicos()
        {
            //Apresentar serviços
        }

        public void ApresentarEscalaPDF()
        {
            //Apresentar PDF
        }


    }
}

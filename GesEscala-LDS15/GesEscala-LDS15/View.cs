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
        //private ViewLog viewlog;

        //private List<Forma> listaFormasView;

        //public event EventHandler UtilizadorClicouEmNovaForma;
        //public event EventHandler UtilizadorClicouEmSair;

        //public delegate void SolicitacaoListaFormas(ref List<Forma> listadeformas);
        //public event SolicitacaoListaFormas PrecisoDeFormas;

        //public delegate string SolicitacaoLog();
        //public event SolicitacaoLog PrecisoDeLog;

        internal View(Model m)
        {
            model = m;
            //viewlog = new ViewLog(janela);
        }

        /*
        public void Encerrar()
        {
            janela.Encerrar();
        }
        */

        public void AtivarInterface()
        {
            janela = new FormMain();
            janela.View = this;
            // A API WinForms desenha as janelas e botões automaticamente
            janela.ShowDialog();
        }

        /*
        public void AtivarViewLog()
        {
            viewlog.AtivarViewLog();
        }
        */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    public class View
    {
        // Atributos
        private Model model;
        private FormMain janela;
        // private FormMain janela;

        private List<Funcionario> listaFuncionariosView = null;
        private List<Dictionary<string, object>> listaEscaladosView = null;
        private List<Servico> listaServicosView = null;

        // Eventos Funcionarios
        public delegate void PedidoListaFuncionarios(ref List<Funcionario> listaFuncionarios);
        public event PedidoListaFuncionarios PrecisoDeFuncionarios;
        public delegate void EventNovoFuncionario(Funcionario novoFuncionario);
        public event EventNovoFuncionario RegistoNovoFuncionario;

        //Eventos Servicos
        public delegate void PedidoListaServicos(ref List<Servico> listaServicos);
        public event PedidoListaServicos PrecisoDeServicos;
        //public delegate void EventNovoServico(Funcionario novoServico);
        //public event EventNovoServico RegistoNovoServico;






        //public event EventHandler UserAtivouTabFuncionarios;

        //public event EventHandler ConfiguracaoInicialButtonClicked;
        //public event EventHandler GerarPDFButtonClicked;
        //public event EventHandler EventUserClicouFuncionarios;
        //public event EventHandler EventUserClicouServicos;
        //public event EventHandler EventUserClicouEscalados;


        // Propriedades
        //public ListView FuncionariosListView { get; set; }

        // Construtor
        internal View(Model m)
        {
            model = m;
        }

        // Métodos
        
        public void IniciarInterface()
        {
            // Apresenta o Form inicial FormMain
            janela = new FormMain();
            janela.View = this;
            janela.ShowDialog();
        }

        public void NovoFuncionario(Funcionario novoFuncionario)
        {
            RegistoNovoFuncionario(novoFuncionario);
        }

        public void ListaNovoFuncionario()
        {

        }

        public void AtualizarListaFuncionarios(object sender, EventArgs e)
        {
            PrecisoDeFuncionarios(ref listaFuncionariosView);
            PopularFuncionarios();
        }

        void PopularFuncionarios()
        {
            janela.PopularFuncionarios(ref listaFuncionariosView);
        }

        public void PrecisoDeListaFuncionarios(ref List<Funcionario> listaFuncionariosView)
        {
            PrecisoDeFuncionarios(ref listaFuncionariosView);
            janela.AtualizaListaFuncionarios(ref listaFuncionariosView);
        }

        public void PrecisoDeListaServicos(ref List<Servico> listaServicosView)
        {
            PrecisoDeServicos(ref listaServicosView);
            janela.AtualizarListaServicos(ref listaServicosView);
        }

        // Método para encerrar a aplicação
        public void Encerrar()
        {
            //Implementar.
        }
    }
}

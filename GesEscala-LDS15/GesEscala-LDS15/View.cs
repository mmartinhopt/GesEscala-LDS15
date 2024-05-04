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
        private List<Dictionary<string, object>> listaServicosView = null;

        // Eventos

        public delegate void PedidoListaFuncionarios(ref List<Funcionario> listaFuncionarios);
        public event PedidoListaFuncionarios PrecisoDeFuncionarios;

        public delegate void NovoFuncionario(ref Funcionario novoFuncionario);
        public event NovoFuncionario RegistoNovoFuncionario;

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

        public void PreencherListView(List<Dictionary<string, object>> funcionarios)
        {
            try
            {
                
                //FuncionariosListView.Items.Clear();
                foreach (var funcionario in funcionarios)
                {
                    ListViewItem item = new ListViewItem(funcionario["Id"].ToString());
                    item.SubItems.Add(funcionario["Numero"].ToString());
                    item.SubItems.Add(funcionario["Nome"].ToString());
                    item.SubItems.Add(funcionario["Morada"].ToString());
                    item.SubItems.Add(funcionario["Contacto"].ToString());
                    //FuncionariosListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao preencher ListView: {ex.Message}");
            }
        }

        
        public void IniciarInterface()
        {
            // Apresenta o Form inicial FormMain
            janela = new FormMain();
            janela.View = this;
            janela.ShowDialog();
        }

        public void RegistarNovoFuncionario(Funcionario novoFuncionario)
        {
            RegistarNovoFuncionario(novoFuncionario);
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

        // Método para encerrar a aplicação
        //public void Encerrar()
        //{
        //}
    }
}

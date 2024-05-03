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
      //  private FormMain janela;



        // Eventos
        public event EventHandler ConfiguracaoInicialButtonClicked;
        public event EventHandler GerarPDFButtonClicked;


        // Propriedades
        public ListView FuncionariosListView { get; set; }

        // Construtor
        public View(Model m)
        {
            model = m;
        }

        // Métodos

        public void PreencherListView(List<Dictionary<string, object>> funcionarios)
        {
            try
            {
                
                FuncionariosListView.Items.Clear();
                foreach (var funcionario in funcionarios)
                {
                    ListViewItem item = new ListViewItem(funcionario["Id"].ToString());
                    item.SubItems.Add(funcionario["Numero"].ToString());
                    item.SubItems.Add(funcionario["Nome"].ToString());
                    item.SubItems.Add(funcionario["Morada"].ToString());
                    item.SubItems.Add(funcionario["Contacto"].ToString());
                    FuncionariosListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao preencher ListView: {ex.Message}");
            }
        }

        
        public void MostrarFormInicial()
        {
            // Apresenta o Form inicial FormMain
            FormMain form = new FormMain();
            form.ShowDialog();
        }

        // Método para encerrar a aplicação
        public void Encerrar()
        {
        }
    }
}

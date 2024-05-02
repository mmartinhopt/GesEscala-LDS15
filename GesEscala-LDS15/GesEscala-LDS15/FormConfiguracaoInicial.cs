using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    public partial class FormConfiguracaoInicial : Form
    {
        private Model model;

        public FormConfiguracaoInicial(Model model)
        {
            InitializeComponent();
            this.model = model; // Recebe o Model
        }

        private void FormConfiguracaoInicial_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Por favor, informe o nome da secção.");
            }
            else
            {
                string nomeSecao = textBox1.Text;
                model.GuardarNomeSeccao(nomeSecao);
                this.Close(); // Fecha a janela
            }
        }
    }
}

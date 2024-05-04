using System.Collections.Immutable;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    public partial class FormMain : Form
    {
        private View view;
        //private Controller controller;

        private List<Funcionario> listaFuncionariosApresentar = null;
        private List<Dictionary<string, object>> listaEscaladosApresentar = null;
        private List<Dictionary<string, object>> listaServicosApresentar = null;

        // Tornar o construtor público
        public FormMain()
        {
            InitializeComponent();

            // Remove todas as tabs da apresentação visual
            remover_tabs();

            //Remove acesso a tabs ainda em desenvolvimento
            desativarIncompletos();
        }


        public void Encerrar()
        {
            //view.Encerrar();
        }

        public View View { get => view; set => view = value; }


        private void btn_adicionar_svc_Click(object sender, EventArgs e)
        {

            // Limpa a ListBox antes de preencher novamente
            listBox_Efetivo.Items.Clear();

            // Preenche a ListBox com os funcionários obtidos
            foreach (Funcionario funcionario in listaFuncionariosApresentar)
            {
                listBox_Efetivo.Items.Add(funcionario.Nome);
            }
        }

        public void AtualizaListaFuncionarios(ref List<Funcionario> listaNova)
        {
            this.listaFuncionariosApresentar = listaNova;
        }

        public void ApresentarFuncionarios()
        {
            //lst_funcionarios_registo.Items.Clear();
            lst_funcionarios_registo.Items.Clear();
            try
            {
                view.PrecisoDeListaFuncionarios(ref listaFuncionariosApresentar);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro a obter lista de funcionarios da view" + e.Message);
            }


            try
            {
                foreach (Funcionario funcionario in listaFuncionariosApresentar)
                {
                    lst_funcionarios_registo.Items.Add(funcionario.Nome);
                }
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao preencher ListView: {ex.Message}");
            }
        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {

            tc_Main.SelectedTab = tc_Main.TabPages["tP_funcionarios"]; // Seleciona a tab de funcionários
            panel3.Visible = false;
            ApresentarFuncionarios();
        }

        internal void PopularFuncionarios(ref List<Funcionario> listaFuncionariosView)
        {
            this.listaFuncionariosApresentar = listaFuncionariosView;
        }


        private void lst_funcionarios_registo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_adicionar.Enabled = false;
            // Verifica se algum item está selecionado
            if (lst_funcionarios_registo.SelectedItem != null)
            {
                lbl_ID.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].ID.ToString();
                tb_numero.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Numero.ToString();
                tb_nome.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Nome.ToString();
                tb_apelido.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Apelido.ToString();
                tb_morada.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Morada.ToString();
                tb_contacto.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Contacto.ToString();
            }
        }

        public void remover_tabs()
        {
            tc_Main.ItemSize = new System.Drawing.Size(0, 1);
            tc_Main.Appearance = TabAppearance.Buttons;
            tc_Main.SizeMode = TabSizeMode.Fixed;
        }

        private void desativarIncompletos()
        {
            btn_escalas.Enabled = false;
            btn_gerarEscala.Enabled = false;
            btn_turnos.Enabled = false;
        }

        private void btn_gerarEscala_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tc_Main.TabPages["tP_nEscala"];

        }

        private void btn_escalas_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tc_Main.TabPages["tP_cEscala"];
        }

        private void btn_turnos_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tc_Main.TabPages["tP_servicos"];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Efetivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            if (lst_funcionarios_registo.SelectedItems.Count > 0)
            {
                lst_funcionarios_registo.SelectedIndex = -1;
            }

            lbl_ID.Text = "";
            tb_numero.Clear();
            tb_nome.Clear();
            tb_apelido.Clear();
            tb_morada.Clear();
            tb_contacto.Clear();

            btn_adicionar.Enabled = true;
        }
    }
}

using System.Windows.Forms;

namespace GesEscala_LDS15
{
    public partial class FormMain : Form
    {
        private View view;
        public View View { get => view; set => view = value; }
        private Controller controller;
        private List<Dictionary<string, object>> funcionarios;
        // Tornar o construtor público
        public FormMain()
        {
            InitializeComponent();
            controller = new Controller(); // Define o controller recebido


            //Inicializadores
            //Obtem o nome dos funcionários
            BuscarFuncionarios();
            remover_tabs(); // Remove todas as tabs
        }


        public void Encerrar()
        {
            view.Encerrar();
        }

        private void BuscarFuncionarios()
        {
            // Obtém a lista de funcionários do controller
            funcionarios = controller.BuscarFuncionarios();
        }
        private void btn_adicionar_svc_Click(object sender, EventArgs e)
        {

            // Limpa a ListBox antes de preencher novamente
            listBox_Efetivo.Items.Clear();

            // Preenche a ListBox com os funcionários obtidos
            foreach (var funcionario in funcionarios)
            {
                listBox_Efetivo.Items.Add(funcionario["Nome"]);
            }
        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {

            tc_Main.SelectedTab = tc_Main.TabPages["tP_funcionarios"];


            lst_funcionarios_registo.Items.Clear();
            foreach (var funcionario in funcionarios)
            {
                lst_funcionarios_registo.Items.Add(funcionario["Nome"]);
            }

        }

        private void lst_funcionarios_registo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado
            if (lst_funcionarios_registo.SelectedItem != null)
            {
                // Obtém o item selecionado

                lbl_ID.Text = funcionarios[lst_funcionarios_registo.SelectedIndex]["Id"].ToString();
                tb_numero.Text = funcionarios[lst_funcionarios_registo.SelectedIndex]["Numero"].ToString();
                tb_nome.Text = funcionarios[lst_funcionarios_registo.SelectedIndex]["Nome"].ToString();
                tb_morada.Text = funcionarios[lst_funcionarios_registo.SelectedIndex]["Morada"].ToString();
                tb_contacto.Text = funcionarios[lst_funcionarios_registo.SelectedIndex]["Contacto"].ToString();

            }
        }

        public void remover_tabs()
        {
            tc_Main.ItemSize = new System.Drawing.Size(0, 1);
            tc_Main.Appearance = TabAppearance.Buttons;
            tc_Main.SizeMode = TabSizeMode.Fixed;


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
    }
}

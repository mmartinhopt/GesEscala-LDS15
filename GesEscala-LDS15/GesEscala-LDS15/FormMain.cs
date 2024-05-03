using System.Windows.Forms;

namespace GesEscala_LDS15
{
    public partial class FormMain : Form
    {
        private View view;
        private Controller controller;

        private List<Dictionary<string, object>> listaFuncionariosApresentar = null;
        private List<Dictionary<string, object>> listaEscaladosApresentar = null;
        private List<Dictionary<string, object>> listaServicosApresentar = null;

        // Tornar o construtor p�blico
        public FormMain()
        {
            InitializeComponent();
            
            //controller = new Controller(); // Define o controller recebido


            //Inicializadores
            //Obtem o nome dos funcion�rios
            BuscarFuncionarios();
            remover_tabs(); // Remove todas as tabs
        }


        public void Encerrar()
        {
            //view.Encerrar();
        }

        public View View { get => view; set => view = value; }


        private void BuscarFuncionarios()
        {
            // Obt�m a lista de funcion�rios do controller
            //funcionarios = controller.BuscarFuncionarios();

        }
        private void btn_adicionar_svc_Click(object sender, EventArgs e)
        {

            // Limpa a ListBox antes de preencher novamente
            listBox_Efetivo.Items.Clear();

            // Preenche a ListBox com os funcion�rios obtidos
            foreach (var funcionario in funcionarios)
            {
                listBox_Efetivo.Items.Add(funcionario["Nome"]);
            }
        }

        public void obterFuncionarios()
        {

            lst_funcionarios_registo.Items.Clear();
            try
            {
                foreach (var funcionario in funcionarios)
                {
                    lst_funcionarios_registo.Items.Add(funcionario["Nome"]);
                }
            }
            catch (Exception ex)
            {
                // Lidar com a exce��o
                Console.WriteLine($"Erro ao preencher ListView: {ex.Message}");
            }
        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {

            tc_Main.SelectedTab = tc_Main.TabPages["tP_funcionarios"]; // Seleciona a tab de funcion�rios
            obterFuncionarios(); // Obt�m os funcion�rios

        }

        private void lst_funcionarios_registo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item est� selecionado
            if (lst_funcionarios_registo.SelectedItem != null)
            {
                // Obt�m o item selecionado

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

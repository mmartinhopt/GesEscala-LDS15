namespace GesEscala_LDS15
{
    public partial class FormMain : Form
    {
        private View view;
        public View View { get => view; set => view = value; }
        private Controller controller;

        // Tornar o construtor público
        public FormMain()
        {
            InitializeComponent();
            controller = new Controller(); // Define o controller recebido
        }


        public void Encerrar()
        {
            view.Encerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtém a lista de funcionários do controller
            List<Dictionary<string, object>> funcionarios = controller.BuscarFuncionarios();

            // Limpa a ListBox antes de preencher novamente
            listBox_Efetivo.Items.Clear();

            // Preenche a ListBox com os funcionários obtidos
            foreach (var funcionario in funcionarios)
            {
                listBox_Efetivo.Items.Add(funcionario["Nome"]);
            }
        }
    }
}

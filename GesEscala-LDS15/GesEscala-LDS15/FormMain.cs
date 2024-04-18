namespace GesEscala_LDS15
{
    public partial class FormMain : Form
    {
        private View view;
        public View View { get => view; set => view = value; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void gerarEscala_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Encerrar()
        {
            Application.Exit();
        }
    }
}

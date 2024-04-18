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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

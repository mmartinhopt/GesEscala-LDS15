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


        public void Encerrar()
        {
            view.Encerrar();
        }

        private void btn_escalas_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void listBox_Efetivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

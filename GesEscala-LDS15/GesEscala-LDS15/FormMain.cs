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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
        private List<Servico> listaServicosApresentar = null;
        
        //get set da instancia da view ao Form
        public View View { get => view; set => view = value; }


        // construtor 
        public FormMain()
        {
            InitializeComponent();

            // Remove todas as tabs da apresentação visual
            remover_tabs();

            //Remove acesso a tabs ainda em desenvolvimento
            desativarIncompletos();
        }

        //Encerrar aplicação
        public void Encerrar()
        {
            //view.Encerrar();
        }


        //Btn adicionar serviço
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
        //Atualizar lista de funcionarios
        public void AtualizaListaFuncionarios(ref List<Funcionario> listaNova)
        {
            this.listaFuncionariosApresentar = listaNova;
        }
        //Atualizar lista de serviços
        public void AtualizarListaServicos(ref List<Servico> novaListaServicos)
        {
            this.listaServicosApresentar = novaListaServicos;
        }

        //Popular a lista de funcionarios
        public void ApresentarFuncionarios()
        {
            // Limpa lista
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
                    string aux = funcionario.ID.ToString() + " - " + funcionario.Nome.ToString() + " " + funcionario.Apelido.ToString();
                    //MessageBox.Show(aux);
                    lst_funcionarios_registo.Items.Add(aux);
                }
            }
            catch (Exception ex)
            {
                // a exceção
                MessageBox.Show($"Erro ao preencher ListView: {ex.Message}");
            }
        }

        //Popular lista de serviços
        public void ApresentarServicos()
        {
            //Limpa lista servicos para preencher
            lst_servicos_registo.Items.Clear();
            try
            {
                view.PrecisoDeListaServicos(ref listaServicosApresentar);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro a obter lista de servicos da view" + e.Message);
            }

            try
            {
                foreach (Servico servico in listaServicosApresentar)
                {
                    string aux = servico.ID.ToString() + " - " + servico.Nome.ToString() + " " + servico.HoraInicio.ToString() + "/" + servico.HoraFim.ToString();
                    //MessageBox.Show(aux);
                    lst_servicos_registo.Items.Add(aux);
                }
            }
            catch (Exception ex)
            {
                // Lidar com a exceção
                Console.WriteLine($"Erro ao preencher ListViewServicos: {ex.Message}");
            }
        }

        //Btn principal de selecao de tab de funcionarios
        private void btn_funcionarios_Click(object sender, EventArgs e)
        {

            tc_Main.SelectedTab = tc_Main.TabPages["tP_funcionarios"]; // Seleciona a tab de funcionários
            //Temporario painel de topo não esta visivel
            panel_top_funcionario.Visible = false;
            ApresentarFuncionarios();
        }

        internal void PopularFuncionarios(ref List<Funcionario> listaFuncionariosView)
        {
            this.listaFuncionariosApresentar = listaFuncionariosView;
        }


        private void lst_funcionarios_registo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_adicionar.Enabled = false;
            btn_remover.Enabled = true;
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

        private void lst_servicos_registo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado
            if (lst_servicos_registo.SelectedItem != null)
            {
                lbl_servico_id.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].ID.ToString();
                tb_servico_nome.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].Nome.ToString();
                tb_servico_desc.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].Descricao.ToString();
                tb_servico_sigla.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].Sigla.ToString();
                tb_servico_inicio.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].HoraInicio.ToString();
                tb_servico_fim.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].HoraFim.ToString();
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
            panel5.Visible = false;
            ApresentarServicos();
        }

        private void limpar_lista()
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
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            try
            {
                limpar_lista();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível limpar caixas de texto.");
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            int numero;
            if (tb_numero.Text.Length > 0 && tb_nome.Text.Length > 0 && int.TryParse(tb_numero.Text, out numero))
            {
                Funcionario novoFuncionario = new Funcionario();

                novoFuncionario.Numero = Convert.ToInt32(tb_numero.Text);
                novoFuncionario.Nome = tb_nome.Text.ToString();

                if (tb_apelido != null) { novoFuncionario.Apelido = tb_apelido.Text.ToString(); }
                if (tb_morada != null) { novoFuncionario.Morada = tb_morada.Text.ToString(); };
                if (tb_contacto.Text.Length > 0 && int.TryParse(tb_contacto.Text, out numero)) { novoFuncionario.Contacto = Convert.ToInt32(tb_contacto.Text); }

                view.NovoFuncionario(novoFuncionario);
                ApresentarFuncionarios();
            }
            else
            {
                MessageBox.Show("O campos NUMERO e NOME são de preenchimento obrigatorio\n" +
                                "Campo NUMERO apenas pode conter digitos.");
            }

        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lbl_ID.Text))
                {
                    MessageBox.Show("Por favor, selecione o funcionario a remover na lista.");
                    return;
                }

                if (!int.TryParse(lbl_ID.Text, out int idFuncionario))
                {
                    MessageBox.Show("Por favor, insira um ID de funcionário válido.");
                    return;
                }
              //View remover funcionario pelo ID.
                view.RemFuncionario(idFuncionario);                
            }
            catch (Exception ex)
            {
                // Tratar qualquer exceção que possa ocorrer
                MessageBox.Show("Ocorreu um erro ao tentar remover o funcionário: " + ex.Message);
            }

            //Refresh À lista de funcionarios e limpa caixas de txtbox
            try
            {
                ApresentarFuncionarios();
                limpar_lista();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro na leitura de funcionarios a carregar para a lista.");
            }
        }

    }
}

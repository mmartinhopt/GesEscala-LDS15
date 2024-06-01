using System.Collections.Immutable;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    public partial class FormMain : Form
    {
        private View view;
        //private Controller controller;

        private List<Funcionario> listaFuncionariosApresentar = null;
        private EscalaDeServicoDiaria escalaDiariaApresentar = null;

        private List<Servico> listaServicosApresentar = null;

        //get set da instancia da view ao Form
        public View View { get => view; set => view = value; }


        // construtor 
        public FormMain()
        {
            InitializeComponent();

            // Remove todas as tabs da apresenta��o visual
            remover_tabs();

            //Remove acesso a tabs ainda em desenvolvimento
            desativarIncompletos();
        }

        //Encerrar aplica��o
        public void Encerrar()
        {
            //view.Encerrar();
        }


        //Btn adicionar servi�o
        private void btn_adicionar_svc_Click(object sender, EventArgs e)
        {

            // Limpa a ListBox antes de preencher novamente
            listBox_Efetivo.Items.Clear();

            // Preenche a ListBox com os funcion�rios obtidos
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
        //Atualizar lista de servi�os
        public void AtualizarListaServicos(ref List<Servico> novaListaServicos)
        {
            this.listaServicosApresentar = novaListaServicos;
        }

        public void ApresentarEscalados(DateTime data)
        {
            try
            {
                view.PrecisoEscalas(ref escalaDiariaApresentar, data);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro a obter lista de escalados da view" + e.Message);
            }
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
                // a exce��o
                MessageBox.Show($"Erro ao preencher ListView: {ex.Message}");
            }
        }

        //Popular lista de servi�os
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
                // Lidar com a exce��o
                Console.WriteLine($"Erro ao preencher ListViewServicos: {ex.Message}");
            }
        }

        //Btn principal de selecao de tab de funcionarios
        private void btn_funcionarios_Click(object sender, EventArgs e)
        {

            tc_Main.SelectedTab = tc_Main.TabPages["tP_funcionarios"]; // Seleciona a tab de funcion�rios
            //Temporario painel de topo n�o esta visivel
            panel_top_funcionario.Visible = false;
            ApresentarFuncionarios();
        }

        // Atualiza a lista de funcion�rios a apresentar com a lista fornecida
        internal void PopularFuncionarios(ref List<Funcionario> listaFuncionariosView)
        {
            this.listaFuncionariosApresentar = listaFuncionariosView;
        }

        //Atualiza a escala de servicos
        internal void PopularEscalados(ref EscalaDeServicoDiaria escalaDiariaView)
        {
            this.escalaDiariaApresentar = escalaDiariaView;
        }

        // Evento acionado quando a sele��o na lista de funcion�rios muda
        private void lst_funcionarios_registo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_adicionar.Enabled = false; // Desativa o bot�o de adicionar
            btn_remover.Enabled = true;    // Ativa o bot�o de remover

            // Verifica se algum item est� selecionado
            if (lst_funcionarios_registo.SelectedItem != null)
            {
                // Atualiza os campos com as informa��es do funcion�rio selecionado
                lbl_ID.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].ID.ToString();
                tb_numero.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Numero.ToString();
                tb_nome.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Nome.ToString();
                tb_apelido.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Apelido.ToString();
                tb_morada.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Morada.ToString();
                tb_contacto.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Contacto.ToString();
            }
        }

        // Evento acionado quando a sele��o na lista de servi�os muda
        private void lst_servicos_registo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item est� selecionado
            if (lst_servicos_registo.SelectedItem != null)
            {
                // Atualiza os campos com as informa��es do servi�o selecionado
                lbl_servico_id.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].ID.ToString();
                tb_servico_nome.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].Nome.ToString();
                tb_servico_desc.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].Descricao.ToString();
                tb_servico_sigla.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].Sigla.ToString();
                tb_servico_inicio.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].HoraInicio.ToString();
                tb_servico_fim.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].HoraFim.ToString();
            }
        }

        //ocultar os headers dos tabs para poder utilizar o tab e os elementos ainda estarem
        //em mem�ria podendo assim continuar. Mero efeito
        public void remover_tabs()
        {
            tc_Main.ItemSize = new System.Drawing.Size(0, 1);
            tc_Main.Appearance = TabAppearance.Buttons;
            tc_Main.SizeMode = TabSizeMode.Fixed;
        }

        //Em desenvolvimento *Temporario
        private void desativarIncompletos()
        {
            btn_gerarEscala.Enabled = false;
        }

        //Btn  do Form, btn principal apresenta o tab da nova escala
        private void btn_gerarEscala_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tc_Main.TabPages["tP_nEscala"];

        }
        //Btn do Form, btn principl apresenta o tab da escala existente
        private void btn_escalas_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tc_Main.TabPages["tP_cEscalas"];
            DateTime data = DateTime.Today;
            label31.Text = data.ToString("dd/MM/yyyy");
            ApresentarEscalados(data);
            PopularEscaladosDataGrid();
        }
        //Btn do Form, btn principal apresenta os servi�os
        private void btn_turnos_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tc_Main.TabPages["tP_servicos"];
            panel5.Visible = false;
            ApresentarServicos();
        }
        //Void para limpar a lista dos funcionarios 
        //� utilizado por mais de um btn, adicionar/remover funcionario
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
        //Btn para limpar a lista
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            try
            {
                limpar_lista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel limpar caixas de texto.");
            }
        }

        //btn adicionar funcionario � lista com verificacao de existencia 
        // de funcionario com o mesmo numero, visto que � elemento unico
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
                MessageBox.Show("O campos NUMERO e NOME s�o de preenchimento obrigatorio\n" +
                                "Campo NUMERO apenas pode conter digitos.");
            }

        }

        //Terminar a aplicacao btn
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Remover funcionario por ID, elemento unico e sequencial
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
                    MessageBox.Show("Por favor, insira um ID de funcion�rio v�lido.");
                    return;
                }
                //View remover funcionario pelo ID.
                view.RemFuncionario(idFuncionario);
            }
            catch (Exception ex)
            {
                // Tratar qualquer exce��o que possa ocorrer
                MessageBox.Show("Ocorreu um erro ao tentar remover o funcion�rio: " + ex.Message);
            }

            //Refresh � lista de funcionarios e limpa caixas de txtbox
            try
            {
                ApresentarFuncionarios();
                limpar_lista();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na leitura de funcionarios a carregar para a lista.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Parse("2024-06-01");
            ApresentarEscalados(data);
            PopularEscaladosDataGrid();

        }

        private void PopularEscaladosDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (ServicoComFuncionarios servicoComFuncionarios in escalaDiariaApresentar.ServicosComFuncionarios)
            {
                foreach (Funcionario funcionario in servicoComFuncionarios.Funcionarios)
                {
                    dataGridView1.Rows.Add(
                        servicoComFuncionarios.Servico.Nome,
                        servicoComFuncionarios.Servico.Sigla,
                        servicoComFuncionarios.Servico.HoraInicio.ToString(),
                        servicoComFuncionarios.Servico.HoraFim.ToString(),
                        funcionario.Numero,
                        funcionario.Nome,
                        funcionario.Apelido
                    );
                }
            }

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime data = DateTime.Parse(monthCalendar2.SelectionStart.ToString());
            label31.Text = data.ToString("dd/MM/yyyy");
            ApresentarEscalados(data);
            PopularEscaladosDataGrid();

        }

        private void btn_exp_servicos_Click(object sender, EventArgs e)
        {
            view.pdfServicos();
        }
    }
}

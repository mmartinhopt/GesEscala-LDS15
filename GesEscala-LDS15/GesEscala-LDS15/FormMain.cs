using System.Collections.Immutable;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            panel_top_funcionario.Visible = true;
            ApresentarFuncionarios();
        }

        // Atualiza a lista de funcionários a apresentar com a lista fornecida
        internal void PopularFuncionarios(ref List<Funcionario> listaFuncionariosView)
        {
            this.listaFuncionariosApresentar = listaFuncionariosView;
        }

        //Atualiza a escala de servicos
        internal void PopularEscalados(ref EscalaDeServicoDiaria escalaDiariaView)
        {
            this.escalaDiariaApresentar = escalaDiariaView;
        }

        // Evento acionado quando a seleção na lista de funcionários muda
        private void lst_funcionarios_registo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_adicionar.Enabled = false; // Desativa o botão de adicionar
            btn_remover.Enabled = true;    // Ativa o botão de remover

            // Verifica se algum item está selecionado
            if (lst_funcionarios_registo.SelectedItem != null)
            {
                // Atualiza os campos com as informações do funcionário selecionado
                lbl_ID.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].ID.ToString();
                tb_numero.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Numero.ToString();
                tb_nome.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Nome.ToString();
                tb_apelido.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Apelido.ToString();
                tb_morada.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Morada.ToString();
                tb_contacto.Text = listaFuncionariosApresentar[lst_funcionarios_registo.SelectedIndex].Contacto.ToString();
            }
        }

        // Evento acionado quando a seleção na lista de serviços muda
        private void lst_servicos_registo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado
            if (lst_servicos_registo.SelectedItem != null)
            {
                // Atualiza os campos com as informações do serviço selecionado
                lbl_servico_id.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].ID.ToString();
                tb_servico_nome.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].Nome.ToString();
                tb_servico_desc.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].Descricao.ToString();
                tb_servico_sigla.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].Sigla.ToString();
                tb_servico_inicio.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].HoraInicio.ToString();
                tb_servico_fim.Text = listaServicosApresentar[lst_servicos_registo.SelectedIndex].HoraFim.ToString();
            }
        }

        //ocultar os headers dos tabs para poder utilizar o tab e os elementos ainda estarem
        //em memória podendo assim continuar. Mero efeito
        public void remover_tabs()
        {
            tc_Main.ItemSize = new System.Drawing.Size(0, 1);
            tc_Main.Appearance = TabAppearance.Buttons;
            tc_Main.SizeMode = TabSizeMode.Fixed;
        }

        //Em desenvolvimento *Temporario
        private void desativarIncompletos()
        {
            //btn_gerarEscala.Enabled = false;
        }

        //Btn  do Form, btn principal apresenta o tab da nova escala
        private void btn_gerarEscala_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tc_Main.TabPages["tP_nEscala"];
            ApresentarServicos();
            ApresentarFuncionarios();

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
        //Btn do Form, btn principal apresenta os serviços
        private void btn_turnos_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tc_Main.TabPages["tP_servicos"];
            panel_top_servicos.Visible = true;
            ApresentarServicos();
            LimparTurnos();
        }

        private void LimparTurnos()
        {
            tb_servico_nome.Text = "";
            tb_servico_desc.Text = "";
            tb_servico_fim.Text = "";
            tb_servico_inicio.Text = "";
            tb_servico_sigla.Text = "";
        }
        //Void para limpar a lista dos funcionarios 
        //É utilizado por mais de um btn, adicionar/remover funcionario
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
                MessageBox.Show("Não foi possível limpar caixas de texto.");
            }
        }

        //btn adicionar funcionario à lista com verificacao de existencia 
        // de funcionario com o mesmo numero, visto que é elemento unico
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
            catch (Exception erro)
            {
                MessageBox.Show("Erro na leitura de funcionarios a carregar para a lista.");
            }
        }

        private void PopularEscaladosDataGrid()
        {
            dG_Escala.Rows.Clear();
            foreach (ServicoComFuncionarios servicoComFuncionarios in escalaDiariaApresentar.ServicosComFuncionarios)
            {
                foreach (Funcionario funcionario in servicoComFuncionarios.Funcionarios)
                {
                    dG_Escala.Rows.Add(
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
            DateTime data = DateTime.Parse(calendario_mensal.SelectionStart.ToString());
            label31.Text = data.ToString("dd/MM/yyyy");
            ApresentarEscalados(data);
            PopularEscaladosDataGrid();

        }

        private void btn_exp_servicos_Click(object sender, EventArgs e)
        {
            view.pdfServicos();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            view.pdfFuncionarios();
        }

        private void btn_impr_escala_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = calendario_mensal.SelectionStart;
            string dataselecionada = dataSelecionada.ToString("dd/MM/yyyy");
            view.GerarEscala(dataselecionada);

        }

        private void CarregarComboServicos()
        {
            comboServico.DataSource = listaServicosApresentar;
            comboServico.DisplayMember = "Nome";
            comboServico.ValueMember = "ID";
        }

        private void CarregarComboFuncionarios()
        {
            comboFuncionario.DataSource = listaFuncionariosApresentar;
            comboFuncionario.DisplayMember = "Nome";
            comboFuncionario.ValueMember = "ID";
        }

        private void lbl_escalaDia_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            lbl_diaEscalar.Text = monthCalendar1.SelectionStart.ToString("yyyy/MM/dd");
            txt_diaEscalar.Text = monthCalendar1.SelectionStart.ToString("yyyy/MM/dd");

            CarregarComboServicos();
            CarregarComboFuncionarios();
        }

        private void comboServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_escala_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)comboServico.SelectedItem;
            Funcionario funcionarioSelecionado = (Funcionario)comboFuncionario.SelectedItem;
           
            monthCalendar1.Enabled = false;
            try
            {
                // Adicionar à lista de escala (isso pode ser uma lista temporária exibida em um DataGridView)
                dataGridViewEscala.Rows.Add(servicoSelecionado.ID, servicoSelecionado.Nome, funcionarioSelecionado.ID, funcionarioSelecionado.Numero, funcionarioSelecionado.Nome, funcionarioSelecionado.Apelido);
            }
            catch (Exception err)
            {
                MessageBox.Show("ERRO: ", err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Salvar a escala no banco de dados
            DateTime data = DateTime.Parse(monthCalendar1.SelectionStart.ToString());
            List<(Servico, Funcionario)> escala = new List<(Servico, Funcionario)>();

            foreach (DataGridViewRow row in dataGridViewEscala.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int servicoId = int.Parse(row.Cells[0].Value.ToString());
                    int funcionarioId = int.Parse(row.Cells[2].Value.ToString());

                    Servico servico = new Servico { ID = servicoId };
                    Funcionario funcionario = new Funcionario { ID = funcionarioId };

                    escala.Add((servico, funcionario));
                }
            }

            view.NovaEscala(escala, data);
        }

        private void btn_escala_lcampos_Click(object sender, EventArgs e)
        {
            dataGridViewEscala.Rows.Clear();
            lbl_diaEscalar.Text = " ";
            txt_diaEscalar.Text = " ";
            comboFuncionario.SelectedItem = null;
            comboServico.SelectedItem = null;
            monthCalendar1.Enabled = true;
        }

        private void btn_adicionar_servico_Click(object sender, EventArgs e)
        {
            Servico novoServico = new Servico
            {
                Nome = tb_servico_nome.Text,
                Descricao = tb_servico_desc.Text,
                Sigla = tb_servico_sigla.Text,
                HoraInicio = tb_servico_inicio.Text,
                HoraFim = tb_servico_fim.Text
            };

            view.NovoServico(novoServico);
            ApresentarServicos();
            LimparTurnos();
        }

        private void btn_remover_servico_Click(object sender, EventArgs e)
        {
            if (lst_servicos_registo.SelectedItem != null)
            {
                int selectedIndex = lst_servicos_registo.SelectedIndex;
                int idServico = listaServicosApresentar[selectedIndex].ID;
                view.RemServico(idServico);
                ApresentarServicos();
                LimparTurnos();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um serviço para remover.");
            }
        }

    }
}


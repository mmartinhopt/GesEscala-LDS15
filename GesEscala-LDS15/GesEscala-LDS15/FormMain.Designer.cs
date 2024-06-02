namespace GesEscala_LDS15
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btn_gerarEscala = new Button();
            panel_menu = new Panel();
            btn_escalas = new Button();
            btn_turnos = new Button();
            btn_funcionarios = new Button();
            btn_sair = new Button();
            tc_Main = new TabControl();
            tP_main = new TabPage();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            tP_nEscala = new TabPage();
            panel_mid = new Panel();
            label2 = new Label();
            dataGridViewEscala = new DataGridView();
            SID = new DataGridViewTextBoxColumn();
            SNome = new DataGridViewTextBoxColumn();
            FID = new DataGridViewTextBoxColumn();
            FNumero = new DataGridViewTextBoxColumn();
            FNome = new DataGridViewTextBoxColumn();
            FApelido = new DataGridViewTextBoxColumn();
            btn_GuardarEscaka = new Button();
            label1 = new Label();
            lbl_servicoEscala = new Label();
            lbl_funcionarioEscala = new Label();
            lbl_diaEscala = new Label();
            comboFuncionario = new ComboBox();
            btn_escala_lcampos = new Button();
            comboServico = new ComboBox();
            btn_add_escala = new Button();
            txt_diaEscalar = new TextBox();
            monthCalendar1 = new MonthCalendar();
            panel_top = new Panel();
            lbl_escalaDia = new Label();
            lbl_diaEscalar = new Label();
            tP_cEscalas = new TabPage();
            btn_impr_escala = new Button();
            dG_Escala = new DataGridView();
            col_sNome = new DataGridViewTextBoxColumn();
            col_sig = new DataGridViewTextBoxColumn();
            col_inicio = new DataGridViewTextBoxColumn();
            col_fim = new DataGridViewTextBoxColumn();
            col_fnumero = new DataGridViewTextBoxColumn();
            col_fnome = new DataGridViewTextBoxColumn();
            col_fapelido = new DataGridViewTextBoxColumn();
            calendario_mensal = new MonthCalendar();
            panel3 = new Panel();
            label31 = new Label();
            lbl_info_escala_dia = new Label();
            tP_funcionarios = new TabPage();
            panel2 = new Panel();
            tb_apelido = new TextBox();
            label20 = new Label();
            btn_exportar = new Button();
            btn_limpar = new Button();
            label9 = new Label();
            tb_numero = new TextBox();
            lbl_ID = new Label();
            lbl_info_ID = new Label();
            pic_Funcionario = new PictureBox();
            btn_remover = new Button();
            btn_adicionar = new Button();
            label8 = new Label();
            tb_contacto = new TextBox();
            label7 = new Label();
            tb_morada = new TextBox();
            label5 = new Label();
            tb_nome = new TextBox();
            label6 = new Label();
            panel_lateral = new Panel();
            lst_funcionarios_registo = new ListBox();
            label4 = new Label();
            panel_top_funcionario = new Panel();
            label17 = new Label();
            tP_servicos = new TabPage();
            panel6 = new Panel();
            lst_servicos_registo = new ListBox();
            label18 = new Label();
            panel4 = new Panel();
            btn_exp_servicos = new Button();
            label29 = new Label();
            tb_servico_desc = new TextBox();
            lbl_servico_id = new Label();
            label28 = new Label();
            label10 = new Label();
            tb_servico_sigla = new TextBox();
            label11 = new Label();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            btn_remover_servico = new Button();
            btn_adicionar_servico = new Button();
            label13 = new Label();
            tb_servico_fim = new TextBox();
            label14 = new Label();
            tb_servico_inicio = new TextBox();
            label15 = new Label();
            tb_servico_nome = new TextBox();
            label16 = new Label();
            panel_top_servicos = new Panel();
            label19 = new Label();
            tP_impressao = new TabPage();
            panel_menu.SuspendLayout();
            tc_Main.SuspendLayout();
            tP_main.SuspendLayout();
            tP_nEscala.SuspendLayout();
            panel_mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscala).BeginInit();
            panel_top.SuspendLayout();
            tP_cEscalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dG_Escala).BeginInit();
            panel3.SuspendLayout();
            tP_funcionarios.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Funcionario).BeginInit();
            panel_lateral.SuspendLayout();
            panel_top_funcionario.SuspendLayout();
            tP_servicos.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_top_servicos.SuspendLayout();
            SuspendLayout();
            // 
            // btn_gerarEscala
            // 
            btn_gerarEscala.FlatStyle = FlatStyle.Flat;
            btn_gerarEscala.Location = new Point(3, 2);
            btn_gerarEscala.Margin = new Padding(3, 2, 3, 2);
            btn_gerarEscala.Name = "btn_gerarEscala";
            btn_gerarEscala.Size = new Size(127, 34);
            btn_gerarEscala.TabIndex = 2;
            btn_gerarEscala.Text = "Nova Escala";
            btn_gerarEscala.UseVisualStyleBackColor = true;
            btn_gerarEscala.Click += btn_gerarEscala_Click;
            // 
            // panel_menu
            // 
            panel_menu.BackColor = SystemColors.Control;
            panel_menu.Controls.Add(btn_escalas);
            panel_menu.Controls.Add(btn_turnos);
            panel_menu.Controls.Add(btn_funcionarios);
            panel_menu.Controls.Add(btn_sair);
            panel_menu.Controls.Add(btn_gerarEscala);
            panel_menu.Dock = DockStyle.Left;
            panel_menu.ForeColor = Color.Black;
            panel_menu.Location = new Point(0, 0);
            panel_menu.Margin = new Padding(3, 2, 3, 2);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(132, 479);
            panel_menu.TabIndex = 3;
            // 
            // btn_escalas
            // 
            btn_escalas.FlatStyle = FlatStyle.Flat;
            btn_escalas.Location = new Point(3, 40);
            btn_escalas.Margin = new Padding(3, 2, 3, 2);
            btn_escalas.Name = "btn_escalas";
            btn_escalas.Size = new Size(127, 34);
            btn_escalas.TabIndex = 6;
            btn_escalas.Text = "Consultar Escala";
            btn_escalas.UseVisualStyleBackColor = true;
            btn_escalas.Click += btn_escalas_Click;
            // 
            // btn_turnos
            // 
            btn_turnos.FlatStyle = FlatStyle.Flat;
            btn_turnos.Location = new Point(2, 78);
            btn_turnos.Margin = new Padding(3, 2, 3, 2);
            btn_turnos.Name = "btn_turnos";
            btn_turnos.Size = new Size(127, 34);
            btn_turnos.TabIndex = 5;
            btn_turnos.Text = "Serviços";
            btn_turnos.UseVisualStyleBackColor = true;
            btn_turnos.Click += btn_turnos_Click;
            // 
            // btn_funcionarios
            // 
            btn_funcionarios.FlatStyle = FlatStyle.Flat;
            btn_funcionarios.Location = new Point(2, 116);
            btn_funcionarios.Margin = new Padding(3, 2, 3, 2);
            btn_funcionarios.Name = "btn_funcionarios";
            btn_funcionarios.Size = new Size(127, 34);
            btn_funcionarios.TabIndex = 4;
            btn_funcionarios.Text = "Funcionários";
            btn_funcionarios.UseVisualStyleBackColor = true;
            btn_funcionarios.Click += btn_funcionarios_Click;
            // 
            // btn_sair
            // 
            btn_sair.Dock = DockStyle.Bottom;
            btn_sair.Location = new Point(0, 445);
            btn_sair.Margin = new Padding(3, 2, 3, 2);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(132, 34);
            btn_sair.TabIndex = 3;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // tc_Main
            // 
            tc_Main.Controls.Add(tP_main);
            tc_Main.Controls.Add(tP_nEscala);
            tc_Main.Controls.Add(tP_cEscalas);
            tc_Main.Controls.Add(tP_funcionarios);
            tc_Main.Controls.Add(tP_servicos);
            tc_Main.Controls.Add(tP_impressao);
            tc_Main.Dock = DockStyle.Fill;
            tc_Main.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tc_Main.Location = new Point(132, 0);
            tc_Main.Margin = new Padding(0);
            tc_Main.Name = "tc_Main";
            tc_Main.SelectedIndex = 0;
            tc_Main.Size = new Size(823, 479);
            tc_Main.TabIndex = 4;
            tc_Main.TabStop = false;
            // 
            // tP_main
            // 
            tP_main.BackColor = Color.Transparent;
            tP_main.Controls.Add(label21);
            tP_main.Controls.Add(label22);
            tP_main.Controls.Add(label23);
            tP_main.Controls.Add(label24);
            tP_main.Controls.Add(label25);
            tP_main.Controls.Add(label26);
            tP_main.Controls.Add(label27);
            tP_main.Location = new Point(4, 26);
            tP_main.Name = "tP_main";
            tP_main.Padding = new Padding(3);
            tP_main.Size = new Size(815, 449);
            tP_main.TabIndex = 5;
            tP_main.Text = "Main";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F);
            label21.Location = new Point(556, 389);
            label21.Name = "label21";
            label21.Size = new Size(178, 21);
            label21.TabIndex = 13;
            label21.Text = "1800197 - José Campos";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(556, 347);
            label22.Name = "label22";
            label22.Size = new Size(209, 21);
            label22.TabIndex = 12;
            label22.Text = "2201083 - Marcelo Bregieira";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(556, 368);
            label23.Name = "label23";
            label23.Size = new Size(186, 21);
            label23.TabIndex = 11;
            label23.Text = "2104851 - António Vieira";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F);
            label24.Location = new Point(556, 326);
            label24.Name = "label24";
            label24.Size = new Size(199, 21);
            label24.TabIndex = 10;
            label24.Text = "2200037 - Marco Martinho";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F);
            label25.Location = new Point(556, 305);
            label25.Name = "label25";
            label25.Size = new Size(201, 21);
            label25.TabIndex = 9;
            label25.Text = "2003918 - Ricardo Sanches";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(464, 275);
            label26.Name = "label26";
            label26.Size = new Size(183, 21);
            label26.TabIndex = 8;
            label26.Text = "Projeto elaborado por:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(234, 142);
            label27.Name = "label27";
            label27.Size = new Size(312, 86);
            label27.TabIndex = 7;
            label27.Text = "GesEscala";
            // 
            // tP_nEscala
            // 
            tP_nEscala.Controls.Add(panel_mid);
            tP_nEscala.Controls.Add(panel_top);
            tP_nEscala.Location = new Point(4, 26);
            tP_nEscala.Margin = new Padding(3, 2, 3, 2);
            tP_nEscala.Name = "tP_nEscala";
            tP_nEscala.Padding = new Padding(3, 2, 3, 2);
            tP_nEscala.Size = new Size(815, 449);
            tP_nEscala.TabIndex = 0;
            tP_nEscala.Text = "Nova Escala";
            tP_nEscala.UseVisualStyleBackColor = true;
            // 
            // panel_mid
            // 
            panel_mid.Controls.Add(label2);
            panel_mid.Controls.Add(dataGridViewEscala);
            panel_mid.Controls.Add(btn_GuardarEscaka);
            panel_mid.Controls.Add(label1);
            panel_mid.Controls.Add(lbl_servicoEscala);
            panel_mid.Controls.Add(lbl_funcionarioEscala);
            panel_mid.Controls.Add(lbl_diaEscala);
            panel_mid.Controls.Add(comboFuncionario);
            panel_mid.Controls.Add(btn_escala_lcampos);
            panel_mid.Controls.Add(comboServico);
            panel_mid.Controls.Add(btn_add_escala);
            panel_mid.Controls.Add(txt_diaEscalar);
            panel_mid.Controls.Add(monthCalendar1);
            panel_mid.Dock = DockStyle.Fill;
            panel_mid.Location = new Point(3, 35);
            panel_mid.Name = "panel_mid";
            panel_mid.Size = new Size(809, 412);
            panel_mid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(56, 22);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 13;
            label2.Text = "Atribuir Tarefas:";
            // 
            // dataGridViewEscala
            // 
            dataGridViewEscala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEscala.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewEscala.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewEscala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEscala.Columns.AddRange(new DataGridViewColumn[] { SID, SNome, FID, FNumero, FNome, FApelido });
            dataGridViewEscala.Location = new Point(30, 246);
            dataGridViewEscala.Name = "dataGridViewEscala";
            dataGridViewEscala.ReadOnly = true;
            dataGridViewEscala.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEscala.Size = new Size(743, 150);
            dataGridViewEscala.TabIndex = 12;
            // 
            // SID
            // 
            SID.HeaderText = "SID";
            SID.Name = "SID";
            SID.ReadOnly = true;
            SID.Visible = false;
            // 
            // SNome
            // 
            SNome.HeaderText = "SNome";
            SNome.Name = "SNome";
            SNome.ReadOnly = true;
            // 
            // FID
            // 
            FID.HeaderText = "FID";
            FID.Name = "FID";
            FID.ReadOnly = true;
            FID.Visible = false;
            // 
            // FNumero
            // 
            FNumero.HeaderText = "FNumero";
            FNumero.Name = "FNumero";
            FNumero.ReadOnly = true;
            // 
            // FNome
            // 
            FNome.HeaderText = "Fnome";
            FNome.Name = "FNome";
            FNome.ReadOnly = true;
            // 
            // FApelido
            // 
            FApelido.HeaderText = "Fapelido";
            FApelido.Name = "FApelido";
            FApelido.ReadOnly = true;
            // 
            // btn_GuardarEscaka
            // 
            btn_GuardarEscaka.FlatStyle = FlatStyle.Flat;
            btn_GuardarEscaka.Location = new Point(380, 176);
            btn_GuardarEscaka.Margin = new Padding(3, 2, 3, 2);
            btn_GuardarEscaka.Name = "btn_GuardarEscaka";
            btn_GuardarEscaka.Size = new Size(152, 29);
            btn_GuardarEscaka.TabIndex = 11;
            btn_GuardarEscaka.Text = "Concluir/Publicar";
            btn_GuardarEscaka.UseVisualStyleBackColor = true;
            btn_GuardarEscaka.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 226);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 10;
            label1.Text = " Escala temporária:";
            // 
            // lbl_servicoEscala
            // 
            lbl_servicoEscala.AutoSize = true;
            lbl_servicoEscala.Location = new Point(83, 100);
            lbl_servicoEscala.Name = "lbl_servicoEscala";
            lbl_servicoEscala.Size = new Size(112, 17);
            lbl_servicoEscala.TabIndex = 7;
            lbl_servicoEscala.Text = "Serviço a escalar:";
            // 
            // lbl_funcionarioEscala
            // 
            lbl_funcionarioEscala.AutoSize = true;
            lbl_funcionarioEscala.Location = new Point(56, 129);
            lbl_funcionarioEscala.Name = "lbl_funcionarioEscala";
            lbl_funcionarioEscala.Size = new Size(139, 17);
            lbl_funcionarioEscala.TabIndex = 6;
            lbl_funcionarioEscala.Text = "Funcionário a escalar:";
            // 
            // lbl_diaEscala
            // 
            lbl_diaEscala.AutoSize = true;
            lbl_diaEscala.Location = new Point(108, 72);
            lbl_diaEscala.Name = "lbl_diaEscala";
            lbl_diaEscala.Size = new Size(87, 17);
            lbl_diaEscala.TabIndex = 5;
            lbl_diaEscala.Text = "Dia a escalar:";
            // 
            // comboFuncionario
            // 
            comboFuncionario.FormattingEnabled = true;
            comboFuncionario.Location = new Point(201, 126);
            comboFuncionario.Margin = new Padding(3, 2, 3, 2);
            comboFuncionario.Name = "comboFuncionario";
            comboFuncionario.Size = new Size(178, 25);
            comboFuncionario.TabIndex = 1;
            // 
            // btn_escala_lcampos
            // 
            btn_escala_lcampos.FlatStyle = FlatStyle.Flat;
            btn_escala_lcampos.Location = new Point(201, 176);
            btn_escala_lcampos.Margin = new Padding(3, 2, 3, 2);
            btn_escala_lcampos.Name = "btn_escala_lcampos";
            btn_escala_lcampos.Size = new Size(152, 29);
            btn_escala_lcampos.TabIndex = 4;
            btn_escala_lcampos.Text = "Limpar Campos";
            btn_escala_lcampos.UseVisualStyleBackColor = true;
            btn_escala_lcampos.Click += btn_escala_lcampos_Click;
            // 
            // comboServico
            // 
            comboServico.FormattingEnabled = true;
            comboServico.Location = new Point(201, 97);
            comboServico.Margin = new Padding(3, 2, 3, 2);
            comboServico.Name = "comboServico";
            comboServico.Size = new Size(178, 25);
            comboServico.TabIndex = 0;
            comboServico.SelectedIndexChanged += comboServico_SelectedIndexChanged;
            // 
            // btn_add_escala
            // 
            btn_add_escala.AutoSize = true;
            btn_add_escala.FlatStyle = FlatStyle.Flat;
            btn_add_escala.Location = new Point(30, 176);
            btn_add_escala.Margin = new Padding(3, 2, 3, 2);
            btn_add_escala.Name = "btn_add_escala";
            btn_add_escala.Size = new Size(152, 29);
            btn_add_escala.TabIndex = 3;
            btn_add_escala.Text = "Adicionar";
            btn_add_escala.UseVisualStyleBackColor = true;
            btn_add_escala.Click += btn_add_escala_Click;
            // 
            // txt_diaEscalar
            // 
            txt_diaEscalar.Location = new Point(201, 68);
            txt_diaEscalar.Margin = new Padding(3, 2, 3, 2);
            txt_diaEscalar.Name = "txt_diaEscalar";
            txt_diaEscalar.ReadOnly = true;
            txt_diaEscalar.Size = new Size(110, 25);
            txt_diaEscalar.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(556, 31);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(99, 99, 99);
            panel_top.Controls.Add(lbl_escalaDia);
            panel_top.Controls.Add(lbl_diaEscalar);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(3, 2);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(809, 33);
            panel_top.TabIndex = 0;
            // 
            // lbl_escalaDia
            // 
            lbl_escalaDia.AutoSize = true;
            lbl_escalaDia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_escalaDia.ForeColor = SystemColors.Control;
            lbl_escalaDia.Location = new Point(14, 9);
            lbl_escalaDia.Name = "lbl_escalaDia";
            lbl_escalaDia.Size = new Size(231, 21);
            lbl_escalaDia.TabIndex = 8;
            lbl_escalaDia.Text = "Programar a  escala para o dia:";
            lbl_escalaDia.Click += lbl_escalaDia_Click;
            // 
            // lbl_diaEscalar
            // 
            lbl_diaEscalar.AutoSize = true;
            lbl_diaEscalar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_diaEscalar.ForeColor = SystemColors.Control;
            lbl_diaEscalar.Location = new Point(251, 9);
            lbl_diaEscalar.Name = "lbl_diaEscalar";
            lbl_diaEscalar.Size = new Size(112, 21);
            lbl_diaEscalar.TabIndex = 9;
            lbl_diaEscalar.Text = "YYYY/MM/DD";
            // 
            // tP_cEscalas
            // 
            tP_cEscalas.BackColor = Color.White;
            tP_cEscalas.Controls.Add(btn_impr_escala);
            tP_cEscalas.Controls.Add(dG_Escala);
            tP_cEscalas.Controls.Add(calendario_mensal);
            tP_cEscalas.Controls.Add(panel3);
            tP_cEscalas.Location = new Point(4, 26);
            tP_cEscalas.Margin = new Padding(3, 2, 3, 2);
            tP_cEscalas.Name = "tP_cEscalas";
            tP_cEscalas.Padding = new Padding(3, 2, 3, 2);
            tP_cEscalas.Size = new Size(815, 449);
            tP_cEscalas.TabIndex = 1;
            tP_cEscalas.Text = "Consultar escala";
            // 
            // btn_impr_escala
            // 
            btn_impr_escala.FlatStyle = FlatStyle.Flat;
            btn_impr_escala.Location = new Point(683, 392);
            btn_impr_escala.Name = "btn_impr_escala";
            btn_impr_escala.Size = new Size(124, 49);
            btn_impr_escala.TabIndex = 7;
            btn_impr_escala.Text = "&Imprimir Escala";
            btn_impr_escala.UseVisualStyleBackColor = true;
            btn_impr_escala.Click += btn_impr_escala_Click;
            // 
            // dG_Escala
            // 
            dG_Escala.AllowUserToAddRows = false;
            dG_Escala.AllowUserToDeleteRows = false;
            dG_Escala.AllowUserToResizeColumns = false;
            dG_Escala.AllowUserToResizeRows = false;
            dG_Escala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dG_Escala.BackgroundColor = SystemColors.ControlLightLight;
            dG_Escala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dG_Escala.Columns.AddRange(new DataGridViewColumn[] { col_sNome, col_sig, col_inicio, col_fim, col_fnumero, col_fnome, col_fapelido });
            dG_Escala.Dock = DockStyle.Fill;
            dG_Escala.Location = new Point(3, 35);
            dG_Escala.Name = "dG_Escala";
            dG_Escala.ReadOnly = true;
            dG_Escala.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dG_Escala.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dG_Escala.Size = new Size(809, 250);
            dG_Escala.TabIndex = 6;
            // 
            // col_sNome
            // 
            col_sNome.HeaderText = "SNome";
            col_sNome.MinimumWidth = 6;
            col_sNome.Name = "col_sNome";
            col_sNome.ReadOnly = true;
            // 
            // col_sig
            // 
            col_sig.HeaderText = "Sigla";
            col_sig.MinimumWidth = 6;
            col_sig.Name = "col_sig";
            col_sig.ReadOnly = true;
            // 
            // col_inicio
            // 
            col_inicio.HeaderText = "Inicio";
            col_inicio.MinimumWidth = 6;
            col_inicio.Name = "col_inicio";
            col_inicio.ReadOnly = true;
            // 
            // col_fim
            // 
            col_fim.HeaderText = "Fim";
            col_fim.MinimumWidth = 6;
            col_fim.Name = "col_fim";
            col_fim.ReadOnly = true;
            // 
            // col_fnumero
            // 
            col_fnumero.HeaderText = "Numero";
            col_fnumero.MinimumWidth = 6;
            col_fnumero.Name = "col_fnumero";
            col_fnumero.ReadOnly = true;
            // 
            // col_fnome
            // 
            col_fnome.HeaderText = "Nome";
            col_fnome.MinimumWidth = 6;
            col_fnome.Name = "col_fnome";
            col_fnome.ReadOnly = true;
            // 
            // col_fapelido
            // 
            col_fapelido.HeaderText = "Apelido";
            col_fapelido.MinimumWidth = 6;
            col_fapelido.Name = "col_fapelido";
            col_fapelido.ReadOnly = true;
            // 
            // calendario_mensal
            // 
            calendario_mensal.CalendarDimensions = new Size(3, 1);
            calendario_mensal.Dock = DockStyle.Bottom;
            calendario_mensal.Location = new Point(3, 285);
            calendario_mensal.MaxSelectionCount = 1;
            calendario_mensal.Name = "calendario_mensal";
            calendario_mensal.TabIndex = 5;
            calendario_mensal.DateChanged += monthCalendar2_DateChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(99, 99, 99);
            panel3.Controls.Add(label31);
            panel3.Controls.Add(lbl_info_escala_dia);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(809, 33);
            panel3.TabIndex = 2;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.ForeColor = SystemColors.ButtonHighlight;
            label31.Location = new Point(102, 9);
            label31.Name = "label31";
            label31.Size = new Size(92, 17);
            label31.TabIndex = 7;
            label31.Text = "YYYY-MM-DD";
            // 
            // lbl_info_escala_dia
            // 
            lbl_info_escala_dia.AutoSize = true;
            lbl_info_escala_dia.ForeColor = SystemColors.ButtonHighlight;
            lbl_info_escala_dia.Location = new Point(3, 9);
            lbl_info_escala_dia.Name = "lbl_info_escala_dia";
            lbl_info_escala_dia.Size = new Size(93, 17);
            lbl_info_escala_dia.TabIndex = 0;
            lbl_info_escala_dia.Text = "Escala do dia: ";
            // 
            // tP_funcionarios
            // 
            tP_funcionarios.Controls.Add(panel2);
            tP_funcionarios.Controls.Add(panel_lateral);
            tP_funcionarios.Controls.Add(panel_top_funcionario);
            tP_funcionarios.Location = new Point(4, 26);
            tP_funcionarios.Name = "tP_funcionarios";
            tP_funcionarios.Padding = new Padding(3);
            tP_funcionarios.Size = new Size(815, 449);
            tP_funcionarios.TabIndex = 2;
            tP_funcionarios.Text = "Funcionários";
            tP_funcionarios.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(tb_apelido);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(btn_exportar);
            panel2.Controls.Add(btn_limpar);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(tb_numero);
            panel2.Controls.Add(lbl_ID);
            panel2.Controls.Add(lbl_info_ID);
            panel2.Controls.Add(pic_Funcionario);
            panel2.Controls.Add(btn_remover);
            panel2.Controls.Add(btn_adicionar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(tb_contacto);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tb_morada);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tb_nome);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 410);
            panel2.TabIndex = 5;
            // 
            // tb_apelido
            // 
            tb_apelido.Location = new Point(100, 217);
            tb_apelido.Name = "tb_apelido";
            tb_apelido.Size = new Size(284, 25);
            tb_apelido.TabIndex = 29;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Location = new Point(37, 220);
            label20.Name = "label20";
            label20.Size = new Size(57, 17);
            label20.TabIndex = 31;
            label20.Text = "Apelido:";
            // 
            // btn_exportar
            // 
            btn_exportar.Location = new Point(408, 358);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(102, 30);
            btn_exportar.TabIndex = 30;
            btn_exportar.Text = "&Exportar PDF";
            btn_exportar.UseVisualStyleBackColor = true;
            btn_exportar.Click += btn_exportar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(192, 358);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(102, 30);
            btn_limpar.TabIndex = 33;
            btn_limpar.Text = "&Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 158);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 28;
            label9.Text = "Numero:";
            // 
            // tb_numero
            // 
            tb_numero.Location = new Point(100, 155);
            tb_numero.Name = "tb_numero";
            tb_numero.Size = new Size(93, 25);
            tb_numero.TabIndex = 27;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.ForeColor = Color.IndianRed;
            lbl_ID.Location = new Point(92, 116);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(0, 17);
            lbl_ID.TabIndex = 26;
            // 
            // lbl_info_ID
            // 
            lbl_info_ID.AutoSize = true;
            lbl_info_ID.Location = new Point(70, 116);
            lbl_info_ID.Name = "lbl_info_ID";
            lbl_info_ID.Size = new Size(24, 17);
            lbl_info_ID.TabIndex = 25;
            lbl_info_ID.Text = "ID:";
            // 
            // pic_Funcionario
            // 
            pic_Funcionario.Image = (Image)resources.GetObject("pic_Funcionario.Image");
            pic_Funcionario.Location = new Point(30, 35);
            pic_Funcionario.Name = "pic_Funcionario";
            pic_Funcionario.Size = new Size(64, 64);
            pic_Funcionario.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_Funcionario.TabIndex = 24;
            pic_Funcionario.TabStop = false;
            // 
            // btn_remover
            // 
            btn_remover.Enabled = false;
            btn_remover.Location = new Point(300, 358);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(102, 30);
            btn_remover.TabIndex = 34;
            btn_remover.Text = "&Remover";
            btn_remover.UseVisualStyleBackColor = true;
            btn_remover.Click += btn_remover_Click;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(84, 358);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(102, 30);
            btn_adicionar.TabIndex = 32;
            btn_adicionar.Text = "&Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 282);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 21;
            label8.Text = "Contacto:";
            // 
            // tb_contacto
            // 
            tb_contacto.Location = new Point(100, 279);
            tb_contacto.Name = "tb_contacto";
            tb_contacto.Size = new Size(184, 25);
            tb_contacto.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 251);
            label7.Name = "label7";
            label7.Size = new Size(58, 17);
            label7.TabIndex = 19;
            label7.Text = "Morada:";
            // 
            // tb_morada
            // 
            tb_morada.Location = new Point(100, 248);
            tb_morada.Name = "tb_morada";
            tb_morada.Size = new Size(384, 25);
            tb_morada.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 189);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 17;
            label5.Text = "Nome:";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(100, 186);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(284, 25);
            tb_nome.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 11);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 5;
            label6.Text = "Funcionário";
            // 
            // panel_lateral
            // 
            panel_lateral.BackColor = Color.FromArgb(99, 99, 99);
            panel_lateral.BorderStyle = BorderStyle.FixedSingle;
            panel_lateral.Controls.Add(lst_funcionarios_registo);
            panel_lateral.Controls.Add(label4);
            panel_lateral.Dock = DockStyle.Right;
            panel_lateral.ForeColor = SystemColors.ButtonFace;
            panel_lateral.Location = new Point(530, 36);
            panel_lateral.Name = "panel_lateral";
            panel_lateral.Size = new Size(282, 410);
            panel_lateral.TabIndex = 4;
            // 
            // lst_funcionarios_registo
            // 
            lst_funcionarios_registo.BorderStyle = BorderStyle.FixedSingle;
            lst_funcionarios_registo.Dock = DockStyle.Fill;
            lst_funcionarios_registo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lst_funcionarios_registo.FormattingEnabled = true;
            lst_funcionarios_registo.ItemHeight = 17;
            lst_funcionarios_registo.Location = new Point(0, 21);
            lst_funcionarios_registo.Name = "lst_funcionarios_registo";
            lst_funcionarios_registo.Size = new Size(280, 387);
            lst_funcionarios_registo.TabIndex = 3;
            lst_funcionarios_registo.SelectedIndexChanged += lst_funcionarios_registo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(185, 21);
            label4.TabIndex = 4;
            label4.Text = "Funcionários em registo";
            // 
            // panel_top_funcionario
            // 
            panel_top_funcionario.BackColor = Color.FromArgb(99, 99, 99);
            panel_top_funcionario.Controls.Add(label17);
            panel_top_funcionario.Dock = DockStyle.Top;
            panel_top_funcionario.Location = new Point(3, 3);
            panel_top_funcionario.Name = "panel_top_funcionario";
            panel_top_funcionario.Size = new Size(809, 33);
            panel_top_funcionario.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(3, 9);
            label17.Name = "label17";
            label17.Size = new Size(150, 17);
            label17.TabIndex = 0;
            label17.Text = "Gestão de Funcionários";
            // 
            // tP_servicos
            // 
            tP_servicos.Controls.Add(panel6);
            tP_servicos.Controls.Add(panel4);
            tP_servicos.Controls.Add(panel_top_servicos);
            tP_servicos.Location = new Point(4, 26);
            tP_servicos.Name = "tP_servicos";
            tP_servicos.Size = new Size(815, 449);
            tP_servicos.TabIndex = 3;
            tP_servicos.Text = "Serviços";
            tP_servicos.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(lst_servicos_registo);
            panel6.Controls.Add(label18);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(514, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(301, 416);
            panel6.TabIndex = 34;
            // 
            // lst_servicos_registo
            // 
            lst_servicos_registo.BorderStyle = BorderStyle.FixedSingle;
            lst_servicos_registo.Dock = DockStyle.Fill;
            lst_servicos_registo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lst_servicos_registo.FormattingEnabled = true;
            lst_servicos_registo.ItemHeight = 17;
            lst_servicos_registo.Location = new Point(0, 21);
            lst_servicos_registo.Name = "lst_servicos_registo";
            lst_servicos_registo.Size = new Size(301, 395);
            lst_servicos_registo.TabIndex = 33;
            lst_servicos_registo.SelectedIndexChanged += lst_servicos_registo_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Top;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(0, 0);
            label18.Name = "label18";
            label18.Size = new Size(155, 21);
            label18.TabIndex = 34;
            label18.Text = "Serviços em registo";
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_exp_servicos);
            panel4.Controls.Add(label29);
            panel4.Controls.Add(tb_servico_desc);
            panel4.Controls.Add(lbl_servico_id);
            panel4.Controls.Add(label28);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(tb_servico_sigla);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btn_remover_servico);
            panel4.Controls.Add(btn_adicionar_servico);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(tb_servico_fim);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(tb_servico_inicio);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(tb_servico_nome);
            panel4.Controls.Add(label16);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(815, 416);
            panel4.TabIndex = 0;
            // 
            // btn_exp_servicos
            // 
            btn_exp_servicos.Location = new Point(395, 367);
            btn_exp_servicos.Name = "btn_exp_servicos";
            btn_exp_servicos.Size = new Size(102, 30);
            btn_exp_servicos.TabIndex = 51;
            btn_exp_servicos.Text = "&Exportar PDF";
            btn_exp_servicos.UseVisualStyleBackColor = true;
            btn_exp_servicos.Click += btn_exp_servicos_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(42, 186);
            label29.Name = "label29";
            label29.Size = new Size(68, 17);
            label29.TabIndex = 60;
            label29.Text = "Descrição:";
            // 
            // tb_servico_desc
            // 
            tb_servico_desc.Location = new Point(116, 183);
            tb_servico_desc.Name = "tb_servico_desc";
            tb_servico_desc.Size = new Size(224, 25);
            tb_servico_desc.TabIndex = 45;
            // 
            // lbl_servico_id
            // 
            lbl_servico_id.AutoSize = true;
            lbl_servico_id.Location = new Point(116, 121);
            lbl_servico_id.Name = "lbl_servico_id";
            lbl_servico_id.Size = new Size(21, 17);
            lbl_servico_id.TabIndex = 58;
            lbl_servico_id.Text = "ID";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(20, 14);
            label28.Name = "label28";
            label28.Size = new Size(72, 21);
            label28.TabIndex = 57;
            label28.Text = "Serviços";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 217);
            label10.Name = "label10";
            label10.Size = new Size(39, 17);
            label10.TabIndex = 56;
            label10.Text = "Sigla:";
            // 
            // tb_servico_sigla
            // 
            tb_servico_sigla.Location = new Point(116, 214);
            tb_servico_sigla.Name = "tb_servico_sigla";
            tb_servico_sigla.Size = new Size(85, 25);
            tb_servico_sigla.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.IndianRed;
            label11.Location = new Point(89, 138);
            label11.Name = "label11";
            label11.Size = new Size(0, 17);
            label11.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(86, 121);
            label12.Name = "label12";
            label12.Size = new Size(24, 17);
            label12.TabIndex = 53;
            label12.Text = "ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(26, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // btn_remover_servico
            // 
            btn_remover_servico.Location = new Point(278, 367);
            btn_remover_servico.Name = "btn_remover_servico";
            btn_remover_servico.Size = new Size(102, 30);
            btn_remover_servico.TabIndex = 50;
            btn_remover_servico.Text = "&Remover";
            btn_remover_servico.UseVisualStyleBackColor = true;
            btn_remover_servico.Click += btn_remover_servico_Click;
            // 
            // btn_adicionar_servico
            // 
            btn_adicionar_servico.Location = new Point(160, 367);
            btn_adicionar_servico.Name = "btn_adicionar_servico";
            btn_adicionar_servico.Size = new Size(102, 30);
            btn_adicionar_servico.TabIndex = 49;
            btn_adicionar_servico.Text = "&Adicionar";
            btn_adicionar_servico.UseVisualStyleBackColor = true;
            btn_adicionar_servico.Click += btn_adicionar_servico_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 279);
            label13.Name = "label13";
            label13.Size = new Size(64, 17);
            label13.TabIndex = 49;
            label13.Text = "Hora fim:";
            // 
            // tb_servico_fim
            // 
            tb_servico_fim.Location = new Point(116, 276);
            tb_servico_fim.Name = "tb_servico_fim";
            tb_servico_fim.Size = new Size(85, 25);
            tb_servico_fim.TabIndex = 48;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(33, 248);
            label14.Name = "label14";
            label14.Size = new Size(77, 17);
            label14.TabIndex = 47;
            label14.Text = "Hora Inicio:";
            // 
            // tb_servico_inicio
            // 
            tb_servico_inicio.Location = new Point(116, 245);
            tb_servico_inicio.Name = "tb_servico_inicio";
            tb_servico_inicio.Size = new Size(85, 25);
            tb_servico_inicio.TabIndex = 47;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(62, 155);
            label15.Name = "label15";
            label15.Size = new Size(48, 17);
            label15.TabIndex = 45;
            label15.Text = "Nome:";
            // 
            // tb_servico_nome
            // 
            tb_servico_nome.Location = new Point(116, 152);
            tb_servico_nome.Name = "tb_servico_nome";
            tb_servico_nome.Size = new Size(224, 25);
            tb_servico_nome.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(63, -28);
            label16.Name = "label16";
            label16.Size = new Size(65, 21);
            label16.TabIndex = 43;
            label16.Text = "Serviço";
            // 
            // panel_top_servicos
            // 
            panel_top_servicos.BackColor = Color.FromArgb(99, 99, 99);
            panel_top_servicos.Controls.Add(label19);
            panel_top_servicos.Dock = DockStyle.Top;
            panel_top_servicos.Location = new Point(0, 0);
            panel_top_servicos.Name = "panel_top_servicos";
            panel_top_servicos.Size = new Size(815, 33);
            panel_top_servicos.TabIndex = 33;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(3, 9);
            label19.Name = "label19";
            label19.Size = new Size(123, 17);
            label19.TabIndex = 0;
            label19.Text = "Gestão de Serviços";
            // 
            // tP_impressao
            // 
            tP_impressao.Location = new Point(4, 26);
            tP_impressao.Name = "tP_impressao";
            tP_impressao.Size = new Size(815, 449);
            tP_impressao.TabIndex = 4;
            tP_impressao.Text = "Impressão";
            tP_impressao.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(955, 479);
            Controls.Add(tc_Main);
            Controls.Add(panel_menu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "GesEscala - Equipa 15 - LDS UAB";
            panel_menu.ResumeLayout(false);
            tc_Main.ResumeLayout(false);
            tP_main.ResumeLayout(false);
            tP_main.PerformLayout();
            tP_nEscala.ResumeLayout(false);
            panel_mid.ResumeLayout(false);
            panel_mid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscala).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            tP_cEscalas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dG_Escala).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tP_funcionarios.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Funcionario).EndInit();
            panel_lateral.ResumeLayout(false);
            panel_lateral.PerformLayout();
            panel_top_funcionario.ResumeLayout(false);
            panel_top_funcionario.PerformLayout();
            tP_servicos.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_top_servicos.ResumeLayout(false);
            panel_top_servicos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_gerarEscala;
        private Panel panel_menu;
        private Button btn_escalas;
        private Button btn_turnos;
        private Button btn_funcionarios;
        private Button btn_sair;
        private TabControl tc_Main;
        private TabPage tP_nEscala;
        private TabPage tP_cEscalas;
        private Panel panel_top;
        private Panel panel_mid;
        private TabPage tP_funcionarios;
        private TabPage tP_servicos;
        private TabPage tP_impressao;
        private TabPage tP_main;
        private Panel panel_lateral;
        private Label label4;
        private Panel panel6;
        private ListBox lst_servicos_registo;
        private Label label18;
        private Panel panel4;
        private Label label10;
        private TextBox tb_servico_sigla;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox1;
        private Button btn_remover_servico;
        private Button btn_adicionar_servico;
        private Label label13;
        private TextBox tb_servico_fim;
        private Label label14;
        private TextBox tb_servico_inicio;
        private Label label15;
        private TextBox tb_servico_nome;
        private Label label16;
        private Panel panel_top_servicos;
        private Label label19;
        private Panel panel2;
        private Label label9;
        private TextBox tb_numero;
        private Label lbl_ID;
        private Label lbl_info_ID;
        private PictureBox pic_Funcionario;
        private Button btn_remover;
        private Button btn_adicionar;
        private Label label8;
        private TextBox tb_contacto;
        private Label label7;
        private TextBox tb_morada;
        private Label label5;
        private TextBox tb_nome;
        private Label label6;
        private ListBox lst_funcionarios_registo;
        private Panel panel_top_funcionario;
        private Label label17;
        private Button btn_exportar;
        private Button btn_limpar;
        private Label label20;
        private TextBox tb_apelido;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label lbl_servico_id;
        private Label label29;
        private TextBox tb_servico_desc;
        private Panel panel3;
        private Label lbl_info_escala_dia;
        private MonthCalendar calendario_mensal;
        private DataGridView dG_Escala;
        private Label label31;
        private Button btn_exp_servicos;
        private Button btn_impr_escala;
        private DataGridViewTextBoxColumn col_sNome;
        private DataGridViewTextBoxColumn col_sig;
        private DataGridViewTextBoxColumn col_inicio;
        private DataGridViewTextBoxColumn col_fim;
        private DataGridViewTextBoxColumn col_fnumero;
        private DataGridViewTextBoxColumn col_fnome;
        private DataGridViewTextBoxColumn col_fapelido;
        private MonthCalendar monthCalendar1;
        private ComboBox comboServico;
        private Button btn_escala_lcampos;
        private Button btn_add_escala;
        private ComboBox comboFuncionario;
        private TextBox txt_diaEscalar;
        private Label lbl_diaEscala;
        private Label lbl_servicoEscala;
        private Label lbl_funcionarioEscala;
        private Label lbl_escalaDia;
        private Label lbl_diaEscalar;
        private Button btn_GuardarEscaka;
        private Label label1;
        private DataGridView dataGridViewEscala;
        private DataGridViewTextBoxColumn SNome;
        private DataGridViewTextBoxColumn FNumero;
        private DataGridViewTextBoxColumn FNome;
        private DataGridViewTextBoxColumn FApelido;
        private DataGridViewTextBoxColumn SID;
        private DataGridViewTextBoxColumn FID;
        private Label label2;
    }
}

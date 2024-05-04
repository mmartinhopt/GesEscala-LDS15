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
            panel_direito = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            btn_adicionar_svc = new Button();
            listBox_Efetivo = new ListBox();
            label2 = new Label();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            panel_mid = new Panel();
            dgv_novaEscala = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel_top = new Panel();
            label1 = new Label();
            tP_cEscalas = new TabPage();
            tP_funcionarios = new TabPage();
            panel2 = new Panel();
            tb_apelido = new TextBox();
            label20 = new Label();
            btn_alterar = new Button();
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
            panel3 = new Panel();
            label17 = new Label();
            tP_servicos = new TabPage();
            panel6 = new Panel();
            listBox1 = new ListBox();
            label18 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            label13 = new Label();
            textBox2 = new TextBox();
            label14 = new Label();
            textBox3 = new TextBox();
            label15 = new Label();
            textBox4 = new TextBox();
            label16 = new Label();
            panel5 = new Panel();
            label19 = new Label();
            tP_impressao = new TabPage();
            panel_menu.SuspendLayout();
            tc_Main.SuspendLayout();
            tP_main.SuspendLayout();
            tP_nEscala.SuspendLayout();
            panel_direito.SuspendLayout();
            panel1.SuspendLayout();
            panel_mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_novaEscala).BeginInit();
            panel_top.SuspendLayout();
            tP_funcionarios.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Funcionario).BeginInit();
            panel_lateral.SuspendLayout();
            panel3.SuspendLayout();
            tP_servicos.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
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
            tP_main.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F);
            label21.Location = new Point(135, 250);
            label21.Name = "label21";
            label21.Size = new Size(178, 21);
            label21.TabIndex = 13;
            label21.Text = "XXXXXXX - José Campos";
            label21.Click += label21_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(135, 208);
            label22.Name = "label22";
            label22.Size = new Size(209, 21);
            label22.TabIndex = 12;
            label22.Text = "2201083 - Marcelo Bregieira";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(135, 229);
            label23.Name = "label23";
            label23.Size = new Size(186, 21);
            label23.TabIndex = 11;
            label23.Text = "2104851 - António Vieira";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F);
            label24.Location = new Point(135, 187);
            label24.Name = "label24";
            label24.Size = new Size(199, 21);
            label24.TabIndex = 10;
            label24.Text = "2200037 - Marco Martinho";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F);
            label25.Location = new Point(135, 166);
            label25.Name = "label25";
            label25.Size = new Size(201, 21);
            label25.TabIndex = 9;
            label25.Text = "2003918 - Ricardo Sanches";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(43, 136);
            label26.Name = "label26";
            label26.Size = new Size(183, 21);
            label26.TabIndex = 8;
            label26.Text = "Projeto elaborado por:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(93, 14);
            label27.Name = "label27";
            label27.Size = new Size(312, 86);
            label27.TabIndex = 7;
            label27.Text = "GesEscala";
            // 
            // tP_nEscala
            // 
            tP_nEscala.Controls.Add(panel_direito);
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
            // panel_direito
            // 
            panel_direito.BackColor = Color.FromArgb(99, 99, 99);
            panel_direito.BorderStyle = BorderStyle.FixedSingle;
            panel_direito.Controls.Add(panel1);
            panel_direito.Controls.Add(listBox_Efetivo);
            panel_direito.Controls.Add(label2);
            panel_direito.Controls.Add(label3);
            panel_direito.Controls.Add(monthCalendar1);
            panel_direito.Dock = DockStyle.Right;
            panel_direito.ForeColor = SystemColors.ButtonFace;
            panel_direito.Location = new Point(583, 35);
            panel_direito.Name = "panel_direito";
            panel_direito.Size = new Size(229, 412);
            panel_direito.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btn_adicionar_svc);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 27);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(108, 0);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(119, 27);
            button2.TabIndex = 9;
            button2.Text = "Remover svc";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_adicionar_svc
            // 
            btn_adicionar_svc.BackColor = SystemColors.Control;
            btn_adicionar_svc.Dock = DockStyle.Left;
            btn_adicionar_svc.FlatStyle = FlatStyle.Flat;
            btn_adicionar_svc.ForeColor = SystemColors.ActiveCaptionText;
            btn_adicionar_svc.Location = new Point(0, 0);
            btn_adicionar_svc.Margin = new Padding(3, 2, 3, 2);
            btn_adicionar_svc.Name = "btn_adicionar_svc";
            btn_adicionar_svc.Size = new Size(108, 27);
            btn_adicionar_svc.TabIndex = 8;
            btn_adicionar_svc.Text = "popular ";
            btn_adicionar_svc.UseVisualStyleBackColor = false;
            btn_adicionar_svc.Click += btn_adicionar_svc_Click;
            // 
            // listBox_Efetivo
            // 
            listBox_Efetivo.BorderStyle = BorderStyle.FixedSingle;
            listBox_Efetivo.Dock = DockStyle.Fill;
            listBox_Efetivo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox_Efetivo.FormattingEnabled = true;
            listBox_Efetivo.HorizontalScrollbar = true;
            listBox_Efetivo.IntegralHeight = false;
            listBox_Efetivo.ItemHeight = 17;
            listBox_Efetivo.Items.AddRange(new object[] { "209 - Rui", "102 - Pedro", "2030 - Miguel", "1 - Corrida", "Utilizadores registados", "quando tem função", "muda de cor conforme o ", "serviço" });
            listBox_Efetivo.Location = new Point(0, 21);
            listBox_Efetivo.Name = "listBox_Efetivo";
            listBox_Efetivo.Size = new Size(227, 206);
            listBox_Efetivo.TabIndex = 2;
            listBox_Efetivo.SelectedIndexChanged += listBox_Efetivo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 1;
            label2.Text = "Funcionários";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 227);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 5;
            label3.Text = "Calendario";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Dock = DockStyle.Bottom;
            monthCalendar1.Location = new Point(0, 248);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // panel_mid
            // 
            panel_mid.Controls.Add(dgv_novaEscala);
            panel_mid.Dock = DockStyle.Fill;
            panel_mid.Location = new Point(3, 35);
            panel_mid.Name = "panel_mid";
            panel_mid.Size = new Size(809, 412);
            panel_mid.TabIndex = 1;
            // 
            // dgv_novaEscala
            // 
            dgv_novaEscala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_novaEscala.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dgv_novaEscala.BackgroundColor = SystemColors.ControlLightLight;
            dgv_novaEscala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_novaEscala.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2 });
            dgv_novaEscala.Dock = DockStyle.Fill;
            dgv_novaEscala.Location = new Point(0, 0);
            dgv_novaEscala.Name = "dgv_novaEscala";
            dgv_novaEscala.Size = new Size(809, 412);
            dgv_novaEscala.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Serviço";
            Column1.Name = "Column1";
            Column1.Width = 77;
            // 
            // Column3
            // 
            Column3.HeaderText = "Horario";
            Column3.Name = "Column3";
            Column3.Width = 79;
            // 
            // Column2
            // 
            Column2.HeaderText = "Funcionarios";
            Column2.Name = "Column2";
            Column2.Width = 110;
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(99, 99, 99);
            panel_top.Controls.Add(label1);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(3, 2);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(809, 33);
            panel_top.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 17);
            label1.TabIndex = 0;
            label1.Text = "Escala do dia: XX/XX/XXXX";
            // 
            // tP_cEscalas
            // 
            tP_cEscalas.Location = new Point(4, 26);
            tP_cEscalas.Margin = new Padding(3, 2, 3, 2);
            tP_cEscalas.Name = "tP_cEscalas";
            tP_cEscalas.Padding = new Padding(3, 2, 3, 2);
            tP_cEscalas.Size = new Size(815, 449);
            tP_cEscalas.TabIndex = 1;
            tP_cEscalas.Text = "Consultar escala";
            tP_cEscalas.UseVisualStyleBackColor = true;
            // 
            // tP_funcionarios
            // 
            tP_funcionarios.Controls.Add(panel2);
            tP_funcionarios.Controls.Add(panel_lateral);
            tP_funcionarios.Controls.Add(panel3);
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
            panel2.Controls.Add(btn_alterar);
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
            tb_apelido.TabIndex = 32;
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
            label20.Click += label20_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Enabled = false;
            btn_alterar.Location = new Point(382, 319);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(102, 30);
            btn_alterar.TabIndex = 30;
            btn_alterar.Text = "&Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(274, 355);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(102, 30);
            btn_limpar.TabIndex = 29;
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
            btn_remover.Location = new Point(382, 355);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(102, 30);
            btn_remover.TabIndex = 23;
            btn_remover.Text = "&Remover";
            btn_remover.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(166, 355);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(102, 30);
            btn_adicionar.TabIndex = 22;
            btn_adicionar.Text = "&Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
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
            tb_contacto.TabIndex = 20;
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
            tb_morada.TabIndex = 18;
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
            tb_nome.TabIndex = 16;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(99, 99, 99);
            panel3.Controls.Add(label17);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(809, 33);
            panel3.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(3, 9);
            label17.Name = "label17";
            label17.Size = new Size(167, 17);
            label17.TabIndex = 0;
            label17.Text = "Escala do dia: XX/XX/XXXX";
            label17.Click += label17_Click;
            // 
            // tP_servicos
            // 
            tP_servicos.Controls.Add(panel6);
            tP_servicos.Controls.Add(panel4);
            tP_servicos.Controls.Add(panel5);
            tP_servicos.Location = new Point(4, 26);
            tP_servicos.Name = "tP_servicos";
            tP_servicos.Size = new Size(815, 449);
            tP_servicos.TabIndex = 3;
            tP_servicos.Text = "Serviços";
            tP_servicos.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(listBox1);
            panel6.Controls.Add(label18);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(558, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(257, 416);
            panel6.TabIndex = 34;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(0, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(257, 395);
            listBox1.TabIndex = 33;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Top;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(0, 0);
            label18.Name = "label18";
            label18.Size = new Size(185, 21);
            label18.TabIndex = 34;
            label18.Text = "Funcionários em registo";
            // 
            // panel4
            // 
            panel4.Controls.Add(label10);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label16);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(815, 416);
            panel4.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 182);
            label10.Name = "label10";
            label10.Size = new Size(39, 17);
            label10.TabIndex = 56;
            label10.Text = "Sigla:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(93, 25);
            textBox1.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.IndianRed;
            label11.Location = new Point(138, 98);
            label11.Name = "label11";
            label11.Size = new Size(0, 17);
            label11.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(116, 98);
            label12.Name = "label12";
            label12.Size = new Size(24, 17);
            label12.TabIndex = 53;
            label12.Text = "ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(287, 339);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 51;
            button1.Text = "&Remover";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(172, 339);
            button3.Name = "button3";
            button3.Size = new Size(102, 30);
            button3.TabIndex = 50;
            button3.Text = "&Adicionar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(74, 275);
            label13.Name = "label13";
            label13.Size = new Size(64, 17);
            label13.TabIndex = 49;
            label13.Text = "Hora fim:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 272);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 25);
            textBox2.TabIndex = 48;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(61, 232);
            label14.Name = "label14";
            label14.Size = new Size(77, 17);
            label14.TabIndex = 47;
            label14.Text = "Hora Inicio:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 25);
            textBox3.TabIndex = 46;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(90, 142);
            label15.Name = "label15";
            label15.Size = new Size(48, 17);
            label15.TabIndex = 45;
            label15.Text = "Nome:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 25);
            textBox4.TabIndex = 44;
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
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(99, 99, 99);
            panel5.Controls.Add(label19);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(815, 33);
            panel5.TabIndex = 33;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(3, 9);
            label19.Name = "label19";
            label19.Size = new Size(167, 17);
            label19.TabIndex = 0;
            label19.Text = "Escala do dia: XX/XX/XXXX";
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
            panel_direito.ResumeLayout(false);
            panel_direito.PerformLayout();
            panel1.ResumeLayout(false);
            panel_mid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_novaEscala).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            tP_funcionarios.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Funcionario).EndInit();
            panel_lateral.ResumeLayout(false);
            panel_lateral.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tP_servicos.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panel_direito;
        private DataGridView dgv_novaEscala;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private Label label2;
        private Panel panel1;
        private Button button2;
        private Button btn_adicionar_svc;
        private TabPage tP_funcionarios;
        private TabPage tP_servicos;
        private TabPage tP_impressao;
        private TabPage tP_main;
        private ListBox listBox_Efetivo;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Panel panel_lateral;
        private Label label4;
        private Panel panel6;
        private ListBox listBox1;
        private Label label18;
        private Panel panel4;
        private Label label10;
        private TextBox textBox1;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Label label13;
        private TextBox textBox2;
        private Label label14;
        private TextBox textBox3;
        private Label label15;
        private TextBox textBox4;
        private Label label16;
        private Panel panel5;
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
        private Panel panel3;
        private Label label17;
        private Button btn_alterar;
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
    }
}

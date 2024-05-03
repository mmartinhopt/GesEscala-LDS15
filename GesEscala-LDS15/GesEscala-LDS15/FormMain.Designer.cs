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
            tP_escala = new TabPage();
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
            tP_conEscalas = new TabPage();
            tP_funcionarios = new TabPage();
            panel2 = new Panel();
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
            tP_turnos = new TabPage();
            tP_impressao = new TabPage();
            tP_main = new TabPage();
            panel_menu.SuspendLayout();
            tc_Main.SuspendLayout();
            tP_escala.SuspendLayout();
            panel_direito.SuspendLayout();
            panel1.SuspendLayout();
            panel_mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_novaEscala).BeginInit();
            panel_top.SuspendLayout();
            tP_funcionarios.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Funcionario).BeginInit();
            panel_lateral.SuspendLayout();
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
            panel_menu.Size = new Size(132, 466);
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
            btn_escalas.Text = "Escalas";
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
            btn_turnos.Text = "Turnos";
            btn_turnos.UseVisualStyleBackColor = true;
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
            btn_sair.Location = new Point(0, 432);
            btn_sair.Margin = new Padding(3, 2, 3, 2);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(132, 34);
            btn_sair.TabIndex = 3;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            // 
            // tc_Main
            // 
            tc_Main.Controls.Add(tP_escala);
            tc_Main.Controls.Add(tP_conEscalas);
            tc_Main.Controls.Add(tP_funcionarios);
            tc_Main.Controls.Add(tP_turnos);
            tc_Main.Controls.Add(tP_impressao);
            tc_Main.Controls.Add(tP_main);
            tc_Main.Dock = DockStyle.Fill;
            tc_Main.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tc_Main.Location = new Point(132, 0);
            tc_Main.Margin = new Padding(3, 2, 3, 2);
            tc_Main.Name = "tc_Main";
            tc_Main.SelectedIndex = 0;
            tc_Main.Size = new Size(776, 466);
            tc_Main.TabIndex = 4;
            // 
            // tP_escala
            // 
            tP_escala.Controls.Add(panel_direito);
            tP_escala.Controls.Add(panel_mid);
            tP_escala.Controls.Add(panel_top);
            tP_escala.Location = new Point(4, 26);
            tP_escala.Margin = new Padding(3, 2, 3, 2);
            tP_escala.Name = "tP_escala";
            tP_escala.Padding = new Padding(3, 2, 3, 2);
            tP_escala.Size = new Size(768, 436);
            tP_escala.TabIndex = 0;
            tP_escala.Text = "Nova Escala";
            tP_escala.UseVisualStyleBackColor = true;
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
            panel_direito.Location = new Point(536, 35);
            panel_direito.Name = "panel_direito";
            panel_direito.Size = new Size(229, 399);
            panel_direito.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btn_adicionar_svc);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 187);
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
            listBox_Efetivo.Size = new Size(227, 193);
            listBox_Efetivo.TabIndex = 2;
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 214);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 5;
            label3.Text = "Calendario";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Dock = DockStyle.Bottom;
            monthCalendar1.Location = new Point(0, 235);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // panel_mid
            // 
            panel_mid.Controls.Add(dgv_novaEscala);
            panel_mid.Dock = DockStyle.Fill;
            panel_mid.Location = new Point(3, 35);
            panel_mid.Name = "panel_mid";
            panel_mid.Size = new Size(762, 399);
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
            dgv_novaEscala.Size = new Size(762, 399);
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
            panel_top.Size = new Size(762, 33);
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
            // tP_conEscalas
            // 
            tP_conEscalas.Location = new Point(4, 26);
            tP_conEscalas.Margin = new Padding(3, 2, 3, 2);
            tP_conEscalas.Name = "tP_conEscalas";
            tP_conEscalas.Padding = new Padding(3, 2, 3, 2);
            tP_conEscalas.Size = new Size(768, 436);
            tP_conEscalas.TabIndex = 1;
            tP_conEscalas.Text = "Consultar escala";
            tP_conEscalas.UseVisualStyleBackColor = true;
            // 
            // tP_funcionarios
            // 
            tP_funcionarios.Controls.Add(panel2);
            tP_funcionarios.Controls.Add(panel_lateral);
            tP_funcionarios.Location = new Point(4, 26);
            tP_funcionarios.Name = "tP_funcionarios";
            tP_funcionarios.Padding = new Padding(3);
            tP_funcionarios.Size = new Size(768, 436);
            tP_funcionarios.TabIndex = 2;
            tP_funcionarios.Text = "Funcionarios";
            tP_funcionarios.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
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
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 430);
            panel2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 182);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 28;
            label9.Text = "Numero:";
            // 
            // tb_numero
            // 
            tb_numero.Location = new Point(100, 179);
            tb_numero.Name = "tb_numero";
            tb_numero.Size = new Size(93, 25);
            tb_numero.TabIndex = 27;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.ForeColor = Color.IndianRed;
            lbl_ID.Location = new Point(92, 140);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(0, 17);
            lbl_ID.TabIndex = 26;
            // 
            // lbl_info_ID
            // 
            lbl_info_ID.AutoSize = true;
            lbl_info_ID.Location = new Point(70, 140);
            lbl_info_ID.Name = "lbl_info_ID";
            lbl_info_ID.Size = new Size(24, 17);
            lbl_info_ID.TabIndex = 25;
            lbl_info_ID.Text = "ID:";
            // 
            // pic_Funcionario
            // 
            pic_Funcionario.Image = (Image)resources.GetObject("pic_Funcionario.Image");
            pic_Funcionario.Location = new Point(33, 55);
            pic_Funcionario.Name = "pic_Funcionario";
            pic_Funcionario.Size = new Size(64, 64);
            pic_Funcionario.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_Funcionario.TabIndex = 24;
            pic_Funcionario.TabStop = false;
            // 
            // btn_remover
            // 
            btn_remover.Location = new Point(332, 379);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(102, 30);
            btn_remover.TabIndex = 23;
            btn_remover.Text = "&Remover";
            btn_remover.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(217, 379);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(102, 30);
            btn_adicionar.TabIndex = 22;
            btn_adicionar.Text = "&Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 322);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 21;
            label8.Text = "Contacto:";
            // 
            // tb_contacto
            // 
            tb_contacto.Location = new Point(100, 319);
            tb_contacto.Name = "tb_contacto";
            tb_contacto.Size = new Size(184, 25);
            tb_contacto.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 274);
            label7.Name = "label7";
            label7.Size = new Size(58, 17);
            label7.TabIndex = 19;
            label7.Text = "Morada:";
            // 
            // tb_morada
            // 
            tb_morada.Location = new Point(100, 271);
            tb_morada.Name = "tb_morada";
            tb_morada.Size = new Size(326, 25);
            tb_morada.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 225);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 17;
            label5.Text = "Nome:";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(100, 222);
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
            label6.Size = new Size(139, 21);
            label6.TabIndex = 5;
            label6.Text = "Novo Funcionário";
            // 
            // panel_lateral
            // 
            panel_lateral.BackColor = Color.FromArgb(99, 99, 99);
            panel_lateral.BorderStyle = BorderStyle.FixedSingle;
            panel_lateral.Controls.Add(lst_funcionarios_registo);
            panel_lateral.Controls.Add(label4);
            panel_lateral.Dock = DockStyle.Right;
            panel_lateral.ForeColor = SystemColors.ButtonFace;
            panel_lateral.Location = new Point(483, 3);
            panel_lateral.Name = "panel_lateral";
            panel_lateral.Size = new Size(282, 430);
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
            lst_funcionarios_registo.Size = new Size(280, 407);
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
            // tP_turnos
            // 
            tP_turnos.Location = new Point(4, 26);
            tP_turnos.Name = "tP_turnos";
            tP_turnos.Size = new Size(768, 436);
            tP_turnos.TabIndex = 3;
            tP_turnos.Text = "Turnos";
            tP_turnos.UseVisualStyleBackColor = true;
            // 
            // tP_impressao
            // 
            tP_impressao.Location = new Point(4, 26);
            tP_impressao.Name = "tP_impressao";
            tP_impressao.Size = new Size(768, 436);
            tP_impressao.TabIndex = 4;
            tP_impressao.Text = "Impressão";
            tP_impressao.UseVisualStyleBackColor = true;
            // 
            // tP_main
            // 
            tP_main.Location = new Point(4, 26);
            tP_main.Name = "tP_main";
            tP_main.Size = new Size(768, 436);
            tP_main.TabIndex = 5;
            tP_main.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(908, 466);
            Controls.Add(tc_Main);
            Controls.Add(panel_menu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "GesEscala - Equipa 15 - LDS UAB";
            panel_menu.ResumeLayout(false);
            tc_Main.ResumeLayout(false);
            tP_escala.ResumeLayout(false);
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
        private TabPage tP_escala;
        private TabPage tP_conEscalas;
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
        private TabPage tP_turnos;
        private TabPage tP_impressao;
        private TabPage tP_main;
        private ListBox listBox_Efetivo;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private ListBox lst_funcionarios_registo;
        private Panel panel_lateral;
        private Label label4;
        private Panel panel2;
        private Label label6;
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
    }
}

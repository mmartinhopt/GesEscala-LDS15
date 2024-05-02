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
            btn_gerarEscala = new Button();
            panel_menu = new Panel();
            btn_escalas = new Button();
            btn_turnos = new Button();
            btn_funcionarios = new Button();
            btn_sair = new Button();
            tabControl1 = new TabControl();
            tabPage_escala = new TabPage();
            panel2 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            listBox_Efetivo = new ListBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            panel_mid = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel_top = new Panel();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel_menu.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage_escala.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel_mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // btn_gerarEscala
            // 
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
            panel_menu.Location = new Point(0, 0);
            panel_menu.Margin = new Padding(3, 2, 3, 2);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(132, 466);
            panel_menu.TabIndex = 3;
            // 
            // btn_escalas
            // 
            btn_escalas.Location = new Point(3, 40);
            btn_escalas.Margin = new Padding(3, 2, 3, 2);
            btn_escalas.Name = "btn_escalas";
            btn_escalas.Size = new Size(127, 34);
            btn_escalas.TabIndex = 6;
            btn_escalas.Text = "Escalas";
            btn_escalas.UseVisualStyleBackColor = true;
            btn_escalas.Click += btn_escalas_Click;
            // 
            // btn_turnos
            // 
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
            btn_funcionarios.Location = new Point(2, 116);
            btn_funcionarios.Margin = new Padding(3, 2, 3, 2);
            btn_funcionarios.Name = "btn_funcionarios";
            btn_funcionarios.Size = new Size(127, 34);
            btn_funcionarios.TabIndex = 4;
            btn_funcionarios.Text = "Funcionários";
            btn_funcionarios.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_escala);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(132, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 466);
            tabControl1.TabIndex = 4;
            // 
            // tabPage_escala
            // 
            tabPage_escala.Controls.Add(panel2);
            tabPage_escala.Controls.Add(panel_mid);
            tabPage_escala.Controls.Add(panel_top);
            tabPage_escala.Location = new Point(4, 24);
            tabPage_escala.Margin = new Padding(3, 2, 3, 2);
            tabPage_escala.Name = "tabPage_escala";
            tabPage_escala.Padding = new Padding(3, 2, 3, 2);
            tabPage_escala.Size = new Size(768, 438);
            tabPage_escala.TabIndex = 0;
            tabPage_escala.Text = "Escala";
            tabPage_escala.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(listBox_Efetivo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(536, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 401);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 42);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(114, 0);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(115, 42);
            button2.TabIndex = 9;
            button2.Text = "Remover svc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 42);
            button1.TabIndex = 8;
            button1.Text = "Adicionar svc";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox_Efetivo
            // 
            listBox_Efetivo.BorderStyle = BorderStyle.None;
            listBox_Efetivo.Dock = DockStyle.Fill;
            listBox_Efetivo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox_Efetivo.FormattingEnabled = true;
            listBox_Efetivo.ItemHeight = 17;
            listBox_Efetivo.Items.AddRange(new object[] { "209 - Rui", "102 - Pedro", "2030 - Miguel", "1 - Corrida", "Utilizadores registados", "quando tem função", "muda de cor conforme o ", "serviço" });
            listBox_Efetivo.Location = new Point(0, 21);
            listBox_Efetivo.Name = "listBox_Efetivo";
            listBox_Efetivo.Size = new Size(229, 197);
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
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Efetivo";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 183);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calendário";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(2, 14);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // panel_mid
            // 
            panel_mid.Controls.Add(dataGridView1);
            panel_mid.Dock = DockStyle.Fill;
            panel_mid.Location = new Point(3, 35);
            panel_mid.Name = "panel_mid";
            panel_mid.Size = new Size(762, 401);
            panel_mid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2 });
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(762, 401);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Serviço";
            Column1.Name = "Column1";
            Column1.Width = 70;
            // 
            // Column3
            // 
            Column3.HeaderText = "Horario";
            Column3.Name = "Column3";
            Column3.Width = 72;
            // 
            // Column2
            // 
            Column2.HeaderText = "Funcionarios";
            Column2.Name = "Column2";
            // 
            // panel_top
            // 
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
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "Escala do dia: XX/XX/XXXX";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(768, 438);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(908, 466);
            Controls.Add(tabControl1);
            Controls.Add(panel_menu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "GesEscala - Equipa 15 - LDS UAB";
            Load += FormMain_Load;
            panel_menu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage_escala.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel_mid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_gerarEscala;
        private Panel panel_menu;
        private Button btn_escalas;
        private Button btn_turnos;
        private Button btn_funcionarios;
        private Button btn_sair;
        private TabControl tabControl1;
        private TabPage tabPage_escala;
        private TabPage tabPage2;
        private Panel panel_top;
        private Panel panel_mid;
        private Panel panel2;
        private ListBox listBox_Efetivo;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private Label label2;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private MonthCalendar monthCalendar1;
    }
}

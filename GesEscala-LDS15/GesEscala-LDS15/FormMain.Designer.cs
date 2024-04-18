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
            panel1 = new Panel();
            btn_sair = new Button();
            btn_funcionarios = new Button();
            btn_turnos = new Button();
            btn_escalas = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_gerarEscala
            // 
            btn_gerarEscala.Location = new Point(3, 3);
            btn_gerarEscala.Name = "btn_gerarEscala";
            btn_gerarEscala.Size = new Size(145, 29);
            btn_gerarEscala.TabIndex = 2;
            btn_gerarEscala.Text = "Nova Escala";
            btn_gerarEscala.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_escalas);
            panel1.Controls.Add(btn_turnos);
            panel1.Controls.Add(btn_funcionarios);
            panel1.Controls.Add(btn_sair);
            panel1.Controls.Add(btn_gerarEscala);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 426);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(3, 394);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(145, 29);
            btn_sair.TabIndex = 3;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_funcionarios
            // 
            btn_funcionarios.Location = new Point(3, 108);
            btn_funcionarios.Name = "btn_funcionarios";
            btn_funcionarios.Size = new Size(145, 29);
            btn_funcionarios.TabIndex = 4;
            btn_funcionarios.Text = "Funcionários";
            btn_funcionarios.UseVisualStyleBackColor = true;
            // 
            // btn_turnos
            // 
            btn_turnos.Location = new Point(3, 73);
            btn_turnos.Name = "btn_turnos";
            btn_turnos.Size = new Size(145, 29);
            btn_turnos.TabIndex = 5;
            btn_turnos.Text = "Turnos";
            btn_turnos.UseVisualStyleBackColor = true;
            // 
            // btn_escalas
            // 
            btn_escalas.Location = new Point(3, 38);
            btn_escalas.Name = "btn_escalas";
            btn_escalas.Size = new Size(145, 29);
            btn_escalas.TabIndex = 6;
            btn_escalas.Text = "Escalas";
            btn_escalas.UseVisualStyleBackColor = true;
            btn_escalas.Click += button5_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(169, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(633, 426);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(625, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 92);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "GesEscala - Equipa 15 - LDS UAB";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btn_gerarEscala;
        private Panel panel1;
        private Button btn_escalas;
        private Button btn_turnos;
        private Button btn_funcionarios;
        private Button btn_sair;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}

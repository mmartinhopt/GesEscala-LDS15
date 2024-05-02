namespace GesEscala_LDS15
{
    partial class FormConfiguracaoInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btn_initOk = new Button();
            btn_inserirEmpregado = new Button();
            btn_inserirServico = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 32);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo ao GesEscala";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 90);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 1;
            label2.Text = "Introduza o nome da seção";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 88);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 2;
            // 
            // btn_initOk
            // 
            btn_initOk.Location = new Point(545, 278);
            btn_initOk.Margin = new Padding(3, 2, 3, 2);
            btn_initOk.Name = "btn_initOk";
            btn_initOk.Size = new Size(82, 22);
            btn_initOk.TabIndex = 3;
            btn_initOk.Text = "Continuar";
            btn_initOk.UseVisualStyleBackColor = true;
            btn_initOk.Click += button1_Click;
            // 
            // btn_inserirEmpregado
            // 
            btn_inserirEmpregado.Location = new Point(237, 156);
            btn_inserirEmpregado.Margin = new Padding(3, 2, 3, 2);
            btn_inserirEmpregado.Name = "btn_inserirEmpregado";
            btn_inserirEmpregado.Size = new Size(173, 22);
            btn_inserirEmpregado.TabIndex = 4;
            btn_inserirEmpregado.Text = "Introduzir empregados";
            btn_inserirEmpregado.UseVisualStyleBackColor = true;
            btn_inserirEmpregado.Click += button2_Click;
            // 
            // btn_inserirServico
            // 
            btn_inserirServico.Location = new Point(237, 197);
            btn_inserirServico.Margin = new Padding(3, 2, 3, 2);
            btn_inserirServico.Name = "btn_inserirServico";
            btn_inserirServico.Size = new Size(173, 22);
            btn_inserirServico.TabIndex = 5;
            btn_inserirServico.Text = "Introduzir serviços";
            btn_inserirServico.UseVisualStyleBackColor = true;
            btn_inserirServico.Click += button3_Click;
            // 
            // FormConfiguracaoInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_inserirServico);
            Controls.Add(btn_inserirEmpregado);
            Controls.Add(btn_initOk);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormConfiguracaoInicial";
            Text = "FormConfiguracaoInicial";
            Load += FormConfiguracaoInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btn_initOk;
        private Button btn_inserirEmpregado;
        private Button btn_inserirServico;
    }
}
﻿namespace GesEscala_LDS15
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 43);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo ao GesEscala";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 120);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 1;
            label2.Text = "Introduza o nome da seção";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(623, 371);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(271, 208);
            button2.Name = "button2";
            button2.Size = new Size(198, 29);
            button2.TabIndex = 4;
            button2.Text = "Introduzir empregados";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(271, 263);
            button3.Name = "button3";
            button3.Size = new Size(198, 29);
            button3.TabIndex = 5;
            button3.Text = "Introduzir serviços";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormConfiguracaoInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
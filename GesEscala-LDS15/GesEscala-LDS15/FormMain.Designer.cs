﻿namespace GesEscala_LDS15
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
            gerarEscala_btn = new Button();
            SuspendLayout();
            // 
            // gerarEscala_btn
            // 
            gerarEscala_btn.Location = new Point(12, 12);
            gerarEscala_btn.Name = "gerarEscala_btn";
            gerarEscala_btn.Size = new Size(94, 29);
            gerarEscala_btn.TabIndex = 1;
            gerarEscala_btn.Text = "Gerar";
            gerarEscala_btn.UseVisualStyleBackColor = true;
            gerarEscala_btn.Click += gerarEscala_btn_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gerarEscala_btn);
            Name = "FormMain";
            Text = "GesEscala - Equipa 15 - LDS UAB";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button gerarEscala_btn;
    }
}

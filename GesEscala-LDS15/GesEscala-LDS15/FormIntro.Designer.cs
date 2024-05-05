namespace GesEscala_LDS15
{
    partial class FormIntro
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 86);
            label1.TabIndex = 0;
            label1.Text = "GesEscala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(165, 21);
            label2.TabIndex = 1;
            label2.Text = "Projeto elaborado por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(104, 161);
            label3.Name = "label3";
            label3.Size = new Size(201, 21);
            label3.TabIndex = 2;
            label3.Text = "2003918 - Ricardo Sanches";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(104, 182);
            label4.Name = "label4";
            label4.Size = new Size(201, 21);
            label4.TabIndex = 3;
            label4.Text = "2003918 - Ricardo Sanches";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(104, 221);
            label5.Name = "label5";
            label5.Size = new Size(201, 21);
            label5.TabIndex = 4;
            label5.Text = "2003918 - Ricardo Sanches";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(104, 200);
            label6.Name = "label6";
            label6.Size = new Size(201, 21);
            label6.TabIndex = 5;
            label6.Text = "2003918 - Ricardo Sanches";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(104, 242);
            label7.Name = "label7";
            label7.Size = new Size(201, 21);
            label7.TabIndex = 6;
            label7.Text = "2003918 - Ricardo Sanches";
            // 
            // FormIntro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 286);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormIntro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfiguracaoInicial";
            Load += FormConfiguracaoInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
namespace QuestiPGM.Desk
{
    partial class categoriapa
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
            this.pergunta_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alternativa_1 = new System.Windows.Forms.RadioButton();
            this.alternativa_2 = new System.Windows.Forms.RadioButton();
            this.alternativa_3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // pergunta_1
            // 
            this.pergunta_1.AutoSize = true;
            this.pergunta_1.Location = new System.Drawing.Point(0, 0);
            this.pergunta_1.Name = "pergunta_1";
            this.pergunta_1.Size = new System.Drawing.Size(0, 13);
            this.pergunta_1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quais desses países fizeram parte da Tríplice Aliança durante a Primeira Guerra M" +
    "undial?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // alternativa_1
            // 
            this.alternativa_1.AutoSize = true;
            this.alternativa_1.BackColor = System.Drawing.Color.Transparent;
            this.alternativa_1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alternativa_1.Location = new System.Drawing.Point(52, 190);
            this.alternativa_1.Name = "alternativa_1";
            this.alternativa_1.Size = new System.Drawing.Size(241, 21);
            this.alternativa_1.TabIndex = 2;
            this.alternativa_1.TabStop = true;
            this.alternativa_1.Text = "E.U.A, Coréia do Norte e Alemanha";
            this.alternativa_1.UseVisualStyleBackColor = false;
            this.alternativa_1.CheckedChanged += new System.EventHandler(this.alternativa_1_CheckedChanged);
            // 
            // alternativa_2
            // 
            this.alternativa_2.AutoSize = true;
            this.alternativa_2.BackColor = System.Drawing.Color.Transparent;
            this.alternativa_2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alternativa_2.Location = new System.Drawing.Point(52, 241);
            this.alternativa_2.Name = "alternativa_2";
            this.alternativa_2.Size = new System.Drawing.Size(295, 21);
            this.alternativa_2.TabIndex = 3;
            this.alternativa_2.TabStop = true;
            this.alternativa_2.Text = "Alemanha, Império Austro-Húngaro e E.U.A.";
            this.alternativa_2.UseVisualStyleBackColor = false;
            // 
            // alternativa_3
            // 
            this.alternativa_3.AutoSize = true;
            this.alternativa_3.BackColor = System.Drawing.Color.Transparent;
            this.alternativa_3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alternativa_3.Location = new System.Drawing.Point(52, 298);
            this.alternativa_3.Name = "alternativa_3";
            this.alternativa_3.Size = new System.Drawing.Size(289, 21);
            this.alternativa_3.TabIndex = 4;
            this.alternativa_3.TabStop = true;
            this.alternativa_3.Text = "Alemanha, Império Austro- Húngaro e Itália.";
            this.alternativa_3.UseVisualStyleBackColor = false;
            // 
            // categoriapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.alternativa_3);
            this.Controls.Add(this.alternativa_2);
            this.Controls.Add(this.alternativa_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pergunta_1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "categoriapa";
            this.Text = "Política de Alianças 1/2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pergunta_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton alternativa_1;
        private System.Windows.Forms.RadioButton alternativa_2;
        private System.Windows.Forms.RadioButton alternativa_3;
    }
}
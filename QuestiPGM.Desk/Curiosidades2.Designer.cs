namespace QuestiPGM.Desk
{
    partial class Curiosidades2
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
            this.cur1 = new System.Windows.Forms.Label();
            this.alt5 = new System.Windows.Forms.RadioButton();
            this.alt4 = new System.Windows.Forms.RadioButton();
            this.alt3 = new System.Windows.Forms.RadioButton();
            this.check2 = new System.Windows.Forms.Button();
            this.finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cur1
            // 
            this.cur1.AutoSize = true;
            this.cur1.BackColor = System.Drawing.Color.White;
            this.cur1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cur1.Location = new System.Drawing.Point(12, 86);
            this.cur1.Name = "cur1";
            this.cur1.Size = new System.Drawing.Size(765, 22);
            this.cur1.TabIndex = 2;
            this.cur1.Text = "Qual procedimento estético teve seu início de desenvolvimento na Primeira Guerra " +
    "Mundial?";
            // 
            // alt5
            // 
            this.alt5.AutoSize = true;
            this.alt5.BackColor = System.Drawing.Color.White;
            this.alt5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alt5.Location = new System.Drawing.Point(16, 205);
            this.alt5.Name = "alt5";
            this.alt5.Size = new System.Drawing.Size(86, 21);
            this.alt5.TabIndex = 4;
            this.alt5.TabStop = true;
            this.alt5.Text = "Tatuagens";
            this.alt5.UseVisualStyleBackColor = false;
            // 
            // alt4
            // 
            this.alt4.AutoSize = true;
            this.alt4.BackColor = System.Drawing.Color.White;
            this.alt4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alt4.Location = new System.Drawing.Point(16, 168);
            this.alt4.Name = "alt4";
            this.alt4.Size = new System.Drawing.Size(135, 21);
            this.alt4.TabIndex = 5;
            this.alt4.TabStop = true;
            this.alt4.Text = "Cirurgias Plásticas";
            this.alt4.UseVisualStyleBackColor = false;
            // 
            // alt3
            // 
            this.alt3.AutoSize = true;
            this.alt3.BackColor = System.Drawing.Color.White;
            this.alt3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alt3.Location = new System.Drawing.Point(16, 129);
            this.alt3.Name = "alt3";
            this.alt3.Size = new System.Drawing.Size(201, 21);
            this.alt3.TabIndex = 6;
            this.alt3.TabStop = true;
            this.alt3.Text = "Processos químicos capilares.";
            this.alt3.UseVisualStyleBackColor = false;
            // 
            // check2
            // 
            this.check2.Location = new System.Drawing.Point(12, 420);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(75, 30);
            this.check2.TabIndex = 8;
            this.check2.Text = "Verificar";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.Click += new System.EventHandler(this.check2_Click);
            // 
            // finalizar
            // 
            this.finalizar.Location = new System.Drawing.Point(697, 418);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(75, 32);
            this.finalizar.TabIndex = 9;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseVisualStyleBackColor = true;
            this.finalizar.Click += new System.EventHandler(this.finalizar_Click);
            // 
            // Curiosidades2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuestiPGM.Desk.Properties.Resources.BF1_mapaguerra_800x5001;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.alt3);
            this.Controls.Add(this.alt4);
            this.Controls.Add(this.alt5);
            this.Controls.Add(this.cur1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "Curiosidades2";
            this.Text = "Curiosidades2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cur1;
        private System.Windows.Forms.RadioButton alt5;
        private System.Windows.Forms.RadioButton alt4;
        private System.Windows.Forms.RadioButton alt3;
        private System.Windows.Forms.Button check2;
        private System.Windows.Forms.Button finalizar;
    }
}
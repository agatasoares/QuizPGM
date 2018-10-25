namespace QuestiPGM.Desk
{
    partial class curiosidades
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
            this.alt2 = new System.Windows.Forms.RadioButton();
            this.alt1 = new System.Windows.Forms.RadioButton();
            this.proximo2 = new System.Windows.Forms.Button();
            this.check2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cur1
            // 
            this.cur1.AutoSize = true;
            this.cur1.BackColor = System.Drawing.Color.White;
            this.cur1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cur1.Location = new System.Drawing.Point(131, 109);
            this.cur1.Name = "cur1";
            this.cur1.Size = new System.Drawing.Size(520, 22);
            this.cur1.TabIndex = 1;
            this.cur1.Text = "Os pombos foram utilizados na guerra para enviar mensagens:";
            // 
            // alt2
            // 
            this.alt2.AutoSize = true;
            this.alt2.BackColor = System.Drawing.Color.White;
            this.alt2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alt2.Location = new System.Drawing.Point(135, 206);
            this.alt2.Name = "alt2";
            this.alt2.Size = new System.Drawing.Size(57, 21);
            this.alt2.TabIndex = 2;
            this.alt2.TabStop = true;
            this.alt2.Text = "Falso";
            this.alt2.UseVisualStyleBackColor = false;
            // 
            // alt1
            // 
            this.alt1.AutoSize = true;
            this.alt1.BackColor = System.Drawing.Color.White;
            this.alt1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alt1.Location = new System.Drawing.Point(135, 170);
            this.alt1.Name = "alt1";
            this.alt1.Size = new System.Drawing.Size(90, 21);
            this.alt1.TabIndex = 3;
            this.alt1.TabStop = true;
            this.alt1.Text = "Verdadeiro";
            this.alt1.UseVisualStyleBackColor = false;
            // 
            // proximo2
            // 
            this.proximo2.Location = new System.Drawing.Point(697, 418);
            this.proximo2.Name = "proximo2";
            this.proximo2.Size = new System.Drawing.Size(75, 32);
            this.proximo2.TabIndex = 6;
            this.proximo2.Text = "Próximo";
            this.proximo2.UseVisualStyleBackColor = true;
            this.proximo2.Click += new System.EventHandler(this.proximo2_Click);
            // 
            // check2
            // 
            this.check2.Location = new System.Drawing.Point(12, 420);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(75, 30);
            this.check2.TabIndex = 7;
            this.check2.Text = "Verificar";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.Click += new System.EventHandler(this.check2_Click_1);
            // 
            // curiosidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuestiPGM.Desk.Properties.Resources.BF1_mapaguerra_800x500;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.proximo2);
            this.Controls.Add(this.alt1);
            this.Controls.Add(this.alt2);
            this.Controls.Add(this.cur1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "curiosidades";
            this.Text = "curiosidades";
            this.Load += new System.EventHandler(this.curiosidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cur1;
        private System.Windows.Forms.RadioButton alt2;
        private System.Windows.Forms.RadioButton alt1;
        private System.Windows.Forms.Button proximo2;
        private System.Windows.Forms.Button check2;
    }
}
namespace QuestiPGM.Desk
{
    partial class ciencia_tec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ciencia_tec));
            this.label1 = new System.Windows.Forms.Label();
            this.alternativa_1 = new System.Windows.Forms.RadioButton();
            this.alternativa_2 = new System.Windows.Forms.RadioButton();
            this.alternativa_3 = new System.Windows.Forms.RadioButton();
            this.check3 = new System.Windows.Forms.Button();
            this.proximo3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual desses equipamentos não foram utilizados durante a 1ª Guerra Mundial?";
            // 
            // alternativa_1
            // 
            this.alternativa_1.AutoSize = true;
            this.alternativa_1.Location = new System.Drawing.Point(54, 168);
            this.alternativa_1.Name = "alternativa_1";
            this.alternativa_1.Size = new System.Drawing.Size(57, 17);
            this.alternativa_1.TabIndex = 1;
            this.alternativa_1.TabStop = true;
            this.alternativa_1.Text = "Drone.";
            this.alternativa_1.UseVisualStyleBackColor = true;
            // 
            // alternativa_2
            // 
            this.alternativa_2.AutoSize = true;
            this.alternativa_2.Location = new System.Drawing.Point(54, 210);
            this.alternativa_2.Name = "alternativa_2";
            this.alternativa_2.Size = new System.Drawing.Size(82, 17);
            this.alternativa_2.TabIndex = 2;
            this.alternativa_2.TabStop = true;
            this.alternativa_2.Text = "Smarphone.";
            this.alternativa_2.UseVisualStyleBackColor = true;
            // 
            // alternativa_3
            // 
            this.alternativa_3.AutoSize = true;
            this.alternativa_3.Location = new System.Drawing.Point(54, 250);
            this.alternativa_3.Name = "alternativa_3";
            this.alternativa_3.Size = new System.Drawing.Size(120, 17);
            this.alternativa_3.TabIndex = 3;
            this.alternativa_3.TabStop = true;
            this.alternativa_3.Text = "Rádio comunicador.";
            this.alternativa_3.UseVisualStyleBackColor = true;
            // 
            // check3
            // 
            this.check3.Location = new System.Drawing.Point(54, 362);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(92, 32);
            this.check3.TabIndex = 4;
            this.check3.Text = "Verificar";
            this.check3.UseVisualStyleBackColor = true;
            this.check3.Click += new System.EventHandler(this.button1_Click);
            // 
            // proximo3
            // 
            this.proximo3.Location = new System.Drawing.Point(668, 371);
            this.proximo3.Name = "proximo3";
            this.proximo3.Size = new System.Drawing.Size(83, 32);
            this.proximo3.TabIndex = 5;
            this.proximo3.Text = "button1";
            this.proximo3.UseVisualStyleBackColor = true;
            this.proximo3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ciencia_tec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.proximo3);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.alternativa_3);
            this.Controls.Add(this.alternativa_2);
            this.Controls.Add(this.alternativa_1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ciencia_tec";
            this.Text = "Ciência e tecnologia 1/2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton alternativa_1;
        private System.Windows.Forms.RadioButton alternativa_2;
        private System.Windows.Forms.RadioButton alternativa_3;
        private System.Windows.Forms.Button check3;
        private System.Windows.Forms.Button proximo3;
    }
}
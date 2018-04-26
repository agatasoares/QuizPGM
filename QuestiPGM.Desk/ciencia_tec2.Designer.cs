namespace QuestiPGM.Desk
{
    partial class ciencia_tec2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ciencia_tec2));
            this.label1 = new System.Windows.Forms.Label();
            this.alternativa_1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o cientista que participou da 1ª Guerra Mundial:";
            // 
            // alternativa_1
            // 
            this.alternativa_1.AutoSize = true;
            this.alternativa_1.Location = new System.Drawing.Point(62, 144);
            this.alternativa_1.Name = "alternativa_1";
            this.alternativa_1.Size = new System.Drawing.Size(31, 17);
            this.alternativa_1.TabIndex = 1;
            this.alternativa_1.TabStop = true;
            this.alternativa_1.Text = "F";
            this.alternativa_1.UseVisualStyleBackColor = true;
            // 
            // ciencia_tec2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.alternativa_1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ciencia_tec2";
            this.Text = "Ciência e tecnologia 2/2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton alternativa_1;
    }
}
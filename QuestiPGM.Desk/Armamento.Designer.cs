namespace QuestiPGM.Desk
{
    partial class Armamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p01op01 = new System.Windows.Forms.RadioButton();
            this.p01op02 = new System.Windows.Forms.RadioButton();
            this.p01op03 = new System.Windows.Forms.RadioButton();
            this.p01op04 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quais destes armamentos foram criados durante a 1° guerra mundial?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.p01op04);
            this.panel1.Controls.Add(this.p01op03);
            this.panel1.Controls.Add(this.p01op02);
            this.panel1.Controls.Add(this.p01op01);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(103, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 265);
            this.panel1.TabIndex = 1;
            // 
            // p01op01
            // 
            this.p01op01.AutoSize = true;
            this.p01op01.Location = new System.Drawing.Point(26, 80);
            this.p01op01.Name = "p01op01";
            this.p01op01.Size = new System.Drawing.Size(233, 17);
            this.p01op01.TabIndex = 1;
            this.p01op01.TabStop = true;
            this.p01op01.Text = "a) Fuzil, Granada, Tanque e Bomba Nuclear";
            this.p01op01.UseVisualStyleBackColor = true;
            this.p01op01.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // p01op02
            // 
            this.p01op02.AutoSize = true;
            this.p01op02.Location = new System.Drawing.Point(26, 113);
            this.p01op02.Name = "p01op02";
            this.p01op02.Size = new System.Drawing.Size(277, 17);
            this.p01op02.TabIndex = 2;
            this.p01op02.TabStop = true;
            this.p01op02.Text = "b) Lança-chamas, Morteiros, Gases tóxicos e Tanque";
            this.p01op02.UseVisualStyleBackColor = true;
            // 
            // p01op03
            // 
            this.p01op03.AutoSize = true;
            this.p01op03.Location = new System.Drawing.Point(26, 148);
            this.p01op03.Name = "p01op03";
            this.p01op03.Size = new System.Drawing.Size(209, 17);
            this.p01op03.TabIndex = 3;
            this.p01op03.TabStop = true;
            this.p01op03.Text = "c) Morteiro, Avião, submarino e bazuca";
            this.p01op03.UseVisualStyleBackColor = true;
            // 
            // p01op04
            // 
            this.p01op04.AutoSize = true;
            this.p01op04.Location = new System.Drawing.Point(26, 181);
            this.p01op04.Name = "p01op04";
            this.p01op04.Size = new System.Drawing.Size(256, 17);
            this.p01op04.TabIndex = 4;
            this.p01op04.TabStop = true;
            this.p01op04.Text = "d) Metralhadora, Granada, Rifles e Gases tóxicos";
            this.p01op04.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Armamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuestiPGM.Desk.Properties.Resources.unnamed_7__6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(710, 551);
            this.Controls.Add(this.panel1);
            this.Name = "Armamento";
            this.Text = "Armamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton p01op04;
        private System.Windows.Forms.RadioButton p01op03;
        private System.Windows.Forms.RadioButton p01op02;
        private System.Windows.Forms.RadioButton p01op01;
        private System.Windows.Forms.Button button1;
    }
}
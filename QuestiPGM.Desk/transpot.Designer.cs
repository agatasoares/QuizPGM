﻿namespace QuestiPGM.Desk
{
    partial class transpot
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
            this.B1 = new System.Windows.Forms.RadioButton();
            this.B2 = new System.Windows.Forms.RadioButton();
            this.B3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quando os tanques alemães começaram a ser usados?";
            // 
            // B1
            // 
            this.B1.AutoSize = true;
            this.B1.Location = new System.Drawing.Point(60, 95);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(80, 17);
            this.B1.TabIndex = 1;
            this.B1.TabStop = true;
            this.B1.Text = "No começo";
            this.B1.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.AutoSize = true;
            this.B2.Location = new System.Drawing.Point(60, 145);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(64, 17);
            this.B2.TabIndex = 2;
            this.B2.TabStop = true;
            this.B2.Text = "No meio";
            this.B2.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            this.B3.AutoSize = true;
            this.B3.Location = new System.Drawing.Point(60, 190);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(55, 17);
            this.B3.TabIndex = 3;
            this.B3.TabStop = true;
            this.B3.Text = "No fim";
            this.B3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.label1);
            this.Name = "transpot";
            this.Text = "transpot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton B1;
        private System.Windows.Forms.RadioButton B2;
        private System.Windows.Forms.RadioButton B3;
        private System.Windows.Forms.Button button1;
    }
}
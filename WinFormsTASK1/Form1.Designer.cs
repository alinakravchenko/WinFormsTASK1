﻿namespace WinFormsTASK1
{
    partial class Form1
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
            this.ShowMesBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowMesBox
            // 
            this.ShowMesBox.Location = new System.Drawing.Point(293, 189);
            this.ShowMesBox.Name = "ShowMesBox";
            this.ShowMesBox.Size = new System.Drawing.Size(132, 23);
            this.ShowMesBox.TabIndex = 0;
            this.ShowMesBox.Text = "ShowMesBox";
            this.ShowMesBox.UseVisualStyleBackColor = true;
            this.ShowMesBox.Click += new System.EventHandler(this.ShowMesBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowMesBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ShowMesBox;
    }
}
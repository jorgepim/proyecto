﻿namespace Proyecto
{
    partial class Menú
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 47);
            button1.Name = "button1";
            button1.Size = new Size(248, 196);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(275, 47);
            button2.Name = "button2";
            button2.Size = new Size(239, 196);
            button2.TabIndex = 1;
            button2.Text = "Votar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Menú
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(538, 271);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menú";
            Text = "Menú";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
﻿namespace AlgebraComputacional
{
    partial class Exercicio7
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
            textBoxResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(67, 12);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(628, 261);
            textBoxResult.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(185, 298);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 7;
            button1.Text = "Calclular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalcular_Click;
            // 
            // button2
            // 
            button2.Location = new Point(360, 298);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 8;
            button2.Text = "Exibir Código";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Exercicio7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxResult);
            Name = "Exercicio7";
            Text = "Exercicio7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult;
        private Button button1;
        private Button button2;
    }
}
namespace AlgebraComputacional
{
    partial class Exercicio5
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(628, 261);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(194, 309);
            button1.Name = "button1";
            button1.Size = new Size(164, 23);
            button1.TabIndex = 7;
            button1.Text = "Resultado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += VerificarBase_Click;
            // 
            // button2
            // 
            button2.Location = new Point(437, 309);
            button2.Name = "button2";
            button2.Size = new Size(164, 23);
            button2.TabIndex = 8;
            button2.Text = "Exibir código";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Exercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Exercicio5";
            Text = "Exercicio5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}
namespace AlgebraComputacional.Lista1
{
    partial class Exercicio1_1
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
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(142, 392);
            button1.Name = "button1";
            button1.Size = new Size(117, 31);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += calcular;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(628, 346);
            textBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(417, 392);
            button2.Name = "button2";
            button2.Size = new Size(132, 31);
            button2.TabIndex = 7;
            button2.Text = "Exibir Código";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ExibirCodigo;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "1.2.5";
            // 
            // Exercicio1_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Exercicio1_1";
            Text = "Exercicio1_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
    }
}
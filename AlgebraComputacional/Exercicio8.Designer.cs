namespace AlgebraComputacional
{
    partial class Exercicio8
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
            textBoxResultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(69, 12);
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ScrollBars = ScrollBars.Vertical;
            textBoxResultado.Size = new Size(628, 261);
            textBoxResultado.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(230, 301);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 8;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalcular_Click;
            // 
            // button2
            // 
            button2.Location = new Point(375, 301);
            button2.Name = "button2";
            button2.Size = new Size(117, 23);
            button2.TabIndex = 9;
            button2.Text = "Exibir código";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Exercicio8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxResultado);
            Name = "Exercicio8";
            Text = "Exercicio8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResultado;
        private Button button1;
        private Button button2;
    }
}
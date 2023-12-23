namespace AlgebraComputacional
{
    partial class Exercicio10
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
            txtResultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(74, 12);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(628, 261);
            txtResultado.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(195, 299);
            button1.Name = "button1";
            button1.Size = new Size(163, 23);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(454, 299);
            button2.Name = "button2";
            button2.Size = new Size(163, 23);
            button2.TabIndex = 10;
            button2.Text = "Exibir Código";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Codigo;
            // 
            // Exercicio10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Name = "Exercicio10";
            Text = "Exercicio10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button button1;
        private Button button2;
    }
}
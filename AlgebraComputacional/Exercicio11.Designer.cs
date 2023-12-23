namespace AlgebraComputacional
{
    partial class Exercicio11
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
            resultadocalculo = new TextBox();
            textBoxCodigo = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(581, 79);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(645, 237);
            txtResultado.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(804, 597);
            button1.Name = "button1";
            button1.Size = new Size(217, 23);
            button1.TabIndex = 10;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultadocalculo
            // 
            resultadocalculo.Location = new Point(581, 322);
            resultadocalculo.Multiline = true;
            resultadocalculo.Name = "resultadocalculo";
            resultadocalculo.ScrollBars = ScrollBars.Vertical;
            resultadocalculo.Size = new Size(645, 234);
            resultadocalculo.TabIndex = 11;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(309, 117);
            textBoxCodigo.Multiline = true;
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.ScrollBars = ScrollBars.Vertical;
            textBoxCodigo.Size = new Size(244, 439);
            textBoxCodigo.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(336, 597);
            button2.Name = "button2";
            button2.Size = new Size(217, 23);
            button2.TabIndex = 13;
            button2.Text = "Exibir Código";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Exercicio11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 693);
            Controls.Add(button2);
            Controls.Add(textBoxCodigo);
            Controls.Add(resultadocalculo);
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Name = "Exercicio11";
            Text = "Exercicio11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button button1;
        private TextBox resultadocalculo;
        private TextBox textBoxCodigo;
        private Button button2;
    }
}
namespace AlgebraComputacional
{
    partial class Exercicio1
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
            Verificar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Verificar
            // 
            Verificar.Location = new Point(264, 316);
            Verificar.Name = "Verificar";
            Verificar.Size = new Size(134, 23);
            Verificar.TabIndex = 1;
            Verificar.Text = "Calcular valores";
            Verificar.UseVisualStyleBackColor = true;
            Verificar.Click += btnVerificar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 34);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(628, 261);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 4);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 5;
            label1.Text = "Exercicio 1";
            // 
            // button1
            // 
            button1.Location = new Point(449, 316);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 6;
            button1.Text = "Exibir Código Usado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ExibirCodigo;
            // 
            // Exercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Verificar);
            Name = "Exercicio1";
            Text = "Exercicio 1";
            Load += Exercicio1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button Verificar;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }


}
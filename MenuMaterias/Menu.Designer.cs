namespace MenuMaterias
{
    partial class Menu
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
            this.BackColor = Color.White;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label1 = new Label();
            Algebra = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 109);
            button1.Name = "button1";
            button1.Size = new Size(206, 63);
            button1.TabIndex = 0;
            button1.Text = "Algebra Linear Computacional";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AlgebraLinear;
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Arial", 10, FontStyle.Regular);

            // 
            // button2
            // 
            button2.Location = new Point(541, 115);
            button2.Name = "button2";
            button2.Size = new Size(234, 57);
            button2.TabIndex = 1;
            button2.Text = "Algoritmos e Programas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Algoritmo;
            button2.BackColor = Color.LightBlue;
            button2.Font = new Font("Arial", 10, FontStyle.Regular);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(248, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 102);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 275);
            button3.Name = "button3";
            button3.Size = new Size(206, 63);
            button3.TabIndex = 3;
            button3.Text = "Topicos Modelagem Computacional";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Modelagem;
            button3.BackColor = Color.LightBlue;
            button3.Font = new Font("Arial", 10, FontStyle.Regular);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 426);
            label1.Name = "label1";
            label1.Size = new Size(301, 15);
            label1.TabIndex = 4;
            label1.Text = "Edinaldo Sá - Mestrado em Modelagem Computacional";
            label1.ForeColor = Color.DarkBlue;
            label1.Font = new Font("Arial", 9, FontStyle.Italic);
            // 
            // Algebra
            // 
            Algebra.Location = new Point(541, 281);
            Algebra.Name = "Algebra";
            Algebra.Size = new Size(234, 57);
            Algebra.TabIndex = 5;
            Algebra.Text = "Álgebra Linear - Catia";
            Algebra.UseVisualStyleBackColor = true;
            Algebra.Click += Algebra_Click;
            Algebra.BackColor = Color.LightBlue;
            Algebra.Font = new Font("Arial", 10, FontStyle.Regular);
            // 
            // button4
            // 
            button4.Location = new Point(276, 198);
            button4.Name = "button4";
            button4.Size = new Size(234, 57);
            button4.TabIndex = 6;
            button4.Text = "Atividades Interdisciplinares";
            button4.UseVisualStyleBackColor = true;
            button4.BackColor = Color.LightBlue;
            button4.Font = new Font("Arial", 10, FontStyle.Regular);
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(Algebra);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu de Matérias";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label1;
        private Button Algebra;
        private Button button4;
    }
}

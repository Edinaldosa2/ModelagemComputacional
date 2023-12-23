namespace AlgebraComputacional
{
    partial class MenuMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMaterias));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            LBL = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(455, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 241);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += AntonioExercicio;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(311, 241);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LBL
            // 
            LBL.AutoSize = true;
            LBL.Location = new Point(273, 21);
            LBL.Name = "LBL";
            LBL.Size = new Size(201, 15);
            LBL.TabIndex = 4;
            LBL.Text = "ÁLGEBRA LINEAR COMPUTACIONAL";
            LBL.Click += LBL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Italic);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 426);
            label1.Name = "label1";
            label1.Size = new Size(310, 15);
            label1.TabIndex = 6;
            label1.Text = "Edinaldo Sá - Mestrado em Modelagem Computacional";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(263, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(262, 102);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // MenuMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(LBL);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "MenuMaterias";
            Text = "Algebra Linear Computacional";
            TransparencyKey = Color.FromArgb(224, 224, 224);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label LBL;
        private Label label1;
        private PictureBox pictureBox3;
    }
}
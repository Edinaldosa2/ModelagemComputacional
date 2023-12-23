using MathNet.Numerics.LinearAlgebra;

namespace AlgebraComputacional
{
    partial class Exercicio3
    {

        private TextBox nullSpaceTextBox;
        private TextBox rowSpaceTextBox;
        private TextBox colSpaceTextBox;
        private TextBox rowSpaceTransposedTextBox;
        private Button calculateSpacesButton;

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
            nullSpaceTextBox = new TextBox();
            rowSpaceTextBox = new TextBox();
            colSpaceTextBox = new TextBox();
            rowSpaceTransposedTextBox = new TextBox();
            calculateSpacesButton = new Button();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            button3 = new Button();
            textBoxCodigo = new TextBox();
            SuspendLayout();
            // 
            // nullSpaceTextBox
            // 
            nullSpaceTextBox.Location = new Point(30, 40);
            nullSpaceTextBox.Multiline = true;
            nullSpaceTextBox.Name = "nullSpaceTextBox";
            nullSpaceTextBox.Size = new Size(200, 100);
            nullSpaceTextBox.TabIndex = 1;
            // 
            // rowSpaceTextBox
            // 
            rowSpaceTextBox.Location = new Point(30, 160);
            rowSpaceTextBox.Multiline = true;
            rowSpaceTextBox.Name = "rowSpaceTextBox";
            rowSpaceTextBox.Size = new Size(200, 100);
            rowSpaceTextBox.TabIndex = 2;
            // 
            // colSpaceTextBox
            // 
            colSpaceTextBox.Location = new Point(260, 40);
            colSpaceTextBox.Multiline = true;
            colSpaceTextBox.Name = "colSpaceTextBox";
            colSpaceTextBox.Size = new Size(200, 100);
            colSpaceTextBox.TabIndex = 3;
            // 
            // rowSpaceTransposedTextBox
            // 
            rowSpaceTransposedTextBox.Location = new Point(260, 160);
            rowSpaceTransposedTextBox.Multiline = true;
            rowSpaceTransposedTextBox.Name = "rowSpaceTransposedTextBox";
            rowSpaceTransposedTextBox.Size = new Size(200, 100);
            rowSpaceTransposedTextBox.TabIndex = 4;
            // 
            // calculateSpacesButton
            // 
            calculateSpacesButton.Location = new Point(200, 290);
            calculateSpacesButton.Name = "calculateSpacesButton";
            calculateSpacesButton.Size = new Size(100, 30);
            calculateSpacesButton.TabIndex = 5;
            calculateSpacesButton.Text = "Calcular";
            calculateSpacesButton.Click += CalculateSpacesButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(337, 290);
            button3.Name = "button3";
            button3.Size = new Size(100, 30);
            button3.TabIndex = 6;
            button3.Text = "Exibir codigo";
            button3.Click += button3_Click;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(484, 40);
            textBoxCodigo.Multiline = true;
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.ScrollBars = ScrollBars.Vertical;
            textBoxCodigo.Size = new Size(304, 280);
            textBoxCodigo.TabIndex = 7;
            // 
            // Exercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCodigo);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(nullSpaceTextBox);
            Controls.Add(rowSpaceTextBox);
            Controls.Add(colSpaceTextBox);
            Controls.Add(rowSpaceTransposedTextBox);
            Controls.Add(calculateSpacesButton);
            Name = "Exercicio3";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void CalculateSpacesButton_Click(object sender, EventArgs e)
        {
            double[,] matrixA = { { 1, -4, 4 }, { 4, -8, 6 }, { 0, -4, 5 } };

            // Calculando o Espaço Nulo (Núcleo de A)
            double[,] rrefMatrix = ReducedRowEchelonForm(matrixA);
            List<double[]> nullSpaceBasis = NullSpaceBasis(rrefMatrix);
            DisplayResult("Espaço Nulo (Núcleo de A):", nullSpaceBasis, nullSpaceTextBox);

            // Espaço de Linha (Imagem de A)
            List<double[]> rowSpace = RowSpace(matrixA);
            DisplayResult("Espaço de Linha (Imagem de A):", rowSpace, rowSpaceTextBox);

            // Espaço de Coluna (Imagem de A^T)
            List<double[]> colSpace = ColumnSpace(matrixA);
            DisplayResult("Espaço de Coluna (Imagem de A^T):", colSpace, colSpaceTextBox);

            // Espaço de Linha de A^T
            List<double[]> rowSpaceTransposed = RowSpace(Transpose(matrixA));
            DisplayResult("Espaço de Linha de A^T:", rowSpaceTransposed, rowSpaceTransposedTextBox);
        }

        private double[,] Transpose(double[,] matrixA)
        {
            // Implemente a lógica para transpor a matriz aqui
            // Esta função deve retornar a matriz transposta

            // Retorne uma matriz transposta de exemplo por enquanto (substitua isso pela lógica real)
            int rows = matrixA.GetLength(0);
            int cols = matrixA.GetLength(1);
            double[,] transposed = new double[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrixA[i, j];
                }
            }
            return transposed;
        }

        private List<double[]> ColumnSpace(double[,] matrix)
        {
            // Implemente a lógica para calcular o espaço de coluna da matriz aqui
            // Esta função deve retornar uma base para o espaço de coluna

            // Retorne uma matriz de exemplo por enquanto (substitua isso pela lógica real)
            //return new double[,] { { 1, 0, 0 }, { 0, 1, 0 } };

            var matrixA = CreateMatrix.DenseOfArray(matrix);
            var svd = matrixA.Svd();
            var matrixU = svd.U;

            List<double[]> columnSpaceBasis = new List<double[]>();

            for (int i = 0; i < matrixU.ColumnCount; i++)
            {
                var column = matrixU.Column(i).ToArray();
                columnSpaceBasis.Add(column);
            }

            return columnSpaceBasis;
        }

        private List<double[]> RowSpace(double[,] matrixA)
        {
            // Implemente a lógica para calcular o espaço de linha (imagem) da matriz aqui
            // Esta função deve retornar uma base para o espaço de linha

            // Retorne uma matriz de exemplo por enquanto (substitua isso pela lógica real)
            //return new double[,] { { 1, 2 }, { 3, 4 } };

            List<double[]> rowSpace = new List<double[]>();
            int rows = matrixA.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                double[] rowVector = GetRow(matrixA, i);
                rowSpace.Add(rowVector);
            }

            return rowSpace;
        }

        static double[] GetRow(double[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            double[] rowVector = new double[cols];

            for (int j = 0; j < cols; j++)
            {
                rowVector[j] = matrix[rowIndex, j];
            }

            return rowVector;
        }

        private List<double[]> NullSpaceBasis(double[,] rrefMatrix)
        {
            // Implemente a lógica para calcular o espaço nulo (núcleo) da matriz aqui
            // Esta função deve retornar uma base para o espaço nulo

            // Retorne uma matriz de exemplo por enquanto (substitua isso pela lógica real)
            //return new double[,] { { 1, 0 }, { 0, 1 } };

            var matrixA = CreateMatrix.DenseOfArray(rrefMatrix);
            var nullSpace = matrixA.Kernel();

            List<double[]> nullSpaceBasis = new List<double[]>();

            foreach (var vector in nullSpace)
            {
                nullSpaceBasis.Add(vector.ToArray());
            }

            return nullSpaceBasis;


        }

        private double[,] ReducedRowEchelonForm(double[,] matrixA)
        {
            // Implemente a lógica para calcular a forma escalonada reduzida (RREF) da matriz aqui
            // Esta função deve retornar a matriz em sua forma escalonada reduzida

            // Aqui está um exemplo simples de como você pode imprimir a matriz fornecida:
            int rows = matrixA.GetLength(0);
            int cols = matrixA.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrixA[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Retorne a própria matriz por enquanto (substitua isso pela lógica real)
            return matrixA;
        }


        #endregion

        private void DisplayResult(string title, List<double[]> matrix, TextBox textBox)
        {
            //textBox.Clear();
            //textBox.AppendText(title + "\r\n");
            //int rows = matrix.GetLength(0);
            //int cols = matrix.GetLength(1);
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        textBox.AppendText(matrix[i, j] + " ");
            //    }
            //    textBox.AppendText("\r\n");
            //}
            //textBox.AppendText($"Dimensão: {cols}");

            textBox.Clear();
            textBox.AppendText(title + "\r\n");

            foreach (var row in matrix)
            {
                foreach (var value in row)
                {
                    textBox.AppendText(value + " ");
                }
                textBox.AppendText("\r\n");
            }

            // O cálculo da dimensão depende do número de colunas no primeiro vetor
            int cols = matrix.Count > 0 ? matrix[0].Length : 0;
            textBox.AppendText($"Dimensão: {cols}");
        }

        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Button button3;
        private TextBox textBoxCodigo;
    }
}

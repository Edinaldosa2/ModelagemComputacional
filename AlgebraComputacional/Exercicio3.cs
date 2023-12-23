using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgebraComputacional
{
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var codigo = @" double[,] matrixA = { { 1, -4, 4 }, { 4, -8, 6 }, { 0, -4, 5 } };

            // Calculando o Espaço Nulo (Núcleo de A)
            double[,] rrefMatrix = ReducedRowEchelonForm(matrixA);
            List<double[]> nullSpaceBasis = NullSpaceBasis(rrefMatrix);
            DisplayResult(""Espaço Nulo (Núcleo de A):"", nullSpaceBasis, nullSpaceTextBox);

            // Espaço de Linha (Imagem de A)
            List<double[]> rowSpace = RowSpace(matrixA);
            DisplayResult(""Espaço de Linha (Imagem de A):"", rowSpace, rowSpaceTextBox);

            // Espaço de Coluna (Imagem de A^T)
            List<double[]> colSpace = ColumnSpace(matrixA);
            DisplayResult(""Espaço de Coluna (Imagem de A^T):"", colSpace, colSpaceTextBox);

            // Espaço de Linha de A^T
            List<double[]> rowSpaceTransposed = RowSpace(Transpose(matrixA));
            DisplayResult(""Espaço de Linha de A^T:"", rowSpaceTransposed, rowSpaceTransposedTextBox);
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
                    Console.Write(matrixA[i, j] + "" "");
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
            //textBox.AppendText(title + ""\r\n"");
            //int rows = matrix.GetLength(0);
            //int cols = matrix.GetLength(1);
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        textBox.AppendText(matrix[i, j] + "" "");
            //    }
            //    textBox.AppendText(""\r\n"");
            //}
            //textBox.AppendText($""Dimensão: {cols}"");

            textBox.Clear();
            textBox.AppendText(title + ""\r\n"");

            foreach (var row in matrix)
            {
                foreach (var value in row)
                {
                    textBox.AppendText(value + "" "");
                }
                textBox.AppendText(""\r\n"");
            }

            // O cálculo da dimensão depende do número de colunas no primeiro vetor
            int cols = matrix.Count > 0 ? matrix[0].Length : 0;
            textBox.AppendText($""Dimensão: {cols}"");
        }

        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Button button3;
    }";

            textBoxCodigo.Text = codigo;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgebraComputacional.Lista1
{
    public partial class Exercicio1_10 : Form
    {
        public Exercicio1_10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Resolver a parte (a) do problema
            double[,] hilbertMatrix = CreateHilbertMatrix(4);
            double[] constants = new double[] { 1 / 2.0, 1 / 3.0, 1 / 4.0, 1 / 5.0 }; // Exemplo de constantes

            double[] solutionA = SolveLinearEquation(hilbertMatrix, constants);
            string resultA = "Solução da parte (a):\r\n" + MatrixToString(solutionA);

            // Discutir a má-condição das matrizes de Hilbert (parte b)
            string resultB = "\r\nAnálise da parte (b):\r\n" +
                             "Matrizes de Hilbert são exemplos clássicos de matrizes mal condicionadas. " +
                             "À medida que o tamanho da matriz aumenta, o número de condição também aumenta, " +
                             "indicando que pequenas mudanças nos dados de entrada podem causar grandes variações na solução.";

            textBox1.Text = "\r\n" + resultA + "\r\n" + resultB;
        }

        private double[,] CreateHilbertMatrix(int size)
        {
            double[,] matrix = new double[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = 1.0 / (i + j + 1);
            return matrix;
        }

        private string MatrixToString(double[] matrix)
        {
            return string.Join(", ", matrix);
        }

        private double[] SolveLinearEquation(double[,] A, double[] b)
        {
            int n = A.GetLength(0);
            double[,] Ab = new double[n, n + 1];

            // Forming the augmented matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Ab[i, j] = A[i, j];
                Ab[i, n] = b[i];
            }

            // Gaussian Elimination
            for (int i = 0; i < n - 1; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    double factor = Ab[k, i] / Ab[i, i];
                    for (int j = i; j <= n; j++)
                        Ab[k, j] -= factor * Ab[i, j];
                }
            }

            // Back Substitution
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                x[i] = Ab[i, n];
                for (int j = i + 1; j < n; j++)
                    x[i] -= Ab[i, j] * x[j];
                x[i] /= Ab[i, i];
            }

            return x;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var codigo = @"private void button1_Click(object sender, EventArgs e)
        {
            // Resolver a parte (a) do problema
            double[,] hilbertMatrix = CreateHilbertMatrix(4);
            double[] constants = new double[] { 1 / 2.0, 1 / 3.0, 1 / 4.0, 1 / 5.0 }; // Exemplo de constantes

            double[] solutionA = SolveLinearEquation(hilbertMatrix, constants);
            string resultA = ""Solução da parte (a):\r\n"" + MatrixToString(solutionA);

            // Discutir a má-condição das matrizes de Hilbert (parte b)
            string resultB = ""\r\nAnálise da parte (b):\r\n"" +
                             ""Matrizes de Hilbert são exemplos clássicos de matrizes mal condicionadas. "" +
                             ""À medida que o tamanho da matriz aumenta, o número de condição também aumenta, "" +
                             ""indicando que pequenas mudanças nos dados de entrada podem causar grandes variações na solução."";

            textBox1.Text = ""\r\n"" + resultA + ""\r\n"" + resultB;
        }

        private double[,] CreateHilbertMatrix(int size)
        {
            double[,] matrix = new double[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = 1.0 / (i + j + 1);
            return matrix;
        }

        private string MatrixToString(double[] matrix)
        {
            return string.Join("", "", matrix);
        }

        private double[] SolveLinearEquation(double[,] A, double[] b)
        {
            int n = A.GetLength(0);
            double[,] Ab = new double[n, n + 1];

            // Forming the augmented matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Ab[i, j] = A[i, j];
                Ab[i, n] = b[i];
            }

            // Gaussian Elimination
            for (int i = 0; i < n - 1; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    double factor = Ab[k, i] / Ab[i, i];
                    for (int j = i; j <= n; j++)
                        Ab[k, j] -= factor * Ab[i, j];
                }
            }

            // Back Substitution
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                x[i] = Ab[i, n];
                for (int j = i + 1; j < n; j++)
                    x[i] -= Ab[i, j] * x[j];
                x[i] /= Ab[i, i];
            }

            return x;

        }";

            textBox1.Text = codigo;

        }
    }
}

using MathNet.Numerics.LinearAlgebra;
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
    public partial class Exercicio1_1 : Form
    {
        public Exercicio1_1()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            //PerformGaussianElimination();
            btnCalculate_Click(sender, e);
        }
        private void PerformGaussianElimination()
        {
            double[,] matriz = new double[,]
            {
                { 4, -8, 5, 1, 0, 0 },
                { 4, -7, 4, 0, 1, 0 },
                { 3, -4, 2, 0, 0, 1 }
            };

            // Aqui, você implementa a eliminação gaussiana
            // Esta é uma versão simplificada e pode precisar de mais validações
            int length = matriz.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                // Tornar o elemento diagonal 1
                double diag = matriz[i, i];
                for (int j = 0; j < length * 2; j++)
                    matriz[i, j] /= diag;

                // Zero abaixo do pivô
                for (int k = i + 1; k < length; k++)
                {
                    double factor = matriz[k, i];
                    for (int j = 0; j < length * 2; j++)
                        matriz[k, j] -= factor * matriz[i, j];
                }
            }

            // Exibir resultado
            DisplayMatrix(matriz);
        }

        private void DisplayMatrix(double[,] matriz)
        {
            string result = "";
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                    result += matriz[i, j].ToString("F2") + " ";
                result += Environment.NewLine;
            }
            textBox1.Text = "O método de eliminação gaussiana foi aplicado em uma matriz aumentada para resolver sistemas de equações lineares. Primeiro, a matriz foi escalonada, tornando os elementos da diagonal principal iguais a 1 e os elementos abaixo deles iguais a 0. Isso foi alcançado dividindo cada linha pelo elemento da diagonal e subtraindo as linhas apropriadas. O resultado é uma matriz na qual as colunas à direita da matriz de coeficientes representam as soluções dos sistemas originais.\n\r";

            textBox1.Text = "\n\r" + textBox1.Text + "\n\r" + result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double[,] A = new double[,] { { 4, -8, 5 }, { 4, -7, 4 }, { 3, -4, 2 } };
            double[] b1 = new double[] { 1, 0, 0 };
            double[] b2 = new double[] { 0, 1, 0 };
            double[] b3 = new double[] { 0, 0, 1 };

            var solution1 = SolveLinearEquation(A, b1);
            var solution2 = SolveLinearEquation(A, b2);
            var solution3 = SolveLinearEquation(A, b3);

            textBox1.Text = "Método de Eliminação Gaussiana:\r\n" +
                "\r\n1. Formação da Matriz Aumentada:\r\n" +
                "   - A matriz de coeficientes (A) é combinada com a matriz de resultados (b) para formar uma única matriz aumentada (Ab).\r\n" +
                "\r\n2. Eliminação para Frente:\r\n" +
                "   - Para cada linha, começando da primeira, transformamos o elemento da coluna atual em um pivô (1) e usamos operações de linha para tornar todos os elementos abaixo do pivô iguais a zero.\r\n" +
                "   - Isso envolve subtrair múltiplos adequados das linhas acima da linha atual.\r\n" +
                "\r\n3. Substituição para Trás:\r\n" +
                "   - Começando da última linha da matriz, calculamos o valor da variável correspondente.\r\n" +
                "   - Progressivamente substituímos os valores já encontrados nas linhas acima para encontrar os valores de outras variáveis.\r\n" +
                "\r\nResultado:\r\n" +
                "   - Os valores das variáveis x, y, z são calculados com base no sistema de equações fornecido.\r\n";


            textBox1.Text = "\r\n" + textBox1.Text + $"Solution 1: x={solution1[0]}, y={solution1[1]}, z={solution1[2]}\r\n" +
                             $"Solution 2: x={solution2[0]}, y={solution2[1]}, z={solution2[2]}\r\n" +
                             $"Solution 3: x={solution3[0]}, y={solution3[1]}, z={solution3[2]}";
        }

        private double[] SolveLinearEquation(double[,] A, double[] b)
        {
            int n = b.Length;
            double[,] Ab = new double[n, n + 1];
            double[] x = new double[n];

            // Forming Augmented Matrix
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
            for (int i = n - 1; i >= 0; i--)
            {
                x[i] = Ab[i, n];
                for (int j = i + 1; j < n; j++)
                    x[i] -= Ab[i, j] * x[j];
                x[i] = x[i] / Ab[i, i];
            }

            return x;
        }

        private void ExibirCodigo(object sender, EventArgs e)
        {
          var codigo = @"double[,] A = new double[,] { { 4, -8, 5 }, { 4, -7, 4 }, { 3, -4, 2 } };
            double[] b1 = new double[] { 1, 0, 0 };
            double[] b2 = new double[] { 0, 1, 0 };
            double[] b3 = new double[] { 0, 0, 1 };

            var solution1 = SolveLinearEquation(A, b1);
            var solution2 = SolveLinearEquation(A, b2);
            var solution3 = SolveLinearEquation(A, b3);

            textBox1.Text = ""Método de Eliminação Gaussiana:\r\n"" +
                ""\r\n1. Formação da Matriz Aumentada:\r\n"" +
                ""   - A matriz de coeficientes (A) é combinada com a matriz de resultados (b) para formar uma única matriz aumentada (Ab).\r\n"" +
                ""\r\n2. Eliminação para Frente:\r\n"" +
                ""   - Para cada linha, começando da primeira, transformamos o elemento da coluna atual em um pivô (1) e usamos operações de linha para tornar todos os elementos abaixo do pivô iguais a zero.\r\n"" +
                ""   - Isso envolve subtrair múltiplos adequados das linhas acima da linha atual.\r\n"" +
                ""\r\n3. Substituição para Trás:\r\n"" +
                ""   - Começando da última linha da matriz, calculamos o valor da variável correspondente.\r\n"" +
                ""   - Progressivamente substituímos os valores já encontrados nas linhas acima para encontrar os valores de outras variáveis.\r\n"" +
                ""\r\nResultado:\r\n"" +
                ""   - Os valores das variáveis x, y, z são calculados com base no sistema de equações fornecido.\r\n"";


            textBox1.Text = ""\r\n"" + textBox1.Text + $""Solution 1: x={solution1[0]}, y={solution1[1]}, z={solution1[2]}\r\n"" +
                             $""Solution 2: x={solution2[0]}, y={solution2[1]}, z={solution2[2]}\r\n"" +
                             $""Solution 3: x={solution3[0]}, y={solution3[1]}, z={solution3[2]}"";


        private double[] SolveLinearEquation(double[,] A, double[] b)
        {
            int n = b.Length;
            double[,] Ab = new double[n, n + 1];
            double[] x = new double[n];

            // Forming Augmented Matrix
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
            for (int i = n - 1; i >= 0; i--)
            {
                x[i] = Ab[i, n];
                for (int j = i + 1; j < n; j++)
                    x[i] -= Ab[i, j] * x[j];
                x[i] = x[i] / Ab[i, i];
            }

            return x;
        }

";

            textBox1.Text = codigo;
        }
    }
}

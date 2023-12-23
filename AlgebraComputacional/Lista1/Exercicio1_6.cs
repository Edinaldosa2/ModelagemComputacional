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
    public partial class Exercicio1_6 : Form
    {
        public Exercicio1_6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolveBoundaryValueProblem(5);
        }

        private void SolveBoundaryValueProblem(int n)
        {
            StringBuilder explanation = new StringBuilder();
            double h = 1.0 / (n + 1);
            double[,] A = new double[n, n];
            double[] b = new double[n];
            double[] y = new double[n + 2];

            // Inicializar o vetor b com os valores correspondentes a 125t_i
            for (int i = 0; i < n; i++)
            {
                b[i] = 125 * (i + 1) * h * h; // Multiplicamos por h^2 devido à formulação do método de diferenças finitas
            }

            // Construir a matriz A baseada no método de diferenças finitas
            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    A[i, i - 1] = 1;
                }
                A[i, i] = -2;
                if (i < n - 1)
                {
                    A[i, i + 1] = 1;
                }
            }

            // Resolver o sistema linear Ay = b
            y = SolveLinearSystem(A, b); // A função SolveLinearSystem precisa ser ajustada para o tamanho correto da matriz e vetor

            // Adicionar a solução ao StringBuilder
            explanation.AppendLine("Solução aproximada para o problema de valor de contorno:");
            for (int i = 1; i <= n; i++)
            {
                explanation.AppendLine($"y({i * h:F2}) = {y[i - 1]:F4}");
            }

            // Adicionar a explicação ao StringBuilder
            explanation.AppendLine("\nExplicação:");
            explanation.AppendLine("O problema de valor de contorno foi discretizado usando o método de diferenças finitas.");
            explanation.AppendLine($"O intervalo [0,1] foi dividido em {n + 1} subintervalos iguais de tamanho {h:F4}.");
            explanation.AppendLine("Uma matriz tridiagonal foi construída para representar as aproximações das derivadas segundas.");
            explanation.AppendLine("O sistema linear resultante foi resolvido para encontrar os valores aproximados de y nos pontos da grade interna.");
            explanation.AppendLine("Note que com apenas quatro pontos de grade internos, não se deve esperar aproximações muito precisas.");

            // Atualizar o textBoxResults
            textBox1.Text = explanation.ToString();
        }


        private double[] SolveLinearSystem(double[,] A, double[] b)
        {
            int n = b.Length;

            // Fazendo a eliminação gaussiana
            for (int i = 0; i < n; i++)
            {
                // Verificar se o pivô é zero
                if (Math.Abs(A[i, i]) < 1e-14)
                {
                    throw new InvalidOperationException("Divisão por zero detectada durante a eliminação gaussiana.");
                }

                // Normalizar a linha do pivô
                for (int j = i + 1; j < n; j++)
                {
                    double factor = A[j, i] / A[i, i];
                    b[j] -= factor * b[i];
                    for (int k = i; k < n; k++)
                    {
                        A[j, k] -= factor * A[i, k];
                    }
                }
            }

            // Fazendo a substituição regressiva
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0.0;
                for (int j = i + 1; j < n; j++)
                {
                    sum += A[i, j] * x[j];
                }
                x[i] = (b[i] - sum) / A[i, i];
            }

            return x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codigo = @"        private void button1_Click(object sender, EventArgs e)
        {
            SolveBoundaryValueProblem(5);
        }

        private void SolveBoundaryValueProblem(int n)
        {
            StringBuilder explanation = new StringBuilder();
            double h = 1.0 / (n + 1);
            double[,] A = new double[n, n];
            double[] b = new double[n];
            double[] y = new double[n + 2];

            // Inicializar o vetor b com os valores correspondentes a 125t_i
            for (int i = 0; i < n; i++)
            {
                b[i] = 125 * (i + 1) * h * h; // Multiplicamos por h^2 devido à formulação do método de diferenças finitas
            }

            // Construir a matriz A baseada no método de diferenças finitas
            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    A[i, i - 1] = 1;
                }
                A[i, i] = -2;
                if (i < n - 1)
                {
                    A[i, i + 1] = 1;
                }
            }

            // Resolver o sistema linear Ay = b
            y = SolveLinearSystem(A, b); // A função SolveLinearSystem precisa ser ajustada para o tamanho correto da matriz e vetor

            // Adicionar a solução ao StringBuilder
            explanation.AppendLine(""Solução aproximada para o problema de valor de contorno:"");
            for (int i = 1; i <= n; i++)
            {
                explanation.AppendLine($""y({i * h:F2}) = {y[i - 1]:F4}"");
            }

            // Adicionar a explicação ao StringBuilder
            explanation.AppendLine(""\nExplicação:"");
            explanation.AppendLine(""O problema de valor de contorno foi discretizado usando o método de diferenças finitas."");
            explanation.AppendLine($""O intervalo [0,1] foi dividido em {n + 1} subintervalos iguais de tamanho {h:F4}."");
            explanation.AppendLine(""Uma matriz tridiagonal foi construída para representar as aproximações das derivadas segundas."");
            explanation.AppendLine(""O sistema linear resultante foi resolvido para encontrar os valores aproximados de y nos pontos da grade interna."");
            explanation.AppendLine(""Note que com apenas quatro pontos de grade internos, não se deve esperar aproximações muito precisas."");

            // Atualizar o textBoxResults
            textBox1.Text = explanation.ToString();
        }


        private double[] SolveLinearSystem(double[,] A, double[] b)
        {
            int n = b.Length;

            // Fazendo a eliminação gaussiana
            for (int i = 0; i < n; i++)
            {
                // Verificar se o pivô é zero
                if (Math.Abs(A[i, i]) < 1e-14)
                {
                    throw new InvalidOperationException(""Divisão por zero detectada durante a eliminação gaussiana."");
                }

                // Normalizar a linha do pivô
                for (int j = i + 1; j < n; j++)
                {
                    double factor = A[j, i] / A[i, i];
                    b[j] -= factor * b[i];
                    for (int k = i; k < n; k++)
                    {
                        A[j, k] -= factor * A[i, k];
                    }
                }
            }

            // Fazendo a substituição regressiva
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0.0;
                for (int j = i + 1; j < n; j++)
                {
                    sum += A[i, j] * x[j];
                }
                x[i] = (b[i] - sum) / A[i, i];
            }

            return x;
        }
";

            textBox1.Text = codigo;
        }
    }
}

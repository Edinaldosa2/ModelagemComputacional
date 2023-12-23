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
    public partial class Exercicio1_3 : Form
    {
        public Exercicio1_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] coefficients = {
            { -1, 3, -2 },
            { -1, 4, -3 },
            { -1, 5, -4 }
        };
            double[] constants = { 1, 0, 0 };

            string explanation = GaussianElimination(coefficients, constants);
            textBox1.Text = explanation;
        }

        private string GaussianElimination(double[,] coefficients, double[] constants)
        {
            StringBuilder explanation = new StringBuilder();
            int n = constants.Length;

            // Realizar a eliminação gaussiana
            for (int i = 0; i < n; i++)
            {
                // Encontrar o maior elemento em módulo na coluna i
                double maxElement = Math.Abs(coefficients[i, i]);
                int maxRow = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(coefficients[k, i]) > maxElement)
                    {
                        maxElement = Math.Abs(coefficients[k, i]);
                        maxRow = k;
                    }
                }

                // Trocar a linha máxima com a linha atual
                for (int k = i; k < n; k++)
                {
                    double tmp = coefficients[maxRow, k];
                    coefficients[maxRow, k] = coefficients[i, k];
                    coefficients[i, k] = tmp;
                }
                double temp = constants[maxRow];
                constants[maxRow] = constants[i];
                constants[i] = temp;

                // Tornar todos os elementos abaixo do pivô zeros
                for (int k = i + 1; k < n; k++)
                {
                    double factor = -coefficients[k, i] / coefficients[i, i];
                    constants[k] += factor * constants[i];
                    for (int j = i; j < n; j++)
                    {
                        coefficients[k, j] += factor * coefficients[i, j];
                    }
                }
            }

            // Verificar se há uma linha com todos os elementos zero e um termo constante não-zero
            for (int i = 0; i < n; i++)
            {
                if (coefficients[i, i] == 0 && constants[i] != 0)
                {
                    explanation.AppendLine("Após realizar a eliminação gaussiana, obtemos uma linha com todos os elementos zero no lado dos coeficientes.");
                    explanation.AppendLine("Isso indica que o sistema é inconsistente e, portanto, não tem solução única.");
                    explanation.AppendLine("Uma linha de zero no lado dos coeficientes e um termo constante não-zero é uma contradição.");
                    explanation.AppendLine("O sistema não tem solução.");
                    return explanation.ToString();
                }
            }

            // Resolver o sistema triangular superior
            double[] solution = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                solution[i] = constants[i];
                for (int j = i + 1; j < n; j++)
                {
                    solution[i] -= coefficients[i, j] * solution[j];
                }
                solution[i] /= coefficients[i, i];
            }

            // Montar a explicação
            explanation.AppendLine("A matriz triangular superior resultante é:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    explanation.AppendFormat("{0:F2}\t", coefficients[i, j]);
                }
                explanation.AppendFormat("| {0:F2}", constants[i]);
                explanation.AppendLine();
            }

            explanation.AppendLine("A solução do sistema é:");
            for (int i = 0; i < n; i++)
            {
                explanation.AppendFormat("x{0} = {1:F2}\n", i + 1, solution[i]);
            }

            return explanation.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codigo = @"
        private void button1_Click(object sender, EventArgs e)
        {
            double[,] coefficients = {
            { -1, 3, -2 },
            { -1, 4, -3 },
            { -1, 5, -4 }
        };
            double[] constants = { 1, 0, 0 };

            string explanation = GaussianElimination(coefficients, constants);
            textBox1.Text = explanation;
        }

        private string GaussianElimination(double[,] coefficients, double[] constants)
        {
            StringBuilder explanation = new StringBuilder();
            int n = constants.Length;

            // Realizar a eliminação gaussiana
            for (int i = 0; i < n; i++)
            {
                // Encontrar o maior elemento em módulo na coluna i
                double maxElement = Math.Abs(coefficients[i, i]);
                int maxRow = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(coefficients[k, i]) > maxElement)
                    {
                        maxElement = Math.Abs(coefficients[k, i]);
                        maxRow = k;
                    }
                }

                // Trocar a linha máxima com a linha atual
                for (int k = i; k < n; k++)
                {
                    double tmp = coefficients[maxRow, k];
                    coefficients[maxRow, k] = coefficients[i, k];
                    coefficients[i, k] = tmp;
                }
                double temp = constants[maxRow];
                constants[maxRow] = constants[i];
                constants[i] = temp;

                // Tornar todos os elementos abaixo do pivô zeros
                for (int k = i + 1; k < n; k++)
                {
                    double factor = -coefficients[k, i] / coefficients[i, i];
                    constants[k] += factor * constants[i];
                    for (int j = i; j < n; j++)
                    {
                        coefficients[k, j] += factor * coefficients[i, j];
                    }
                }
            }

            // Verificar se há uma linha com todos os elementos zero e um termo constante não-zero
            for (int i = 0; i < n; i++)
            {
                if (coefficients[i, i] == 0 && constants[i] != 0)
                {
                    explanation.AppendLine(""Após realizar a eliminação gaussiana, obtemos uma linha com todos os elementos zero no lado dos coeficientes."");
                    explanation.AppendLine(""Isso indica que o sistema é inconsistente e, portanto, não tem solução única."");
                    explanation.AppendLine(""Uma linha de zero no lado dos coeficientes e um termo constante não-zero é uma contradição."");
                    explanation.AppendLine(""O sistema não tem solução."");
                    return explanation.ToString();
                }
            }

            // Resolver o sistema triangular superior
            double[] solution = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                solution[i] = constants[i];
                for (int j = i + 1; j < n; j++)
                {
                    solution[i] -= coefficients[i, j] * solution[j];
                }
                solution[i] /= coefficients[i, i];
            }

            // Montar a explicação
            explanation.AppendLine(""A matriz triangular superior resultante é:"");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    explanation.AppendFormat(""{0:F2}\t"", coefficients[i, j]);
                }
                explanation.AppendFormat(""| {0:F2}"", constants[i]);
                explanation.AppendLine();
            }

            explanation.AppendLine(""A solução do sistema é:"");
            for (int i = 0; i < n; i++)
            {
                explanation.AppendFormat(""x{0} = {1:F2}\n"", i + 1, solution[i]);
            }

            return explanation.ToString();
        }";
            textBox1.Text = codigo;
        }
    }
}
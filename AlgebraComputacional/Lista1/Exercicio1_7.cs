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
    public partial class Exercicio1_7 : Form
    {
        public Exercicio1_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolveBoundaryValueProblem(10); // n = 10 subintervalos com exemplo. 
        }

        private void SolveBoundaryValueProblem(int n)
        {
            StringBuilder explanation = new StringBuilder();
            double h = 1.0 / (n + 1);
            double[] f = new double[n + 2]; // Inclui f(0) e f(n+1) que são as condições de contorno
            double[,] A = new double[n + 2, n + 2];
            double[] y = new double[n + 2]; // Inclui y(0) e y(n+1) que são as condições de contorno

            // Inicializar f(t) e as condições de contorno
            for (int i = 0; i < f.Length; i++)
            {
                f[i] = SomeFunction(i * h); // Substitua SomeFunction pela função f(t) específica do problema
            }
            y[0] = y[n + 1] = 0; // Condições de contorno y(0) = y(1) = 0

            // Construir a matriz A com base no método de diferenças finitas
            for (int i = 1; i <= n; i++)
            {
                A[i, i - 1] = -1.0 / (h * h) - 1.0 / (2.0 * h);
                A[i, i] = 2.0 / (h * h) + 1.0 / (2.0 * h);
                A[i, i + 1] = -1.0 / (h * h) + 1.0 / (2.0 * h);
            }

            // Resolver o sistema Ay = f para y
            double[] solution = SolveLinearSystem(A, f, n);

            // Construir a explicação detalhada
            explanation.AppendLine("O método de diferenças finitas foi aplicado para resolver o problema de valor de contorno.");
            explanation.AppendLine("O intervalo [0,1] foi dividido em " + n + " subintervalos iguais.");
            explanation.AppendLine("O tamanho de cada subintervalo h é: " + h.ToString("F4"));
            explanation.AppendLine("A matriz do sistema linear associado e o vetor de termos constantes foram construídos.");
            explanation.AppendLine("A solução do sistema linear é aproximadamente:");
            for (int i = 0; i < solution.Length; i++)
            {
                explanation.AppendLine($"y({i * h:F2}) = {solution[i]:F4}");
            }

            textBox1.Text = explanation.ToString();
        }

        private double[] SolveLinearSystem(double[,] A, double[] f, int n)
        {
            // A matriz deve ser (n+2)x(n+2) para incluir as condições de contorno
            n = n + 2;

            // Implementação do algoritmo de eliminação gaussiana
            for (int i = 1; i < n - 1; i++) // Começa de 1 e vai até n-2, pois as linhas 0 e n-1 são as condições de contorno
            {
                // Encontre o pivô
                double max = Math.Abs(A[i, i]);
                int row = i;
                for (int k = i + 1; k < n - 1; k++)
                {
                    if (Math.Abs(A[k, i]) > max)
                    {
                        max = Math.Abs(A[k, i]);
                        row = k;
                    }
                }

                // Troque as linhas se necessário
                if (row != i)
                {
                    for (int k = 1; k < n - 1; k++) // As colunas 0 e n-1 são condições de contorno e não devem ser alteradas
                    {
                        double temp = A[row, k];
                        A[row, k] = A[i, k];
                        A[i, k] = temp;
                    }
                    double tempF = f[row];
                    f[row] = f[i];
                    f[i] = tempF;
                }

                // Elimine as linhas abaixo do pivô
                for (int k = i + 1; k < n - 1; k++)
                {
                    double factor = A[k, i] / A[i, i];
                    for (int j = i; j < n - 1; j++)
                    {
                        A[k, j] -= factor * A[i, j];
                    }
                    f[k] -= factor * f[i];
                }
            }

            // Resolva o sistema por substituição regressiva
            double[] y = new double[n];
            for (int i = n - 2; i > 0; i--) // Começa de n-2 e vai até 1
            {
                y[i] = f[i];
                for (int j = i + 1; j < n - 1; j++)
                {
                    y[i] -= A[i, j] * y[j];
                }
                y[i] /= A[i, i];
            }

            // As condições de contorno já estão definidas como y[0] = y[n-1] = 0
            return y;
        }
        private double SomeFunction(double t)
        {
            // Substitua esta função pela função específica f(t) do problema
            // Exemplo: f(t) = t^2
            return t * t;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}


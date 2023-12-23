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
    public partial class Exercicio1_5 : Form
    {
        public Exercicio1_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolveParabolaCoefficients();
        }

        private void SolveParabolaCoefficients()
        {
            double[,] A = {
                { 1, 1, 1 },
                { 1, 2, 4 },
                { 1, 3, 9 }
            };

            double[] b = { 1, 2, 0 };

            double[] coefficients = SolveLinearSystem(A, b);

            StringBuilder explanation = new StringBuilder();
            explanation.AppendLine("Para encontrar os coeficientes da parábola que passa pelos pontos (1,1), (2,2) e (3,0),");
            explanation.AppendLine("montamos o seguinte sistema de equações a partir da equação geral da parábola y = α + βx + γx²:");
            explanation.AppendLine("1 = α + β + γ");
            explanation.AppendLine("2 = α + 2β + 4γ");
            explanation.AppendLine("0 = α + 3β + 9γ");
            explanation.AppendLine("Resolvendo este sistema, encontramos os coeficientes:");
            explanation.AppendLine($"α (alpha) = {coefficients[0]:F2}, β (beta) = {coefficients[1]:F2}, γ (gamma) = {coefficients[2]:F2}");

            textBox1.Text = explanation.ToString();
        }


        private double[] SolveLinearSystem(double[,] A, double[] b)
        {
            int n = b.Length;
            double[] x = new double[n];

            // Pivoteamento parcial e eliminação gaussiana
            for (int i = 0; i < n - 1; i++)
            {
                // Encontrar o pivô
                int maxIndex = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(A[k, i]) > Math.Abs(A[maxIndex, i]))
                    {
                        maxIndex = k;
                    }
                }
                // Trocar as linhas
                if (i != maxIndex)
                {
                    for (int k = 0; k < n; k++)
                    {
                        double tmp = A[i, k];
                        A[i, k] = A[maxIndex, k];
                        A[maxIndex, k] = tmp;
                    }
                    double tmpB = b[i];
                    b[i] = b[maxIndex];
                    b[maxIndex] = tmpB;
                }

                // Verificar se o elemento da diagonal principal é zero
                if (Math.Abs(A[i, i]) <= 1e-10)
                {
                    throw new InvalidOperationException("O sistema não tem solução única.");
                }

                // Eliminação
                for (int k = i + 1; k < n; k++)
                {
                    double factor = A[k, i] / A[i, i];
                    b[k] -= factor * b[i];
                    for (int j = i; j < n; j++)
                    {
                        A[k, j] -= factor * A[i, j];
                    }
                }
            }

            // Verificar se o último elemento da diagonal principal é zero
            if (Math.Abs(A[n - 1, n - 1]) <= 1e-10)
            {
                throw new InvalidOperationException("O sistema não tem solução única.");
            }

            // Substituição regressiva
            for (int i = n - 1; i >= 0; i--)
            {
                x[i] = b[i];
                for (int j = i + 1; j < n; j++)
                {
                    x[i] -= A[i, j] * x[j];
                }
                x[i] /= A[i, i];
            }

            return x;
        }

    }
}
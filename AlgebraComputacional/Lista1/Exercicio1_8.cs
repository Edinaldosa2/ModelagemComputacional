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
    public partial class Exercicio1_8 : Form
    {
        public Exercicio1_8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateAndExplainSystems();
        }

        private void CalculateAndExplainSystems()
        {
            // Sistema A
            double[] solutionA = SolveSystem(new double[,] { { 1.001, 0.0001 }, { 1, -1 } },
                                             new double[] { 0.765, 0.235 });
            string explanationA = "Sistema (A) - As linhas são quase paralelas, indicando um sistema potencialmente mal condicionado.";

            // Sistema B
            double[] solutionB = SolveSystem(new double[,] { { 1.001, 0.9999 }, { 1, -1 } },
                                             new double[] { 0.765, 0.235 });
            string explanationB = "Sistema (B) - As linhas estão quase paralelas, mas o ponto de interseção é ligeiramente mais estável do que em (A).";

            // Sistema C
            double[] solutionC = SolveSystem(new double[,] { { 1.001, -1 }, { 1, 0.9999 } },
                                             new double[] { 0.235, 0.765 });
            string explanationC = "Sistema (C) - As linhas se cruzam em um ângulo mais aberto, resultando em um ponto de interseção mais estável e um sistema melhor condicionado.";

            // Definir texto para textBox1 com as soluções e explicações
            textBox1.Text = $"Solução Sistema (A): x = {solutionA[0]}, y = {solutionA[1]}\r\n" +
                            $"{explanationA}\r\n\r\n" +
                            $"Solução Sistema (B): x = {solutionB[0]}, y = {solutionB[1]}\r\n" +
                            $"{explanationB}\r\n\r\n" +
                            $"Solução Sistema (C): x = {solutionC[0]}, y = {solutionC[1]}\r\n" +
                            $"{explanationC}";
        }

        private double[] SolveSystem(double[,] coefficients, double[] constants)
        {
            // Assume-se que coefficients é uma matriz 2x2 e constants é um vetor 2x1,
            // representando um sistema de equações lineares de duas variáveis.

            // Calculando o determinante da matriz de coeficientes
            double det = coefficients[0, 0] * coefficients[1, 1] - coefficients[0, 1] * coefficients[1, 0];
            if (Math.Abs(det) < 1e-14) // Considere um pequeno valor como zero para evitar divisão por zero
            {
                throw new InvalidOperationException("O sistema de equações não tem uma solução única.");
            }

            // Aplicando a eliminação de Gauss para encontrar os valores de x e y
            double[] solution = new double[2];

            // Normalizando a linha 1
            double factor = coefficients[0, 0];
            coefficients[0, 0] /= factor;
            coefficients[0, 1] /= factor;
            constants[0] /= factor;

            // Tornando o elemento (2,1) zero, subtraindo a linha 1 da linha 2
            factor = coefficients[1, 0];
            coefficients[1, 0] -= factor * coefficients[0, 0];
            coefficients[1, 1] -= factor * coefficients[0, 1];
            constants[1] -= factor * constants[0];

            // Agora, a matriz de coeficientes está em forma triangular superior
            // Podemos resolver as variáveis por substituição regressiva

            // Resolvendo para y
            solution[1] = constants[1] / coefficients[1, 1];

            // Resolvendo para x
            solution[0] = (constants[0] - coefficients[0, 1] * solution[1]) / coefficients[0, 0];

            return solution;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codigo = @"
        private void CalculateAndExplainSystems()
        {
            // Sistema A
            double[] solutionA = SolveSystem(new double[,] { { 1.001, 0.0001 }, { 1, -1 } },
                                             new double[] { 0.765, 0.235 });
            string explanationA = ""Sistema (A) - As linhas são quase paralelas, indicando um sistema potencialmente mal condicionado."";

            // Sistema B
            double[] solutionB = SolveSystem(new double[,] { { 1.001, 0.9999 }, { 1, -1 } },
                                             new double[] { 0.765, 0.235 });
            string explanationB = ""Sistema (B) - As linhas estão quase paralelas, mas o ponto de interseção é ligeiramente mais estável do que em (A)."";

            // Sistema C
            double[] solutionC = SolveSystem(new double[,] { { 1.001, -1 }, { 1, 0.9999 } },
                                             new double[] { 0.235, 0.765 });
            string explanationC = ""Sistema (C) - As linhas se cruzam em um ângulo mais aberto, resultando em um ponto de interseção mais estável e um sistema melhor condicionado."";

            // Definir texto para textBox1 com as soluções e explicações
            textBox1.Text = $""Solução Sistema (A): x = {solutionA[0]}, y = {solutionA[1]}\r\n"" +
                            $""{explanationA}\r\n\r\n"" +
                            $""Solução Sistema (B): x = {solutionB[0]}, y = {solutionB[1]}\r\n"" +
                            $""{explanationB}\r\n\r\n"" +
                            $""Solução Sistema (C): x = {solutionC[0]}, y = {solutionC[1]}\r\n"" +
                            $""{explanationC}"";
        }

        private double[] SolveSystem(double[,] coefficients, double[] constants)
        {
            // Assume-se que coefficients é uma matriz 2x2 e constants é um vetor 2x1,
            // representando um sistema de equações lineares de duas variáveis.

            // Calculando o determinante da matriz de coeficientes
            double det = coefficients[0, 0] * coefficients[1, 1] - coefficients[0, 1] * coefficients[1, 0];
            if (Math.Abs(det) < 1e-14) // Considere um pequeno valor como zero para evitar divisão por zero
            {
                throw new InvalidOperationException(""O sistema de equações não tem uma solução única."");
            }

            // Aplicando a eliminação de Gauss para encontrar os valores de x e y
            double[] solution = new double[2];

            // Normalizando a linha 1
            double factor = coefficients[0, 0];
            coefficients[0, 0] /= factor;
            coefficients[0, 1] /= factor;
            constants[0] /= factor;

            // Tornando o elemento (2,1) zero, subtraindo a linha 1 da linha 2
            factor = coefficients[1, 0];
            coefficients[1, 0] -= factor * coefficients[0, 0];
            coefficients[1, 1] -= factor * coefficients[0, 1];
            constants[1] -= factor * constants[0];

            // Agora, a matriz de coeficientes está em forma triangular superior
            // Podemos resolver as variáveis por substituição regressiva

            // Resolvendo para y
            solution[1] = constants[1] / coefficients[1, 1];

            // Resolvendo para x
            solution[0] = (constants[0] - coefficients[0, 1] * solution[1]) / coefficients[0, 0];

            return solution;
        }
";

            textBox1.Text = codigo;
        }
    }
}

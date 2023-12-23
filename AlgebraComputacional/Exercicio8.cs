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
using MathNet.Numerics.LinearAlgebra;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgebraComputacional
{
    public partial class Exercicio8 : Form
    {
        public Exercicio8()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Ler os valores dos coeficientes e do vetor do lado direito dos TextBoxes
            double[,] matrizCoeficientes = {
                { 1, -1, -1 },
                { 1, 0, 1 },
                { 1, -1, 3 }
            };

            double[] vetorLadoDireito = { -5.0 / 3, 3.0 / 4, 7.0 / 3 };

            // Convertendo os valores para matrizes/vetores do MathNet.Numerics
            var A = Matrix<double>.Build.DenseOfArray(matrizCoeficientes);
            var b = Vector<double>.Build.DenseOfArray(vetorLadoDireito);

            // Obter a fatoração QR
            var qr = A.QR();

            // Resolver o sistema usando a fatoração QR
            var x = qr.Solve(b);

            var primeira = x[0] - x[1] - x[2];
            var segunda = x[0] + x[2];
            var terceria = x[0] - x[1] + 3 * x[2];



            // Exibir o resultado nas TextBoxes de saída
            textBoxResultado.Clear();
            textBoxResultado.AppendText("Prova");
            textBoxResultado.AppendText("\r\n");
            textBoxResultado.AppendText("Primeira equação " + primeira + " Fração : " + ConverterParaFracao(primeira));
            textBoxResultado.AppendText("\r\n");
            textBoxResultado.AppendText("\r\n");
            textBoxResultado.AppendText("Segunda equação " + segunda + " Fração : " + ConverterParaFracao(segunda));
            textBoxResultado.AppendText("\r\n");
            textBoxResultado.AppendText("\r\n");
            textBoxResultado.AppendText("Terceria equação " + terceria + " Fração : " + ConverterParaFracao(terceria));
            textBoxResultado.AppendText("\r\n");
            textBoxResultado.AppendText("\r\n");
            textBoxResultado.AppendText($"x1 = {x[0]}\r\n");
            textBoxResultado.AppendText($"x2 = {x[1]}\r\n");
            textBoxResultado.AppendText($"x3 = {x[2]}\r\n");
        }


        static string ConverterParaFracao(double numero)
        {


            const double epsilon = 1e-10; // Valor de tolerância para comparação

            int maxDenominador = 1000; // Definindo um máximo para o denominador

            for (int denominador = 1; denominador <= maxDenominador; denominador++)
            {
                int numerador = (int)Math.Round(numero * denominador);

                // Verifica se o número é suficientemente próximo da fração correspondente
                if (Math.Abs(numero - (double)numerador / denominador) < epsilon)
                {
                    int mdc = CalcularMDC(numerador, denominador);

                    numerador /= mdc;
                    denominador /= mdc;

                    return numerador + "/" + denominador;
                }
            }

            return "Não foi possível converter em uma fração com o máximo denominador permitido.";
        }

        static int CalcularMDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static string DividirFracao(string fracao1, string fracao2)
        {
            // Separando numerador e denominador das frações
            int numerador1 = int.Parse(fracao1.Split('/')[0]);
            int denominador1 = int.Parse(fracao1.Split('/')[1]);
            int numerador2 = int.Parse(fracao2.Split('/')[0]);
            int denominador2 = int.Parse(fracao2.Split('/')[1]);

            // Realizando a divisão de frações
            int numeradorResultado = numerador1 * denominador2;
            int denominadorResultado = denominador1 * numerador2;

            // Reduzindo o resultado da divisão ao máximo
            int mdc = CalcularMDC(numeradorResultado, denominadorResultado);
            numeradorResultado /= mdc;
            denominadorResultado /= mdc;

            return numeradorResultado + "/" + denominadorResultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var codigo = @"        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Ler os valores dos coeficientes e do vetor do lado direito dos TextBoxes
            double[,] matrizCoeficientes = {
                { 1, -1, -1 },
                { 1, 0, 1 },
                { 1, -1, 3 }
            };

            double[] vetorLadoDireito = { -5.0 / 3, 3.0 / 4, 7.0 / 3 };

            // Convertendo os valores para matrizes/vetores do MathNet.Numerics
            var A = Matrix<double>.Build.DenseOfArray(matrizCoeficientes);
            var b = Vector<double>.Build.DenseOfArray(vetorLadoDireito);

            // Obter a fatoração QR
            var qr = A.QR();

            // Resolver o sistema usando a fatoração QR
            var x = qr.Solve(b);

            var primeira = x[0] - x[1] - x[2];
            var segunda = x[0] + x[2];
            var terceria = x[0] - x[1] + 3 * x[2];



            // Exibir o resultado nas TextBoxes de saída
            textBoxResultado.Clear();
            textBoxResultado.AppendText(""Prova"");
            textBoxResultado.AppendText(""\r\n"");
            textBoxResultado.AppendText(""Primeira equação "" + primeira + "" Fração : "" + ConverterParaFracao(primeira));
            textBoxResultado.AppendText(""\r\n"");
            textBoxResultado.AppendText(""\r\n"");
            textBoxResultado.AppendText(""Segunda equação "" + segunda + "" Fração : "" + ConverterParaFracao(segunda));
            textBoxResultado.AppendText(""\r\n"");
            textBoxResultado.AppendText(""\r\n"");
            textBoxResultado.AppendText(""Terceria equação "" + terceria + "" Fração : "" + ConverterParaFracao(terceria));
            textBoxResultado.AppendText(""\r\n"");
            textBoxResultado.AppendText(""\r\n"");
            textBoxResultado.AppendText($""x1 = {x[0]}\r\n"");
            textBoxResultado.AppendText($""x2 = {x[1]}\r\n"");
            textBoxResultado.AppendText($""x3 = {x[2]}\r\n"");
        }


        static string ConverterParaFracao(double numero)
        {


            const double epsilon = 1e-10; // Valor de tolerância para comparação

            int maxDenominador = 1000; // Definindo um máximo para o denominador

            for (int denominador = 1; denominador <= maxDenominador; denominador++)
            {
                int numerador = (int)Math.Round(numero * denominador);

                // Verifica se o número é suficientemente próximo da fração correspondente
                if (Math.Abs(numero - (double)numerador / denominador) < epsilon)
                {
                    int mdc = CalcularMDC(numerador, denominador);

                    numerador /= mdc;
                    denominador /= mdc;

                    return numerador + ""/"" + denominador;
                }
            }

            return ""Não foi possível converter em uma fração com o máximo denominador permitido."";
        }

        static int CalcularMDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static string DividirFracao(string fracao1, string fracao2)
        {
            // Separando numerador e denominador das frações
            int numerador1 = int.Parse(fracao1.Split('/')[0]);
            int denominador1 = int.Parse(fracao1.Split('/')[1]);
            int numerador2 = int.Parse(fracao2.Split('/')[0]);
            int denominador2 = int.Parse(fracao2.Split('/')[1]);

            // Realizando a divisão de frações
            int numeradorResultado = numerador1 * denominador2;
            int denominadorResultado = denominador1 * numerador2;

            // Reduzindo o resultado da divisão ao máximo
            int mdc = CalcularMDC(numeradorResultado, denominadorResultado);
            numeradorResultado /= mdc;
            denominadorResultado /= mdc;

            return numeradorResultado + ""/"" + denominadorResultado;
        }";

            textBoxResultado.Text = codigo;

        }
    }


}

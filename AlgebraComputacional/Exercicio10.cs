using System;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.OdeSolvers;

namespace AlgebraComputacional
{
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e, Matrix<double> a)
        {
            ResolverEquacoesDiferenciais();
        }

        public void ResolverEquacoesDiferenciais()
        {
            // Condições iniciais
            double x1 = 4, x2 = 6, x3 = -7;
            double h = 0.1; // Tamanho do passo
            double tempoInicial = 0;
            double tempoFinal = 10;

            // Resolução do sistema de equações diferenciais usando o método de Runge-Kutta de quarta ordem
            for (double t = tempoInicial; t < tempoFinal; t += h)
            {
                double k1 = Funcao1(x1, x2, x3);
                double l1 = Funcao2(x1, x2, x3);
                double m1 = Funcao3(x1, x2, x3);

                double k2 = Funcao1(x1 + h * k1 / 2, x2 + h * l1 / 2, x3 + h * m1 / 2);
                double l2 = Funcao2(x1 + h * k1 / 2, x2 + h * l1 / 2, x3 + h * m1 / 2);
                double m2 = Funcao3(x1 + h * k1 / 2, x2 + h * l1 / 2, x3 + h * m1 / 2);

                double k3 = Funcao1(x1 + h * k2 / 2, x2 + h * l2 / 2, x3 + h * m2 / 2);
                double l3 = Funcao2(x1 + h * k2 / 2, x2 + h * l2 / 2, x3 + h * m2 / 2);
                double m3 = Funcao3(x1 + h * k2 / 2, x2 + h * l2 / 2, x3 + h * m2 / 2);

                double k4 = Funcao1(x1 + h * k3, x2 + h * l3, x3 + h * m3);
                double l4 = Funcao2(x1 + h * k3, x2 + h * l3, x3 + h * m3);
                double m4 = Funcao3(x1 + h * k3, x2 + h * l3, x3 + h * m3);

                x1 += h * (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x2 += h * (l1 + 2 * l2 + 2 * l3 + l4) / 6;
                x3 += h * (m1 + 2 * m2 + 2 * m3 + m4) / 6;
            }

            string resultado = "Solução do sistema de equações diferenciais abaixo empregando o método matricial:\r\n";
            resultado += "x' = 1 -12 -14\r\n       1    2 -3\r\n       1   1  -2\r\n\r\n";
            resultado += $"x(0) = 4, 6, -7\r\n\r\n";

            // Adicionando mais informações
            resultado += "Explicação:\r\n";
            resultado += "O método de Runge-Kutta de quarta ordem é um método numérico utilizado para resolver equações diferenciais ordinárias. ";
            resultado += "Ele divide o intervalo de tempo especificado em intervalos menores, calculando a taxa de variação das funções x1, x2 e x3 em cada um desses intervalos.\r\n";
            resultado += "Para cada intervalo de tempo h, o método de Runge-Kutta calcula o próximo valor das funções x1, x2 e x3. ";
            resultado += "Esse cálculo é feito considerando as taxas de variação obtidas em quatro pontos diferentes dentro do intervalo, usando uma combinação ponderada dessas taxas para estimar a variação das funções no próximo ponto.\r\n";
            resultado += "A precisão desse método numérico pode variar dependendo do tamanho do intervalo de tempo (h) escolhido e da complexidade das equações diferenciais. ";
            resultado += "Porém, ele oferece uma boa aproximação para sistemas de equações diferenciais onde soluções analíticas podem ser difíceis ou impossíveis de obter.";

            // Exibindo o resultado no TextBox
            txtResultado.Text = resultado;

            // Exibindo o resultado no TextBox
            txtResultado.Text = $"x1: {x1}, x2: {x2}, x3: {x3}" + "\r\n" + "\r\n" + resultado;
        }

        // Funções para as equações diferenciais
        private double Funcao1(double x1, double x2, double x3)
        {
            return 1 * x1 - 12 * x2 - 14 * x3;
        }

        private double Funcao2(double x1, double x2, double x3)
        {
            return x1 + 2 * x2 - 3 * x3;
        }

        private double Funcao3(double x1, double x2, double x3)
        {
            return x1 + x2 - 2 * x3;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ResolverEquacoesDiferenciais();

        }

        private void Codigo(object sender, EventArgs e)
        {

            var codigo = @"  // Condições iniciais
            double x1 = 4, x2 = 6, x3 = -7;
            double h = 0.1; // Tamanho do passo
            double tempoInicial = 0;
            double tempoFinal = 10;

            // Resolução do sistema de equações diferenciais usando o método de Runge-Kutta de quarta ordem
            for (double t = tempoInicial; t < tempoFinal; t += h)
            {
                double k1 = Funcao1(x1, x2, x3);
                double l1 = Funcao2(x1, x2, x3);
                double m1 = Funcao3(x1, x2, x3);

                double k2 = Funcao1(x1 + h * k1 / 2, x2 + h * l1 / 2, x3 + h * m1 / 2);
                double l2 = Funcao2(x1 + h * k1 / 2, x2 + h * l1 / 2, x3 + h * m1 / 2);
                double m2 = Funcao3(x1 + h * k1 / 2, x2 + h * l1 / 2, x3 + h * m1 / 2);

                double k3 = Funcao1(x1 + h * k2 / 2, x2 + h * l2 / 2, x3 + h * m2 / 2);
                double l3 = Funcao2(x1 + h * k2 / 2, x2 + h * l2 / 2, x3 + h * m2 / 2);
                double m3 = Funcao3(x1 + h * k2 / 2, x2 + h * l2 / 2, x3 + h * m2 / 2);

                double k4 = Funcao1(x1 + h * k3, x2 + h * l3, x3 + h * m3);
                double l4 = Funcao2(x1 + h * k3, x2 + h * l3, x3 + h * m3);
                double m4 = Funcao3(x1 + h * k3, x2 + h * l3, x3 + h * m3);

                x1 += h * (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x2 += h * (l1 + 2 * l2 + 2 * l3 + l4) / 6;
                x3 += h * (m1 + 2 * m2 + 2 * m3 + m4) / 6;
            }

            string resultado = ""Solução do sistema de equações diferenciais abaixo empregando o método matricial:\r\n"";
            resultado += ""x' = 1 -12 -14\r\n       1    2 -3\r\n       1   1  -2\r\n\r\n"";
            resultado += $""x(0) = 4, 6, -7\r\n\r\n"";

            // Adicionando mais informações
            resultado += ""Explicação:\r\n"";
            resultado += ""O método de Runge-Kutta de quarta ordem é um método numérico utilizado para resolver equações diferenciais ordinárias. "";
            resultado += ""Ele divide o intervalo de tempo especificado em intervalos menores, calculando a taxa de variação das funções x1, x2 e x3 em cada um desses intervalos.\r\n"";
            resultado += ""Para cada intervalo de tempo h, o método de Runge-Kutta calcula o próximo valor das funções x1, x2 e x3. "";
            resultado += ""Esse cálculo é feito considerando as taxas de variação obtidas em quatro pontos diferentes dentro do intervalo, usando uma combinação ponderada dessas taxas para estimar a variação das funções no próximo ponto.\r\n"";
            resultado += ""A precisão desse método numérico pode variar dependendo do tamanho do intervalo de tempo (h) escolhido e da complexidade das equações diferenciais. "";
            resultado += ""Porém, ele oferece uma boa aproximação para sistemas de equações diferenciais onde soluções analíticas podem ser difíceis ou impossíveis de obter."";

            // Exibindo o resultado no TextBox
            txtResultado.Text = resultado;

            // Exibindo o resultado no TextBox
            txtResultado.Text = $""x1: {x1}, x2: {x2}, x3: {x3}"" + ""\r\n"" + ""\r\n"" + resultado;
        }

        // Funções para as equações diferenciais
        private double Funcao1(double x1, double x2, double x3)
        {
            return 1 * x1 - 12 * x2 - 14 * x3;
        }

        private double Funcao2(double x1, double x2, double x3)
        {
            return x1 + 2 * x2 - 3 * x3;
        }

        private double Funcao3(double x1, double x2, double x3)
        {
            return x1 + x2 - 2 * x3;
        }
";

            txtResultado.Text = codigo;

        }
    }
}


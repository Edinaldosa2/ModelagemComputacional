using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;

namespace AlgebraComputacional
{
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
            // Dados do problema
            double c = 4; // Constante de atrito do ar (N * s * m^−1)
            double k = 3; // Constante da mola (N * s^−1)
            double mu = 0.3; // Coeficiente de atrito
            double m = 1; // Massa (kg)
            double g = 10; // Aceleração devida à gravidade (m/s²)

            // Enunciado do problema
            string enunciado = "\r\n Aplicando a segunda lei de Newton, obtenha a EDO de segunda ordem que modela o " +
                "movimento da massa m presa por uma mola de constante elástica k, onde atuam a força de atrito devido ao ar (far) " +
                "e a força de atrito devido a rugosidade da superfície (fµ).\n\n";
            enunciado += "Resolva a EDO resultante aplicando a técnica de redução de ordem " +
                "(transforme a EDO de 2ª ordem em um sistema de duas EDO de 1ª ordem).\n\n";
            enunciado += "Dados: 𝑓𝑎𝑟 = −𝑐 𝑥′, 𝑓μ =−𝜇 𝑚 𝑔, 𝑓𝑘 = −𝑘 𝑥, onde 𝑚 = 1 𝑘𝑔, 𝑐 = 4𝑁 𝑠 𝑚−1, 𝑘 = 3𝑁 𝑠 −1, 𝑔 = 10𝑚 𝑠 −2 e µ =0,3";

            // Explicação do processo de resolução
            string explicacao = "Para resolver a equação diferencial de segundo grau utilizando a técnica de redução de ordem, " +
                "vamos transformá-la em um sistema de duas equações diferenciais de primeira ordem. " +
                "Isso nos permitirá resolver o problema numericamente.\n\n";
            explicacao += "Primeiro, usamos a segunda lei de Newton para formar a EDO de segunda ordem que modela o movimento da massa.\n";
            explicacao += "Depois, aplicamos a técnica de redução de ordem, transformando essa EDO de segunda ordem em um sistema de duas EDOs de primeira ordem.\n";
            explicacao += "Finalmente, resolvemos numericamente as equações diferenciais de primeira ordem utilizando o método de Euler.\n";

            // Resolver as equações diferenciais e gerar o gráfico
            double x1 = 0; // Posição inicial
            double x2 = 0; // Velocidade inicial
            double h = 0.1; // Tamanho do passo
            double tempoInicial = 0;
            double tempoFinal = 10;

            var model = new PlotModel { Title = "Gráfico da Posição e Velocidade x Tempo" };

            var positionSeries = new LineSeries { Title = "Posição x Tempo" };
            var velocitySeries = new LineSeries { Title = "Velocidade x Tempo" };
            double i = 1;

            for (double t = tempoInicial; t < tempoFinal; t += h)
            {
                double dx1dt = x2;

                double dx2dt;

                dx2dt = (-c * x2 - mu * m * g - k * x1) / m;

                if (i == 1)
                {
                    dx2dt = 0;
                }


                x1 += h * dx1dt;
                x2 += h * dx2dt;

                positionSeries.Points.Add(new DataPoint(t, x1));
                velocitySeries.Points.Add(new DataPoint(t, x2));


                i = i + 1;
            }

            model.Series.Add(positionSeries);
            model.Series.Add(velocitySeries);

            var plotView = new OxyPlot.WindowsForms.PlotView();
            plotView.Model = model;
            plotView.Dock = DockStyle.Fill;
            Controls.Add(plotView);

            // Exibindo o resultado no TextBox
            txtResultado.Text = enunciado + "\n\n" + explicacao;
        }

        private void Calcular()
        {
            #region Codigo
            double c = 4; // Constante de atrito do ar (N * s * m^−1)
            double k = 3; // Constante da mola (N * s^−1)
            double mu = 0.3; // Coeficiente de atrito
            double m = 1; // Massa (kg)
            double g = 10; // Aceleração devida à gravidade (m/s²)

            // Explicação do processo de resolução
            string explicacao = "Para resolver a equação diferencial de segundo grau utilizando a técnica de redução de ordem, " +
                "vamos transformá-la em um sistema de duas equações diferenciais de primeira ordem. " +
                "Isso nos permitirá resolver o problema numericamente.\n\r\n\r";

            // Resolver as equações diferenciais e explicação adicional
            // Equações diferenciais de 1ª ordem derivadas da EDO de 2ª ordem
            double x1 = 0; // Posição inicial
            double x2 = 0; // Velocidade inicial

            double h = 0.1; // Tamanho do passo
            double tempoInicial = 0;
            double tempoFinal = 10;

            string resultado = "Resultados:\n\r\n\r";

            for (double t = tempoInicial; t < tempoFinal; t += h)
            {
                // Cálculo das derivadas para o sistema de equações diferenciais de 1ª ordem
                double dx1dt = x2;
                double dx2dt = (-c * x2 - mu * m * g - k * x1) / m;

                // Método de Euler para resolver numericamente as equações diferenciais de 1ª ordem
                x1 += h * dx1dt;
                x2 += h * dx2dt;

                // Atualiza o resultado para exibição
                resultado += $"\n\rTempo: {t}, Posição (x1): {x1}, Velocidade (x2): {x2}\n\n\n\r";
            }

            // Exibindo o resultado no TextBox
            resultadocalculo.Text = explicacao + "\n\n" + resultado;

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codigo = @"     private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
            // Dados do problema
            double c = 4; // Constante de atrito do ar (N * s * m^−1)
            double k = 3; // Constante da mola (N * s^−1)
            double mu = 0.3; // Coeficiente de atrito
            double m = 1; // Massa (kg)
            double g = 10; // Aceleração devida à gravidade (m/s²)

            // Enunciado do problema
            string enunciado = ""\r\n Aplicando a segunda lei de Newton, obtenha a EDO de segunda ordem que modela o "" +
                ""movimento da massa m presa por uma mola de constante elástica k, onde atuam a força de atrito devido ao ar (far) "" +
                ""e a força de atrito devido a rugosidade da superfície (fµ).\n\n"";
            enunciado += ""Resolva a EDO resultante aplicando a técnica de redução de ordem "" +
                ""(transforme a EDO de 2ª ordem em um sistema de duas EDO de 1ª ordem).\n\n"";
            enunciado += ""Dados: 𝑓𝑎𝑟 = −𝑐 𝑥′, 𝑓μ =−𝜇 𝑚 𝑔, 𝑓𝑘 = −𝑘 𝑥, onde 𝑚 = 1 𝑘𝑔, 𝑐 = 4𝑁 𝑠 𝑚−1, 𝑘 = 3𝑁 𝑠 −1, 𝑔 = 10𝑚 𝑠 −2 e µ =0,3"";

            // Explicação do processo de resolução
            string explicacao = ""Para resolver a equação diferencial de segundo grau utilizando a técnica de redução de ordem, "" +
                ""vamos transformá-la em um sistema de duas equações diferenciais de primeira ordem. "" +
                ""Isso nos permitirá resolver o problema numericamente.\n\n"";
            explicacao += ""Primeiro, usamos a segunda lei de Newton para formar a EDO de segunda ordem que modela o movimento da massa.\n"";
            explicacao += ""Depois, aplicamos a técnica de redução de ordem, transformando essa EDO de segunda ordem em um sistema de duas EDOs de primeira ordem.\n"";
            explicacao += ""Finalmente, resolvemos numericamente as equações diferenciais de primeira ordem utilizando o método de Euler.\n"";

            // Resolver as equações diferenciais e gerar o gráfico
            double x1 = 0; // Posição inicial
            double x2 = 0; // Velocidade inicial
            double h = 0.1; // Tamanho do passo
            double tempoInicial = 0;
            double tempoFinal = 10;

            var model = new PlotModel { Title = ""Gráfico da Posição e Velocidade x Tempo"" };

            var positionSeries = new LineSeries { Title = ""Posição x Tempo"" };
            var velocitySeries = new LineSeries { Title = ""Velocidade x Tempo"" };
            double i = 1;

            for (double t = tempoInicial; t < tempoFinal; t += h)
            {
                double dx1dt = x2;

                double dx2dt;

                dx2dt = (-c * x2 - mu * m * g - k * x1) / m;

                if (i == 1)
                {
                    dx2dt = 0;
                }


                x1 += h * dx1dt;
                x2 += h * dx2dt;

                positionSeries.Points.Add(new DataPoint(t, x1));
                velocitySeries.Points.Add(new DataPoint(t, x2));


                i = i + 1;
            }

            model.Series.Add(positionSeries);
            model.Series.Add(velocitySeries);

            var plotView = new OxyPlot.WindowsForms.PlotView();
            plotView.Model = model;
            plotView.Dock = DockStyle.Fill;
            Controls.Add(plotView);

            // Exibindo o resultado no TextBox
            txtResultado.Text = enunciado + ""\n\n"" + explicacao;
        }

        private void Calcular()
        {
            #region Codigo
            double c = 4; // Constante de atrito do ar (N * s * m^−1)
            double k = 3; // Constante da mola (N * s^−1)
            double mu = 0.3; // Coeficiente de atrito
            double m = 1; // Massa (kg)
            double g = 10; // Aceleração devida à gravidade (m/s²)

            // Explicação do processo de resolução
            string explicacao = ""Para resolver a equação diferencial de segundo grau utilizando a técnica de redução de ordem, "" +
                ""vamos transformá-la em um sistema de duas equações diferenciais de primeira ordem. "" +
                ""Isso nos permitirá resolver o problema numericamente.\n\r\n\r"";

            // Resolver as equações diferenciais e explicação adicional
            // Equações diferenciais de 1ª ordem derivadas da EDO de 2ª ordem
            double x1 = 0; // Posição inicial
            double x2 = 0; // Velocidade inicial

            double h = 0.1; // Tamanho do passo
            double tempoInicial = 0;
            double tempoFinal = 10;

            string resultado = ""Resultados:\n\r\n\r"";

            for (double t = tempoInicial; t < tempoFinal; t += h)
            {
                // Cálculo das derivadas para o sistema de equações diferenciais de 1ª ordem
                double dx1dt = x2;
                double dx2dt = (-c * x2 - mu * m * g - k * x1) / m;

                // Método de Euler para resolver numericamente as equações diferenciais de 1ª ordem
                x1 += h * dx1dt;
                x2 += h * dx2dt;

                // Atualiza o resultado para exibição
                resultado += $""\n\rTempo: {t}, Posição (x1): {x1}, Velocidade (x2): {x2}\n\n\n\r"";
            }

            // Exibindo o resultado no TextBox
            resultadocalculo.Text = explicacao + ""\n\n"" + resultado;

            #endregion";

            textBoxCodigo.Text = codigo;
        }
    }
}


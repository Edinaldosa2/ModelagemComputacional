using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgebraComputacional
{
    public partial class Exercicio9 : Form
    {
        public Exercicio9()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {

            double E1 = 12; // Volts
            double E2 = 6; // Volts
            double L = 1; // Henry
            double C = 0.5; // Farad
            double R1 = 5; // Ohms
            double R2 = 6; // Ohms

            double iL = 0; // Corrente inicial no indutor (A)
            double iC = 0; // Corrente inicial no capacitor (A)

            double dt = 0.01; // Passo de tempo
            double tempoFinal = 10; // Tempo final (segundos)

            var model = new PlotModel { Title = "Correntes no Indutor e no Capacitor ao Longo do Tempo" };
            var iLSeries = new LineSeries { Title = "Corrente no Indutor (iL)" };
            var iCSeries = new LineSeries { Title = "Corrente no Capacitor (iC)" };
            var i1Series = new LineSeries { Title = "Corrente do Indutor (i1)" };
            var i2Series = new LineSeries { Title = "Corrente do Capacitor (i2)" };

            var plotView = new OxyPlot.WindowsForms.PlotView();
            plotView.Model = model;
            plotView.Dock = DockStyle.Fill;
            Controls.Add(plotView);

            // Exibindo a explicação no TextBox
            txtResultado.Text = "Esse gráfico mostra as correntes no indutor e no capacitor ao longo do tempo após a chave ser ligada.\r\n\r\n";
            txtResultado.Text += "As equações diferenciais que modelam o circuito são resolvidas numericamente utilizando o método de Euler.\r\n";
            txtResultado.Text += "Os cálculos são realizados passo a passo para determinar as correntes iL, iC, i1 e i2.\r\n\r\n";

            // Exibindo os cálculos realizados e preenchendo o gráfico
            txtResultado.Text += "Cálculos:\r\n";
            double t = 0; // Tempo inicial
            while (t <= tempoFinal)
            {
                double dILdt = (E1 - E2 - R1 * iL - R2 * (iL - iC)) / L;
                double dICdt = (E2 - E1 - R2 * (iC - iL)) / C;

                iL += dILdt * dt;
                iC += dICdt * dt;

                iLSeries.Points.Add(new DataPoint(t, iL));
                iCSeries.Points.Add(new DataPoint(t, iC));

                // Cálculo de i1 e i2
                double i1 = (E1 - E2 - R1 * iL) / R2;
                double i2 = iL - iC;

                i1Series.Points.Add(new DataPoint(t, i1));
                i2Series.Points.Add(new DataPoint(t, i2));

                t += dt;

                if (t % 0.5 == 0)
                {
                    // Adiciona à explicação detalhes sobre os cálculos a cada intervalo de tempo
                    txtResultado.Text += $"\n\n\rTempo: {t:F2}s - Corrente no Indutor: {iL:F4}A - Corrente no Capacitor: {iC:F4}A - i1: {i1:F4}A - i2: {i2:F4}A\r\n";
                }
            }

            // Atualiza o gráfico ao final do cálculo
            model.Series.Clear();
            model.Series.Add(iLSeries);
            model.Series.Add(iCSeries);
            model.Series.Add(i1Series);
            model.Series.Add(i2Series);
            plotView.InvalidatePlot(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var codigo = @"        private void calcular(object sender, EventArgs e)
        {

            double E1 = 12; // Volts
            double E2 = 6; // Volts
            double L = 1; // Henry
            double C = 0.5; // Farad
            double R1 = 5; // Ohms
            double R2 = 6; // Ohms

            double iL = 0; // Corrente inicial no indutor (A)
            double iC = 0; // Corrente inicial no capacitor (A)

            double dt = 0.01; // Passo de tempo
            double tempoFinal = 10; // Tempo final (segundos)

            var model = new PlotModel { Title = ""Correntes no Indutor e no Capacitor ao Longo do Tempo"" };
            var iLSeries = new LineSeries { Title = ""Corrente no Indutor (iL)"" };
            var iCSeries = new LineSeries { Title = ""Corrente no Capacitor (iC)"" };
            var i1Series = new LineSeries { Title = ""Corrente do Indutor (i1)"" };
            var i2Series = new LineSeries { Title = ""Corrente do Capacitor (i2)"" };

            var plotView = new OxyPlot.WindowsForms.PlotView();
            plotView.Model = model;
            plotView.Dock = DockStyle.Fill;
            Controls.Add(plotView);

            // Exibindo a explicação no TextBox
            txtResultado.Text = ""Esse gráfico mostra as correntes no indutor e no capacitor ao longo do tempo após a chave ser ligada.\r\n\r\n"";
            txtResultado.Text += ""As equações diferenciais que modelam o circuito são resolvidas numericamente utilizando o método de Euler.\r\n"";
            txtResultado.Text += ""Os cálculos são realizados passo a passo para determinar as correntes iL, iC, i1 e i2.\r\n\r\n"";

            // Exibindo os cálculos realizados e preenchendo o gráfico
            txtResultado.Text += ""Cálculos:\r\n"";
            double t = 0; // Tempo inicial
            while (t <= tempoFinal)
            {
                double dILdt = (E1 - E2 - R1 * iL - R2 * (iL - iC)) / L;
                double dICdt = (E2 - E1 - R2 * (iC - iL)) / C;

                iL += dILdt * dt;
                iC += dICdt * dt;

                iLSeries.Points.Add(new DataPoint(t, iL));
                iCSeries.Points.Add(new DataPoint(t, iC));

                // Cálculo de i1 e i2
                double i1 = (E1 - E2 - R1 * iL) / R2;
                double i2 = iL - iC;

                i1Series.Points.Add(new DataPoint(t, i1));
                i2Series.Points.Add(new DataPoint(t, i2));

                t += dt;

                if (t % 0.5 == 0)
                {
                    // Adiciona à explicação detalhes sobre os cálculos a cada intervalo de tempo
                    txtResultado.Text += $""\n\n\rTempo: {t:F2}s - Corrente no Indutor: {iL:F4}A - Corrente no Capacitor: {iC:F4}A - i1: {i1:F4}A - i2: {i2:F4}A\r\n"";
                }
            }

            // Atualiza o gráfico ao final do cálculo
            model.Series.Clear();
            model.Series.Add(iLSeries);
            model.Series.Add(iCSeries);
            model.Series.Add(i1Series);
            model.Series.Add(i2Series);
            plotView.InvalidatePlot(true);
        }";

            txtResultado.Text= codigo;

        }
    }
}



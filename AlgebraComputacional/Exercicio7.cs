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
    public partial class Exercicio7 : Form
    {
        public Exercicio7()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Cálculo das funções ortonormais
            double normaF1 = 1; // Norma de f1(x) = 1
            double normaF2 = Math.Sqrt(1.0 / 2); // Norma de f2(x) = x

            double g1Norm = 1 / Math.Sqrt(normaF1); // Normalização de f1(x)
            double g2Norm = Math.Sqrt(2) / Math.Sqrt(normaF2); // Normalização de f2(x)

            double produtoInterno = Math.Sqrt(2) / 2; // Produto interno entre g1(x) e g2(x)

            // Exibindo os resultados nas TextBoxes
            textBoxResult.Clear();
            textBoxResult.AppendText($"g1(x) = {g1Norm} * 1 = {g1Norm}" + Environment.NewLine);
            textBoxResult.AppendText($"g2(x) = {g2Norm} * x = {g2Norm} * x" + Environment.NewLine);
            textBoxResult.AppendText($"Produto interno entre g1(x) e g2(x) = {produtoInterno}" + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codigo = @"        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Cálculo das funções ortonormais
            double normaF1 = 1; // Norma de f1(x) = 1
            double normaF2 = Math.Sqrt(1.0 / 2); // Norma de f2(x) = x

            double g1Norm = 1 / Math.Sqrt(normaF1); // Normalização de f1(x)
            double g2Norm = Math.Sqrt(2) / Math.Sqrt(normaF2); // Normalização de f2(x)

            double produtoInterno = Math.Sqrt(2) / 2; // Produto interno entre g1(x) e g2(x)

            // Exibindo os resultados nas TextBoxes
            textBoxResult.Clear();
            textBoxResult.AppendText($""g1(x) = {g1Norm} * 1 = {g1Norm}"" + Environment.NewLine);
            textBoxResult.AppendText($""g2(x) = {g2Norm} * x = {g2Norm} * x"" + Environment.NewLine);
            textBoxResult.AppendText($""Produto interno entre g1(x) e g2(x) = {produtoInterno}"" + Environment.NewLine);
        }";

            textBoxResult.Text = codigo;
        }
    }
}

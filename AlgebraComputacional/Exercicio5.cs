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
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void VerificarBase_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            // Loop para verificar para quais valores de k β é uma base de ℜ²
            for (int k = -10; k <= 10; k++)
            {
                if (k != 2 && k != -2)
                {
                    // Verifica se a matriz é uma base para ℝ²
                    if (IsBaseForR2(1, k, k, 4))
                    {
                        textBox1.AppendText($"Para k = {k}, β = {{(1, {k}), ({k}, 4)}} é uma base para ℝ²\n");
                        textBox1.AppendText("\r\n");
                        textBox1.AppendText("\r\n");
                    }
                }
            }

            textBox1.AppendText("Portanto, o conjunto  β ={ (1, k),(k, 4)} é uma base para para ℝ² todos os valores de k que não sejam k = 2 ou k =−2.");

        }

        // Função para verificar se o conjunto forma uma base para ℝ²
        private bool IsBaseForR2(double a, double b, double c, double d)
        {
            // Calcula o determinante da matriz formada pelos vetores
            double determinante = a * d - b * c;

            // Retorna verdadeiro se o determinante for diferente de zero
            return Math.Abs(determinante) > 0.0001; // Considere uma pequena margem para diferenças numéricas
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codigo = @"        private void VerificarBase_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            // Loop para verificar para quais valores de k β é uma base de ℜ²
            for (int k = -10; k <= 10; k++)
            {
                if (k != 2 && k != -2)
                {
                    // Verifica se a matriz é uma base para ℝ²
                    if (IsBaseForR2(1, k, k, 4))
                    {
                        textBox1.AppendText($""Para k = {k}, β = {{(1, {k}), ({k}, 4)}} é uma base para ℝ²\n"");
                        textBox1.AppendText(""\r\n"");
                        textBox1.AppendText(""\r\n"");
                    }
                }
            }

            textBox1.AppendText(""Portanto, o conjunto  β ={ (1, k),(k, 4)} é uma base para para ℝ² todos os valores de k que não sejam k = 2 ou k =−2."");

        }

        // Função para verificar se o conjunto forma uma base para ℝ²
        private bool IsBaseForR2(double a, double b, double c, double d)
        {
            // Calcula o determinante da matriz formada pelos vetores
            double determinante = a * d - b * c;

            // Retorna verdadeiro se o determinante for diferente de zero
            return Math.Abs(determinante) > 0.0001; // Considere uma pequena margem para diferenças numéricas
        }";

            textBox1.Text = codigo;
        }
    }
}

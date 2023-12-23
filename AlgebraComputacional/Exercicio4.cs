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

namespace AlgebraComputacional
{
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void VerificarIndependencia_Click(object sender, EventArgs e)
        {
            // Definir a matriz A
            Matrix<double> matrizA = Matrix<double>.Build.DenseOfArray(new double[,] {
                                        { 2, 1, 1, 0 },
                                        { 4, 2, 1, 2 },
                                        { 6, 3, 2, 2 }
                                      });

            // Encontrar as colunas linearmente independentes usando SVD
            var svd = matrizA.Svd();
            var colunasIndependentes = new List<int>();

            // Verificar os vetores singulares da matriz e encontrar as colunas independentes
            for (int i = 0; i < svd.U.RowCount; i++)
            {
                if (svd.S[i] > 1e-10) // Verificar se o valor singular é significativamente diferente de zero
                {
                    colunasIndependentes.Add(i);
                }
            }

            // Exibir o resultado na caixa de texto
            textBox1.AppendText("Colunas independentes de A = {");
            foreach (int col in colunasIndependentes)
            {
                textBox1.AppendText("[");
                for (int row = 0; row < matrizA.RowCount; row++)
                {
                    textBox1.AppendText(matrizA[row, col].ToString());
                    if (row < matrizA.RowCount - 1) textBox1.AppendText(", ");
                }
                textBox1.AppendText("], ");
            }
            textBox1.Text = textBox1.Text.TrimEnd(' ', ',') + "}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codigo = @"       // Definir a matriz A
            Matrix<double> matrizA = Matrix<double>.Build.DenseOfArray(new double[,] {
                                        { 2, 1, 1, 0 },
                                        { 4, 2, 1, 2 },
                                        { 6, 3, 2, 2 }
                                      });

            // Encontrar as colunas linearmente independentes usando SVD
            var svd = matrizA.Svd();
            var colunasIndependentes = new List<int>();

            // Verificar os vetores singulares da matriz e encontrar as colunas independentes
            for (int i = 0; i < svd.U.RowCount; i++)
            {
                if (svd.S[i] > 1e-10) // Verificar se o valor singular é significativamente diferente de zero
                {
                    colunasIndependentes.Add(i);
                }
            }

            // Exibir o resultado na caixa de texto
            textBox1.AppendText(""Colunas independentes de A = {"");
            foreach (int col in colunasIndependentes)
            {
                textBox1.AppendText(""["");
                for (int row = 0; row < matrizA.RowCount; row++)
                {
                    textBox1.AppendText(matrizA[row, col].ToString());
                    if (row < matrizA.RowCount - 1) textBox1.AppendText("", "");
                }
                textBox1.AppendText(""], "");
            }
            textBox1.Text = textBox1.Text.TrimEnd(' ', ',') + ""}"";
        }";

            textBox1.Text += codigo;
        }
    }
}
  
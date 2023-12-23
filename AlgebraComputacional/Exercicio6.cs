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
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void CalcularSubespaços_Click(object sender, EventArgs e)
        {

            double[,] matriz = { { 1, -2, 3, -1 }, { 2, -4, 6, -2 }, { 3, -6, 9, -3 } };
            textBoxResult.Clear();

            List<double[]> espacoLinha = ObterEspacoLinha(matriz);
            List<double[]> espacoColuna = ObterEspacoColuna(matriz);
            List<double[]> espacoNulo = ObterEspacoNulo(matriz);
            List<double[]> espacoNuloTransposta = ObterEspacoNuloTransposta(matriz);

            ExibirResultado("Espaço Linha (C(A^T)):", espacoLinha);
            ExibirResultado("Espaço Coluna (C(A)):", espacoColuna);
            ExibirResultado("Espaço Nulo (N(A)):", espacoNulo);
            ExibirResultado("Espaço Nulo Transposta (N(A^T)):", espacoNuloTransposta);
        }

        private List<double[]> ObterEspacoLinha(double[,] matriz)
        {
            double[,] transposta = MatrizTransposta(matriz);
            double[,] rref = RREF(transposta);
            List<double[]> baseEspacoLinha = new List<double[]>();

            for (int i = 0; i < rref.GetLength(0); i++)
            {
                bool ehLinhaNula = true;
                for (int j = 0; j < rref.GetLength(1); j++)
                {
                    if (Math.Abs(rref[i, j]) > 0.0001)
                    {
                        ehLinhaNula = false;
                        break;
                    }
                }
                if (!ehLinhaNula)
                {
                    double[] vetor = new double[rref.GetLength(1)];
                    for (int k = 0; k < rref.GetLength(1); k++)
                    {
                        vetor[k] = rref[i, k];
                    }
                    baseEspacoLinha.Add(vetor);
                }
            }
            return baseEspacoLinha;
        }

        private List<double[]> ObterEspacoColuna(double[,] matriz)
        {
            return ObterEspacoLinha(matriz);
        }

        private List<double[]> ObterEspacoNulo(double[,] matriz)
        {
            double[,] rref = RREF(matriz);
            List<double[]> baseEspacoNulo = new List<double[]>();

            for (int j = 0; j < rref.GetLength(1); j++)
            {
                bool ehColunaPivo = true;
                for (int i = 0; i < rref.GetLength(0) - 1; i++)
                {
                    if (i != j && Math.Abs(rref[i, j]) > 0.0001)
                    {
                        ehColunaPivo = false;
                        break;
                    }
                }
                if (!ehColunaPivo)
                {
                    double[] vetor = new double[rref.GetLength(0)];
                    for (int k = 0; k < rref.GetLength(0); k++)
                    {
                        vetor[k] = rref[k, j];
                    }
                    baseEspacoNulo.Add(vetor);
                }
            }
            return baseEspacoNulo;
        }

        private List<double[]> ObterEspacoNuloTransposta(double[,] matriz)
        {
            double[,] transposta = MatrizTransposta(matriz);
            return ObterEspacoNulo(transposta);
        }

        private double[,] MatrizTransposta(double[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            double[,] transposta = new double[colunas, linhas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }
            return transposta;
        }

        private double[,] RREF(double[,] matriz)
        {
            // Implemente aqui o algoritmo para obter a forma escalonada reduzida da matriz
            // Aqui você pode usar uma biblioteca de álgebra linear ou implementar o algoritmo RREF

            // Simulação da forma escalonada reduzida da matriz (exemplo)
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            double[,] rref = new double[linhas, colunas];

            // Preenchendo rref com valores da matriz para fins de exemplo
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    rref[i, j] = matriz[i, j];
                }
            }
            return rref;
        }

        private void ExibirResultado(string titulo, List<double[]> subespaco)
        {
            textBoxResult.AppendText(titulo + Environment.NewLine);
            foreach (double[] vetor in subespaco)
            {
                textBoxResult.AppendText("(");
                for (int i = 0; i < vetor.Length; i++)
                {
                    textBoxResult.AppendText(vetor[i].ToString());
                    if (i < vetor.Length - 1)
                    {
                        textBoxResult.AppendText(", ");
                    }
                }
                textBoxResult.AppendText(")" + Environment.NewLine);
            }
            textBoxResult.AppendText(Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codigo = @"        private void CalcularSubespaços_Click(object sender, EventArgs e)
        {

            double[,] matriz = { { 1, -2, 3, -1 }, { 2, -4, 6, -2 }, { 3, -6, 9, -3 } };
            textBoxResult.Clear();

            List<double[]> espacoLinha = ObterEspacoLinha(matriz);
            List<double[]> espacoColuna = ObterEspacoColuna(matriz);
            List<double[]> espacoNulo = ObterEspacoNulo(matriz);
            List<double[]> espacoNuloTransposta = ObterEspacoNuloTransposta(matriz);

            ExibirResultado(""Espaço Linha (C(A^T)):"", espacoLinha);
            ExibirResultado(""Espaço Coluna (C(A)):"", espacoColuna);
            ExibirResultado(""Espaço Nulo (N(A)):"", espacoNulo);
            ExibirResultado(""Espaço Nulo Transposta (N(A^T)):"", espacoNuloTransposta);
        }

        private List<double[]> ObterEspacoLinha(double[,] matriz)
        {
            double[,] transposta = MatrizTransposta(matriz);
            double[,] rref = RREF(transposta);
            List<double[]> baseEspacoLinha = new List<double[]>();

            for (int i = 0; i < rref.GetLength(0); i++)
            {
                bool ehLinhaNula = true;
                for (int j = 0; j < rref.GetLength(1); j++)
                {
                    if (Math.Abs(rref[i, j]) > 0.0001)
                    {
                        ehLinhaNula = false;
                        break;
                    }
                }
                if (!ehLinhaNula)
                {
                    double[] vetor = new double[rref.GetLength(1)];
                    for (int k = 0; k < rref.GetLength(1); k++)
                    {
                        vetor[k] = rref[i, k];
                    }
                    baseEspacoLinha.Add(vetor);
                }
            }
            return baseEspacoLinha;
        }

        private List<double[]> ObterEspacoColuna(double[,] matriz)
        {
            return ObterEspacoLinha(matriz);
        }

        private List<double[]> ObterEspacoNulo(double[,] matriz)
        {
            double[,] rref = RREF(matriz);
            List<double[]> baseEspacoNulo = new List<double[]>();

            for (int j = 0; j < rref.GetLength(1); j++)
            {
                bool ehColunaPivo = true;
                for (int i = 0; i < rref.GetLength(0) - 1; i++)
                {
                    if (i != j && Math.Abs(rref[i, j]) > 0.0001)
                    {
                        ehColunaPivo = false;
                        break;
                    }
                }
                if (!ehColunaPivo)
                {
                    double[] vetor = new double[rref.GetLength(0)];
                    for (int k = 0; k < rref.GetLength(0); k++)
                    {
                        vetor[k] = rref[k, j];
                    }
                    baseEspacoNulo.Add(vetor);
                }
            }
            return baseEspacoNulo;
        }

        private List<double[]> ObterEspacoNuloTransposta(double[,] matriz)
        {
            double[,] transposta = MatrizTransposta(matriz);
            return ObterEspacoNulo(transposta);
        }

        private double[,] MatrizTransposta(double[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            double[,] transposta = new double[colunas, linhas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }
            return transposta;
        }

        private double[,] RREF(double[,] matriz)
        {
            // Implemente aqui o algoritmo para obter a forma escalonada reduzida da matriz
            // Aqui você pode usar uma biblioteca de álgebra linear ou implementar o algoritmo RREF

            // Simulação da forma escalonada reduzida da matriz (exemplo)
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            double[,] rref = new double[linhas, colunas];

            // Preenchendo rref com valores da matriz para fins de exemplo
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    rref[i, j] = matriz[i, j];
                }
            }
            return rref;
        }

        private void ExibirResultado(string titulo, List<double[]> subespaco)
        {
            textBoxResult.AppendText(titulo + Environment.NewLine);
            foreach (double[] vetor in subespaco)
            {
                textBoxResult.AppendText(""("");
                for (int i = 0; i < vetor.Length; i++)
                {
                    textBoxResult.AppendText(vetor[i].ToString());
                    if (i < vetor.Length - 1)
                    {
                        textBoxResult.AppendText("", "");
                    }
                }
                textBoxResult.AppendText("")"" + Environment.NewLine);
            }
            textBoxResult.AppendText(Environment.NewLine);
        }";

            textBoxResult.Text = codigo;
        }
    }
}


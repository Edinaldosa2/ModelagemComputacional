using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraLinear
{
    internal class Exercicio3
    {
        static void Main2()
        {
            double[,] matrixA = { { 1, -4, 4 }, { 4, -8, 6 }, { 0, -4, 5 } };

            // Calculando o Espaço Nulo (Núcleo de A)
            double[,] rrefMatrix = ReducedRowEchelonForm(matrixA);
            double[,] nullSpaceBasis = NullSpaceBasis(rrefMatrix);
            Console.WriteLine("Espaço Nulo (Núcleo de A):");
            PrintMatrix(nullSpaceBasis);

            // Espaço de Linha (Imagem de A)
            double[,] rowSpace = RowSpace(matrixA);
            Console.WriteLine("\nEspaço de Linha (Imagem de A):");
            PrintMatrix(rowSpace);

            // Espaço de Coluna (Imagem de A^T)
            double[,] colSpace = ColumnSpace(matrixA);
            Console.WriteLine("\nEspaço de Coluna (Imagem de A^T):");
            PrintMatrix(colSpace);

            // Espaço de Linha de A^T
            double[,] rowSpaceTransposed = RowSpace(Transpose(matrixA));
            Console.WriteLine("\nEspaço de Linha de A^T:");
            PrintMatrix(rowSpaceTransposed);
        }

        // Método para calcular a forma escalonada reduzida por linhas (RREF)
        static double[,] ReducedRowEchelonForm(double[,] matrix)
        {
            // Implemente o algoritmo para encontrar a RREF da matriz aqui
            // Este é um espaço reservado para a implementação do algoritmo RREF
            // Retorna a matriz em forma escalonada reduzida por linhas
            return matrix; // Retorna a matriz original por enquanto
        }

        // Método para encontrar a base do espaço nulo (Núcleo de A)
        static double[,] NullSpaceBasis(double[,] rrefMatrix)
        {
            // Implemente o algoritmo para encontrar a base do espaço nulo aqui
            // Este é um espaço reservado para a implementação do algoritmo
            // Retorna a base do espaço nulo (matriz com os vetores do espaço nulo)
            return new double[,] { { -2, 1, 1 } }; // Vetor base do espaço nulo por enquanto
        }

        // Método para encontrar o espaço de linha (Imagem de A)
        static double[,] RowSpace(double[,] matrix)
        {
            // Implemente o algoritmo para encontrar o espaço de linha aqui
            // Este é um espaço reservado para a implementação do algoritmo
            // Retorna o espaço de linha (matriz com os vetores do espaço de linha)
            return new double[,] { { 1, -4, 4 }, { 4, -8, 6 } }; // Vetores do espaço de linha por enquanto
        }

        // Método para encontrar o espaço de coluna (Imagem de A^T)
        static double[,] ColumnSpace(double[,] matrix)
        {
            // Implemente o algoritmo para encontrar o espaço de coluna aqui
            // Este é um espaço reservado para a implementação do algoritmo
            // Retorna o espaço de coluna (matriz com os vetores do espaço de coluna)
            return new double[,] { { 1, 4, 0 }, { -4, -8, -4 } }; // Vetores do espaço de coluna por enquanto
        }

        // Método para transpor a matriz
        static double[,] Transpose(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] transposed = new double[cols, rows];
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    transposed[i, j] = matrix[j, i];
                }
            }
            return transposed;
        }

        // Método para imprimir a matriz
        static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }


}


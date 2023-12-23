using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Definir a matriz do sistema
        double[,] A = {
            {1, -1, -1},
            {1, 0, 1},
            {1, -1, 3}
        };

        // Definir o vetor do lado direito
        double[] b = { -5 / 3, 3 / 4, 7 / 3 };

        // Fatoração QR
        var qrResult = QRDecomposition(A);
        double[,] Q = qrResult.Item1;
        double[,] R = qrResult.Item2;

        // Resolver o sistema usando a fatoração QR
        double[] QT_b = new double[Q.GetLength(1)];
        for (int j = 0; j < Q.GetLength(1); j++)
        {
            QT_b[j] = Q.Cast<double>().Select((Qij, i) => Qij * b[i]).Sum();
        }

        double[] x = new double[R.GetLength(1)];

        for (int i = R.GetLength(1) - 1; i >= 0; i--)
        {
            x[i] = QT_b[i];
            for (int j = i + 1; j < R.GetLength(1); j++)
            {
                x[i] -= R[i, j] * x[j];
            }
            x[i] /= R[i, i];
        }

        // Exibir os resultados em formato de fração reduzida
        Console.WriteLine("Solução do sistema:");
        Console.WriteLine($"x1 = {x[0]}");
        Console.WriteLine($"x2 = {x[1]}");
        Console.WriteLine($"x3 = {x[2]}");

        Console.WriteLine($"x1 - x2 - x3 = {Simplify(x[0] - x[1] - x[2])}");
        Console.WriteLine($"x1 + x3 = {Simplify(x[0] + x[2])}");
        Console.WriteLine($"x1 - x2 + 3x3 = {Simplify(x[0] - x[1] + x[2] * 3)}");
    }

    static Tuple<double[,], double[,]> QRDecomposition(double[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        double[,] Q = new double[m, n];
        double[,] R = new double[n, n];

        for (int j = 0; j < n; j++)
        {
            double[] v = new double[m];
            for (int i = 0; i < m; i++)
            {
                v[i] = matrix[i, j];
            }

            for (int i = 0; i < j; i++)
            {
                R[i, j] = Q.Cast<double>().Select((Qij, k) => Qij * v[k]).Sum();
                for (int k = 0; k < m; k++)
                {
                    v[k] -= R[i, j] * Q[k, i];
                }
            }

            R[j, j] = Math.Sqrt(v.Cast<double>().Select(val => val * val).Sum());

            for (int i = 0; i < m; i++)
            {
                Q[i, j] = v[i] / R[j, j];
            }
        }

        return Tuple.Create(Q, R);
    }

    static string Simplify(double value)
    {
        int numerator = (int)Math.Round(value * 1000000);
        int denominator = 1000000;

        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;

        return $"{numerator}/{denominator}";
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
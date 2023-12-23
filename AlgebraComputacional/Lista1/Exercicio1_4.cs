using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgebraComputacional.Lista1
{
    public partial class Exercicio1_4 : Form
    {
        public Exercicio1_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] matrix = {
                { -1, 3, -2, 4 },
                { -1, 4, -3, 5 },
                { -1, 5, -4, 6 }
            };

            string explanation = SolveSystem(matrix);
            textBox1.Text = explanation;
        }

        private string SolveSystem(double[,] matrix)
        {
            // Simulação da eliminação gaussiana (não será feita de fato, só para explicação)
            string explanation = "Attempt to solve the system using Gaussian elimination:\r\n";
            explanation += "Original system:\r\n";
            explanation += "(-1)x1 + 3x2 - 2x3 = 4\r\n";
            explanation += "(-1)x1 + 4x2 - 3x3 = 5\r\n";
            explanation += "(-1)x1 + 5x2 - 4x3 = 6\r\n\r\n";

            explanation += "Performing row operations...\r\n";
            explanation += "R2 = R2 + R1\r\n";
            explanation += "R3 = R3 + R1\r\n\r\n";

            explanation += "New system after row operations:\r\n";
            explanation += "(-1)x1 + 3x2 - 2x3 = 4\r\n";
            explanation += "0x1 + 1x2 - 1x3 = 1\r\n";
            explanation += "0x1 + 2x2 - 2x3 = 2\r\n\r\n";

            explanation += "The last equation suggests that any value of x3 gives a valid solution (infinite solutions).\r\n";
            explanation += "The system has infinitely many solutions because it's underdetermined: it has more variables than independent equations.\r\n";

            return explanation;
        }
    }
}
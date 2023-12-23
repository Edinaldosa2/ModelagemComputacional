using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlgebraComputacional.Lista1
{
    public partial class Exercicio1_9 : Form
    {
        public Exercicio1_9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Conhecemos z diretamente da última equação
            int z = 1;

            // Com z conhecido, resolvemos para y na penúltima equação
            int y = z; // y - z = 0 -> y = z

            // Com y e z conhecidos, resolvemos para x na terceira equação
            int x = y + z; // x - y - z = 0 -> x = y + z

            // Com x, y e z conhecidos, resolvemos para w na segunda equação
            int w = x + y + z; // w - x - y - z = 0 -> w = x + y + z

            // Com w, x, y e z conhecidos, resolvemos para v na primeira equação
            int v = w + x + y + z; // v - w - x - y - z = 0 -> v = w + x + y + z

            // Exibindo os cálculos passo a passo
            textBox1.Text = "Solução do sistema passo a passo:\r\n\r\n" +
                            "Começamos com a última equação, que nos dá z diretamente:\r\n" +
                            "5. z = 1\r\n\r\n" +
                            "Com o valor de z, resolvemos para y na quarta equação:\r\n" +
                            "4. y - z = 0 => y = z => y = 1\r\n\r\n" +
                            "Com os valores de y e z, resolvemos para x na terceira equação:\r\n" +
                            "3. x - y - z = 0 => x = y + z => x = 2\r\n\r\n" +
                            "Com os valores de x, y e z, resolvemos para w na segunda equação:\r\n" +
                            "2. w - x - y - z = 0 => w = x + y + z => w = 4\r\n\r\n" +
                            "Finalmente, com os valores de w, x, y e z, resolvemos para v na primeira equação:\r\n" +
                            "1. v - w - x - y - z = 0 => v = w + x + y + z => v = 8\r\n\r\n" +
                            "Portanto, a solução do sistema é:\r\n" +
                            $"v = {v}\r\n" +
                            $"w = {w}\r\n" +
                            $"x = {x}\r\n" +
                            $"y = {y}\r\n" +
                            $"z = {z}";

        }
    }
}




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
    public partial class Exercicio_2 : Form
    {
        public Exercicio_2()
        {
            InitializeComponent();
        }

        private void VerificarSubespaco_Click(object sender, EventArgs e)
        {
            // 1. Verificando se o vetor nulo (0, 0) pertence a S
            bool contemVetorNulo = (0 == 2 * 0); // Verifica se 0 = 2*0

            // 2. Verificando fechamento sob adição e multiplicação por escalar
            bool fechamentoAdicao = VerificarFechamentoAdicao();
            bool fechamentoMultEscalar = VerificarFechamentoMultEscalar();

            // Exibindo resultados na caixa de texto
            textBox1.AppendText("Mostre que S = {(x, y) ∈ ℜ2/y = 2x} é um subespaço do ℜ²");
            textBox1.AppendText("\r\n");
            textBox1.AppendText("1. Contém o vetor nulo (0, 0): " + contemVetorNulo + "\r\n");
            textBox1.AppendText("2. Fechamento sob adição: " + fechamentoAdicao + "\r\n");
            textBox1.AppendText("3. Fechamento sob multiplicação por escalar: " + fechamentoMultEscalar + "\r\n");
        }

        private bool VerificarFechamentoAdicao()
        {
            double[] vetorU = new double[] { 2.5, 5 }; // Substitua pelos valores de x1 e y1
            double[] vetorV = new double[] { -3.5, -7 }; // Substitua pelos valores de x2 e y2

            double[] soma = new double[] { vetorU[0] + vetorV[0], vetorU[1] + vetorV[1] };

            return (soma[1] == 2 * soma[0]); // Verifica se y = 2x
        }

        private bool VerificarFechamentoMultEscalar()
        {
            double[] vetorU = new double[] { 1.7, 3.4 }; // Substitua pelos valores de x1 e y1
            double escalar = 2.0; // Substitua pelo escalar k

            double[] multEscalar = new double[] { escalar * vetorU[0], escalar * vetorU[1] };

            return (multEscalar[1] == 2 * multEscalar[0]); // Verifica se y = 2x
        }

        private void button2_Click(object sender, EventArgs e)

        { 
            var codigo = @"
            // 1. Verificando se o vetor nulo (0, 0) pertence a S
            bool contemVetorNulo = (0 == 2 * 0); // Verifica se 0 = 2*0

            // 2. Verificando fechamento sob adição e multiplicação por escalar
            bool fechamentoAdicao = VerificarFechamentoAdicao();
            bool fechamentoMultEscalar = VerificarFechamentoMultEscalar();

            // Exibindo resultados na caixa de texto
            textBox1.AppendText(""Mostre que S = {(x, y) ∈ ℜ2/y = 2x} é um subespaço do ℜ²"");
            textBox1.AppendText(""\r\n"");
            textBox1.AppendText(""1. Contém o vetor nulo (0, 0): "" + contemVetorNulo + ""\r\n"");
            textBox1.AppendText(""2. Fechamento sob adição: "" + fechamentoAdicao + ""\r\n"");
            textBox1.AppendText(""3. Fechamento sob multiplicação por escalar: "" + fechamentoMultEscalar + ""\r\n"");
        }

        private bool VerificarFechamentoAdicao()
        {
            double[] vetorU = new double[] { 2.5, 5 }; // Substitua pelos valores de x1 e y1
            double[] vetorV = new double[] { -3.5, -7 }; // Substitua pelos valores de x2 e y2

            double[] soma = new double[] { vetorU[0] + vetorV[0], vetorU[1] + vetorV[1] };

            return (soma[1] == 2 * soma[0]); // Verifica se y = 2x
        }

        private bool VerificarFechamentoMultEscalar()
        {
            double[] vetorU = new double[] { 1.7, 3.4 }; // Substitua pelos valores de x1 e y1
            double escalar = 2.0; // Substitua pelo escalar k

            double[] multEscalar = new double[] { escalar * vetorU[0], escalar * vetorU[1] };

            return (multEscalar[1] == 2 * multEscalar[0]); // Verifica se y = 2x
        }";


            textBox1.Text = codigo;
        
        }
    }
}

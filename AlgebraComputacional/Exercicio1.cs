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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            // Propriedade 1: Adição é comutativa
            double x1 = 2.5;
            double y1 = -3.8;
            double x2 = -1.5;
            double y2 = 4.2;

            bool adicaoComutativa = (x1 + x2 == x2 + x1) && (y1 + y2 == y2 + y1);

            // Propriedade 2: Adição é associativa
            double x3 = 1.7;
            double y3 = -2.3;

            bool adicaoAssociativa = ((x1 + x2) + x3 == x1 + (x2 + x3)) && ((y1 + y2) + y3 == y1 + (y2 + y3));

            var calculo1 = ((x1 + x2) + x3 == x1 + (x2 + x3));
            var calculo2 = ((y1 + y2) + y3 == y1 + (y2 + y3));
            var calculo3 = ((y1 + y2) + y3);
            var calculo4 = y1 + (y2 + y3);

            // Propriedade 3: Existência de elemento neutro (0, 0)
            double zero = 0;

            bool existenciaElementoNeutro = ((x1 + zero == x1) && (y1 + zero == y1) && (x2 + zero == x2) && (y2 + zero == y2));

            // Propriedade 4: Existência de elemento oposto
            double x1Op = -x1;
            double y1Op = -y1;
            double x2Op = -x2;
            double y2Op = -y2;

            bool existenciaElementoOposto = ((x1 + x1Op == zero) && (y1 + y1Op == zero) && (x2 + x2Op == zero) && (y2 + y2Op == zero));

            // Propriedade 5: Multiplicação por escalar é associativa
            double escalar1 = 2.0;
            double escalar2 = 3.0;

            bool multEscalarAssociativa = ((escalar1 * escalar2) * x1 == escalar1 * (escalar2 * x1)) && ((escalar1 * escalar2) * y1 == escalar1 * (escalar2 * y1));

            // Propriedade 6: Distributividade da soma de escalares
            double escalar3 = 4.0;

            bool distSomaEscalar = ((escalar1 + escalar2) * x1 == (escalar1 * x1) + (escalar2 * x1)) && ((escalar1 + escalar2) * y1 == (escalar1 * y1) + (escalar2 * y1));

            // Propriedade 7: Distributividade da soma de vetores
            double x4 = 1.0;
            double y4 = -1.0;

            bool distSomaVetores = (escalar3 * (x1 + x4) == (escalar3 * x1) + (escalar3 * x4)) && (escalar3 * (y1 + y4) == (escalar3 * y1) + (escalar3 * y4));

            // Propriedade 8: Multiplicação por escalar identidade
            double identidade = 1.0;

            bool multEscalarIdentidade = (identidade * x1 == x1) && (identidade * y1 == y1);

            // Exibir os resultados na caixa de texto
            textBox1.AppendText(" Mostre que o conjunto V = ℜ² = {(x, y)/x, y ∈ ℜ} é um espaço vetorial");
            textBox1.AppendText("\r\n");

            textBox1.AppendText($"valor de x1: {x1}\r\n");
            textBox1.AppendText($"valor de y1: {y1}\r\n");
            textBox1.AppendText($"valor de x2: {x2}\r\n");
            textBox1.AppendText($"valor de y2: {y2}\r\n");
            textBox1.AppendText($"valor de x3: {x3}\r\n");
            textBox1.AppendText($"valor de y3: {y3}\r\n");

            textBox1.AppendText("\r\n");

            //textBox1.AppendText($"calculo1: {calculo1}\r\n");
            //textBox1.AppendText($"calculo2: {calculo2}\r\n");
            //textBox1.AppendText($"calculo3: {calculo3}\r\n");
            //textBox1.AppendText($"calculo4: {calculo4}\r\n");
            textBox1.AppendText(" ");
            textBox1.AppendText(" ");
            textBox1.AppendText($"Adição é comutativa: {adicaoComutativa}\r\n");
            textBox1.AppendText($"Adição é associativa: {adicaoAssociativa}\r\n");
            textBox1.AppendText($"Existência de elemento neutro: {existenciaElementoNeutro}\r\n");
            textBox1.AppendText($"Existência de elemento oposto: {existenciaElementoOposto}\r\n");
            textBox1.AppendText($"Multiplicação por escalar é associativa: {multEscalarAssociativa}\r\n");
            textBox1.AppendText($"Distributividade da soma de escalares: {distSomaEscalar}\r\n");
            textBox1.AppendText($"Distributividade da soma de vetores: {distSomaVetores}\r\n");
            textBox1.AppendText($"Multiplicação por escalar identidade: {multEscalarIdentidade}\r\n");


        }

        private void ComValoresA(object sender, EventArgs e)
        {
            {
                // Propriedade 1: Adição é comutativa
                double x1 = 2.5;
                double y1 = -1.8;
                double x2 = -3.5;
                double y2 = 4.2;

                bool adicaoComutativa = (x1 + x2 == x2 + x1) && (y1 + y2 == y2 + y1);

                // Propriedade 2: Adição é associativa
                double x3 = 1.7;
                double y3 = -2.3;

                bool adicaoAssociativa = ((x1 + x2) + x3 == x1 + (x2 + x3)) && ((y1 + y2) + y3 == y1 + (y2 + y3));
                var calculo1 = ((x1 + x2) + x3 == x1 + (x2 + x3));
                var calculo2 = ((y1 + y2) + y3 == y1 + (y2 + y3));
                var calculo3 = ((y1 + y2) + y3);
                var calculo4 = y1 + (y2 + y3);


                // Propriedade 3: Existência de elemento neutro (0, 0)
                double zero = 0;

                bool existenciaElementoNeutro = ((x1 + zero == x1) && (y1 + zero == y1) && (x2 + zero == x2) && (y2 + zero == y2));

                // Propriedade 4: Existência de elemento oposto
                double x1Op = -x1;
                double y1Op = -y1;
                double x2Op = -x2;
                double y2Op = -y2;

                bool existenciaElementoOposto = ((x1 + x1Op == zero) && (y1 + y1Op == zero) && (x2 + x2Op == zero) && (y2 + y2Op == zero));

                // Propriedade 5: Multiplicação por escalar é associativa
                double escalar1 = 2.0;
                double escalar2 = 3.0;

                bool multEscalarAssociativa = ((escalar1 * escalar2) * x1 == escalar1 * (escalar2 * x1)) && ((escalar1 * escalar2) * y1 == escalar1 * (escalar2 * y1));

                // Propriedade 6: Distributividade da soma de escalares
                double escalar3 = 4.0;

                bool distSomaEscalar = ((escalar1 + escalar2) * x1 == (escalar1 * x1) + (escalar2 * x1)) && ((escalar1 + escalar2) * y1 == (escalar1 * y1) + (escalar2 * y1));

                // Propriedade 7: Distributividade da soma de vetores
                double x4 = 1.0;
                double y4 = -1.0;

                bool distSomaVetores = (escalar3 * (x1 + x4) == (escalar3 * x1) + (escalar3 * x4)) && (escalar3 * (y1 + y4) == (escalar3 * y1) + (escalar3 * y4));

                // Propriedade 8: Multiplicação por escalar identidade
                double identidade = 1.0;

                bool multEscalarIdentidade = (identidade * x1 == x1) && (identidade * y1 == y1);

                // Exibir os resultados na caixa de texto


                textBox1.AppendText("Método B ");
                textBox1.AppendText(" ");
                textBox1.AppendText($"valor de x1: {x1}\r\n");
                textBox1.AppendText($"valor de y1: {y1}\r\n");
                textBox1.AppendText($"valor de x2: {x2}\r\n");
                textBox1.AppendText($"valor de y2: {y2}\r\n");

                textBox1.AppendText($"calculo1: {calculo1}\r\n");
                textBox1.AppendText($"calculo2: {calculo2}\r\n");
                textBox1.AppendText($"calculo3: {calculo3}\r\n");
                textBox1.AppendText($"calculo4: {calculo4}\r\n");
                textBox1.AppendText(" ");



                textBox1.AppendText($"Adição é comutativa: {adicaoComutativa}\r\n");
                textBox1.AppendText($"Adição é associativa: {adicaoAssociativa}\r\n");
                textBox1.AppendText($"Existência de elemento neutro: {existenciaElementoNeutro}\r\n");
                textBox1.AppendText($"Existência de elemento oposto: {existenciaElementoOposto}\r\n");
                textBox1.AppendText($"Multiplicação por escalar é associativa: {multEscalarAssociativa}\r\n");
                textBox1.AppendText($"Distributividade da soma de escalares: {distSomaEscalar}\r\n");
                textBox1.AppendText($"Distributividade da soma de vetores: {distSomaVetores}\r\n");
                textBox1.AppendText($"Multiplicação por escalar identidade: {multEscalarIdentidade}\r\n");
            }
        }

        private void Exercicio1_Load(object sender, EventArgs e)
        {

        }

        private void ExibirCodigo(object sender, EventArgs e)
        {
            var codigo = @"Propriedade 1: Adição é comutativa
                double x1 = 2.5;
                double y1 = -1.8;
                double x2 = -3.5;
                double y2 = 4.2;

                bool adicaoComutativa = (x1 + x2 == x2 + x1) && (y1 + y2 == y2 + y1);

                // Propriedade 2: Adição é associativa
                double x3 = 1.7;
                double y3 = -2.3;

                bool adicaoAssociativa = ((x1 + x2) + x3 == x1 + (x2 + x3)) && ((y1 + y2) + y3 == y1 + (y2 + y3));
                var calculo1 = ((x1 + x2) + x3 == x1 + (x2 + x3));
                var calculo2 = ((y1 + y2) + y3 == y1 + (y2 + y3));
                var calculo3 = ((y1 + y2) + y3);
                var calculo4 = y1 + (y2 + y3);


                // Propriedade 3: Existência de elemento neutro (0, 0)
                double zero = 0;

                bool existenciaElementoNeutro = ((x1 + zero == x1) && (y1 + zero == y1) && (x2 + zero == x2) && (y2 + zero == y2));

                // Propriedade 4: Existência de elemento oposto
                double x1Op = -x1;
                double y1Op = -y1;
                double x2Op = -x2;
                double y2Op = -y2;

                bool existenciaElementoOposto = ((x1 + x1Op == zero) && (y1 + y1Op == zero) && (x2 + x2Op == zero) && (y2 + y2Op == zero));

                // Propriedade 5: Multiplicação por escalar é associativa
                double escalar1 = 2.0;
                double escalar2 = 3.0;

                bool multEscalarAssociativa = ((escalar1 * escalar2) * x1 == escalar1 * (escalar2 * x1)) && ((escalar1 * escalar2) * y1 == escalar1 * (escalar2 * y1));

                // Propriedade 6: Distributividade da soma de escalares
                double escalar3 = 4.0;

                bool distSomaEscalar = ((escalar1 + escalar2) * x1 == (escalar1 * x1) + (escalar2 * x1)) && ((escalar1 + escalar2) * y1 == (escalar1 * y1) + (escalar2 * y1));

                // Propriedade 7: Distributividade da soma de vetores
                double x4 = 1.0;
                double y4 = -1.0;

                bool distSomaVetores = (escalar3 * (x1 + x4) == (escalar3 * x1) + (escalar3 * x4)) && (escalar3 * (y1 + y4) == (escalar3 * y1) + (escalar3 * y4));

                // Propriedade 8: Multiplicação por escalar identidade
                double identidade = 1.0;

                bool multEscalarIdentidade = (identidade * x1 == x1) && (identidade * y1 == y1);

                // Exibir os resultados na caixa de texto

                textBox1.AppendText(Método B );
                textBox1.AppendText();
                textBox1.AppendText($valor de x1: {x1}\r\);
                textBox1.AppendText($valor de y1: {y1}\r\n);
                textBox1.AppendText($valor de x2: {x2}\r\n);
                textBox1.AppendText($valor de y2: {y2}\r\n);

                textBox1.AppendText($calculo1: {calculo1}\r\n);
                textBox1.AppendText($calculo2: {calculo2}\r\n);
                textBox1.AppendText($calculo3: {calculo3}\r\n);
                textBox1.AppendText($calculo4: {calculo4}\r\n);
                textBox1.AppendText();
                textBox1.AppendText()Adição é comutativa: {adicaoComutativa}\r\n);
                textBox1.AppendText($Adição é associativa: {adicaoAssociativa}\r\n);
                textBox1.AppendText($Existência de elemento neutro: {existenciaElementoNeutro}\r\n);
                textBox1.AppendText($Existência de elemento oposto: {existenciaElementoOposto}\r\n);
                textBox1.AppendText($Multiplicação por escalar é associativa: {multEscalarAssociativa}\r\n);
                textBox1.AppendText($Distributividade da soma de escalares: {distSomaEscalar}\r\n);
                textBox1.AppendText($Distributividade da soma de vetores: {distSomaVetores}\r\n);
                textBox1.AppendText($Multiplicação por escalar identidade: {multEscalarIdentidade}\r\n);";

            textBox1.Text = codigo;


        }
    }
}

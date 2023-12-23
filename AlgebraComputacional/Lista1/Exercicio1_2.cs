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
    public partial class Exercicio1_2 : Form
    {
        public Exercicio1_2()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.ReadOnly = true;
            textBox1.Text = "Explicações e Soluções para Operações de Linha em Matrizes:\r\n\r\n" +
                            "1. Troca de Linhas:\r\n" +
                            "   - Se trocarmos duas linhas em A para obter B, podemos trocar as mesmas linhas em B para recuperar A.\r\n\r\n" +
                            "2. Multiplicação de uma Linha por um Escalar Não-Nulo:\r\n" +
                            "   - Se multiplicarmos uma linha em A por um escalar não-nulo para obter B, podemos multiplicar a mesma linha em B pelo inverso desse escalar para voltar a A.\r\n\r\n" +
                            "3. Adição de um Múltiplo de uma Linha a Outra:\r\n" +
                            "   - Se adicionarmos um múltiplo de uma linha a outra em A para obter B, podemos subtrair o mesmo múltiplo dessa linha em B para recuperar A.\r\n\r\n" +
                            "Conclusão:\r\n" +
                            "   - Cada operação de linha tem uma operação inversa correspondente, permitindo a reversibilidade do processo.\r\n";
        }


        private void ExibirCodigo(object sender, EventArgs e)
        {
            var codigo = @" textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.ReadOnly = true;
            textBox1.Text = ""Explicações e Soluções para Operações de Linha em Matrizes:\r\n\r\n"" +
                            ""1. Troca de Linhas:\r\n"" +
                            ""   - Se trocarmos duas linhas em A para obter B, podemos trocar as mesmas linhas em B para recuperar A.\r\n\r\n"" +
                            ""2. Multiplicação de uma Linha por um Escalar Não-Nulo:\r\n"" +
                            ""   - Se multiplicarmos uma linha em A por um escalar não-nulo para obter B, podemos multiplicar a mesma linha em B pelo inverso desse escalar para voltar a A.\r\n\r\n"" +
                            ""3. Adição de um Múltiplo de uma Linha a Outra:\r\n"" +
                            ""   - Se adicionarmos um múltiplo de uma linha a outra em A para obter B, podemos subtrair o mesmo múltiplo dessa linha em B para recuperar A.\r\n\r\n"" +
                            ""Conclusão:\r\n"" +
                            ""   - Cada operação de linha tem uma operação inversa correspondente, permitindo a reversibilidade do processo.\r\n"";
        }";

            textBox1.Text = codigo;

        }
    }


}


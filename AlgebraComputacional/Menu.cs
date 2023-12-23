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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exercicio1(object sender, EventArgs e)
        {
            Exercicio1 formSecundario = new Exercicio1();

            // Exibe o segundo formulário
            formSecundario.Show();
        }

        private void Exercicio2(object sender, EventArgs e)
        {

            Exercicio_2 formSecundario = new Exercicio_2();

            // Exibe o segundo formulário
            formSecundario.Show();

        }

        private void Exercicio3(object sender, EventArgs e)
        {
            Exercicio3 formSecundario = new Exercicio3();

            // Exibe o segundo formulário
            formSecundario.Show();

        }

        private void Exercicio4(object sender, EventArgs e)
        {
            Exercicio4 formSecundario = new Exercicio4();
            formSecundario.Show();
        }

        private void Exercicio5(object sender, EventArgs e)
        {
            Exercicio5 formSecundario = new Exercicio5();
            formSecundario.Show();

        }

        private void Exercicio6(object sender, EventArgs e)
        {
            Exercicio6 formSecundario = new Exercicio6();
            formSecundario.Show();

        }

        private void Exercicio7(object sender, EventArgs e)
        {
            Exercicio7 formSecundario = new Exercicio7();
            formSecundario.Show();

        }

        private void Exercicio8(object sender, EventArgs e)
        {
            Exercicio8 formSecundario = new Exercicio8();
            formSecundario.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Exercicio10 formSecundario = new Exercicio10();
            formSecundario.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Exercicio11 formSecundario = new Exercicio11();
            formSecundario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Exercicio9 formSecundario = new Exercicio9();
            formSecundario.Show();

        }
    }
}

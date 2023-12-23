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
    public partial class MenuLista1 : Form
    {
        public MenuLista1()
        {
            InitializeComponent();
        }

        private void Exercicio1(object sender, EventArgs e)
        {
            Exercicio1_1 formSecundario = new Exercicio1_1();
            formSecundario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio1_3 formSecundario = new Exercicio1_3();
            formSecundario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Exercicio1_2 formSecundario = new Exercicio1_2();
            formSecundario.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Exercicio1_4 formSecundario = new Exercicio1_4();
            formSecundario.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Exercicio1_5 formSecundario = new Exercicio1_5();
            formSecundario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exercicio1_6 formSecundario = new Exercicio1_6();
            formSecundario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Exercicio1_7 formSecundario = new Exercicio1_7();
            formSecundario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exercicio1_8 formSecundario = new Exercicio1_8();
            formSecundario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exercicio1_9 formSecundario = new Exercicio1_9();
            formSecundario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exercicio1_10 formSecundario = new Exercicio1_10();
            formSecundario.Show();
        }
    }
}

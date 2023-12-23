using AlgebraComputacional.Lista1;
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
    public partial class Menu0 : Form
    {
        public Menu0()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuLista1 formSecundario = new MenuLista1();
            formSecundario.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu formSecundario = new Menu();
            formSecundario.Show();
        }
    }
}

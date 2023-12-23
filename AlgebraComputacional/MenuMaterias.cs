using AlgebraComputacional.Properties;
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
    public partial class MenuMaterias : Form
    {
        public MenuMaterias()
        {
            InitializeComponent();
        }

        private void AlgebraAntonio(object sender, EventArgs e)
        {
            Menu formSecundario = new Menu();
            formSecundario.Show();
        }

        private void AlgebraMatheus(object sender, EventArgs e)
        {
            Menu0 formSecundario = new Menu0();
            formSecundario.Show();
        }

        private void AntonioExercicio(object sender, EventArgs e)
        {
            Menu formSecundario = new Menu();
            formSecundario.Show();
        }



        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.algebra3;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.algebra5;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu0 formSecundario = new Menu0();
            formSecundario.Show();
        }

        private void LBL_Click(object sender, EventArgs e)
        {

        }
    }
}

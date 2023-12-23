using AlgebraComputacional;
using AlgoritmoseProgramas;
using TopicosModelagemComputacional;


namespace MenuMaterias
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AlgebraLinear(object sender, EventArgs e)
        {
            Menu0 formSecundario = new Menu0();
            formSecundario.Show();
        }

        private void Algoritmo(object sender, EventArgs e)
        {
            MenuAlgoritmo formSecundario = new MenuAlgoritmo();
            formSecundario.Show();
        }

        private void Modelagem(object sender, EventArgs e)
        {
            MenuModelagem formSecundario = new MenuModelagem();
            formSecundario.Show();
        }

        private void Algebra_Click(object sender, EventArgs e)
        {

            AlgebraComputacional.Menu formSecundario = new AlgebraComputacional.Menu();
            formSecundario.Show();
        }
    }
}

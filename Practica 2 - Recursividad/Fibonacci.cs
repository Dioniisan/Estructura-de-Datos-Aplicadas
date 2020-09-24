using System;
using System.Windows.Forms;

namespace Practica_2___Recursividad
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        public int Calcular(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                return Calcular(num - 1) + Calcular(num - 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(textBox1.Text.Trim());
            label4.Text = Calcular(num).ToString(); 
        }
    }
}

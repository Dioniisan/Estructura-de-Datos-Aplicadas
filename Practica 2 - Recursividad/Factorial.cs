using System;
using System.Windows.Forms;

namespace Practica_2___Recursividad
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public int Calcular(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            else
            {
                return num * Calcular(num - 1);
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

using System;
using System.Windows.Forms;

namespace Practica_2___Recursividad
{
    public partial class MCD : Form
    {
        public MCD()
        {
            InitializeComponent();
        }
        public int Calcular(int n1, int n2)
        {
            int mcd;
            if (n1 < n2)
            {
                
                mcd = Calcular(n2, n1);
            }
            else if (n2 == 0)
            {
                mcd = n1;
               
            }
            else
            {
                mcd = Calcular(n2, (n1 % n2));
            }

            return mcd;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = Convert.ToInt32(textBox1.Text.Trim());
            n2 = Convert.ToInt32(textBox2.Text.Trim());
            label4.Text= Calcular(n1,n2).ToString();

        }
    }
}

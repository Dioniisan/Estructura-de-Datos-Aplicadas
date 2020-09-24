using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2___Recursividad
{
    public partial class Monedas : Form
    {
        public Monedas()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {            
                try
                {
                    double resta = double.Parse(txtCantidadI.Text) - double.Parse(txtCantidadAP.Text);
                    CambioMonedas(resta);
                    P100 = 0;
                    P50 = 0;
                    P20 = 0;
                    P10 = 0;
                    P5 = 0;
                    P1 = 0;
                    C50 = 0;
                    C20 = 0;
                    C1 = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }           
        }
        double P100 = 0, P50 = 0, P20 = 0, P10 = 0, P5 = 0, P1 = 0, C50 = 0, C20 = 0, C1 = 0;
        

        private void Monedas_Load(object sender, EventArgs e)
        {

        }

       

        public void CambioMonedas(double x)
        {

            if (x > 0)
            {
                if (x >= 100)
                {
                    x -= 100;
                    P100++;
                }
                else if ((x) >= 50)
                {

                    x -= 50;
                    P50++;
                }
                else if ((x) >= 20)
                {

                    x -= 20;
                    P20++;
                }
                else if ((x) >= 10)
                {

                    x -= 10;
                    P10++;
                }
                else if ((x) >= 5)
                {

                    x -= 5;
                    P5++;
                }
                else if ((x) >= 1)
                {

                    x -= 1;
                    P1++;
                }
                else if ((x) >= 0.5)
                {

                    x -= 0.5;
                    C50++;
                }
                else if (x >= 0.2)
                {

                    x = (x - 0.2);

                    C20++;
                }
                else if (x >= 0.01)
                {

                    x -= 0.01;

                    C1++;
                }

                x = (double)decimal.Round((decimal)x, 2);
                CambioMonedas(x);
            }

            txt100P.Text = P100.ToString();
            txt50P.Text = P50.ToString();
            txt20P.Text = P20.ToString();
            txt10P.Text = P10.ToString();
            txt5P.Text = P5.ToString();
            txt1P.Text = P1.ToString();
            txt50C.Text = C50.ToString();
            txt20C.Text = C20.ToString();
            txt1C.Text = C1.ToString();
        }
    }
}

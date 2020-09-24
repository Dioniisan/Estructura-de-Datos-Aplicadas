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
    public partial class Recursividad : Form
    {
        public Recursividad()
        {
            InitializeComponent();
        }

        private void AbrirFormMenor(object formmenor)
        {
            if (this.PanelEjercicios.Controls.Count > 0)
                this.PanelEjercicios.Controls.RemoveAt(0);
            Form fm = formmenor as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.PanelEjercicios.Controls.Add(fm);
            this.PanelEjercicios.Tag = fm;
            fm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboxOpciones.Text == "Factorial")
            {
                AbrirFormMenor(new Factorial());
            }
            if (CboxOpciones.Text == "Fibonacci")
            {
                AbrirFormMenor(new Fibonacci());
            }
            if (CboxOpciones.Text == "MCD")
            {
                AbrirFormMenor(new MCD());
            }
            if (CboxOpciones.Text == "Monedas")
            {
                AbrirFormMenor(new Monedas());
            }
            if (CboxOpciones.Text == "Torres de Hanói")
            {
                AbrirFormMenor(new Hanoi());
            }
        }
    }
}




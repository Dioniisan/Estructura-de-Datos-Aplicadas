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
    public partial class Hanoi : Form
    {
        public Hanoi()
        {
            InitializeComponent();
        }
        int x1, x2, x3;
        int n, m = 0, p = 0;
        Graphics graphics;
        Bitmap Bitmap;
        Pen Pen;
        int[,] box;
        char[,] move;
        SolidBrush solid;


        private void hanoi(int h, char s, char i, char d)
        {
            if (h == 1)
            {
                listBox1.Items.Add(s + "-->" + d);
                move[0, m] = s;
                move[1, m] = d;
                m++;
            }
            else
            {
                hanoi(h - 1, s, d, i);
                hanoi(1, s, i, d);
                hanoi(h - 1, i, s, d);
            }
        }


        private void refr()
        {
            pictureBox1.Image = Bitmap;
        }

        private int pow(int a, int b)
        {
            if (b != 0)
                return a * pow(a, b - 1);
            else
                return 1;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int i;
                timer1.Enabled = true;
                listBox1.Items.Clear();
                n = int.Parse(textBox1.Text);
                box = new int[3, n];
                move = new char[2, 1000];
                for (i = 0; i < n; i++)
                {
                    box[0, i] = n - i;
                }
                hanoi(n, 'A', 'B', 'C');
                draw_();
                timer1.Enabled = true;
                x1 = 0;
                x2 = 0;
                x3 = 0;
                m = 0;
                p = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            x1 = -1;
            x2 = -1;
            x3 = -1;

            graphics.DrawLine(Pen, 60, 350, 200, 350);
            graphics.DrawLine(Pen, 250, 350, 390, 350);
            graphics.DrawLine(Pen, 440, 350, 580, 350);
            graphics.DrawLine(Pen, 130, 350, 130, 150);
            graphics.DrawLine(Pen, 320, 350, 320, 150);
            graphics.DrawLine(Pen, 510, 350, 510, 150);

            for (int i = 0; i < n; i++)
            {
                if (box[0, i] == 0)
                {
                    x1 = i;
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (box[1, i] == 0)
                {
                    x2 = i;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (box[2, i] == 0)
                {
                    x3 = i;
                    break;
                }
            }
            if (x1 == -1)
                x1 = n;
            if (x2 == -1)
                x2 = n;
            if (x3 == -1)
                x3 = n;


            switch (move[0, p])
            {
                case 'A':
                    switch (move[1, p])
                    {
                        case 'B':
                            box[1, x2] = box[0, x1 - 1];
                            box[0, x1 - 1] = 0;
                            break;
                        case 'C':
                            box[2, x3] = box[0, x1 - 1];
                            box[0, x1 - 1] = 0;
                            break;
                    }
                    break;
                case 'B':
                    switch (move[1, p])
                    {
                        case 'A':
                            box[0, x1] = box[1, x2 - 1];
                            box[1, x2 - 1] = 0;
                            break;
                        case 'C':
                            box[2, x3] = box[1, x2 - 1];
                            box[1, x2 - 1] = 0;
                            break;
                    }
                    break;
                case 'C':
                    switch (move[1, p])
                    {
                        case 'A':
                            box[0, x1] = box[2, x3 - 1];
                            box[2, x3 - 1] = 0;
                            break;
                        case 'B':
                            box[1, x2] = box[2, x3 - 1];
                            box[2, x3 - 1] = 0;
                            break;
                    }
                    break;
            }
            draw_();
            refr();
            p++;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Hanoi_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3";

            timer1.Interval = 300;

            Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            graphics = Graphics.FromImage(Bitmap);

            Pen = new Pen(Color.Black, 3);
        }


        private void draw_()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (box[i, j] != 0)
                    {
                        switch (box[i, j])
                        {
                            case 1:
                                solid = new SolidBrush(Color.Red);
                                break;
                            case 2:
                                solid = new SolidBrush(Color.Pink);
                                break;
                            case 3:
                                solid = new SolidBrush(Color.Yellow);
                                break;
                            case 4:
                                solid = new SolidBrush(Color.Green);
                                break;
                            case 5:
                                solid = new SolidBrush(Color.Blue);
                                break;
                            case 6:
                                solid = new SolidBrush(Color.Brown);
                                break;
                            case 7:
                                solid = new SolidBrush(Color.DarkOrange);
                                break;
                            case 8:
                                solid = new SolidBrush(Color.DarkRed);
                                break;
                        }
                        graphics.FillRectangle(solid, (i + 1) * 190 - 60 - (box[i, j]) * 10, 320 - j * 30, box[i, j] * 20, 30);
                    }
                }
            }
        }

    }
}

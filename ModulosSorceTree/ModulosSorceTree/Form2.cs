using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ModulosSorceTree
{
    public partial class Form2 : Form
    {
        Nodo N = null;
        int d = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Thread Hilo = new Thread(PintarLineas);
            if (!Hilo.IsAlive)
                Hilo.Start();
        }

        private void PintarLineas()
        {
            int W = 100;
            Graphics Gr = pictureBox1.CreateGraphics();
            Lista L = new Lista();
            int s = 0;
            while(s != 1)
            {
                L.Mov(d, L.inicio);
                Random R = new Random();
                if (N == null)
                {
                    int Nx = R.Next(19) * 10;
                    int Ny = R.Next(19) * 10;
                    N = new Nodo(Nx, Ny, -1);
                }
                if (N.x == L.inicio.x && N.y == L.inicio.y)
                {
                    int Nx = R.Next(19) * 10;
                    int Ny = R.Next(19) * 10;
                    L.Insertar(N.x, N.y, L.inicio.Direccion);
                    N = new Nodo(Nx, Ny, -1);
                    if (W < 250)
                        W = W + 10;
                }
                L.Pintar(Gr, N);
                Thread.Sleep(500-W);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d = 3;
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.GetHashCode() == Keys.Down.GetHashCode())
            {
                button1.Focus();
                d = 1;
            }
            if (e.GetHashCode() == Keys.Left.GetHashCode())
            {
                button2.Focus();
                d = 3;
            }
            if (e.GetHashCode() == Keys.Up.GetHashCode())
            {
                button3.Focus();
                d = 0;
            }
            if (e.GetHashCode() == Keys.Down.GetHashCode())
            {
                button4.Focus();
                d = 2;
            }
        }
    }
}

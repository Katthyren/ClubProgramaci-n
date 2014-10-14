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
        Lista L = new Lista();
        Nodo N = null;
        int d = 1, s = 0, P = 0, W = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Thread Hilo = new Thread(PintarLineas);
            if (!Hilo.IsAlive)
                Hilo.Start();
        }

        private void PintarLineas()
        {
            try
            {
                Graphics Gr = pictureBox1.CreateGraphics();
                while (s != 1)
                {
                    if (L.Perder())
                        s = 1;
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
                        if (W < 450)
                            W = W + 50;
                        P = P + 10;
                    }
                    L.Pintar(Gr, N);
                    Gr.DrawString((500 - W).ToString() + " ms", new Font("Arial", 10), Brushes.Blue, 0, 0);
                    Gr.DrawString(P.ToString() + " puntos", new Font("Arial", 12), Brushes.Purple, 0, 12);
                    Thread.Sleep(500 - W);
                }
            }
            catch (Exception ms)
            { }
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.Enter))
                    s = 0;
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.R))
                {
                    L.inicio = new Nodo(100, 100, L.inicio.Direccion);
                    P = W = s = 0;
                }
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.Up) && L.inicio.Direccion != 2)
                    d = 0;
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.Right) && L.inicio.Direccion != 3)
                    d = 1;
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.Down) && L.inicio.Direccion != 0)
                    d = 2;
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.Left) && L.inicio.Direccion != 1)
                    d = 3;
            }
            catch (Exception ms)
            { }
        }
    }
}

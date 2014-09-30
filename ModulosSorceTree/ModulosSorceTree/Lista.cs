using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ModulosSorceTree
{
    class Lista
    {
        public Nodo inicio;
        public Lista()
        {
            inicio = new Nodo(100, 100, 1);
        }
        public bool Perder()
        {
            Nodo p = null;
            p = inicio.liga;
            if (p != null)
            {
                while (p != null)
                {
                    if (p.x == inicio.x && p.y == inicio.y)
                        return true;
                    p = p.liga;
                }
            }
            return false;
        }
        public void Insertar(int x, int y, int d)
        {
            Nodo p = null;
            p = new Nodo(x, y, d);
            if (inicio == null)
                inicio = p;
            else
            {
                switch (d)
                {
                    case 0:
                        p.y = p.y - 10;
                        break;
                    case 1:
                        p.x = p.x + 10;
                        break;
                    case 2:
                        p.y = p.y + 10;
                        break;
                    case 3:
                        p.x = p.x - 10;
                        break;
                }
                p.liga = inicio;
                inicio = p;
            }
        }
        public void Mov(int d, Nodo p)
        {
            if (Perder())
                inicio = new Nodo(100, 100, 1);
            if (p.liga != null)
                Mov(p.Direccion, p.liga);
            switch (p.Direccion)
            {
                case 0:
                    p.y = p.y - 10;
                    break;
                case 1:
                    p.x = p.x + 10;
                    break;
                case 2:
                    p.y = p.y + 10;
                    break;
                case 3:
                    p.x = p.x - 10;
                    break;
            }
            if (p.x < 0)
                p.x = 190;
            if (p.x > 190)
                p.x = 0;
            if (p.y < 0)
                p.y = 190;
            if (p.y > 190)
                p.y = 0;
            p.Direccion = d;
        }

        public void Pintar(Graphics Gr, Nodo N)
        {
            try
            {
                Gr.Clear(Color.White);
                Pen z = new Pen(Color.Black, 0.5f);
                int k = 0;
                Nodo p = inicio;
                while (p != null)
                {
                    if (k % 2 == 0)
                        Gr.FillRectangle(Brushes.Black, new Rectangle(N.x, N.y, 10, 10));
                    else
                        Gr.FillRectangle(Brushes.Green, new Rectangle(N.x, N.y, 10, 10));
                    Gr.FillRectangle(Brushes.Black, new Rectangle(p.x, p.y, 10, 10));
                    p = p.liga;
                }
            }
            catch (Exception ms)
            {}
        }
    }
}
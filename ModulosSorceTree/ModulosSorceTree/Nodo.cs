using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModulosSorceTree
{
    class Nodo
    {
        public int x;
        public int y;
        public int Direccion;
        public Nodo liga;
        public Nodo()
        {
            x = -1;
            y = -1;
            Direccion = -1;
            liga = null;
        }
        public Nodo(int X, int Y, int D)
        {
            x = X;
            y = Y;
            Direccion = D;
            liga = null;
        }
    }
}
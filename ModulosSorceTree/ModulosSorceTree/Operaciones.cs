using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosSorceTree
{
    static class Operaciones
    {

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public static double Restar(double a, double b)
        {
            return (a - b);
        }
        /*public static double Sumar(double a, double b)
         {
           
         }
         */ public static double Dividir(double a, double b)
        {
            if (b != 0)
                return (a / b);
            else
                return 0.000;
        }
          
	public static double Exponenciar(double a, double b)
        {
	         return  math.Pow(a,b);
		//tu nana en tangas
        }                  
    }
}

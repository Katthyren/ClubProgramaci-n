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
<<<<<<< HEAD
        public static double sumar(double a, double b)
        { 
            return a + b; 
        }
       
        public static double Dividir(double a, double b)
        {
            return a / b;
        }
         
	    public static double Exponenciar(double a, double b)
=======
<<<<<<< HEAD
        /*public static double Sumar(double a, double b)
         {
           
         }
         */ public static double Dividir(double a, double b)
=======
        public double sumar(double a, double b)
        { return a + b; }
         /* public static double Dividir(double a, double b)
>>>>>>> 78c0b4da9ed5264415174feff761b90b68e57541
        {
            if (b != 0)
                return (a / b);
            else
                return 0.000;
        }
          
	public static double Exponenciar(double a, double b)
>>>>>>> 4b91f5f5f11a4a18d26fc5f5dc7101e1ec2a7316
        {
	         return  Math.Pow(a,b);
        }                  
    }
}

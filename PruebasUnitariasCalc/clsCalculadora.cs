using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasUnitariasCalc
{
   public  class clsCalculadora
    {
        public static double suma(double a, double b) {
            return a + b;
        }

        public static double resta(double a, double b)
        {
            return a - b;
        }

        public static double multiplicacion(double a, double b)
        {
            return a * b;
        }

        public static double division(double a, double b)
        {
            if (a == 0)
                return 0;
            if (b == 0)
                return -1;
           
            return a / b;
        }
    }
}

//Probar Cambios
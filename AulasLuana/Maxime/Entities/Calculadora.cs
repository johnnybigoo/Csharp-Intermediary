using System;
using System.Collections.Generic;
using System.Text;

namespace Maxime.Entities
{
    public class Calculadora //Static
    {
        //public double soma = 0;
        public static double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtrai(double n1, double n2)
        {
            return  n1 - n2;
        }
        public static double Porcentagem(double n, double p)
        {
            return (n * p) / 100;
        }
    }
}

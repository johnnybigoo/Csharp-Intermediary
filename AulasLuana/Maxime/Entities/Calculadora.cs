
using System;
using System.Collections.Generic;
using System.Text;


namespace Maxime.Entities
{
    public class Calculadora //Static
    {
        public double Soma = 0;
        public static double soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtrai(double n1, double n2)
        {
            double Subtrai = n1 - n2;
        }
        public static double porcento(double n, double p)
        {
            return (n * p) / 100;
        }
    }
}

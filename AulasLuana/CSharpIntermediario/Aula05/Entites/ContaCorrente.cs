using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediario.Aula05.Entites
{
    public class ContaCorrente : ContaBancaria
    {
        private double anuidade;

        public double Anuidade { get => anuidade; set => anuidade = value; }
    }
    /* Luana's code
    {
        public class ContaCorrente : ContaBancaria
        {
        private double anuidade;

        public double Anuidade { get => anuidade; set => anuidade = value; }

        public ContaCorrente() //default
        {

        }

        public ContaCorrente(double anuidade, string agencia, string numero, double saldo, Titular titular)
            : base(agencia, numero, saldo, titular)
        {
            this.anuidade = anuidade;
        }


     }
        
     */
}

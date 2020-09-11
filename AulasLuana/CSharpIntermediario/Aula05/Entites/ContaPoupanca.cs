using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediario.Aula05.Entites
{
    public class ContaPoupanca : ContaBancaria
    {
        private double rendimento;

        public double Rendimento { get => rendimento; set => rendimento = value; }


        public ContaPoupanca(double rendimento, string agencia, string numero, double saldo, string titular) 
            : base(agencia, numero, saldo, titular)
        {
            this.rendimento = rendimento;
        }

        /*public void test()
        {
            Saldo = 50;
            Agencia = "18290";
        }*/

        /* Luana's code
         {
    public class ContaPoupanca : ContaBancaria
    {
        private double rendimento;

        public double Rendimento { get => rendimento; set => rendimento = value; }

        public ContaPoupanca()
        {
            
        }

        public ContaPoupanca(string agencia, string numero)
            : base(agencia,  numero)
        {

        }

        public ContaPoupanca(double rendimento, string agencia, string numero, double saldo, Titular titular) 
            : base(agencia, numero, saldo, titular)
        {
            this.rendimento = rendimento;
        }

        }
            
         */
    }
}

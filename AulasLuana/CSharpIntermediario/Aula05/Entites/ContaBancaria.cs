using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediario.Aula05.Entites
{
    public class ContaBancaria
    {
        private string agencia;
        private string numero; //0233-1
        private double saldo;
        private string titular;

        public ContaBancaria(string agencia, string numero, double saldo, string titular)
        {
            this.agencia = agencia;
            this.numero = numero;
            this.saldo = saldo;
            this.titular = titular;
        }

        public string Agencia { get => agencia; set => agencia = value; }
        public string Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Titular { get => titular; set => titular = value; }

        
    }
    /* Luana's code
     {
    public abstract class ContaBancaria
    {
        protected string agencia;
        protected string numero; //0233-1
        protected double saldo;
        protected Titular titular;

        public ContaBancaria()
        {

        }

        public ContaBancaria(string agencia, string numero)
        {
            this.agencia = agencia;
            this.numero = numero;
        }

        public ContaBancaria(string agencia, string numero, double saldo, Titular titular)
        {
            this.agencia = agencia;
            this.numero = numero;
            this.saldo = saldo;
            this.titular = titular;
        }

        public string Agencia { get => agencia; set => agencia = value; }
        public string Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public Titular Titular { get => titular; set => titular = value; }

        }
    }
     */
}

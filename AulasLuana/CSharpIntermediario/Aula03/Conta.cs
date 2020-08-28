using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula03
{
    public class Conta
    {
        private double saldo = 0;
        //prop + 2x (tab)
        public string Agencia { get; set; }
        public string Numero { get; set; }
        public string Titular { get; set; }
        public string DataDeAbertura { get; }

        public Conta()
        {

        }
        public Conta(string agencia, string numero, string titular, string dataDeAbertura)
        {
            Agencia = agencia;
            Numero = numero;
            Titular = titular;
            DataDeAbertura = dataDeAbertura;
        }

        //Métodos de acesso (Getters e Setters)
        public double getSaldo()
        {
            return saldo;
        }


        public void deposita(double valor)
        {
            saldo = saldo + valor;
            //saldo += valor; 
        }

        public bool saca(double valor)
        {
            if (valor <= saldo && valor > 0)
            {
                saldo = saldo - valor;
                return true;
            }

            return false;
        }
    }
}

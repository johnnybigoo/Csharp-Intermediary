using CSharpIntermediario.Aula05.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediario.Aula05
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.Agencia = "1234-0";
            conta1.Numero = "923820-1";
            conta1.Saldo = 100.00;
            conta1.Titular = "Jones";
            conta1.Anuidade = 20.00;         

            Console.ReadKey();

           
        }

        /* Luana's code
             {
           public class Program
           {
           static void Main(string[] args)
           {
           Titular titular1 = new Titular();
           titular1.Nome = "Jones";
           titular1.Cpf = "890920293-20";

           ContaCorrente conta1 = new ContaCorrente();
           conta1.Agencia = "1293-9";
           conta1.Numero = "923820-1";
           conta1.Saldo = 100.00;
           conta1.Titular = titular1;
           conta1.Anuidade = 20.00;



           ContaPoupanca conta2 = new ContaPoupanca(10.00, "18292-9", "93820-1", 200.00, titular1);
           ContaPoupanca conta3 = new ContaPoupanca("38931-2", "738292-2");

           //ContaBancaria conta4 = new ContaBancaria();

           Console.ReadKey();
           }
               }   

            */
    }
}

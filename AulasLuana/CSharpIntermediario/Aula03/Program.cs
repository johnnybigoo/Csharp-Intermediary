using System;

namespace CursoCSharp.Aula03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta("1234", "5637-9", "Adriele", "2020-08-20");
            conta1.deposita(120);
            conta1.deposita(50);

            conta1.saca(30);
            conta1.saca(-800);
            conta1.Agencia = "3451"; //set

            Console.WriteLine("Saldo: " + conta1.getSaldo());
            Console.WriteLine("Agencia: " + conta1.Agencia); //get

            Console.ReadKey();
        }
    }
}

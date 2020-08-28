using System;

namespace CursoCSharp.Aula02._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(); //objeto
            p1.nome = "Patricia";
            p1.idade = 25;
            p1.salario = 1000;

            Pessoa p2 = new Pessoa(); //objeto
            p2.nome = "Roberto";
            p2.idade = 32;
            p2.salario = 2000;

            p1.SeApresentar(); // Eu sou Patrícia!
            //double retorno1 = p1.RetornaDezPorcentoDoSalario(); //chamada do método!
            Console.WriteLine("10 porcento do salário: " + p1.RetornaDezPorcentoDoSalario());
            double retorno2 = p1.RetornaPorcentoDoSalario(20); //chamada do método com parâmetro!
            Console.WriteLine("20 porcento do salário: " + retorno2);

            p2.SeApresentar(); // Eu sou Roberto!
            double retorno3 = p2.RetornaDezPorcentoDoSalario();
            Console.WriteLine("10 porcento do salário: " + retorno3);

            int[] valores = { 4, 6, 2 };

            int[] array = p2.PreencheArrayComTresValores(5, 2, 9);
            Console.WriteLine("Valor do array: " + array[0]);
            Console.WriteLine("Valor do array: " + array[1]);
            Console.WriteLine("Valor do array: " + array[2]);

            int[] array2 = p2.PreencheArrayComOutroArray(valores);
            Console.WriteLine("Valor do array2: " + array2[0]);
            Console.WriteLine("Valor do array2: " + array2[1]);
            Console.WriteLine("Valor do array2: " + array2[2]);

            Console.WriteLine("Soma1: " + p2.Soma(5, 4));
            Console.WriteLine("Soma2: " + p2.Soma(5, 4, 6)); //sobrecargas
            Console.WriteLine("Soma3: " + p2.Soma(5, 4, 9, 2)); //sobrecargas

            Console.ReadKey();

        }
        

        
    }
}

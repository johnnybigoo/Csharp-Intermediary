using System;

namespace Escola
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            aluno1.setNome("Maria");

            Aluno aluno2 = new Aluno();
            aluno2.setNome("Maria Maria Maria Maria Maria Maria");

            Console.WriteLine("Nome: " + aluno2.getNome());
            Console.WriteLine("Nome: " + aluno1.getNome());

            Console.ReadKey();
        }
    }
}

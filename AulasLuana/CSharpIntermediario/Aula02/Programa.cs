using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula02
{
    public class Programa //Runnable
    {
        public static void Main(string[] args)
        {
           
            Funcionario funcionario1 = new Funcionario(); //Objeto
            funcionario1.nome = "Marcos";
            funcionario1.sobrenome = "Alves Da Silva";
            funcionario1.email = "M.alvesdasilva@gmail.com";
            funcionario1.idade = 34;
            funcionario1.endereco = "rua Do Teste, n01 - Montreal";
            funcionario1.registro = "CARE2W3";
            funcionario1.cargo = "Diretor";

            Console.WriteLine("Funcionario(a)");
            funcionario1.MostraOsDadosDeFuncionarioNaTela(); //chamada do metodo
            Console.WriteLine("\n");
            funcionario1.MostraEmail();
            Console.WriteLine("\n");
            funcionario1.MostraODobroDaIdade();
            Console.WriteLine("\n");
            funcionario1.MostraNomeESobrenomeJuntos();


            Console.ReadKey();

        }
    }
}


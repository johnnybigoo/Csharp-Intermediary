using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            String nome1 = "Joao";
            String nome2 = "Maria";

            Aluno aluno1 = new Aluno();
            aluno1.nome = "Joao";
            aluno1.idade = 30;
            aluno1.email = "joao1@gmail.com";
            aluno1.endereco = "rua da esperanca, n1, Monreeal";
            aluno1.matricula = "ABCD001";

            Professor professor1 = new Professor();
            professor1.nome = "Maria";
            professor1.idade = 40;
            professor1.email = "Maria1@gmail.com";
            professor1.endereco = "rua do ensino n2, Montreal";
            professor1.disciplina = "Programacao";

            Console.WriteLine("Aluno(a)");
            aluno1.MostraOsDadosDeAlunoNaTela();
            Console.WriteLine("\n");
            Console.WriteLine("Professor(a)");
            professor1.MostraOsDadosDeProfessorNaTela();
            Console.WriteLine("\n");


            Funcionario funcionario1 = new Funcionario();
            funcionario1.nome = "Marcos";
            funcionario1.sobrenome = "Alves Da Silva";
            funcionario1.email = "M.alvesdasilva@gmail.com";
            funcionario1.idade = 34;
            funcionario1.endereco = "rua Do Teste, n01 - Montreal";
            funcionario1.registro = "CARE2W3";
            funcionario1.cargo = "Diretor";

            Console.WriteLine("Funcionario(a)");
            funcionario1.MostraOsDadosDeFuncionarioNaTela();
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

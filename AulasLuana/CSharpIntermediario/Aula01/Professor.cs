using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    public class Professor
    {
        public String nome;
        public int idade;
        public String email;
        public String endereco;
        public String disciplina;

        public void MostraOsDadosDeProfessorNaTela()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Endereco: " + endereco);
            Console.WriteLine("Disciplina: " + disciplina);
        }
    }
}

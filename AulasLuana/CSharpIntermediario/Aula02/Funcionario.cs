using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula02
{
    public class Funcionario //classe
    {
        public String nome; //atributo
        public String sobrenome;
        public String email;
        public int idade;
        public String endereco;
        public String registro;
        public String cargo;

        public void MostraOsDadosDeFuncionarioNaTela() //Metodo
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Endereco: " + endereco);
            Console.WriteLine("Numero de Registro: " + registro);
            Console.WriteLine("Cargo: " + cargo);
        }

        public void MostraEmail()
        {
            Console.WriteLine("Email: " + email);
        }
        public void MostraODobroDaIdade()
        {
            Console.WriteLine("O dobro da idade e: " + idade * 2);
        }
        public void MostraNomeESobrenomeJuntos()
        {
            Console.WriteLine("Nome completo: " + nome + " " + sobrenome);
        }
    }
}


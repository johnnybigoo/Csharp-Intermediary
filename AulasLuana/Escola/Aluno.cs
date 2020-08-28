using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    public class Aluno
    {
        private string nome;
        private double nota1, nota2;

        public string Nome { get => nome; set => nome = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }

       public string getNome()
        {
            return nome;
        }

       public void setNome(string valor)
        {
            if (valor.Length >= 30)
            {
                Console.WriteLine("O nome deve conter até 30 caracteres");
            }
            else
            {
                this.nome =  valor;
            }
        }

    }

   


}

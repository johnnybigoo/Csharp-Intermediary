using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula02._1
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double salario;
        public int[] array = new int[3];

        public void SeApresentar() //Void --> Sem retorno!
        {
            Console.WriteLine("Eu sou: " + nome);
        }
        
        public double RetornaDezPorcentoDoSalario() //o tipo que ele retorna!
        {
            //double dezPorcento = (salario * 10) / 100;
            return (salario * 10) / 100;
        }

        public double RetornaPorcentoDoSalario(double porcento) //parametro, argumento, input
        {
            double resultado = (salario * porcento) / 100;
            return resultado;
        }

        public int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Soma(int n1, int n2, int n3) // Sobrecarga
        {
            return n1 + n2 + n3;
        }
        public int Soma(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        public int[] PreencheArrayComTresValores(int n1, int n2, int n3)
        {
            // Funcionario [nome, idade, email]
            // array [0, 1, 2]
            //idade = 12
            // array = { 12, 43, 56 }

            array[0] = n1;
            array[1] = n2;
            array[2] = n3;

            return array;
        }
        public int[] PreencheArrayComOutroArray(int[] vetor)
        {
            array[0] = vetor[0];
            array[1] = vetor[1];
            array[2] = vetor[2];

            return array;
        }





    }

}


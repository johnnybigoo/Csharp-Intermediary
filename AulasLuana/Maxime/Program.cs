using Maxime.Entities;
using System;

namespace Maxime
{
    class Program
    {
        private const string V = "Joao Vicente";

        static void Main(string[] args)
        {
            Produto papel1 = new Produto();
            papel1.Codigo = "01";
            papel1.Modelo = "A4";
            papel1.Marca = "Canon";
            papel1.Valor = 10;
            papel1.ImpostoFederal = 1.2;
            papel1.ImpostoProvincial = 1.0;

            Produto papel2 = new Produto();
            papel2.Codigo = "02";
            papel2.Modelo = "A3";
            papel2.Marca = "HP";
            papel2.Valor = 15;
            papel2.ImpostoFederal = 2.3;
            papel2.ImpostoProvincial = 1.1;

            Produto papel3 = new Produto();
            papel3.Codigo = "03";
            papel3.Modelo = "A5";
            papel3.Marca = "OfficeJet";
            papel3.Valor = 11;
            papel3.ImpostoFederal = 3.1;
            papel3.ImpostoProvincial = 1.2;

            Boleto boleto = new Boleto();           
            boleto.Comprador = "Empresa Exemplo 1".ToUpper();
            
    
            Registradora registradora = new Registradora();
            registradora.addProduto(papel1);
            registradora.addProduto(papel2);
            registradora.addProduto(papel3);


            Console.WriteLine("Produto 1: " + registradora.getNomeDoProduto(papel1) + " - " + "{0:0.00} ", papel1.getPreco());
            Console.WriteLine("Produto 2: " + registradora.getNomeDoProduto(papel2) + " - " + "{0:0.00} ", papel2.getPreco());
            Console.WriteLine("Produto 3: " + registradora.getNomeDoProduto(papel3) + " - " + "{0:0.00} ", papel3.getPreco());
            Console.WriteLine("\n" + "Total a pagar: {0:0.00} ", registradora.getTotal());

            Boleto boleto = new Boleto();
            boleto.Comprador = "Empresa Exemplo 1";
            boleto.Valor = registradora.getTotal();
            boleto.Taxa = 3.2;
            boleto.aplicaDesconto(8, false);

            Console.WriteLine("Vencimento: " + boleto.getVencimento());
            Console.WriteLine("Comprador: " + boleto.Comprador);
            Console.WriteLine("Valor do Boleto: " + boleto.Valor);



        }
    }
}

/*
 * Luana's code
 using Maxime.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxime
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto papel1 = new Produto();
            papel1.Codigo = "01";
            papel1.Modelo = "A4";
            papel1.Marca = "Canon";
            papel1.Valor = 10;
            papel1.ImpostoFederal = 2.1;

            Produto papel2 = new Produto();
            papel2.Codigo = "02";
            papel2.Modelo = "A3";
            papel2.Marca = "HP";
            papel2.Valor = 15;
            papel2.ImpostoFederal = 3.2;

            Produto papel3 = new Produto();
            papel3.Codigo = "03";
            papel3.Modelo = "A5";
            papel3.Marca = "OfficeJet";
            papel3.Valor = 11;
            papel3.ImpostoFederal = 1.3;

            Registradora registradora = new Registradora();
            registradora.addProduto(papel1);
            registradora.addProduto(papel2);
            registradora.addProduto(papel3);



            Console.WriteLine("Produto 1: " + registradora.getNomeDoProduto(papel1));
            Console.WriteLine("Produto 2: " + registradora.getNomeDoProduto(papel2));
            Console.WriteLine("Produto 3: " + registradora.getNomeDoProduto(papel3));
            Console.WriteLine("Total a pagar: {0:0.00} ", registradora.getTotal());

            Console.ReadKey();

        }
    }
}
 */
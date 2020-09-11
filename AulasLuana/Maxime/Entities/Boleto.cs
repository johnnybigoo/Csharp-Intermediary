using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxime.Entities
{
    public class Boleto
    {
        private string comprador;
        private double valor;
        private DateTime vencimento;
        private double taxa = 2.00;
        private const int PRAZO = 5;

        public string Comprador { get => comprador.ToUpper(); set => comprador = value; }
        public double Valor { get => valor + taxa; set => valor = value; }
        public double Taxa { set => taxa = value; }

        //{ get => vencimento; } //Lambda
        public DateTime getVencimento()
        {
            DateTime Hoje = DateTime.Today;
            vencimento = Hoje.AddDays(PRAZO);
            {
                if (vencimento.DayOfWeek == DayOfWeek.Saturday)
                    vencimento.AddDays(2);
                else if (Hoje.DayOfWeek == DayOfWeek.Sunday)
                    vencimento.AddDays(1);
               
                return vencimento;
            }
                
        }

        //+aplicaDesconto(double, desconto, boolean porcento): Void
        public void aplicaDesconto(double desconto, bool porcentagem)
        {
            if (porcentagem && desconto > 0)
            {
                desconto = Calculadora.Porcentagem(valor, desconto);
                
            }

            valor = Calculadora.Subtrai(valor, desconto);
           
        }
    }
     
}

/* Luana's code
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxime.Entities
{
    public class Boleto
    {
        private string comprador;
        private double valor;
        private DateTime vencimeto;
        private const double TAXA = 2;
        private const int PRAZO = 5;

        public string Comprador { get => comprador; set => comprador = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime Vencimeto { get => vencimeto; set => vencimeto = value; }

        public static double TAXA1 => TAXA;

        public static int PRAZO1 => PRAZO;
    }
}
 */
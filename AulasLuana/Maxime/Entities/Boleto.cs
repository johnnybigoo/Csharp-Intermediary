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
           //if(Hoje.DayOfWeek == DayOfWeek.Saturday)
            vencimento = Hoje.AddDays(PRAZO);
            return vencimento;
        }

        //+aplicaDesconto(double, desconto, boolean porcento): Void
        public void aplicaDesconto(double desconto, bool porcento)
        {
            if(porcento  && desconto > 0)
            {
                double desc = Calculadora.porcentagem(valor , desconto)
                valor -= desc;
            }
            else{
                valor -= desconto;
            }
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
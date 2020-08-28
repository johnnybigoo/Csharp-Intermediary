using System;
using System.Collections.Generic;
using System.Text;

namespace Maxime.Entities
{
    public class Boleto
    {
        private string comprador;
        private double valor;
        private DateTime vencimento;
        private const double TAXA = 2.00;
        private int PRAZO = 5;
    }
}

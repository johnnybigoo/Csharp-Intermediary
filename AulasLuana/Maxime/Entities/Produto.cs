using System;
using System.Collections.Generic;
using System.Text;

namespace Maxime.Entities
{
    public class Produto
    {
        private string codigo, modelo, marca;
        private double impostoFederal, valor;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public double ImpostoFederal { get => impostoFederal; set => impostoFederal = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}

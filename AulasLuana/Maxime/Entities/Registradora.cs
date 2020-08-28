﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Maxime.Entities
{
    public class Registradora
    {
        private double total;

        public void addProduto(Produto produto)
        {
            total += produto.Valor + produto.ImpostoFederal;
        }

        public double getTotal()
        {
            return total;
        }

        public string getNomeDoProduto(Produto produto)
        {
            //código/modelo – marca
            return produto.Codigo + " / " + produto.Modelo + " - " + produto.Marca;
        }
    }
}

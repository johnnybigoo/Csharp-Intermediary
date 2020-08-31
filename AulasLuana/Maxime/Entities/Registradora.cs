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
        public string getNomeDoComprador(Boleto boleto)
        {
            /*comprador
            -----------------------
            */
            return boleto.Comprador + "\n" + "-----------------------" + "\n";
        }
        public string getNomeDoProduto(Produto produto)
        {
            //código/modelo – marca
            
            return produto.Codigo + " / " + produto.Modelo + " - " + produto.Marca;
        }

        
    }
}

/* Luana's code
 * 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxime.Entities
{
    public class Registradora
    {
        private double total;

        public void addProduto(Produto produto)
        {
            total = total + produto.Valor + produto.ImpostoFederal;
        }

        public double getTotal()
        {
            return total;
        }

        public string getNomeDoProduto(Produto produto)
        {
            //código/modelo – marca
            return produto.Codigo + "/" + produto.Modelo + " - " + produto.Marca;
        }
    }
}
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras
{
    public class Itens
    {
        public String item;
        public int quantidade;
        public int preco;

        public Itens(String item, int quantidade, int preco)
        {
            this.item       = item;
            this.quantidade = quantidade;
            this.preco      = preco;
        }
    }
}

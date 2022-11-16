using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppautomovel3.Models
{
    public class Carrinho
    {
        List<Item> itens;
        public Carrinho()
        {
            itens = new List<Item>();
        }

        public List<Item> Itens
        {
            get { return itens; }
            set { itens = value; }
        }
        Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public void AddItem(Item item)
        {
            bool existe = false;
            foreach(Item it in Itens)
            {
                if(it.Automovel.IdAutomovel==item.Automovel.IdAutomovel)
                {
                    it.Quantidade++;
                    existe = true;
                }
            }
            if(!existe)
            {
                Itens.Add(item);
            }
        }

        public decimal? TotalCarrinho 
        {
            get
            {
                decimal? soma = 0;
                foreach (Item it in itens)
                {
                    soma = it.Quantidade * it.ValorUnitario + soma;
                }
                return soma;
            }
        }


    }
}
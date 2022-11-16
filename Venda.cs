using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppautomovel3.Models
{
    public class Venda
    {
        int idVenda;

        [Key]
        public int IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }
        Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        DateTime dataVenda;

        public DateTime DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }
        List<Item> itensVenda;

        public List<Item> ItensVenda
        {
            get { return itensVenda; }
            set { itensVenda = value; }
        }
    }
}
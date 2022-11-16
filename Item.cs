using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WebAppautomovel3.Models
{
    [Table ("Itens")]
    public class Item
    {
        int idItem;
        [Key]
        public int IdItem
        {
            get { return idItem; }
            set { idItem = value; }
        }
        Automovel automovel;

        public Automovel Automovel
        {
            get { return automovel; }
            set { automovel = value; }
        }
        int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        decimal? valorUnitario;


        public decimal? ValorUnitario
        {
            get { return valorUnitario; }
            set { valorUnitario = value; }
        }

    }
}

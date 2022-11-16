using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppautomovel3.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        int idCliente;
        [Key]
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        string nome;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

    }
}
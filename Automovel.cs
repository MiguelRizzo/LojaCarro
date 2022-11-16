using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppautomovel3.Models
{
    [Table("Automoveis")]
    public class Automovel
    {

        int idAutomovel;
        [Key]

        public int IdAutomovel
        {
            get { return idAutomovel; }
            set { idAutomovel = value; }
        }
        string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        string serie;

        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }
        string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        int ano;

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        string motor;

        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }
        string foto;

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        decimal? valor;

        public decimal? Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
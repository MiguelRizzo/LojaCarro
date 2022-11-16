namespace WebAppautomovel3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAppautomovel3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppautomovel3.Models.ModelBDAutomovel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppautomovel3.Models.ModelBDAutomovel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Automoveis.AddOrUpdate
                (
                a=>a.IdAutomovel,
                    new Automovel
                    {
                        Modelo = "Lexus",Ano = 2016,Cor = "Vermelho",Serie = "Lc 500",Valor = 346990,
                        Foto = @"https://qcveiculos.com.br/wp-content/uploads/2017/11/Lexus-LC-500-2017.jpg"
                    }
                );
        }
    }
}

namespace WebAppautomovel3.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelBDAutomovel : DbContext
    {
        // Your context has been configured to use a 'ModelBDAutomovel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebAppautomovel3.Models.ModelBDAutomovel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelBDAutomovel' 
        // connection string in the application configuration file.
        public ModelBDAutomovel()
            : base("name=ModelBDAutomovel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Automovel> Automoveis { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }
        public virtual DbSet<Item> Itens { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}


}
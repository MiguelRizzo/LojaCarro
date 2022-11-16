namespace WebAppautomovel3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Itens",
                c => new
                    {
                        IdItem = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Automovel_IdAutomovel = c.Int(),
                        Venda_IdVenda = c.Int(),
                    })
                .PrimaryKey(t => t.IdItem)
                .ForeignKey("dbo.Automoveis", t => t.Automovel_IdAutomovel)
                .ForeignKey("dbo.Vendas", t => t.Venda_IdVenda)
                .Index(t => t.Automovel_IdAutomovel)
                .Index(t => t.Venda_IdVenda);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        IdVenda = c.Int(nullable: false, identity: true),
                        DataVenda = c.DateTime(nullable: false),
                        Cliente_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.IdVenda)
                .ForeignKey("dbo.Clientes", t => t.Cliente_IdCliente)
                .Index(t => t.Cliente_IdCliente);
            
            AddColumn("dbo.Automoveis", "Valor", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Itens", "Venda_IdVenda", "dbo.Vendas");
            DropForeignKey("dbo.Vendas", "Cliente_IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Itens", "Automovel_IdAutomovel", "dbo.Automoveis");
            DropIndex("dbo.Vendas", new[] { "Cliente_IdCliente" });
            DropIndex("dbo.Itens", new[] { "Venda_IdVenda" });
            DropIndex("dbo.Itens", new[] { "Automovel_IdAutomovel" });
            DropColumn("dbo.Automoveis", "Valor");
            DropTable("dbo.Vendas");
            DropTable("dbo.Itens");
            DropTable("dbo.Clientes");
        }
    }
}

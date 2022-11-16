namespace WebAppautomovel3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Automoveis",
                c => new
                    {
                        IdAutomovel = c.Int(nullable: false, identity: true),
                        Modelo = c.String(),
                        Serie = c.String(),
                        Cor = c.String(),
                        Ano = c.Int(nullable: false),
                        Motor = c.String(),
                        Foto = c.String(),
                    })
                .PrimaryKey(t => t.IdAutomovel);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Automoveis");
        }
    }
}

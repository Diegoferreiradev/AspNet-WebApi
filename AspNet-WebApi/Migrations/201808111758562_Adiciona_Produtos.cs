namespace AspNet_WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adiciona_Produtos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Marca = c.String(nullable: false, maxLength: 100),
                        Modelo = c.String(nullable: false, maxLength: 100),
                        Cor = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 2300),
                        numero_de_serie = c.String(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.produtos");
        }
    }
}

namespace floreria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialFloreria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        dni = c.Int(nullable: false),
                        nombre = c.String(nullable: false, maxLength: 50),
                        direccion = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Devolucions",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        importeaDevolver = c.Int(nullable: false),
                        motivo = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Id)
                .ForeignKey("dbo.PedidoCabs", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PedidoCabs",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Id)
                .ForeignKey("dbo.PedidoDetalles", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PedidoDetalles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        flor = c.String(maxLength: 50),
                        cantidad = c.Int(nullable: false),
                        importe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Flors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 50),
                        precio = c.Int(nullable: false),
                        especie = c.String(maxLength: 50),
                        stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pagoes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        importeTotal = c.Int(nullable: false),
                        tipoPago = c.String(maxLength: 50),
                        tipoEnvio = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PedidoCabs", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pagoes", "Id", "dbo.PedidoCabs");
            DropForeignKey("dbo.Devolucions", "Id", "dbo.PedidoCabs");
            DropForeignKey("dbo.PedidoCabs", "Id", "dbo.PedidoDetalles");
            DropForeignKey("dbo.PedidoCabs", "Id", "dbo.Clientes");
            DropForeignKey("dbo.Devolucions", "Id", "dbo.Clientes");
            DropIndex("dbo.Pagoes", new[] { "Id" });
            DropIndex("dbo.PedidoCabs", new[] { "Id" });
            DropIndex("dbo.Devolucions", new[] { "Id" });
            DropTable("dbo.Pagoes");
            DropTable("dbo.Flors");
            DropTable("dbo.PedidoDetalles");
            DropTable("dbo.PedidoCabs");
            DropTable("dbo.Devolucions");
            DropTable("dbo.Clientes");
        }
    }
}

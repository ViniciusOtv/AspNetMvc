namespace LojaVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtoes", newName: "Produtos");
            CreateTable(
                "dbo.PedidoItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        PrecoUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PedidoId = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtos", t => t.ProdutoId, cascadeDelete: true)
                .ForeignKey("dbo.Pedidos", t => t.PedidoId, cascadeDelete: true)
                .Index(t => t.PedidoId)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PedidoItem", "PedidoId", "dbo.Pedidos");
            DropForeignKey("dbo.PedidoItem", "ProdutoId", "dbo.Produtos");
            DropIndex("dbo.PedidoItem", new[] { "ProdutoId" });
            DropIndex("dbo.PedidoItem", new[] { "PedidoId" });
            DropTable("dbo.Pedidos");
            DropTable("dbo.PedidoItem");
            RenameTable(name: "dbo.Produtos", newName: "Produtoes");
        }
    }
}

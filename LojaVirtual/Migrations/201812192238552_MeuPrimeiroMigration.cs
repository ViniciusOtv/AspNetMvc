namespace LojaVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeuPrimeiroMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PedidoItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        PrecoUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProdutoId = c.Int(nullable: false),
                        Pedido_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtos", t => t.ProdutoId, cascadeDelete: true)
                .ForeignKey("dbo.Pedidos", t => t.Pedido_Id)
                .Index(t => t.ProdutoId)
                .Index(t => t.Pedido_Id);
            
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
            DropForeignKey("dbo.PedidoItem", "Pedido_Id", "dbo.Pedidos");
            DropForeignKey("dbo.PedidoItem", "ProdutoId", "dbo.Produtos");
            DropIndex("dbo.PedidoItem", new[] { "Pedido_Id" });
            DropIndex("dbo.PedidoItem", new[] { "ProdutoId" });
            DropTable("dbo.Pedidos");
            DropTable("dbo.PedidoItem");
        }
    }
}

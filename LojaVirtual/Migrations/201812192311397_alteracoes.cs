namespace LojaVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracoes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PedidoItem", "Pedido_Id", "dbo.Pedidos");
            DropIndex("dbo.PedidoItem", new[] { "Pedido_Id" });
            RenameColumn(table: "dbo.PedidoItem", name: "Pedido_Id", newName: "PedidoId");
            AlterColumn("dbo.PedidoItem", "PedidoId", c => c.Int(nullable: false));
            CreateIndex("dbo.PedidoItem", "PedidoId");
            AddForeignKey("dbo.PedidoItem", "PedidoId", "dbo.Pedidos", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PedidoItem", "PedidoId", "dbo.Pedidos");
            DropIndex("dbo.PedidoItem", new[] { "PedidoId" });
            AlterColumn("dbo.PedidoItem", "PedidoId", c => c.Int());
            RenameColumn(table: "dbo.PedidoItem", name: "PedidoId", newName: "Pedido_Id");
            CreateIndex("dbo.PedidoItem", "Pedido_Id");
            AddForeignKey("dbo.PedidoItem", "Pedido_Id", "dbo.Pedidos", "Id");
        }
    }
}

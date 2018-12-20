using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LojaVirtual.Models;


namespace LojaVirtual.DAL
{
    public class Database : DbContext
    {
        public IDbSet<Produto> Produtos { get; set; }
        public IDbSet<Categoria> Categorias { get; set; }
        public IDbSet<Pedido> Pedidos { get; set; }
        public IDbSet<ItemPedido> ItemPedidos { get; set; }

         static private string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EcommerceDb; Integrated Security=true;";
        }

        public Database() : base(GetConnectionString())
        {
            GetConnectionString();
        }
    }
}
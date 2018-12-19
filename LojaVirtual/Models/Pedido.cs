using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public StatusPedido Status { get; set; }

        public virtual List<ItemPedido> Itens { get; set;}

        public decimal PrecoTotal
            => Itens.Sum(i => i.PrecoTotal);

        public Pedido(){}

        public Pedido(List<ItemPedido> items)
        {
            Date = DateTime.Now;
            Status = StatusPedido.AguardandoPagamento;
            items = Itens;

        }
    }

    public enum StatusPedido
    {
        AguardandoPagamento = 1,
        SeparandoPedido = 2,
        ACaminho = 3,
        ProdutoEntregue = 4
    }
}
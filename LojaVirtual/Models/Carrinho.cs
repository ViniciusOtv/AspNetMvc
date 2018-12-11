using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    public class Carrinho
    {
        private Dictionary<int, CarrinhoItem> Itens;

        public Carrinho()
        {
            Itens = new Dictionary<int, CarrinhoItem>();
        }

        public void Add(Produto produto)
        {
            if (Itens.ContainsKey(produto.Id))
            {
                Itens[produto.Id].Quantidade++;
            }
            else
            {
                var carrinhoItem = new CarrinhoItem(produto.Id,
                    produto.Nome,
                    produto.Preco);

                Itens.Add(produto.Id, carrinhoItem);
            }
        }
    }
}
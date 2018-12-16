using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    public class CarrinhoItem
    {
        public int IdProduto { get; set; }

        public string Nome { get; set; }

        public decimal PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

        public CarrinhoItem(int idProduto, 
            string nome, 
            decimal preco,
            int qnd = 1)
        {
            IdProduto = idProduto;
            Nome = nome;
            PrecoUnitario = preco;
            Quantidade = qnd;
        }

        public decimal PrecoTotal
             => PrecoUnitario * Quantidade;
    }
}
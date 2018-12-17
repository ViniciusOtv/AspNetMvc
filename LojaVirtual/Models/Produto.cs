using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    public class Produto
    {
        static Random _random = new Random(); 

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Imagem { get; set; }

        public string Descricao { get; set; }

        public int Id { get; set; }

        public int CategoriaId { get; set; }

        public Produto(string nome, int id, string img, int categoriaId)
        {
            Id = id;
            Nome = nome;
            Preco = _random.Next(10, 100) + (decimal)_random.NextDouble();
            Descricao = "Descrição - " + Nome;
            Imagem = "/Imagens/" + img;
            CategoriaId = categoriaId;
        }

    }
}
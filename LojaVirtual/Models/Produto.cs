using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    public class Produto
    { 
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Imagem { get; set; }

        public string Descricao { get; set; }

        public int Id { get; set; }

        public int CategoriaId { get; set; }

    }
}
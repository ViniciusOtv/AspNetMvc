using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    public class HomeIndexViewModel
    {
        public Produto[] Produtos { get; set; }

        public Categoria[] Categorias { get; set; }

        //public string NomeCategoria(Produto produto)
        //{

        //    foreach (Categoria item in Categorias)
        //    {
        //        if (item.Id == produto.CategoriaId)
        //        {

        //            return item.Nome;

        //        }
        //    }
        //    return "Categoria não existente";


        //}
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    public class HomeIndexViewModel
    {
        public Produto[] Produtos { get; set; }

        public Categoria[] Categorias { get; set; }

        public int? CategoriaSelecionada { get; set; }

    }
}
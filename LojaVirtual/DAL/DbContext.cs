using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaVirtual.Models;
using System.Linq;

namespace LojaVirtual.DAL
{
    public class DbContext
    {

        static Produto[] _produtos;
        static Categoria[] _categorias;

        public Produto[] GetProdutos()
        {
            if (_produtos == null)
            {
                _produtos = new Models.Produto[]
                {
                   new Models.Produto("Celular Samsung", 1, "CelularSamsung.png", 1),
                   new Models.Produto("TV Led", 2, "tv.png", 2),
                   new Models.Produto("IPhone", 3, "IPhone.jpg", 1),
                   new Models.Produto("Fritadeira", 4, "Fritadeira.jpg", 3),
                   new Models.Produto("Beats", 4, "Beats.jpg", 3),
                   new Models.Produto("Geladeira", 4, "Geladeira.jpg", 3),
                   new Models.Produto("SmartTv", 4, "tv.jpg", 3),
                };
            }

            return _produtos;
        }

        public Produto GetProdutoPorId(int id)
        {
            var TodososProdutos = GetProdutos();

            return TodososProdutos.First(item => item.Id == id);
        }

        public Categoria[] GetCategorias()
        {
            if (_categorias == null)
            {
                _categorias = new Models.Categoria[]
                {
                    new Categoria(1, "SmartPhones"),
                    new Categoria(2, "Smart Tv"),
                    new Categoria(3, "Eletro Eletrônico"),
                };
            }
            return _categorias;
        }
    }
}
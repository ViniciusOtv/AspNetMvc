using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(int? id)
        {
            var model = new Models.HomeIndexViewModel();

            model.CategoriaSelecionada = id;
            model.Produtos = _dbc.GetProdutos();
            model.Categorias = _dbc.GetCategorias();

            if (id != null)
            {
                model.Produtos = model.Produtos
                    .Where(p => p.CategoriaId == id)
                    .ToArray();
            }
            return View(model);
        }

        public ActionResult AddItem(int id, int? categoria)
        {
            var produto = _dbc.GetProdutoPorId(id);
            var carrinho = GetCarrinho();

            carrinho.Add(produto);

            return RedirectToAction("Index", new { categoria });
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
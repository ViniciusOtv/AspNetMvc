using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class CheckoutController : BaseController
    {
        public ActionResult Index()
        {
            var model = new CheckoutIndexModel();
            model.Carrinho = GetCarrinho();

            return View(viewName: "Index",
               model: model);
        }

        public ActionResult Continuar()
        {
            return View();
        }
        public ActionResult Incrementa(int id)
        {
            var carrinho = GetCarrinho();
            carrinho.Incrementa(id);

            return RedirectToAction("Index");
        }

        public ActionResult Decrementa(int id)
        {
            var carrinho = GetCarrinho();
            carrinho.Decrementa(id);

            return RedirectToAction("Index");
        }

        public ActionResult Deleta(int id)
        {
            var carrinho = GetCarrinho();
            carrinho.Delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult Limpar()
        {
            var carrinho = GetCarrinho();
            carrinho.Limpar();

            return RedirectToAction(
                actionName: "Index",
                controllerName: "Home");
        }
    }
}

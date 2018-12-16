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
            model.Produtos = new Models.Produto[]
            {
                new Models.Produto("Celular Samsung", 1, "CelularSamsung.png", 1),
                new Models.Produto("TV Led", 2, "tv.png", 2),
                new Models.Produto("IPhone", 3, "IPhone.jpg", 1),
                new Models.Produto("Fritadeira", 4, "Fritadeira.jpg", 3),
                new Models.Produto("Beats", 4, "Beats.jpg", 3),
                new Models.Produto("Geladeira", 4, "Geladeira.jpg", 3),
                new Models.Produto("SmartTv", 4, "tv.jpg", 3),
            };

            return View(model);
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
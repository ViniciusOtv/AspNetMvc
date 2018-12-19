using LojaVirtual.DAL;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class BaseController : Controller
    {
        protected Database _dbc = new Database();


        protected override void OnActionExecuting(
            ActionExecutingContext filterContext)
        {
            ViewBag.Carrinho = GetCarrinho();

            base.OnActionExecuting(filterContext);

            //ViewBag.Categoria = new Categoria[]
            //{
            //    new Categoria(1, "SmartPhones"),
            //    new Categoria(2, "Smart Tv"),
            //    new Categoria(3, "Eletro Eletrônico"),
            //};
        }

        public Carrinho GetCarrinho()
        {
            if (Session["carrinho"] == null)
            {
                Session["carrinho"] = new Carrinho();
            }
            return (Carrinho)Session["carrinho"];
        }
    }
}
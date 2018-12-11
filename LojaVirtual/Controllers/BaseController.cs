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
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.Categoria = new Categoria[]
            {
                new Categoria(1, "SmartPhones"),
                new Categoria(2, "Smart Tv"),
                new Categoria(3, "Eletro Eletrônico"),
            };
                
            base.OnActionExecuting(filterContext);
        }
    }
}
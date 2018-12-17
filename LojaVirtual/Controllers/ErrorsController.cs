using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class ErrorsController : Controller
    {
        public ActionResult InternalServerError()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

    }
}
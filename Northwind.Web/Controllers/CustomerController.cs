using System.Web.Mvc;

namespace Northwind.Web.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
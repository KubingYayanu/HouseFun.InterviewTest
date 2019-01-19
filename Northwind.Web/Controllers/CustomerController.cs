using Northwind.Service;
using System.Web.Mvc;

namespace Northwind.Web.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController()
        {
            this.customerService = new CustomerService();
        }

        private ICustomerService customerService { get; }
        
        public ActionResult Index()
        {
            var customers = customerService.GetCustomers();
            return View(customers);
        }
    }
}
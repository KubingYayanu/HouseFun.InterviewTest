using Northwind.Service;
using System.Web.Http;

namespace Northwind.Web.Controllers.Api
{
    public class CustomerController : ApiController
    {
        public CustomerController()
        {
            this.customerService = new CustomerService();
        }

        private ICustomerService customerService { get; }

        [HttpGet]
        public IHttpActionResult GetCustomers()
        {
            var result = customerService.GetCustomers();
            return Ok(result);
        }
    }
}
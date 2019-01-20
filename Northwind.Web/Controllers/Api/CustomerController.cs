using Northwind.Service;
using Northwind.Service.Dtos;
using System.Net;
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

        [HttpGet]
        public IHttpActionResult GetCustomer(string id)
        {
            var result = customerService.GetCustomer(id);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customer)
        {
            var result = customerService.AddCustomer(customer);

            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost]
        public IHttpActionResult UpdateCustomer(CustomerDto customer)
        {
            var result = customerService.UpdateCustomer(customer);

            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost]
        public IHttpActionResult DeleteCustomer(string id)
        {
            var result = customerService.DeleteCustomer(id);

            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
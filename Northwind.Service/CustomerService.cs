using AutoMapper;
using Northwind.Entity.Models;
using Northwind.Service.Dtos;
using Notrhwind.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.Service
{
    public class CustomerService : ICustomerService
    {
        public CustomerService()
        {
            this.customerRepository = new CustomerRepository();
        }

        private ICustomerRepository customerRepository { get; }

        public Customer GetCustomer(string id) => customerRepository.GetAll().FirstOrDefault(x => x.CustomerID == id);

        public List<CustomerDto> GetCustomers()
        {
            var result = customerRepository.GetAll().ToList();

            return Mapper.Map<List<CustomerDto>>(result);
        }

        public bool AddCustomer(CustomerDto customer)
        {
            try
            {
                var newCustomer = new Customer();
                Mapper.Map(customer, newCustomer);
                customerRepository.Add(newCustomer);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteCustomer(string id)
        {
            try
            {
                var customer = customerRepository.GetAll().FirstOrDefault(x => x.CustomerID == id);

                customerRepository.Delete(customer);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateCustomer(CustomerDto customer)
        {
            try
            {
                var customerInDB = GetCustomer(customer.CustomerID);
                if (customerInDB == null)
                {
                    return false;
                }

                Mapper.Map(customer, customerInDB);
                customerRepository.Update(customerInDB);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
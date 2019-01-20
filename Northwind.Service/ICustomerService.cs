﻿using Northwind.Entity.Models;
using Northwind.Service.Dtos;
using System.Collections.Generic;

namespace Northwind.Service
{
    public interface ICustomerService
    {
        Customer GetCustomer(string id);

        List<CustomerDto> GetCustomers();

        bool AddCustomer(Customer customer);

        bool DeleteCustomer(string id);

        bool UpdateCustomer(Customer customer);
    }
}
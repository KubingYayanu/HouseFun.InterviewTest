using AutoMapper;
using Northwind.Entity.Models;
using Northwind.Service.Dtos;

namespace Northwind.Service.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() : base()
        {
            CreateMap<Customer, CustomerDto>();
        }
    }
}
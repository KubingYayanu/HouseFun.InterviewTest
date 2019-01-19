using Northwind.Entity;
using Northwind.Entity.Models;

namespace Notrhwind.Repository
{
    public class CustomerRepository : RepositoryBase<NorthwindContext, Customer>, ICustomerRepository
    {
    }
}
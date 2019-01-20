using AutoMapper;
using Northwind.Service.Mappings;

namespace Northwind.Service
{
    public class MapperConfigurationFactory
    {
        public static void CreateConfiguration()
        {
            Mapper.Initialize(c => c.AddProfile<CustomerProfile>());
        }
    }
}
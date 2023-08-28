using AutoMapper;
using Ecommerce.Model.EcommerceDbModels;
using Ecommerce.Model.EcommerceDtos.Customer;

namespace Ecommerce.Configurations.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer,CustomerListDto>();
            CreateMap<CustomerAddDto,Customer>();
            CreateMap<CustomerUpdateorDeleteDto,Customer>();
        }
    }
}

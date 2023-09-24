using AutoMapper;
using Ecommerce.Model.EcommerceDbModels;
using Ecommerce.Model.EcommerceDtos.Customer;

namespace Ecommerce.Configurations.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer,CustomerListDto>()
                .ForMember(des=> des.CustomerId,o=> o.MapFrom(s=>s.Id));
            CreateMap<CustomerAddDto,Customer>();
            CreateMap<CustomerUpdateorDeleteDto,Customer>();
        }
    }
}

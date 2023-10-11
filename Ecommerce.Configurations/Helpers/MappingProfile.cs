using AutoMapper;
using Ecommerce.Model.EcommerceDbModels;
using Ecommerce.Model.EcommerceDtos.Cart;
using Ecommerce.Model.EcommerceDtos.Customer;
using Ecommerce.Model.EcommerceDtos.Product;

namespace Ecommerce.Configurations.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerListDto>()
                .ForMember(des => des.CustomerId, o => o.MapFrom(s => s.Id));
            CreateMap<CustomerAddDto, Customer>();
            CreateMap<CustomerUpdateorDeleteDto, Customer>();

            CreateMap<Product, ProductListDto>();
            CreateMap<ProductAddDto, Product>();
            CreateMap<ProductUpdateOrDeleteDto, Product>();

            CreateMap<CartAddDto, Cart>();
        }
    }
}

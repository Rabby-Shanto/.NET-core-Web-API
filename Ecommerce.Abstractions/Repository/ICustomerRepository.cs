using Ecommerce.Abstractions.Repository.Base;
using Ecommerce.Model.EcommerceDbModels;

namespace Ecommerce.Abstractions.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<List<Customer>> GetListOfCustomer(List<int> id);
    }
}

using Ecommerce.Abstractions.BLL.Base;
using Ecommerce.Model.EcommerceDbModels;

namespace Ecommerce.Abstractions.BLL
{
    public interface ICustomer : IManager<Customer>
    {
        Task<List<Customer>> GetListOfCustomer(List<int> id);
        Task<ICollection<Customer>> GetFilterdCustomers(string name);

    }
}

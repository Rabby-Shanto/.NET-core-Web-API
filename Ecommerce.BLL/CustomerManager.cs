using Ecommerce.Abstractions.BLL;
using Ecommerce.Abstractions.Repository;
using Ecommerce.BLL.Base;
using Ecommerce.Model.EcommerceDbModels;

namespace Ecommerce.BLL
{
    public class CustomerManager : Manager<Customer>,ICustomer
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<ICollection<Customer>> GetFilterdCustomers(string name)
        {
            return await _customerRepository.GetFilterdCustomers(name);
        }

        public async Task<List<Customer>> GetListOfCustomer(List<int> id)
        {
            return await _customerRepository.GetListOfCustomer(id);
        }



    }
}

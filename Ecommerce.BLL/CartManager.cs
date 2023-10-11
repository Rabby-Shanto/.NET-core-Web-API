using Ecommerce.Abstractions.BLL;
using Ecommerce.Abstractions.Repository;
using Ecommerce.BLL.Base;
using Ecommerce.Model.EcommerceDbModels;

namespace Ecommerce.BLL
{
    public class CartManager : Manager<Cart>, ICart
    {
        private readonly ICartRepository _repository;
        public CartManager(ICartRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }

}
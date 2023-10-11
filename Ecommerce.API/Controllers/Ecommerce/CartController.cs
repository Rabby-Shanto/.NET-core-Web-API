using AutoMapper;
using Ecommerce.Abstractions.BLL;
using Ecommerce.Model.EcommerceDbModels;
using Ecommerce.Model.EcommerceDtos.Cart;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers.Ecommerce
{


    public class CartController : BaseApiController
    {
        private readonly ICart _cart;
        private readonly IMapper _mapper;

        public CartController(ICart cart, IMapper mapper)
        {
            _cart = cart;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddCart([FromBody] CartAddDto cart)
        {
            var mapper = _mapper.Map<Cart>(cart);
            var request = await _cart.AddAsync(mapper);
            return Ok(request);
        }

    }
}
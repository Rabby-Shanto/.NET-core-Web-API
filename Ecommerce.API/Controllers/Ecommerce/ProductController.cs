using AutoMapper;
using Ecommerce.Abstractions.BLL;
using Ecommerce.BLL;
using Ecommerce.Model.EcommerceDbModels;
using Ecommerce.Model.EcommerceDtos.Product;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers.Ecommerce
{
    public class ProductController : BaseApiController
    {
        private readonly IProduct _product;
        private readonly IMapper _mapper;

        public ProductController(IProduct product,IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductListDto>>> GetProducts()
        {
            var products = await _product.GetAllAsync();
            var mapper = _mapper.Map<List<ProductListDto>>(products);
            return Ok(mapper);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _product.GetByIdAsync(id);
            return Ok(product);

        }
        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] ProductAddDto product)
        {
            var mapper = _mapper.Map<Product>(product);
            var request = await _product.AddAsync(mapper);
            return Ok(request);
        }
        [HttpPut]
        public async Task<IActionResult> PutProduct([FromBody] ProductUpdateOrDeleteDto product)
        {
            var mapper = _mapper.Map<Product>(product);
            var request = await _product.UpdateAsync(mapper);
            return Ok(request);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct([FromBody] ProductUpdateOrDeleteDto product)
        {
            var mapper = _mapper.Map<Product>(product);
            var request = await _product.DeleteAsync(mapper);
            return Ok(request);
        }
        [HttpGet("search-product")]
        public async Task<IActionResult> GetAll(string name)
        {
            try
            {
                var products = await _product.GetFilterdProducts(name);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

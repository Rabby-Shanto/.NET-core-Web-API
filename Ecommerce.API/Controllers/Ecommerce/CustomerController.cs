using AutoMapper;
using Ecommerce.Abstractions.BLL;
using Ecommerce.Model.EcommerceDbModels;
using Ecommerce.Model.EcommerceDtos.Customer;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers.Ecommerce
{
    public class CustomerController : BaseApiController
    {
        private readonly ICustomer _customermanager;
        private readonly IMapper _mapper;

        public CustomerController(ICustomer customermanager, IMapper mapper)
        {
            _customermanager = customermanager;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<CustomerListDto>>> GetCustomers()
        {
            var customers = await _customermanager.GetAllAsync();
            var mapper = _mapper.Map<List<CustomerListDto>>(customers);
            return Ok(mapper);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult>GetCustomerById(int id)
        {
            var customer = await _customermanager.GetByIdAsync(id);
            return Ok(customer);
            
        }
        [HttpPost]
        public async Task<IActionResult> PostCustomer([FromBody] CustomerAddDto customer)
        {
            var mapper = _mapper.Map<Customer>(customer);
            var request = await _customermanager.AddAsync(mapper);
            return Ok(request);
        }
        [HttpPut]
        public async Task<IActionResult> PutCustomer([FromBody] CustomerUpdateorDeleteDto customer)
        {
            var mapper = _mapper.Map<Customer>(customer);
            var request = await _customermanager.UpdateAsync(mapper);
            return Ok(request);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCutomer([FromBody] CustomerUpdateorDeleteDto customer)
        {
            var mapper = _mapper.Map<Customer>(customer);
            var request = await _customermanager.DeleteAsync(mapper);
            return Ok(request);
        }
    }
}

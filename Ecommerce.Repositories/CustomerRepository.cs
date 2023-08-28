using Ecommerce.Abstractions.Repository;
using Ecommerce.Database.EcommerceDb;
using Ecommerce.Model.EcommerceDbModels;
using Ecommerce.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repositories
{
    public class CustomerRepository : EfRepository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext _db;

        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<List<Customer>> GetListOfCustomer(List<int> id)
        {
            return await _db.Customers.AsNoTracking().Where(x => id.Contains(x.Id)).ToListAsync();
        }

    }
}

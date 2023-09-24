﻿using Ecommerce.Abstractions.Repository;
using Ecommerce.Database.EcommerceDb;
using Ecommerce.Model.EcommerceDbModels;
using Ecommerce.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repositories
{
    public class ProductRepository : EfRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<List<Product>> GetListofProducts(List<int> id)
        {
            return await _db.Products.AsNoTracking().Where(x => id.Contains(x.Id)).ToListAsync();
        }
    }
}

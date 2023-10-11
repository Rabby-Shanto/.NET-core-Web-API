using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Abstractions.Repository;
using Ecommerce.Database.EcommerceDb;
using Ecommerce.Model.EcommerceDbModels;
using Ecommerce.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repositories
{
    public class CartRepository : EfRepository<Cart>, ICartRepository
    {
        private readonly ApplicationDbContext _db;
        public CartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
using Ecommerce.Abstractions.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repositories.Base
{
    public abstract class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _db;

        public EfRepository(DbContext db)
        {
            _db = db;
        }

        public virtual async Task<bool> AddAllAsync(List<T> entities)
        {
            _db.Set<T>().AddRange(entities);
            return await _db.SaveChangesAsync() > 0;
        }

        public virtual async Task<bool> AddAsync(T entity)
        {
            _db.Set<T>().Add(entity);
            return await _db.SaveChangesAsync() > 0;
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            return await _db.SaveChangesAsync() > 0;
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
            
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return await _db.SaveChangesAsync() >= 0;
        }
    }
}

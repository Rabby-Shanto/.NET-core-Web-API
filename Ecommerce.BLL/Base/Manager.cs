using Ecommerce.Abstractions.BLL.Base;
using Ecommerce.Abstractions.Repository.Base;
namespace Ecommerce.BLL.Base
{
    public abstract class Manager<T> : IManager<T> where T : class
    {
        private readonly IRepository<T> _repository;
        public Manager(IRepository<T> repository)
        {
            _repository = repository;

        }

        public async Task<bool> AddAllAsync(List<T> entities)
        {
            return await _repository.AddAllAsync(entities);
        }

        public async Task<bool> AddAsync(T entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}

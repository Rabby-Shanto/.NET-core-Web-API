namespace Ecommerce.Abstractions.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddAllAsync(List<T> entities);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}

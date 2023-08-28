namespace Ecommerce.Abstractions.BLL.Base
{
    public interface IManager<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddAllAsync(List<T> entities);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}

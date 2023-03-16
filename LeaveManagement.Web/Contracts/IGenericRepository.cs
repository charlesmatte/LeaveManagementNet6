namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<bool> Exists(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}

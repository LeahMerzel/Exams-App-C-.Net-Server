namespace Exams_App_C__.Net_Server.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(string? id);
        Task<T> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task DeleteAsync(string? id);
        string GetEntityId(T entity);

    }
}

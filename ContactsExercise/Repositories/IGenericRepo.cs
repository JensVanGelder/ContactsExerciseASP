using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactsExercise.Repositories
{
    public interface IGenericRepo<T>
    {
        Task AddEntityAsync(T entity);
        Task DeleteEntityAsync(T entity);
        Task<bool> EntityExistsAsync(int id);
        Task<IList<T>> GetEntitiesAsync();
        Task<T> GetEntityAsync(int id);
        Task UpdateEntityAsync(T entity);
    }
}
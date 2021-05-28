using ContactsExercise.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactsExercise.Repositories
{
    public interface IContactRepo : IGenericRepo<Contact>
    {
        Task<IList<Contact>> GetEntitiesAsync();

        Task<Contact> GetEntityAsync(int id);
    }
}
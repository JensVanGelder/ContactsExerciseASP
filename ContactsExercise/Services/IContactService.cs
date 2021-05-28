using ContactsExercise.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactsExercise.Services
{
    public interface IContactService
    {
        Task AddContactAsync(Contact model);
        Task DeleteContactAsync(Contact model);
        Task<Contact> GetContactAsync(int id);
        Task<IList<Contact>> GetContactsAsync();
        Task UpdateContactAsync(Contact model);
    }
}
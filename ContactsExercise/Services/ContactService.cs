using ContactsExercise.Models;
using ContactsExercise.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactsExercise.Services
{
    public class ContactService : IContactService
    {
        private IContactRepo _contactRepo;
        private IGenericRepo<Address> _addressRepo;

        public ContactService(IContactRepo repo, IGenericRepo<Address> addressRepo)
        {
            _contactRepo = repo;
            _addressRepo = addressRepo;
        }

        public async Task<IList<Contact>> GetContactsAsync()
        {
            return await _contactRepo.GetEntitiesAsync();
        }

        public async Task AddContactAsync(Contact model)
        {
            await _contactRepo.AddEntityAsync(model);
        }

        public async Task<Contact> GetContactAsync(int id)
        {
            var model = await _contactRepo.GetEntityAsync(id);
            return model;
        }

        public async Task UpdateContactAsync(Contact model)
        {
            await _contactRepo.UpdateEntityAsync(model);
        }

        public async Task DeleteContactAsync(Contact model)
        {
            await _contactRepo.DeleteEntityAsync(model);
        }
    }
}
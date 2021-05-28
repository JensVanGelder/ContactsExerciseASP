using ContactsExercise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsExercise.Repositories
{
    public class ContactRepo : GenericRepo<Contact>, IContactRepo
    {
        public ContactRepo(AppContext context)
            : base(context)
        {
        }

        public override async Task<IList<Contact>> GetEntitiesAsync()
        {
            return await _context.Contacts
                .Include(x => x.Address)
                .ToListAsync();
        }

        public override async Task<Contact> GetEntityAsync(int id)
        {
            return await _context.Contacts
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
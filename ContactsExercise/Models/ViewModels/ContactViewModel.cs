using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsExercise.Models.ViewModels
{
    public class ContactViewModel
    {
        public ICollection<Contact> Contacts { get; set; }
    }
}
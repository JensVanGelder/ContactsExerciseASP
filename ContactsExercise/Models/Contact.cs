using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsExercise.Models
{
    public class Contact : BaseModel
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
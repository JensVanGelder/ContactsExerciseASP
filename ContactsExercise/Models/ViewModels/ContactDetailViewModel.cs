using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsExercise.Models.ViewModels
{
    public class ContactDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Box { get; set; }
        public string PostalCode { get; set; }
        public string Residence { get; set; }
    }
}
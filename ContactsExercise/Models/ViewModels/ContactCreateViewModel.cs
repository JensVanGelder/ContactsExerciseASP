using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsExercise.Models.ViewModels
{
    public class ContactCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public int AddressId { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        [MaxLength(5)]
        public int HouseNumber { get; set; }

        [Required]
        [MaxLength(1)]
        public string Box { get; set; }

        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [Required]
        public string Residence { get; set; }
    }
}
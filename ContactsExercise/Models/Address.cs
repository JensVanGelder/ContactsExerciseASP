using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsExercise.Models
{
    public class Address : BaseModel
    {
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Box { get; set; }
        public string PostalCode { get; set; }
        public string Residence { get; set; }
    }
}
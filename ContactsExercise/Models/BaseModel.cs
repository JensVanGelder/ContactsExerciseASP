using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsExercise.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdated { get; set; }

        public BaseModel()
        {
            CreatedAt = DateTime.Now;
            LastUpdated = DateTime.Now;
        }
    }
}
using ContactsExercise.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsExercise
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    Name = "Vermicelli",
                    FirstName = "Alberto",
                    Email = "TisAlberto@kapperszaak.be",
                    PhoneNumber = "0420 69 69 69",
                    AddressId = 1
                },
                new Contact
                {
                    Id = 2,
                    Name = "Verhulst",
                    FirstName = "Gert",
                    Email = "ILoveMarleneke@studio100.be",
                    PhoneNumber = "0420 10 10 10",
                    AddressId = 2
                });
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    Street = "VermeersStraat",
                    HouseNumber = 69,
                    Box = "b",
                    PostalCode = "4200",
                    Residence = "Studio100"
                },
                new Address
                {
                    Id = 2,
                    Street = "BelDoetHetNietStraat",
                    HouseNumber = 101,
                    Box = "a",
                    PostalCode = "4200",
                    Residence = "Studio100"
                }
                );
        }
    }
}
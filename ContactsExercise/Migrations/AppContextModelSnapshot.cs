// <auto-generated />
using System;
using ContactsExercise;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactsExercise.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactsExercise.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Box")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Residence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Box = "b",
                            CreatedAt = new DateTime(2021, 5, 27, 22, 14, 38, 210, DateTimeKind.Local).AddTicks(8223),
                            HouseNumber = 69,
                            LastUpdated = new DateTime(2021, 5, 27, 22, 14, 38, 210, DateTimeKind.Local).AddTicks(8249),
                            PostalCode = "4200",
                            Residence = "Studio100",
                            Street = "VermeersStraat"
                        },
                        new
                        {
                            Id = 2,
                            Box = "a",
                            CreatedAt = new DateTime(2021, 5, 27, 22, 14, 38, 211, DateTimeKind.Local).AddTicks(1512),
                            HouseNumber = 101,
                            LastUpdated = new DateTime(2021, 5, 27, 22, 14, 38, 211, DateTimeKind.Local).AddTicks(1528),
                            PostalCode = "4200",
                            Residence = "Studio100",
                            Street = "BelDoetHetNietStraat"
                        });
                });

            modelBuilder.Entity("ContactsExercise.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            CreatedAt = new DateTime(2021, 5, 27, 22, 14, 38, 206, DateTimeKind.Local).AddTicks(1276),
                            Email = "TisAlberto@kapperszaak.be",
                            FirstName = "Alberto",
                            LastUpdated = new DateTime(2021, 5, 27, 22, 14, 38, 208, DateTimeKind.Local).AddTicks(7404),
                            Name = "Vermicelli",
                            PhoneNumber = "0420 69 69 69"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            CreatedAt = new DateTime(2021, 5, 27, 22, 14, 38, 209, DateTimeKind.Local).AddTicks(1897),
                            Email = "ILoveMarleneke@studio100.be",
                            FirstName = "Gert",
                            LastUpdated = new DateTime(2021, 5, 27, 22, 14, 38, 209, DateTimeKind.Local).AddTicks(1924),
                            Name = "Verhulst",
                            PhoneNumber = "0420 10 10 10"
                        });
                });

            modelBuilder.Entity("ContactsExercise.Models.Contact", b =>
                {
                    b.HasOne("ContactsExercise.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}

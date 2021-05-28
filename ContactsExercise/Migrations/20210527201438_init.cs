using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsExercise.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    Box = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Residence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Box", "CreatedAt", "HouseNumber", "LastUpdated", "PostalCode", "Residence", "Street" },
                values: new object[] { 1, "b", new DateTime(2021, 5, 27, 22, 14, 38, 210, DateTimeKind.Local).AddTicks(8223), 69, new DateTime(2021, 5, 27, 22, 14, 38, 210, DateTimeKind.Local).AddTicks(8249), "4200", "Studio100", "VermeersStraat" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Box", "CreatedAt", "HouseNumber", "LastUpdated", "PostalCode", "Residence", "Street" },
                values: new object[] { 2, "a", new DateTime(2021, 5, 27, 22, 14, 38, 211, DateTimeKind.Local).AddTicks(1512), 101, new DateTime(2021, 5, 27, 22, 14, 38, 211, DateTimeKind.Local).AddTicks(1528), "4200", "Studio100", "BelDoetHetNietStraat" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "AddressId", "CreatedAt", "Email", "FirstName", "LastUpdated", "Name", "PhoneNumber" },
                values: new object[] { 1, 1, new DateTime(2021, 5, 27, 22, 14, 38, 206, DateTimeKind.Local).AddTicks(1276), "TisAlberto@kapperszaak.be", "Alberto", new DateTime(2021, 5, 27, 22, 14, 38, 208, DateTimeKind.Local).AddTicks(7404), "Vermicelli", "0420 69 69 69" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "AddressId", "CreatedAt", "Email", "FirstName", "LastUpdated", "Name", "PhoneNumber" },
                values: new object[] { 2, 2, new DateTime(2021, 5, 27, 22, 14, 38, 209, DateTimeKind.Local).AddTicks(1897), "ILoveMarleneke@studio100.be", "Gert", new DateTime(2021, 5, 27, 22, 14, 38, 209, DateTimeKind.Local).AddTicks(1924), "Verhulst", "0420 10 10 10" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
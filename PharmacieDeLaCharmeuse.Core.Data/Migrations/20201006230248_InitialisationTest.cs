using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class InitialisationTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestImagelUrl",
                table: "TestProduit");

            migrationBuilder.AddColumn<string>(
                name: "TestImageUrl",
                table: "TestProduit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "TestProduit",
                columns: new[] { "TestProduitId", "DateEdition", "Description", "DescriptionCourte", "NoteTest", "TestImageUrl", "Titre" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 8, "https://www.dinafem.org/uploads/sativex_3.jpg", "dentifrice" });

            migrationBuilder.InsertData(
                table: "TestProduit",
                columns: new[] { "TestProduitId", "DateEdition", "Description", "DescriptionCourte", "NoteTest", "TestImageUrl", "Titre" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 8, "https://www.dinafem.org/uploads/sativex_3.jpg", "dentifrice" });

            migrationBuilder.InsertData(
                table: "TestProduit",
                columns: new[] { "TestProduitId", "DateEdition", "Description", "DescriptionCourte", "NoteTest", "TestImageUrl", "Titre" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 8, "https://www.dinafem.org/uploads/sativex_3.jpg", "dentifrice" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "TestImageUrl",
                table: "TestProduit");

            migrationBuilder.AddColumn<string>(
                name: "TestImagelUrl",
                table: "TestProduit",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

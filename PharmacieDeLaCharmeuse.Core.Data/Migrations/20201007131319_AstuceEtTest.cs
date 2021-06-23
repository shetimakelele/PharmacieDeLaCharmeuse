using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class AstuceEtTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Astuce_CategorieAstuce_CategorieAstuceId",
                table: "Astuce");

            migrationBuilder.DropTable(
                name: "CategorieAstuce");

            migrationBuilder.DropIndex(
                name: "IX_Astuce_CategorieAstuceId",
                table: "Astuce");

            migrationBuilder.DropColumn(
                name: "CategorieAstuceId",
                table: "Astuce");

            migrationBuilder.UpdateData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 2,
                columns: new[] { "NoteTest", "Titre" },
                values: new object[] { 6, "Savon ph 7" });

            migrationBuilder.UpdateData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 3,
                column: "NoteTest",
                value: 1);

            migrationBuilder.InsertData(
                table: "TestProduit",
                columns: new[] { "TestProduitId", "DateEdition", "Description", "DescriptionCourte", "NoteTest", "TestImageUrl", "Titre" },
                values: new object[,]
                {
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 1, "https://www.dinafem.org/uploads/sativex_3.jpg", "dentifrice" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 5, "https://www.dinafem.org/uploads/sativex_3.jpg", "dentifrice" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 3, "https://www.dinafem.org/uploads/sativex_3.jpg", "dentifrice" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 6);

            migrationBuilder.AddColumn<int>(
                name: "CategorieAstuceId",
                table: "Astuce",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategorieAstuce",
                columns: table => new
                {
                    CategorieAstuceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionCategorieAstuce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomCategorieAstuce = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieAstuce", x => x.CategorieAstuceID);
                });

            migrationBuilder.InsertData(
                table: "CategorieAstuce",
                columns: new[] { "CategorieAstuceID", "DescriptionCategorieAstuce", "NomCategorieAstuce" },
                values: new object[,]
                {
                    { 1, "Description ici", "Beauté" },
                    { 2, "Description ici et la", "Régime" }
                });

            migrationBuilder.UpdateData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 2,
                columns: new[] { "NoteTest", "Titre" },
                values: new object[] { 8, "dentifrice" });

            migrationBuilder.UpdateData(
                table: "TestProduit",
                keyColumn: "TestProduitId",
                keyValue: 3,
                column: "NoteTest",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 1,
                column: "CategorieAstuceId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 2,
                column: "CategorieAstuceId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 3,
                column: "CategorieAstuceId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 4,
                column: "CategorieAstuceId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 5,
                column: "CategorieAstuceId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 6,
                column: "CategorieAstuceId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Astuce_CategorieAstuceId",
                table: "Astuce",
                column: "CategorieAstuceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Astuce_CategorieAstuce_CategorieAstuceId",
                table: "Astuce",
                column: "CategorieAstuceId",
                principalTable: "CategorieAstuce",
                principalColumn: "CategorieAstuceID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

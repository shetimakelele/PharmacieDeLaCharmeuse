using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 1,
                columns: new[] { "AstuceImageUrl", "CategorieAstuceId", "ProduitId" },
                values: new object[] { " https://www.dinafem.org/uploads/sativex_3.jpg", 1, 4 });

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 2,
                columns: new[] { "AstuceImageUrl", "ProduitId" },
                values: new object[] { " https://www.dinafem.org/uploads/sativex_3.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 3,
                columns: new[] { "AstuceImageUrl", "CategorieAstuceId" },
                values: new object[] { " https://www.dinafem.org/uploads/sativex_3.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 4,
                column: "ProduitId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 5,
                columns: new[] { "CategorieAstuceId", "ProduitId" },
                values: new object[] { 1, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 1,
                columns: new[] { "AstuceImageUrl", "CategorieAstuceId", "ProduitId" },
                values: new object[] { "https://www.dinafem.org/uploads/sativex_3.jpg", 2, 8 });

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 2,
                columns: new[] { "AstuceImageUrl", "ProduitId" },
                values: new object[] { "https://www.dinafem.org/uploads/sativex_3.jpg", 6 });

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 3,
                columns: new[] { "AstuceImageUrl", "CategorieAstuceId" },
                values: new object[] { "https://www.dinafem.org/uploads/sativex_3.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 4,
                column: "ProduitId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 5,
                columns: new[] { "CategorieAstuceId", "ProduitId" },
                values: new object[] { 2, 6 });
        }
    }
}

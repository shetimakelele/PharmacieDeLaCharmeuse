using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class Initialisation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produit_Image_ImageModelId",
                table: "Produit");

            migrationBuilder.DropTable(
                name: "AstuceDuMois");

            migrationBuilder.DropTable(
                name: "ProduitDuMois");

            migrationBuilder.DropTable(
                name: "TestDuMois");

            migrationBuilder.DropIndex(
                name: "IX_Produit_ImageModelId",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "ImageModelId",
                table: "Produit");

            migrationBuilder.AddColumn<string>(
                name: "ImageThumnailUrL",
                table: "TestProduit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrL",
                table: "TestProduit",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrixPromo",
                table: "Produit",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Prix",
                table: "Produit",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "EnStock",
                table: "Produit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnailUrL",
                table: "Produit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrL",
                table: "Produit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ProduitDuMois",
                table: "Produit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AstuceDuMois",
                table: "Astuce",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CategorieProduit",
                columns: new[] { "CategorieProduitID", "DescriptionCategorieProduit", "NomCategorieProduit" },
                values: new object[] { 1, "Médicament de premier niveau a recuper sans ordonance", "Médicament sans ordonnace" });

            migrationBuilder.InsertData(
                table: "CategorieProduit",
                columns: new[] { "CategorieProduitID", "DescriptionCategorieProduit", "NomCategorieProduit" },
                values: new object[] { 2, "Médicament de deuxieme niveau uniquement par ordonnance", "Médicament avec ordonnace" });

            migrationBuilder.InsertData(
                table: "Produit",
                columns: new[] { "ProduitId", "CategorieProduitId", "DescriptionCourte", "DescriptionLongue", "EnStock", "ImageThumbnailUrL", "ImageUrL", "Nom", "Prix", "PrixPromo", "ProduitDuMois" },
                values: new object[,]
                {
                    { 1, 1, "Ici une Description courte", "ici une DescriptionLongue longue", 10, "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-box-1554031811", "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-opened-1554031808", "Doliprane", 2m, 1m, true },
                    { 2, 1, "Ici une Description courte", "ici une DescriptionLongue longue", 100, "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-box-1554031811", "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-opened-1554031808", "Paracetamol", 5m, 1m, true },
                    { 4, 2, "Ici une Description courte", "ici une DescriptionLongue longue", 10, "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-box-1554031811", "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-opened-1554031808", "Vaccin", 2m, 1m, true },
                    { 5, 2, "Ici une Description courte", "ici une DescriptionLongue longue", 105, "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-box-1554031811", "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-opened-1554031808", "Sirop", 5m, 1m, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategorieProduit",
                keyColumn: "CategorieProduitID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategorieProduit",
                keyColumn: "CategorieProduitID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ImageThumnailUrL",
                table: "TestProduit");

            migrationBuilder.DropColumn(
                name: "ImageUrL",
                table: "TestProduit");

            migrationBuilder.DropColumn(
                name: "ImageThumbnailUrL",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "ImageUrL",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "ProduitDuMois",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "AstuceDuMois",
                table: "Astuce");

            migrationBuilder.AlterColumn<float>(
                name: "PrixPromo",
                table: "Produit",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<float>(
                name: "Prix",
                table: "Produit",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "EnStock",
                table: "Produit",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ImageModelId",
                table: "Produit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AstuceDuMois",
                columns: table => new
                {
                    AstuceDuMoisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AstuceId = table.Column<int>(type: "int", nullable: false),
                    Mois = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AstuceDuMois", x => x.AstuceDuMoisID);
                    table.ForeignKey(
                        name: "FK_AstuceDuMois_Astuce_AstuceId",
                        column: x => x.AstuceId,
                        principalTable: "Astuce",
                        principalColumn: "AstuceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProduitDuMois",
                columns: table => new
                {
                    ProduitDuMoisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mois = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProduitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitDuMois", x => x.ProduitDuMoisId);
                    table.ForeignKey(
                        name: "FK_ProduitDuMois_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "ProduitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestDuMois",
                columns: table => new
                {
                    TestDuMoisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mois = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestProduitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestDuMois", x => x.TestDuMoisId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produit_ImageModelId",
                table: "Produit",
                column: "ImageModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AstuceDuMois_AstuceId",
                table: "AstuceDuMois",
                column: "AstuceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProduitDuMois_ProduitId",
                table: "ProduitDuMois",
                column: "ProduitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produit_Image_ImageModelId",
                table: "Produit",
                column: "ImageModelId",
                principalTable: "Image",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class ProduitFinis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Information");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrL", "ImageUrL" },
                values: new object[] { "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg", "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg" });

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrL", "ImageUrL" },
                values: new object[] { "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg", "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg" });

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrL", "ImageUrL", "Nom" },
                values: new object[] { "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg", "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg", "Doliprane" });

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrL", "ImageUrL" },
                values: new object[] { "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg", "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg" });

            migrationBuilder.InsertData(
                table: "Produit",
                columns: new[] { "ProduitId", "CategorieProduitId", "DescriptionCourte", "DescriptionLongue", "EnStock", "ImageThumbnailUrL", "ImageUrL", "Nom", "Prix", "PrixPromo", "ProduitDuMois" },
                values: new object[,]
                {
                    { 6, 2, "Ici une Description courte", "ici une DescriptionLongue longue", 105, "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg", "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg", "Baume", 15m, 16m, false },
                    { 3, 2, "Ici une Description courte", "ici une DescriptionLongue longue", 105, "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg", "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg", "contraception", 15m, 16m, false },
                    { 7, 2, "Ici une Description courte", "ici une DescriptionLongue longue", 105, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.bobst.com%2Ffrfr%2Fsecteur-dutilisation-finale%2Fsoins-personnels%2Fproduits-pharmaceutiques%2F&psig=AOvVaw2a_bhGpZjpNdrQUOgPvNME&ust=1600195601907000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCOiAxq2n6esCFQAAAAAdAAAAABAE", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.bobst.com%2Ffrfr%2Fsecteur-dutilisation-finale%2Fsoins-personnels%2Fproduits-pharmaceutiques%2F&psig=AOvVaw2a_bhGpZjpNdrQUOgPvNME&ust=1600195601907000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCOiAxq2n6esCFQAAAAAdAAAAABAE", "Lotion", 15m, 16m, false },
                    { 8, 2, "Ici une Description courte", "ici une DescriptionLongue longue", 105, "https://www.dinafem.org/uploads/sativex_3.jpg", "https://www.dinafem.org/uploads/sativex_3.jpg", "dentifrice", 15m, 16m, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 8);

            migrationBuilder.CreateTable(
                name: "Information",
                columns: table => new
                {
                    InformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.InformationId);
                });

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrL", "ImageUrL" },
                values: new object[] { "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-box-1554031811", "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-opened-1554031808" });

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrL", "ImageUrL" },
                values: new object[] { "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-box-1554031811", "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-opened-1554031808" });

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrL", "ImageUrL", "Nom" },
                values: new object[] { "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-box-1554031811", "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-opened-1554031808", "Vaccin" });

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrL", "ImageUrL" },
                values: new object[] { "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-box-1554031811", "https://www.shutterstock.com/fr/image-photo/benon-france-november-7-2019close-opened-1554031808" });
        }
    }
}

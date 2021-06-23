using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class InitiaAstuce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Astuce_Image_imageModelImageId",
                table: "Astuce");

            migrationBuilder.DropIndex(
                name: "IX_Astuce_imageModelImageId",
                table: "Astuce");

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
                name: "AstuceDuMois",
                table: "Astuce");

            migrationBuilder.DropColumn(
                name: "imageModelImageId",
                table: "Astuce");

            migrationBuilder.AddColumn<int>(
                name: "ProduitId",
                table: "TestProduit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AstuceImageUrl",
                table: "Astuce",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CategorieAstuce",
                columns: new[] { "CategorieAstuceID", "DescriptionCategorieAstuce", "NomCategorieAstuce" },
                values: new object[] { 1, "Description ici", "Beauté" });

            migrationBuilder.InsertData(
                table: "CategorieAstuce",
                columns: new[] { "CategorieAstuceID", "DescriptionCategorieAstuce", "NomCategorieAstuce" },
                values: new object[] { 2, "Description ici et la", "Régime" });

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 7,
                column: "ImageUrL",
                value: "https://www.dinafem.org/uploads/sativex_3.jpg");

            migrationBuilder.InsertData(
                table: "Astuce",
                columns: new[] { "AstuceId", "AstuceImageUrl", "CategorieAstuceId", "DateEdition", "Description", "DescriptionCourte", "ProduitId", "Titre" },
                values: new object[,]
                {
                    { 2, " https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.buzzwebzine.fr%2Fpeeling-visage-astuce-beaute-regenerer-peau%2F&psig=AOvVaw3e_OkZqfolyvEmr8mIf0KJ&ust=1600804129522000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNizkaeC--sCFQAAAAAdAAAAABAE", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 6, "ici un titre" },
                    { 4, " https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.buzzwebzine.fr%2Fpeeling-visage-astuce-beaute-regenerer-peau%2F&psig=AOvVaw3e_OkZqfolyvEmr8mIf0KJ&ust=1600804129522000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNizkaeC--sCFQAAAAAdAAAAABAE", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 8, "ici un titre" },
                    { 6, " https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.buzzwebzine.fr%2Fpeeling-visage-astuce-beaute-regenerer-peau%2F&psig=AOvVaw3e_OkZqfolyvEmr8mIf0KJ&ust=1600804129522000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNizkaeC--sCFQAAAAAdAAAAABAE", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 4, "ici un titre" },
                    { 1, " https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.buzzwebzine.fr%2Fpeeling-visage-astuce-beaute-regenerer-peau%2F&psig=AOvVaw3e_OkZqfolyvEmr8mIf0KJ&ust=1600804129522000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNizkaeC--sCFQAAAAAdAAAAABAE", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 8, "ici un titre" },
                    { 3, " https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.buzzwebzine.fr%2Fpeeling-visage-astuce-beaute-regenerer-peau%2F&psig=AOvVaw3e_OkZqfolyvEmr8mIf0KJ&ust=1600804129522000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNizkaeC--sCFQAAAAAdAAAAABAE", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 4, "ici un titre" },
                    { 5, " https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.buzzwebzine.fr%2Fpeeling-visage-astuce-beaute-regenerer-peau%2F&psig=AOvVaw3e_OkZqfolyvEmr8mIf0KJ&ust=1600804129522000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNizkaeC--sCFQAAAAAdAAAAABAE", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ici une DescriptionLongue longue", "Ici une Description courte", 6, "ici un titre" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestProduit_ProduitId",
                table: "TestProduit",
                column: "ProduitId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestProduit_Produit_ProduitId",
                table: "TestProduit",
                column: "ProduitId",
                principalTable: "Produit",
                principalColumn: "ProduitId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestProduit_Produit_ProduitId",
                table: "TestProduit");

            migrationBuilder.DropIndex(
                name: "IX_TestProduit_ProduitId",
                table: "TestProduit");

            migrationBuilder.DeleteData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Astuce",
                keyColumn: "AstuceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategorieAstuce",
                keyColumn: "CategorieAstuceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategorieAstuce",
                keyColumn: "CategorieAstuceID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ProduitId",
                table: "TestProduit");

            migrationBuilder.DropColumn(
                name: "AstuceImageUrl",
                table: "Astuce");

            migrationBuilder.AddColumn<string>(
                name: "ImageThumnailUrL",
                table: "TestProduit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrL",
                table: "TestProduit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnailUrL",
                table: "Produit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AstuceDuMois",
                table: "Astuce",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "imageModelImageId",
                table: "Astuce",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 1,
                column: "ImageThumbnailUrL",
                value: "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 2,
                column: "ImageThumbnailUrL",
                value: "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 3,
                column: "ImageThumbnailUrL",
                value: "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 4,
                column: "ImageThumbnailUrL",
                value: "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 5,
                column: "ImageThumbnailUrL",
                value: "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 6,
                column: "ImageThumbnailUrL",
                value: "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrL", "ImageUrL" },
                values: new object[] { "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.bobst.com%2Ffrfr%2Fsecteur-dutilisation-finale%2Fsoins-personnels%2Fproduits-pharmaceutiques%2F&psig=AOvVaw2a_bhGpZjpNdrQUOgPvNME&ust=1600195601907000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCOiAxq2n6esCFQAAAAAdAAAAABAE", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.bobst.com%2Ffrfr%2Fsecteur-dutilisation-finale%2Fsoins-personnels%2Fproduits-pharmaceutiques%2F&psig=AOvVaw2a_bhGpZjpNdrQUOgPvNME&ust=1600195601907000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCOiAxq2n6esCFQAAAAAdAAAAABAE" });

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "ProduitId",
                keyValue: 8,
                column: "ImageThumbnailUrL",
                value: "https://www.dinafem.org/uploads/sativex_3.jpg");

            migrationBuilder.CreateIndex(
                name: "IX_Astuce_imageModelImageId",
                table: "Astuce",
                column: "imageModelImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Astuce_Image_imageModelImageId",
                table: "Astuce",
                column: "imageModelImageId",
                principalTable: "Image",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

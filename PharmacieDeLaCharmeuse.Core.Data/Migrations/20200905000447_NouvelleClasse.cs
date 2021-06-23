using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class NouvelleClasse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Astuce_CategorieAstuce_CategorieAstuceID",
                table: "Astuce");

            migrationBuilder.DropForeignKey(
                name: "FK_Produit_CategorieProduit_CategorieProduitID",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "CategorieID",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "ProduitImageThumbnailUrl",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "ProduitImageUrl",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Astuce");

            migrationBuilder.DropColumn(
                name: "AstuceCategorieId",
                table: "Astuce");

            migrationBuilder.DropColumn(
                name: "AstuceImageThumbnailUrl",
                table: "Astuce");

            migrationBuilder.DropColumn(
                name: "AstuceImageUrl",
                table: "Astuce");

            migrationBuilder.RenameColumn(
                name: "CategorieProduitID",
                table: "Produit",
                newName: "CategorieProduitId");

            migrationBuilder.RenameColumn(
                name: "ProduitID",
                table: "Produit",
                newName: "ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Produit_CategorieProduitID",
                table: "Produit",
                newName: "IX_Produit_CategorieProduitId");

            migrationBuilder.RenameColumn(
                name: "CategorieAstuceID",
                table: "Astuce",
                newName: "CategorieAstuceId");

            migrationBuilder.RenameIndex(
                name: "IX_Astuce_CategorieAstuceID",
                table: "Astuce",
                newName: "IX_Astuce_CategorieAstuceId");

            migrationBuilder.AlterColumn<int>(
                name: "CategorieProduitId",
                table: "Produit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageModelId",
                table: "Produit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CategorieAstuceId",
                table: "Astuce",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProduitId",
                table: "Astuce",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "imageModelImageId",
                table: "Astuce",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProduitDuMois_ProduitId",
                table: "ProduitDuMois",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_ImageModelId",
                table: "Produit",
                column: "ImageModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AstuceDuMois_AstuceId",
                table: "AstuceDuMois",
                column: "AstuceId");

            migrationBuilder.CreateIndex(
                name: "IX_Astuce_imageModelImageId",
                table: "Astuce",
                column: "imageModelImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Astuce_CategorieAstuce_CategorieAstuceId",
                table: "Astuce",
                column: "CategorieAstuceId",
                principalTable: "CategorieAstuce",
                principalColumn: "CategorieAstuceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Astuce_Image_imageModelImageId",
                table: "Astuce",
                column: "imageModelImageId",
                principalTable: "Image",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AstuceDuMois_Astuce_AstuceId",
                table: "AstuceDuMois",
                column: "AstuceId",
                principalTable: "Astuce",
                principalColumn: "AstuceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produit_CategorieProduit_CategorieProduitId",
                table: "Produit",
                column: "CategorieProduitId",
                principalTable: "CategorieProduit",
                principalColumn: "CategorieProduitID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produit_Image_ImageModelId",
                table: "Produit",
                column: "ImageModelId",
                principalTable: "Image",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitDuMois_Produit_ProduitId",
                table: "ProduitDuMois",
                column: "ProduitId",
                principalTable: "Produit",
                principalColumn: "ProduitId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Astuce_CategorieAstuce_CategorieAstuceId",
                table: "Astuce");

            migrationBuilder.DropForeignKey(
                name: "FK_Astuce_Image_imageModelImageId",
                table: "Astuce");

            migrationBuilder.DropForeignKey(
                name: "FK_AstuceDuMois_Astuce_AstuceId",
                table: "AstuceDuMois");

            migrationBuilder.DropForeignKey(
                name: "FK_Produit_CategorieProduit_CategorieProduitId",
                table: "Produit");

            migrationBuilder.DropForeignKey(
                name: "FK_Produit_Image_ImageModelId",
                table: "Produit");

            migrationBuilder.DropForeignKey(
                name: "FK_ProduitDuMois_Produit_ProduitId",
                table: "ProduitDuMois");

            migrationBuilder.DropIndex(
                name: "IX_ProduitDuMois_ProduitId",
                table: "ProduitDuMois");

            migrationBuilder.DropIndex(
                name: "IX_Produit_ImageModelId",
                table: "Produit");

            migrationBuilder.DropIndex(
                name: "IX_AstuceDuMois_AstuceId",
                table: "AstuceDuMois");

            migrationBuilder.DropIndex(
                name: "IX_Astuce_imageModelImageId",
                table: "Astuce");

            migrationBuilder.DropColumn(
                name: "ImageModelId",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "ProduitId",
                table: "Astuce");

            migrationBuilder.DropColumn(
                name: "imageModelImageId",
                table: "Astuce");

            migrationBuilder.RenameColumn(
                name: "CategorieProduitId",
                table: "Produit",
                newName: "CategorieProduitID");

            migrationBuilder.RenameColumn(
                name: "ProduitId",
                table: "Produit",
                newName: "ProduitID");

            migrationBuilder.RenameIndex(
                name: "IX_Produit_CategorieProduitId",
                table: "Produit",
                newName: "IX_Produit_CategorieProduitID");

            migrationBuilder.RenameColumn(
                name: "CategorieAstuceId",
                table: "Astuce",
                newName: "CategorieAstuceID");

            migrationBuilder.RenameIndex(
                name: "IX_Astuce_CategorieAstuceId",
                table: "Astuce",
                newName: "IX_Astuce_CategorieAstuceID");

            migrationBuilder.AlterColumn<int>(
                name: "CategorieProduitID",
                table: "Produit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategorieID",
                table: "Produit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProduitImageThumbnailUrl",
                table: "Produit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProduitImageUrl",
                table: "Produit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategorieAstuceID",
                table: "Astuce",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Astuce",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AstuceCategorieId",
                table: "Astuce",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AstuceImageThumbnailUrl",
                table: "Astuce",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AstuceImageUrl",
                table: "Astuce",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Astuce_CategorieAstuce_CategorieAstuceID",
                table: "Astuce",
                column: "CategorieAstuceID",
                principalTable: "CategorieAstuce",
                principalColumn: "CategorieAstuceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produit_CategorieProduit_CategorieProduitID",
                table: "Produit",
                column: "CategorieProduitID",
                principalTable: "CategorieProduit",
                principalColumn: "CategorieProduitID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

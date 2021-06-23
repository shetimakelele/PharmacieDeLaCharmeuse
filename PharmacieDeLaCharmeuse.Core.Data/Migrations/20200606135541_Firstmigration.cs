using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class Firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AstuceDuMois",
                columns: table => new
                {
                    AstuceDuMoisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mois = table.Column<DateTime>(nullable: false),
                    AstuceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AstuceDuMois", x => x.AstuceDuMoisID);
                });

            migrationBuilder.CreateTable(
                name: "CategorieAstuce",
                columns: table => new
                {
                    CategorieAstuceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCategorieAstuce = table.Column<string>(nullable: true),
                    DescriptionCategorieAstuce = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieAstuce", x => x.CategorieAstuceID);
                });

            migrationBuilder.CreateTable(
                name: "CategorieProduit",
                columns: table => new
                {
                    CategorieProduitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCategorieProduit = table.Column<string>(nullable: true),
                    DescriptionCategorieProduit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieProduit", x => x.CategorieProduitID);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitreImage = table.Column<string>(nullable: true),
                    NomImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "Information",
                columns: table => new
                {
                    InformationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.InformationId);
                });

            migrationBuilder.CreateTable(
                name: "ProduitDuMois",
                columns: table => new
                {
                    ProduitDuMoisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mois = table.Column<DateTime>(nullable: false),
                    ProduitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitDuMois", x => x.ProduitDuMoisId);
                });

            migrationBuilder.CreateTable(
                name: "TestDuMois",
                columns: table => new
                {
                    TestDuMoisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mois = table.Column<DateTime>(nullable: false),
                    TestProduitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestDuMois", x => x.TestDuMoisId);
                });

            migrationBuilder.CreateTable(
                name: "TestProduit",
                columns: table => new
                {
                    TestProduitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateEdition = table.Column<DateTime>(nullable: false),
                    Titre = table.Column<string>(nullable: false),
                    DescriptionCourte = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    NoteTest = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestProduit", x => x.TestProduitId);
                });

            migrationBuilder.CreateTable(
                name: "Astuce",
                columns: table => new
                {
                    AstuceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateEdition = table.Column<DateTime>(nullable: false),
                    Titre = table.Column<string>(nullable: false),
                    DescriptionCourte = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    AstuceImageUrl = table.Column<string>(nullable: true),
                    AstuceImageThumbnailUrl = table.Column<string>(nullable: true),
                    AstuceCategorieId = table.Column<int>(nullable: false),
                    ArticleId = table.Column<int>(nullable: false),
                    CategorieAstuceID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Astuce", x => x.AstuceId);
                    table.ForeignKey(
                        name: "FK_Astuce_CategorieAstuce_CategorieAstuceID",
                        column: x => x.CategorieAstuceID,
                        principalTable: "CategorieAstuce",
                        principalColumn: "CategorieAstuceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    ProduitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    DescriptionCourte = table.Column<string>(nullable: true),
                    DescriptionLongue = table.Column<string>(nullable: true),
                    Prix = table.Column<float>(nullable: false),
                    PrixPromo = table.Column<float>(nullable: false),
                    ProduitImageUrl = table.Column<string>(nullable: true),
                    ProduitImageThumbnailUrl = table.Column<string>(nullable: true),
                    EnStock = table.Column<string>(nullable: true),
                    CategorieID = table.Column<int>(nullable: false),
                    CategorieProduitID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.ProduitID);
                    table.ForeignKey(
                        name: "FK_Produit_CategorieProduit_CategorieProduitID",
                        column: x => x.CategorieProduitID,
                        principalTable: "CategorieProduit",
                        principalColumn: "CategorieProduitID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Astuce_CategorieAstuceID",
                table: "Astuce",
                column: "CategorieAstuceID");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_CategorieProduitID",
                table: "Produit",
                column: "CategorieProduitID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Astuce");

            migrationBuilder.DropTable(
                name: "AstuceDuMois");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Information");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "ProduitDuMois");

            migrationBuilder.DropTable(
                name: "TestDuMois");

            migrationBuilder.DropTable(
                name: "TestProduit");

            migrationBuilder.DropTable(
                name: "CategorieAstuce");

            migrationBuilder.DropTable(
                name: "CategorieProduit");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class Panier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PanierItems",
                columns: table => new
                {
                    PanierItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    PanierSessionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanierItems", x => x.PanierItemId);
                    table.ForeignKey(
                        name: "FK_PanierItems_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "ProduitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PanierItems_ProduitId",
                table: "PanierItems",
                column: "ProduitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PanierItems");
        }

        public static Panier GetPanier()
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    public partial class TestProduit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestProduit_Produit_ProduitId",
                table: "TestProduit");

            migrationBuilder.DropIndex(
                name: "IX_TestProduit_ProduitId",
                table: "TestProduit");

            migrationBuilder.DropColumn(
                name: "ProduitId",
                table: "TestProduit");

            migrationBuilder.AddColumn<string>(
                name: "TestImagelUrl",
                table: "TestProduit",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Commandes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Commandes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Commandes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Commandes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresse1",
                table: "Commandes",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestImagelUrl",
                table: "TestProduit");

            migrationBuilder.AddColumn<int>(
                name: "ProduitId",
                table: "TestProduit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Commandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Commandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Commandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Commandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Adresse1",
                table: "Commandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

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
    }
}

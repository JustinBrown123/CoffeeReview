using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeReview.Migrations
{
    public partial class ModelEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Coffees_CoffeeId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coffees",
                table: "Coffees");

            migrationBuilder.RenameTable(
                name: "Coffees",
                newName: "Coffee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coffee",
                table: "Coffee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Coffee_CoffeeId",
                table: "Review",
                column: "CoffeeId",
                principalTable: "Coffee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Coffee_CoffeeId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coffee",
                table: "Coffee");

            migrationBuilder.RenameTable(
                name: "Coffee",
                newName: "Coffees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coffees",
                table: "Coffees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Coffees_CoffeeId",
                table: "Review",
                column: "CoffeeId",
                principalTable: "Coffees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

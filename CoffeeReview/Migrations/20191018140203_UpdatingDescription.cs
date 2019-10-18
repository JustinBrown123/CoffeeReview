using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeReview.Migrations
{
    public partial class UpdatingDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Light to medium Roast Costa Rican and Dark roast Hondauran. Organic, Fair Trade, Shade Grown Balanced acidity, clean flavorful cup");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Full Medium Roast Specialty Grade Crisp, Citrus tones, Nice Finish", " /images/tanzanianpeaberry.jpg" });

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Eastern Highlands, Papua New Guinea. Notes of: plum, blood orange, chocolate malt. ");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Region: Asia-Pacific. Notes of Cedary Spice and Herbs.  ");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Medium Roast. Sweet, fruity and well balanced");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "San Pascual Columbian. Notes of Fruit punch and creamy mouthfeel");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Dark Roast. Espresso Style, Smooth, Full-Bodied");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Dark Roast from Americas. Notes of sun-ripened cherry fruit and intense, bright Meyer lemon citrus-acidity.");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Medium Roast. Decaffinated Coffee that almost tastes like normal Coffee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "happyhappy stuff");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "really good stuff", "/images/tanzanianpeaberry.jpg" });

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "makes happy");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "happyhappy stuff");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "great cheap coffee");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Pretty Solid");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "excellent for the cost");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Deliciousness");

            migrationBuilder.UpdateData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Horrible");
        }
    }
}

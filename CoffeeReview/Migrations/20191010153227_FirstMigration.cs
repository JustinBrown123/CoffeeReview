using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeReview.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coffees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true),
                    Kind = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    CoffeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Coffees_CoffeeId",
                        column: x => x.CoffeeId,
                        principalTable: "Coffees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "Id", "Brand", "Description", "ImageUrl", "Kind" },
                values: new object[,]
                {
                    { 1, "Cleveland Coffee", "happyhappy stuff", "/images/brightsideblend.jpg", "Bright Side Blend" },
                    { 2, "Cleveland Coffee", "really good stuff", "/images/tanzanianpeaberry.jpg", "Tanzanian Peaberry" },
                    { 3, "Rising Star", "makes happy", "/images/apocooperative.jpg", "Apo Cooperative" },
                    { 4, "Starbucks", "happyhappy stuff", "/images/komododragon.jpg", "Komodo Dragon" },
                    { 5, "8 O'Clock", "great cheap coffee", "/images/theoriginal.jpg", "The Original" },
                    { 6, "Brioso", "Pretty Solid", "/images/colombiasantabarbara.jpg", "Santa Barbara Estate" },
                    { 7, "8 O'Clock", "excellent for the cost", "/images/redeyeroast.jpg", "Red Eye Roast" },
                    { 8, "Peets", "Deliciousness", "/images/costaricapeaberry.jpg", "Costa Rica Peaberry" },
                    { 9, "Dunkin' Donuts", "Horrible", "/images/dunkindecaf.jpg", "Dunkin Decaf" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "CoffeeId", "Content" },
                values: new object[,]
                {
                    { 1, 1, "Splendid, I must say. Gracious upon the first sip jolly ole chaps." },
                    { 2, 2, "Quite awful in taste and overall quality mate. Do not recommend this one for a night out with the chaps" },
                    { 3, 3, "Good for a wee bit of a wakeup but not a particular favorite of mine" },
                    { 4, 4, "Absolutely splendid chaps!!" },
                    { 10, 4, "James loves this coffee" },
                    { 5, 5, "Golly gee, this was a wee bit AWFUL" },
                    { 11, 5, "OMG THIS IS THE BEST COFFEE EVER" },
                    { 6, 6, "I was absolutely stunned when I tried this! Will definitely be sharing with a few of my chaps" },
                    { 7, 7, "Oh I hate to be a damper here but gosh I hated this one, an awful aftertaste ruins an otherwise ok taste" },
                    { 8, 8, "I almost thought I enjoyed this one but after about half a cup and a crumpet, my tummy hurt. 10/10 would not recommend to the chaps" },
                    { 9, 9, "Another favorite for my chaps and I. Good for a biscuit in the morning or a crumpet at night" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_CoffeeId",
                table: "Review",
                column: "CoffeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Coffees");
        }
    }
}

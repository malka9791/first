using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yad2.DATA.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Advertisers_advertiserId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "advertiserId",
                table: "Products",
                newName: "AdvertiserId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_advertiserId",
                table: "Products",
                newName: "IX_Products_AdvertiserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Advertisers_AdvertiserId",
                table: "Products",
                column: "AdvertiserId",
                principalTable: "Advertisers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Advertisers_AdvertiserId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "AdvertiserId",
                table: "Products",
                newName: "advertiserId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_AdvertiserId",
                table: "Products",
                newName: "IX_Products_advertiserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Advertisers_advertiserId",
                table: "Products",
                column: "advertiserId",
                principalTable: "Advertisers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

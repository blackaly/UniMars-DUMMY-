using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniMars.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DetailedUserId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "DetailedUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DetailedUserId",
                table: "AspNetUsers",
                column: "DetailedUserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DetailedUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DetailedUser");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DetailedUserId",
                table: "AspNetUsers",
                column: "DetailedUserId");
        }
    }
}

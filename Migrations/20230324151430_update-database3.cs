using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniMars.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "AspNetUsers",
                newName: "DetailedUserId");

            migrationBuilder.AddColumn<int>(
                name: "DetailedUserId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DetailedUser",
                columns: table => new
                {
                    DetailedUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bio = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailedUser", x => x.DetailedUserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_DetailedUserId",
                table: "Posts",
                column: "DetailedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DetailedUserId",
                table: "AspNetUsers",
                column: "DetailedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DetailedUser_DetailedUserId",
                table: "AspNetUsers",
                column: "DetailedUserId",
                principalTable: "DetailedUser",
                principalColumn: "DetailedUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_DetailedUser_DetailedUserId",
                table: "Posts",
                column: "DetailedUserId",
                principalTable: "DetailedUser",
                principalColumn: "DetailedUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DetailedUser_DetailedUserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_DetailedUser_DetailedUserId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "DetailedUser");

            migrationBuilder.DropIndex(
                name: "IX_Posts_DetailedUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DetailedUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DetailedUserId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "DetailedUserId",
                table: "AspNetUsers",
                newName: "PostId");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

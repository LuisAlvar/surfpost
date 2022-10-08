using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace surfuserservice.Migrations
{
    public partial class EnsureToAddActiveFieldToAllClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Friends",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Followings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Followers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Followings");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Followers");
        }
    }
}

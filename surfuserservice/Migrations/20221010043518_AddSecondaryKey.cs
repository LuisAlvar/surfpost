using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace surfuserservice.Migrations
{
    public partial class AddSecondaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e299f8c7-7e25-4f07-a3a3-bc11dbe42e3f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("f678f05a-4947-4314-b9ff-001986480e75"));

            migrationBuilder.AddColumn<Guid>(
                name: "FriendshipId",
                table: "Friends",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("10924bd1-cd46-4427-b4b6-1706429ba467"));

            migrationBuilder.AddColumn<Guid>(
                name: "FollowingshipId",
                table: "Followings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("54a83938-f27f-49f6-9f11-cb06f328bb52"));

            migrationBuilder.AddColumn<Guid>(
                name: "FollowershipId",
                table: "Followers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("707217f5-77af-42d7-a0a8-60eca96405f2"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FriendshipId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "FollowingshipId",
                table: "Followings");

            migrationBuilder.DropColumn(
                name: "FollowershipId",
                table: "Followers");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("f678f05a-4947-4314-b9ff-001986480e75"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e299f8c7-7e25-4f07-a3a3-bc11dbe42e3f"));
        }
    }
}

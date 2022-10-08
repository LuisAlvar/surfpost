using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace surfuserservice.Migrations
{
    public partial class AddDefaultValueToUserModel_UserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("f678f05a-4947-4314-b9ff-001986480e75"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("f678f05a-4947-4314-b9ff-001986480e75"));
        }
    }
}

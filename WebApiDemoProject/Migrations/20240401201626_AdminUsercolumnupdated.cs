using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiDemoProject.Migrations
{
    /// <inheritdoc />
    public partial class AdminUsercolumnupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminUSers",
                table: "AdminUSers");

            migrationBuilder.RenameTable(
                name: "AdminUSers",
                newName: "AdminUsers");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AdminUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AdminUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminUsers",
                table: "AdminUsers",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminUsers",
                table: "AdminUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AdminUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AdminUsers");

            migrationBuilder.RenameTable(
                name: "AdminUsers",
                newName: "AdminUSers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminUSers",
                table: "AdminUSers",
                column: "Id");
        }
    }
}

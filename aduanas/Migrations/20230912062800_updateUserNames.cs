using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aduanas.Migrations
{
    /// <inheritdoc />
    public partial class updateUserNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserNames",
                table: "AspNetUsers",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNames",
                table: "AspNetUsers");
        }
    }
}

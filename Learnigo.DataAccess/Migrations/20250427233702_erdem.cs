using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Learnigo.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class erdem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Enail",
                table: "Subscribes",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Subscribes",
                newName: "Enail");
        }
    }
}

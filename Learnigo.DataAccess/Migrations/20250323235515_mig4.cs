using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Learnigo.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Messages",
                newName: "MessageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageId",
                table: "Messages",
                newName: "Id");
        }
    }
}

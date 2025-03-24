using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Learnigo.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCatogories_BlogCategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CoursesCatagories_CategoryId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Massages",
                table: "Massages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoursesCatagories",
                table: "CoursesCatagories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogCatogories",
                table: "BlogCatogories");

            migrationBuilder.RenameTable(
                name: "Massages",
                newName: "Messages");

            migrationBuilder.RenameTable(
                name: "CoursesCatagories",
                newName: "CourseCategories");

            migrationBuilder.RenameTable(
                name: "BlogCatogories",
                newName: "BlogCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseCategories",
                table: "CourseCategories",
                column: "CourseCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogCategories",
                table: "BlogCategories",
                column: "BlogCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogCategories_BlogCategoryId",
                table: "Blogs",
                column: "BlogCategoryId",
                principalTable: "BlogCategories",
                principalColumn: "BlogCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCategories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "CourseCategories",
                principalColumn: "CourseCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCategories_BlogCategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCategories_CategoryId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseCategories",
                table: "CourseCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogCategories",
                table: "BlogCategories");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Massages");

            migrationBuilder.RenameTable(
                name: "CourseCategories",
                newName: "CoursesCatagories");

            migrationBuilder.RenameTable(
                name: "BlogCategories",
                newName: "BlogCatogories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Massages",
                table: "Massages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoursesCatagories",
                table: "CoursesCatagories",
                column: "CourseCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogCatogories",
                table: "BlogCatogories",
                column: "BlogCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogCatogories_BlogCategoryId",
                table: "Blogs",
                column: "BlogCategoryId",
                principalTable: "BlogCatogories",
                principalColumn: "BlogCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CoursesCatagories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "CoursesCatagories",
                principalColumn: "CourseCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

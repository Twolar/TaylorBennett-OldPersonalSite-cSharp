using Microsoft.EntityFrameworkCore.Migrations;

namespace TaylorBennett.BackService.Migrations
{
    public partial class RefactorV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlostPostDate",
                table: "BlogPosts",
                newName: "BlogPostDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogPostDate",
                table: "BlogPosts",
                newName: "BlostPostDate");
        }
    }
}

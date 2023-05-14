using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookshop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Роберт Мартин", "Идеальный программист\" и \"Чистый код\" - легендарные бестселлеры Роберта Мартина - рассказывают, как достичь высот профессионализма. \"Чистая архитектура\" продолжает эту тему, но не предлагает несколько вариантов в стиле \"решай сам\", а объясняет, что именно следует делать, по какой причине и почему именно такое решение станет принципиально важным для вашего успеха.", "9785446107728", 15.69, 15.0, 12.0, 13.0, "Чистая архитектура" },
                    { 2, "Роберт Мартин", "Даже плохой программный код может работать. Однако если код не является \"чистым\", это всегда будет мешать развитию проекта и компании-разработчика, отнимая значительные ресурсы на его поддержку и \"укрощение\".Эта книга посвящена хорошему программированию. Она полна реальных примеров кода.", "9785446109609", 13.69, 13.0, 10.0, 12.0, "Чистый код" },
                    { 3, "Роберт Мартин", "Всех программистов, которые добиваются успеха в мире разработки ПО, отличает один общий признак: они больше всего заботятся о качестве создаваемого программного обеспечения. Это — основа для них. Потому что они являются профессионалами своего дела. ", "9785446110674", 11.59, 11.0, 8.0, 10.0, "Идеальный программист" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}

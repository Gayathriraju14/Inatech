using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitFrame.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductBatch",
                columns: table => new
                {
                    BatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductFK = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    quantity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBatch", x => x.BatchID);
                    table.ForeignKey(
                        name: "FK_ProductBatch_Products_ProductFK",
                        column: x => x.ProductFK,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductBatch_ProductFK",
                table: "ProductBatch",
                column: "ProductFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductBatch");
        }
    }
}

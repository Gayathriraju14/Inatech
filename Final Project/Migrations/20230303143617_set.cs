using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryExpress.Migrations
{
    /// <inheritdoc />
    public partial class set : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderList",
                columns: table => new
                {
                    OrderTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderList", x => x.OrderTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromAddr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToAddr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_OrderList_OrderTypeId",
                        column: x => x.OrderTypeId,
                        principalTable: "OrderList",
                        principalColumn: "OrderTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryExecutive",
                columns: table => new
                {
                    ExecutiveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExecutiveName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    OrderTypeId = table.Column<int>(type: "int", nullable: false),
                    PhnNo = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryExecutive", x => x.ExecutiveId);
                    table.ForeignKey(
                        name: "FK_DeliveryExecutive_OrderList_OrderTypeId",
                        column: x => x.OrderTypeId,
                        principalTable: "OrderList",
                        principalColumn: "OrderTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrderTypeId",
                table: "Customer",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryExecutive_OrderTypeId",
                table: "DeliveryExecutive",
                column: "OrderTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "DeliveryExecutive");

            migrationBuilder.DropTable(
                name: "OrderList");
        }
    }
}

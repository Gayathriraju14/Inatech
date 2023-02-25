using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitFrame.Migrations
{
    /// <inheritdoc />
    public partial class new8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_Standard_StandarRefId",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Standard",
                table: "Standard");

            migrationBuilder.RenameTable(
                name: "Standard",
                newName: "standards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_standards",
                table: "standards",
                column: "StandardID");

            migrationBuilder.AddForeignKey(
                name: "FK_students_standards_StandarRefId",
                table: "students",
                column: "StandarRefId",
                principalTable: "standards",
                principalColumn: "StandardID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_standards_StandarRefId",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_standards",
                table: "standards");

            migrationBuilder.RenameTable(
                name: "standards",
                newName: "Standard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Standard",
                table: "Standard",
                column: "StandardID");

            migrationBuilder.AddForeignKey(
                name: "FK_students_Standard_StandarRefId",
                table: "students",
                column: "StandarRefId",
                principalTable: "Standard",
                principalColumn: "StandardID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

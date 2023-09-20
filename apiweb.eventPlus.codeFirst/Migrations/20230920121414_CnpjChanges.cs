using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiweb.eventPlus.codeFirst.Migrations
{
    /// <inheritdoc />
    public partial class CnpjChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Institutions",
                type: "VARCHAR(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(14)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Institutions",
                type: "CHAR(14)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)");
        }
    }
}

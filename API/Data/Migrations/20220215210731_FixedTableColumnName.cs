using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class FixedTableColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecipientDelated",
                table: "Messages",
                newName: "RecipientDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecipientDeleted",
                table: "Messages",
                newName: "RecipientDelated");
        }
    }
}

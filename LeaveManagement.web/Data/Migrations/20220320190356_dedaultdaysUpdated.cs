using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.web.Data.Migrations
{
    public partial class dedaultdaysUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DafaultDays",
                table: "LeaveTypes",
                newName: "DefaultDays");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefaultDays",
                table: "LeaveTypes",
                newName: "DafaultDays");
        }
    }
}

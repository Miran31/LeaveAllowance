using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveAllowance.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "leaveTypes",
                newName: "LeaveType");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "leaveTypes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "leaveTypes");

            migrationBuilder.RenameColumn(
                name: "LeaveType",
                table: "leaveTypes",
                newName: "Name");
        }
    }
}

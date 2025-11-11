using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeRecord.Migrations
{
    /// <inheritdoc />
    public partial class InitialChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpAddress",
                table: "employeeMasters",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpAddress",
                table: "employeeMasters");
        }
    }
}

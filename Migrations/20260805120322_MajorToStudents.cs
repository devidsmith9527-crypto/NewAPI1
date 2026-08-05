using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewAPI1.Migrations
{
    /// <inheritdoc />
    public partial class MajorToStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MajorId",
                table: "tbl_Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MajorId",
                table: "tbl_Students");
        }
    }
}

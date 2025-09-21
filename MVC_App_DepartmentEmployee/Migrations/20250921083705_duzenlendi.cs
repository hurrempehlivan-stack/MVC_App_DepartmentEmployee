using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_App_DepartmentEmployee.Migrations
{
    /// <inheritdoc />
    public partial class duzenlendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeAdress",
                table: "Employees",
                newName: "EmployeeAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeAddress",
                table: "Employees",
                newName: "EmployeeAdress");
        }
    }
}

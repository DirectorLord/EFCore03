using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore03.Context.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Employee",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                newName: "IX_Employee_departmentId");

            migrationBuilder.AlterColumn<int>(
                name: "departmentId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_departmentId",
                table: "Employee",
                column: "departmentId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_departmentId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Employee",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_departmentId",
                table: "Employee",
                newName: "IX_Employee_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

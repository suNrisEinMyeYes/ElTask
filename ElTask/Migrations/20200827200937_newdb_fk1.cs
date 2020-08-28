using Microsoft.EntityFrameworkCore.Migrations;

namespace ElTask.Migrations
{
    public partial class newdb_fk1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Employee_Id",
                table: "Lreg",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lreg_Employee_Id",
                table: "Lreg",
                column: "Employee_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lreg_Employees_Employee_Id",
                table: "Lreg",
                column: "Employee_Id",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lreg_Employees_Employee_Id",
                table: "Lreg");

            migrationBuilder.DropIndex(
                name: "IX_Lreg_Employee_Id",
                table: "Lreg");

            migrationBuilder.DropColumn(
                name: "Employee_Id",
                table: "Lreg");
        }
    }
}

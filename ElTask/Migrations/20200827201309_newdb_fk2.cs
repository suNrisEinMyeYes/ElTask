using Microsoft.EntityFrameworkCore.Migrations;

namespace ElTask.Migrations
{
    public partial class newdb_fk2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Laptop_Id",
                table: "Lreg",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Lreg_Laptop_Id",
                table: "Lreg",
                column: "Laptop_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lreg_Laptops_Laptop_Id",
                table: "Lreg",
                column: "Laptop_Id",
                principalTable: "Laptops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lreg_Laptops_Laptop_Id",
                table: "Lreg");

            migrationBuilder.DropIndex(
                name: "IX_Lreg_Laptop_Id",
                table: "Lreg");

            migrationBuilder.DropColumn(
                name: "Laptop_Id",
                table: "Lreg");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Employees",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}

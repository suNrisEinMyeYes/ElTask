using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElTask.Migrations
{
    public partial class newdb_fix_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CurrentStatus",
                table: "Laptops",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CurrentStatus",
                table: "Laptops",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}

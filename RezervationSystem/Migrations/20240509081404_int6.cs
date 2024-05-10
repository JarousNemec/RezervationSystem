using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RezervationSystem.Migrations
{
    /// <inheritdoc />
    public partial class int6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BankBranches_BranchId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<Guid>(
                name: "BranchId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BankBranches_BranchId",
                table: "AspNetUsers",
                column: "BranchId",
                principalTable: "BankBranches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BankBranches_BranchId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BranchId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BankBranches_BranchId",
                table: "AspNetUsers",
                column: "BranchId",
                principalTable: "BankBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

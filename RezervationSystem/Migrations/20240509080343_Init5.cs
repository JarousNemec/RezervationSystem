using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RezervationSystem.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "Meetings",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "BankBranches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranches", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_BranchId",
                table: "Meetings",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BranchId",
                table: "AspNetUsers",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BankBranches_BranchId",
                table: "AspNetUsers",
                column: "BranchId",
                principalTable: "BankBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_BankBranches_BranchId",
                table: "Meetings",
                column: "BranchId",
                principalTable: "BankBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BankBranches_BranchId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_BankBranches_BranchId",
                table: "Meetings");

            migrationBuilder.DropTable(
                name: "BankBranches");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_BranchId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BranchId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "AspNetUsers");
        }
    }
}

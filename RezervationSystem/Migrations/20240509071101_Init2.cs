using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RezervationSystem.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AspNetUsers_ClientId1",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AspNetUsers_EmployeeId1",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_ClientId1",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_EmployeeId1",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Meetings");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ClientId",
                table: "Meetings",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_EmployeeId",
                table: "Meetings",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AspNetUsers_ClientId",
                table: "Meetings",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AspNetUsers_EmployeeId",
                table: "Meetings",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AspNetUsers_ClientId",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AspNetUsers_EmployeeId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_ClientId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_EmployeeId",
                table: "Meetings");

            migrationBuilder.AddColumn<string>(
                name: "ClientId1",
                table: "Meetings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "Meetings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ClientId1",
                table: "Meetings",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_EmployeeId1",
                table: "Meetings",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AspNetUsers_ClientId1",
                table: "Meetings",
                column: "ClientId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AspNetUsers_EmployeeId1",
                table: "Meetings",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

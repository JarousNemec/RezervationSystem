using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RezervationSystem.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AspNetUsers_ClientId",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AspNetUsers_EmployeeId",
                table: "Meetings");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Meetings",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Meetings",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Meetings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AspNetUsers_ClientId",
                table: "Meetings",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AspNetUsers_EmployeeId",
                table: "Meetings",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
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

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Meetings");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Meetings",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Meetings",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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
    }
}

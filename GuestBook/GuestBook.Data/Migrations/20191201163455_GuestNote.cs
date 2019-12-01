using Microsoft.EntityFrameworkCore.Migrations;

namespace GuestBook.Data.Migrations
{
    public partial class GuestNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "GuestNotes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GuestNotes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "GuestNotes",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "GuestNotes",
                maxLength: 345,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "GuestNotes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GuestNotes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "GuestNotes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "GuestNotes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 345);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact_list.Migrations
{
    public partial class fluent_api_configs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Addresses_Addressid",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_Addressid",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Addressid",
                table: "Contacts");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contacts",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddresId",
                table: "Contacts",
                column: "AddresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Addresses_AddresId",
                table: "Contacts",
                column: "AddresId",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Addresses_AddresId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AddresId",
                table: "Contacts");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "Addressid",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Addressid",
                table: "Contacts",
                column: "Addressid");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Addresses_Addressid",
                table: "Contacts",
                column: "Addressid",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

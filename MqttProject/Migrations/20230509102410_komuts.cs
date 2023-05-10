using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MqttProject.Migrations
{
    /// <inheritdoc />
    public partial class komuts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModemGorev_Komuts_Komutid",
                table: "ModemGorev");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModemGorev",
                table: "ModemGorev");

            migrationBuilder.RenameTable(
                name: "ModemGorev",
                newName: "ModemGorevs");

            migrationBuilder.RenameIndex(
                name: "IX_ModemGorev_Komutid",
                table: "ModemGorevs",
                newName: "IX_ModemGorevs_Komutid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModemGorevs",
                table: "ModemGorevs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModemGorevs_Komuts_Komutid",
                table: "ModemGorevs",
                column: "Komutid",
                principalTable: "Komuts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModemGorevs_Komuts_Komutid",
                table: "ModemGorevs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModemGorevs",
                table: "ModemGorevs");

            migrationBuilder.RenameTable(
                name: "ModemGorevs",
                newName: "ModemGorev");

            migrationBuilder.RenameIndex(
                name: "IX_ModemGorevs_Komutid",
                table: "ModemGorev",
                newName: "IX_ModemGorev_Komutid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModemGorev",
                table: "ModemGorev",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModemGorev_Komuts_Komutid",
                table: "ModemGorev",
                column: "Komutid",
                principalTable: "Komuts",
                principalColumn: "Id");
        }
    }
}

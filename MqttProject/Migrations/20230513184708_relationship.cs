using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MqttProject.Migrations
{
    /// <inheritdoc />
    public partial class relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModemGorevs_Komuts_Komutid",
                table: "ModemGorevs");

            migrationBuilder.DropIndex(
                name: "IX_ModemGorevs_Komutid",
                table: "ModemGorevs");

            migrationBuilder.RenameColumn(
                name: "Komutid",
                table: "ModemGorevs",
                newName: "KomutId");

            migrationBuilder.CreateIndex(
                name: "IX_ModemGorevs_KomutId",
                table: "ModemGorevs",
                column: "KomutId",
                unique: true,
                filter: "[KomutId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ModemGorevs_Komuts_KomutId",
                table: "ModemGorevs",
                column: "KomutId",
                principalTable: "Komuts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModemGorevs_Komuts_KomutId",
                table: "ModemGorevs");

            migrationBuilder.DropIndex(
                name: "IX_ModemGorevs_KomutId",
                table: "ModemGorevs");

            migrationBuilder.RenameColumn(
                name: "KomutId",
                table: "ModemGorevs",
                newName: "Komutid");

            migrationBuilder.CreateIndex(
                name: "IX_ModemGorevs_Komutid",
                table: "ModemGorevs",
                column: "Komutid",
                unique: true,
                filter: "[Komutid] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ModemGorevs_Komuts_Komutid",
                table: "ModemGorevs",
                column: "Komutid",
                principalTable: "Komuts",
                principalColumn: "Id");
        }
    }
}

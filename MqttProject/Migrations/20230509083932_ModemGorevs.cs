using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MqttProject.Migrations
{
    /// <inheritdoc />
    public partial class ModemGorevs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Komuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CihazId = table.Column<int>(type: "int", nullable: false),
                    ModemId = table.Column<int>(type: "int", nullable: false),
                    KomutKod = table.Column<int>(type: "int", nullable: false),
                    KomutParams = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaglantiDenemeSayisi = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModemGorev",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rc = table.Column<int>(type: "int", nullable: true),
                    Komutid = table.Column<int>(type: "int", nullable: true),
                    ModemSeriNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gorevid = table.Column<int>(type: "int", nullable: false),
                    Param = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tip = table.Column<int>(type: "int", nullable: false),
                    Periyot = table.Column<long>(type: "bigint", nullable: false),
                    Dakika = table.Column<int>(type: "int", nullable: false),
                    Saat = table.Column<int>(type: "int", nullable: false),
                    Gun = table.Column<int>(type: "int", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModemGorev", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModemGorev_Komuts_Komutid",
                        column: x => x.Komutid,
                        principalTable: "Komuts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModemGorev_Komutid",
                table: "ModemGorev",
                column: "Komutid",
                unique: true,
                filter: "[Komutid] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModemGorev");

            migrationBuilder.DropTable(
                name: "Komuts");
        }
    }
}

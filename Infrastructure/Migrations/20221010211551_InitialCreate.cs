using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRODUTO",
                columns: table => new
                {
                    COD_PRODUTO = table.Column<string>(type: "TEXT", maxLength: 4, nullable: false),
                    DES_PRODUTO = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    STA_STATUS = table.Column<string>(type: "TEXT", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO", x => x.COD_PRODUTO);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO_COSIF",
                columns: table => new
                {
                    COD_PRODUTO = table.Column<string>(type: "TEXT", maxLength: 4, nullable: false),
                    COD_COST = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    COD_CLASSIFICACAO = table.Column<string>(type: "TEXT", maxLength: 6, nullable: true),
                    STA_STATUS = table.Column<string>(type: "TEXT", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO_COSIF", x => new { x.COD_PRODUTO, x.COD_COST });
                    table.ForeignKey(
                        name: "FK_PRODUTO_COSIF_PRODUTO_COD_PRODUTO",
                        column: x => x.COD_PRODUTO,
                        principalTable: "PRODUTO",
                        principalColumn: "COD_PRODUTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MOVIMENTO_MANUAL",
                columns: table => new
                {
                    DAT_MES = table.Column<int>(type: "INTEGER", maxLength: 2, nullable: false),
                    DAT_ANO = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    NUM_LANCAMENTO = table.Column<int>(type: "INTEGER", maxLength: 18, nullable: false),
                    COD_PRODUTO = table.Column<string>(type: "TEXT", maxLength: 4, nullable: false),
                    COD_COSIF = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    PRODUTO_COSIF_COD_COSIFCOD_PRODUTO = table.Column<string>(type: "TEXT", nullable: false),
                    PRODUTO_COSIF_COD_COSIFCOD_COST = table.Column<string>(type: "TEXT", nullable: false),
                    DES_DESCRICAO = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DAT_MOVIMENTO = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    COD_USUARIO = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    VAL_VALOR = table.Column<decimal>(type: "TEXT", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOVIMENTO_MANUAL", x => new { x.DAT_MES, x.DAT_ANO, x.NUM_LANCAMENTO, x.COD_PRODUTO });
                    table.ForeignKey(
                        name: "FK_MOVIMENTO_MANUAL_PRODUTO_COSIF_PRODUTO_COSIF_COD_COSIFCOD_PRODUTO_PRODUTO_COSIF_COD_COSIFCOD_COST",
                        columns: x => new { x.PRODUTO_COSIF_COD_COSIFCOD_PRODUTO, x.PRODUTO_COSIF_COD_COSIFCOD_COST },
                        principalTable: "PRODUTO_COSIF",
                        principalColumns: new[] { "COD_PRODUTO", "COD_COST" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MOVIMENTO_MANUAL_PRODUTO_COSIF_COD_COSIFCOD_PRODUTO_PRODUTO_COSIF_COD_COSIFCOD_COST",
                table: "MOVIMENTO_MANUAL",
                columns: new[] { "PRODUTO_COSIF_COD_COSIFCOD_PRODUTO", "PRODUTO_COSIF_COD_COSIFCOD_COST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MOVIMENTO_MANUAL");

            migrationBuilder.DropTable(
                name: "PRODUTO_COSIF");

            migrationBuilder.DropTable(
                name: "PRODUTO");
        }
    }
}

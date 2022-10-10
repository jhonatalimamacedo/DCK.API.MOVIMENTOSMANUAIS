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
                name: "mOVIMENTO_MANUAL",
                columns: table => new
                {
                    DAT_MES = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DAT_ANO = table.Column<int>(type: "INTEGER", nullable: false),
                    NUM_LANCAMENTO = table.Column<int>(type: "INTEGER", nullable: false),
                    COD_PRODUTO = table.Column<string>(type: "TEXT", nullable: false),
                    COD_COSIF = table.Column<string>(type: "TEXT", nullable: false),
                    DES_DESCRICAO = table.Column<string>(type: "TEXT", nullable: false),
                    DAT_MOVIMENTO = table.Column<DateTime>(type: "TEXT", nullable: false),
                    COD_USUARIO = table.Column<string>(type: "TEXT", nullable: false),
                    VAL_VALOR = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mOVIMENTO_MANUAL", x => x.DAT_MES);
                });

            migrationBuilder.CreateTable(
                name: "pRODUTO",
                columns: table => new
                {
                    COD_PRODUTO = table.Column<string>(type: "TEXT", nullable: false),
                    DES_PRODUTO = table.Column<string>(type: "TEXT", nullable: false),
                    STA_STATUS = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pRODUTO", x => x.COD_PRODUTO);
                });

            migrationBuilder.CreateTable(
                name: "pRODUTO_COSIF",
                columns: table => new
                {
                    COD_PRODUTO = table.Column<string>(type: "TEXT", nullable: false),
                    COD_COST = table.Column<string>(type: "TEXT", nullable: false),
                    COD_CLASSIFICACAO = table.Column<string>(type: "TEXT", nullable: false),
                    STA_STATUS = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pRODUTO_COSIF", x => new { x.COD_PRODUTO, x.COD_COST });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mOVIMENTO_MANUAL");

            migrationBuilder.DropTable(
                name: "pRODUTO");

            migrationBuilder.DropTable(
                name: "pRODUTO_COSIF");
        }
    }
}

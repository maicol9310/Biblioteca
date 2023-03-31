using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Infrastructure.Persistence.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    IBSN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    editoriales_id = table.Column<int>(type: "int", nullable: false),
                    titulos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sinopsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    n_paginas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.IBSN);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}

﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TKMaster.AulaCSharp.Core.Data.Migrations
{
    public partial class BaseDesenv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "fornecedor",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    tipo_pessoa = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
                    nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    dt_inclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dt_alteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dt_exclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fornecedor",
                schema: "dbo");
        }
    }
}

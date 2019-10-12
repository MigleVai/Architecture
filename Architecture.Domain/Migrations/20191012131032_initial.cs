using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture.Domain.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaleModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AssetName = table.Column<string>(maxLength: 50, nullable: true),
                    StartSale = table.Column<DateTime>(nullable: false),
                    EndSale = table.Column<DateTime>(nullable: false),
                    PublisherEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleModels");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLNH_APIs.Migrations
{
    public partial class AddLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "LocationId",
            //    table: "GuestTable",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.CreateTable(
            //    name: "Location",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Location", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTable_LocationId",
            //    table: "GuestTable",
            //    column: "LocationId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_GuestTable_Location_LocationId",
            //    table: "GuestTable",
            //    column: "LocationId",
            //    principalTable: "Location",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_GuestTable_Location_LocationId",
            //    table: "GuestTable");

            //migrationBuilder.DropTable(
            //    name: "Location");

            //migrationBuilder.DropIndex(
            //    name: "IX_GuestTable_LocationId",
            //    table: "GuestTable");

            //migrationBuilder.DropColumn(
            //    name: "LocationId",
            //    table: "GuestTable");
        }
    }
}

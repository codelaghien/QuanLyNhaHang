using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLNH_APIs.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Created",
            //    table: "User",
            //    type: "datetime",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<bool>(
            //    name: "Deleted",
            //    table: "User",
            //    type: "tinyint(1)",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<string>(
            //    name: "Description",
            //    table: "User",
            //    type: "longtext",
            //    nullable: true)
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.AddColumn<bool>(
            //    name: "OffDuty",
            //    table: "User",
            //    type: "tinyint(1)",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<double>(
            //    name: "Price",
            //    table: "User",
            //    type: "double",
            //    nullable: false,
            //    defaultValue: 0.0);

            //migrationBuilder.AddColumn<int>(
            //    name: "RoleId",
            //    table: "User",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Updated",
            //    table: "User",
            //    type: "datetime",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Created",
            //    table: "Item",
            //    type: "datetime",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<bool>(
            //    name: "Deleted",
            //    table: "Item",
            //    type: "tinyint(1)",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<double>(
            //    name: "Discount",
            //    table: "Item",
            //    type: "double",
            //    nullable: false,
            //    defaultValue: 0.0);

            //migrationBuilder.AddColumn<double>(
            //    name: "Price",
            //    table: "Item",
            //    type: "double",
            //    nullable: false,
            //    defaultValue: 0.0);

            //migrationBuilder.AddColumn<int>(
            //    name: "Quantity",
            //    table: "Item",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<int>(
            //    name: "UnitId",
            //    table: "Item",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Updated",
            //    table: "Item",
            //    type: "datetime",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Created",
            //    table: "Category",
            //    type: "datetime",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<bool>(
            //    name: "Deleted",
            //    table: "Category",
            //    type: "tinyint(1)",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Updated",
            //    table: "Category",
            //    type: "datetime",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<int>(
            //    name: "parentId",
            //    table: "Category",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateTable(
            //    name: "ItemImage",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Data = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemImage", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ItemImage_Item_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Role",
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
            //        table.PrimaryKey("PK_Role", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "UnitType",
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
            //        table.PrimaryKey("PK_UnitType", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Unit",
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
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        UnitTypeId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Unit", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Unit_UnitType_UnitTypeId",
            //            column: x => x.UnitTypeId,
            //            principalTable: "UnitType",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateIndex(
            //    name: "IX_User_RoleId",
            //    table: "User",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Item_UnitId",
            //    table: "Item",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ItemImage_ItemId",
            //    table: "ItemImage",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Unit_UnitTypeId",
            //    table: "Unit",
            //    column: "UnitTypeId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Item_Unit_UnitId",
            //    table: "Item",
            //    column: "UnitId",
            //    principalTable: "Unit",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_User_Role_RoleId",
            //    table: "User",
            //    column: "RoleId",
            //    principalTable: "Role",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Item_Unit_UnitId",
            //    table: "Item");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_User_Role_RoleId",
            //    table: "User");

            //migrationBuilder.DropTable(
            //    name: "ItemImage");

            //migrationBuilder.DropTable(
            //    name: "Role");

            //migrationBuilder.DropTable(
            //    name: "Unit");

            //migrationBuilder.DropTable(
            //    name: "UnitType");

            //migrationBuilder.DropIndex(
            //    name: "IX_User_RoleId",
            //    table: "User");

            //migrationBuilder.DropIndex(
            //    name: "IX_Item_UnitId",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Created",
            //    table: "User");

            //migrationBuilder.DropColumn(
            //    name: "Deleted",
            //    table: "User");

            //migrationBuilder.DropColumn(
            //    name: "Description",
            //    table: "User");

            //migrationBuilder.DropColumn(
            //    name: "OffDuty",
            //    table: "User");

            //migrationBuilder.DropColumn(
            //    name: "Price",
            //    table: "User");

            //migrationBuilder.DropColumn(
            //    name: "RoleId",
            //    table: "User");

            //migrationBuilder.DropColumn(
            //    name: "Updated",
            //    table: "User");

            //migrationBuilder.DropColumn(
            //    name: "Created",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Deleted",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Discount",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Price",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Quantity",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "UnitId",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Updated",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Created",
            //    table: "Category");

            //migrationBuilder.DropColumn(
            //    name: "Deleted",
            //    table: "Category");

            //migrationBuilder.DropColumn(
            //    name: "Updated",
            //    table: "Category");

            //migrationBuilder.DropColumn(
            //    name: "parentId",
            //    table: "Category");
        }
    }
}

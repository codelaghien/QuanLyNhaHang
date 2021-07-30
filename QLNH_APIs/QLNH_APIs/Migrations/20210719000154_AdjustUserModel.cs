using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLNH_APIs.Migrations
{
    public partial class AdjustUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Price",
            //    table: "User");

            //migrationBuilder.CreateTable(
            //    name: "Guest",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Phone = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Guest", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "OrderItem",
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
            //        Voided = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        SalePrice = table.Column<double>(type: "double", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderItem", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_OrderItem_Item_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Status",
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
            //        table.PrimaryKey("PK_Status", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Order",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        OrderNumber = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        Voided = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        TotalPrice = table.Column<double>(type: "double", nullable: false),
            //        PaidAmount = table.Column<double>(type: "double", nullable: false),
            //        OrderItemId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Order", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Order_OrderItem_OrderItemId",
            //            column: x => x.OrderItemId,
            //            principalTable: "OrderItem",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "GuestTable",
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
            //        StatusId = table.Column<int>(type: "int", nullable: true),
            //        GuestId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GuestTable", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_GuestTable_Guest_GuestId",
            //            column: x => x.GuestId,
            //            principalTable: "Guest",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_GuestTable_Status_StatusId",
            //            column: x => x.StatusId,
            //            principalTable: "Status",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTable_GuestId",
            //    table: "GuestTable",
            //    column: "GuestId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTable_StatusId",
            //    table: "GuestTable",
            //    column: "StatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Order_OrderItemId",
            //    table: "Order",
            //    column: "OrderItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_ItemId",
            //    table: "OrderItem",
            //    column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "GuestTable");

            //migrationBuilder.DropTable(
            //    name: "Order");

            //migrationBuilder.DropTable(
            //    name: "Guest");

            //migrationBuilder.DropTable(
            //    name: "Status");

            //migrationBuilder.DropTable(
            //    name: "OrderItem");

            //migrationBuilder.AddColumn<double>(
            //    name: "Price",
            //    table: "User",
            //    type: "double",
            //    nullable: false,
            //    defaultValue: 0.0);
        }
    }
}

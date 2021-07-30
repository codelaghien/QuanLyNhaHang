using Microsoft.EntityFrameworkCore.Migrations;

namespace QLNH_APIs.Migrations
{
    public partial class AdjustModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Order_OrderItem_OrderItemId",
            //    table: "Order");

            //migrationBuilder.DropIndex(
            //    name: "IX_Order_OrderItemId",
            //    table: "Order");

            //migrationBuilder.DropColumn(
            //    name: "OrderItemId",
            //    table: "Order");

            //migrationBuilder.AddColumn<int>(
            //    name: "OrderId",
            //    table: "OrderItem",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "CategoryId",
            //    table: "Item",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_OrderId",
            //    table: "OrderItem",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Item_CategoryId",
            //    table: "Item",
            //    column: "CategoryId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Item_Category_CategoryId",
            //    table: "Item",
            //    column: "CategoryId",
            //    principalTable: "Category",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_OrderItem_Order_OrderId",
            //    table: "OrderItem",
            //    column: "OrderId",
            //    principalTable: "Order",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Item_Category_CategoryId",
            //    table: "Item");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_OrderItem_Order_OrderId",
            //    table: "OrderItem");

            //migrationBuilder.DropIndex(
            //    name: "IX_OrderItem_OrderId",
            //    table: "OrderItem");

            //migrationBuilder.DropIndex(
            //    name: "IX_Item_CategoryId",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "OrderId",
            //    table: "OrderItem");

            //migrationBuilder.DropColumn(
            //    name: "CategoryId",
            //    table: "Item");

            //migrationBuilder.AddColumn<int>(
            //    name: "OrderItemId",
            //    table: "Order",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Order_OrderItemId",
            //    table: "Order",
            //    column: "OrderItemId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Order_OrderItem_OrderItemId",
            //    table: "Order",
            //    column: "OrderItemId",
            //    principalTable: "OrderItem",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}

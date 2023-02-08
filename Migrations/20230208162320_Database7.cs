using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTudoroiuSimona251.Migrations
{
    /// <inheritdoc />
    public partial class Database7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Orders_OrderId",
                table: "ProductInOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Products_ProductId",
                table: "ProductInOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder");

            migrationBuilder.RenameTable(
                name: "ProductInOrder",
                newName: "ProductsInOrder");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrder_OrderId",
                table: "ProductsInOrder",
                newName: "IX_ProductsInOrder_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsInOrder",
                table: "ProductsInOrder",
                columns: new[] { "ProductId", "OrderId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsInOrder_Orders_OrderId",
                table: "ProductsInOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsInOrder_Products_ProductId",
                table: "ProductsInOrder",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsInOrder_Orders_OrderId",
                table: "ProductsInOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsInOrder_Products_ProductId",
                table: "ProductsInOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsInOrder",
                table: "ProductsInOrder");

            migrationBuilder.RenameTable(
                name: "ProductsInOrder",
                newName: "ProductInOrder");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "Birthday");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsInOrder_OrderId",
                table: "ProductInOrder",
                newName: "IX_ProductInOrder_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder",
                columns: new[] { "ProductId", "OrderId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Orders_OrderId",
                table: "ProductInOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Products_ProductId",
                table: "ProductInOrder",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

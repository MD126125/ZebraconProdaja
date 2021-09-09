using Microsoft.EntityFrameworkCore.Migrations;

namespace ZebraconProdaja.Migrations
{
    public partial class AddShopingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CbBrandId = table.Column<int>(type: "int", nullable: true),
                    CbModelId = table.Column<int>(type: "int", nullable: true),
                    ThermalPrintersId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_CbBrand_CbBrandId",
                        column: x => x.CbBrandId,
                        principalTable: "CbBrand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_CbModel_CbModelId",
                        column: x => x.CbModelId,
                        principalTable: "CbModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ThermalPrinters_ThermalPrintersId",
                        column: x => x.ThermalPrintersId,
                        principalTable: "ThermalPrinters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CbBrandId",
                table: "ShoppingCartItems",
                column: "CbBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CbModelId",
                table: "ShoppingCartItems",
                column: "CbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ThermalPrintersId",
                table: "ShoppingCartItems",
                column: "ThermalPrintersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");
        }
    }
}

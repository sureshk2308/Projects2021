using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Data.Migrations
{
    public partial class _2ndMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Brands_BrandCategoryForienKey",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_TaxMasters_TaxCategoryForienKey",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryImages_Categories_CategoryForienKey",
                table: "CategoryImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductForienKey",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandProductForienKey",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryProductForienKey",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TaxMasters_TaxProductForienKey",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BrandProductForienKey",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryProductForienKey",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TaxProductForienKey",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductForienKey",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_CategoryImages_CategoryForienKey",
                table: "CategoryImages");

            migrationBuilder.DropIndex(
                name: "IX_Categories_BrandCategoryForienKey",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_TaxCategoryForienKey",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BrandProductForienKey",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryProductForienKey",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TaxProductForienKey",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AuditTime",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BrandCategoryForienKey",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "TaxCategoryForienKey",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryForienKey",
                table: "CategoryImages",
                newName: "CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "CategoryImages",
                newName: "CategoryForienKey");

            migrationBuilder.AddColumn<int>(
                name: "BrandProductForienKey",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryProductForienKey",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxProductForienKey",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditTime",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BrandCategoryForienKey",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxCategoryForienKey",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandProductForienKey",
                table: "Products",
                column: "BrandProductForienKey");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryProductForienKey",
                table: "Products",
                column: "CategoryProductForienKey");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TaxProductForienKey",
                table: "Products",
                column: "TaxProductForienKey");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductForienKey",
                table: "ProductImages",
                column: "ProductForienKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryImages_CategoryForienKey",
                table: "CategoryImages",
                column: "CategoryForienKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BrandCategoryForienKey",
                table: "Categories",
                column: "BrandCategoryForienKey");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TaxCategoryForienKey",
                table: "Categories",
                column: "TaxCategoryForienKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Brands_BrandCategoryForienKey",
                table: "Categories",
                column: "BrandCategoryForienKey",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_TaxMasters_TaxCategoryForienKey",
                table: "Categories",
                column: "TaxCategoryForienKey",
                principalTable: "TaxMasters",
                principalColumn: "TaxId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryImages_Categories_CategoryForienKey",
                table: "CategoryImages",
                column: "CategoryForienKey",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductForienKey",
                table: "ProductImages",
                column: "ProductForienKey",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandProductForienKey",
                table: "Products",
                column: "BrandProductForienKey",
                principalTable: "Brands",
                principalColumn: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryProductForienKey",
                table: "Products",
                column: "CategoryProductForienKey",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TaxMasters_TaxProductForienKey",
                table: "Products",
                column: "TaxProductForienKey",
                principalTable: "TaxMasters",
                principalColumn: "TaxId");
        }
    }
}

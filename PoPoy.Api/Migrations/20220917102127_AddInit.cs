﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoPoy.Api.Migrations
{
    public partial class AddInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvatarPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCategories", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPath", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("bba8299b-6a49-4d45-98bb-763d0043361d"), 0, null, "a45c1c4d-4c0e-44b8-8f34-0d68e8fe1449", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hovanthanh12102002@gmail.com", true, "Van Thanh", "Ho", false, null, "hovanthanh12102002@gmail.com", "thanhhv", "AQAAAAEAACcQAAAAEIfPJ+WSaz/rS/+jGf4yumb5pDavBMvWq+flnEp4ZpmXy9Z+i2rxhsEIeiOGSlItsQ==", "032132131", false, "36de83b0-c0dd-4b2c-8ac5-33050fcc8f92", false, "thanhhv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "SortOrder", "Status", "Url" },
                values: new object[,]
                {
                    { 3, "Giày Nike", 1, 1, "nike-shoes" },
                    { 1, "Giày Adidas", 1, 1, "adidas-shoes" },
                    { 2, "Giày Jordan", 1, 1, "jordan-shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "OriginalPrice", "Price", "Quantity", "Stock", "Title", "Views" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 9, 17, 17, 21, 27, 101, DateTimeKind.Local).AddTicks(8882), "ADIDAS ALPHABOOST “CORE BLACK”", 0m, 2150000m, 1000, 0, "ADIDAS ALPHABOOST “CORE BLACK”", 0 },
                    { 17, 3, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9807), "NIKE AIR FORCE 1 GS WHITE UNIVERSITY RED ", 0m, 2850000m, 1000, 0, "NIKE AIR FORCE 1 GS WHITE UNIVERSITY RED ", 0 },
                    { 16, 3, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9805), "NIKE AIR FORCE 1 GS LOW WHITE PINK FOAM ", 0m, 2950000m, 1000, 0, "NIKE AIR FORCE 1 GS LOW WHITE PINK FOAM ", 0 },
                    { 15, 3, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9803), "NIKE AIR FORCE 1 LOW BY YOU CUSTOM – GUCCI ", 0m, 3950000m, 1000, 0, "NIKE AIR FORCE 1 LOW BY YOU CUSTOM – GUCCI ", 0 },
                    { 14, 3, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9801), "GIÀY NIKE DUNK LOW DISRUPT 2 ‘MALACHITE’ ", 0m, 4850000m, 1000, 0, "GIÀY NIKE DUNK LOW DISRUPT 2 ‘MALACHITE’ ", 0 },
                    { 13, 3, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9799), "CR7 X AIR MAX 97 GS ‘PORTUGAL PATCHWORK’ ", 0m, 4300000m, 1000, 0, "CR7 X AIR MAX 97 GS ‘PORTUGAL PATCHWORK’ ", 0 },
                    { 12, 2, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9797), "AIR JORDAN 1 LOW GS RUSH BLUE BRILL ", 0m, 4350000m, 1000, 0, "AIR JORDAN 1 LOW GS RUSH BLUE BRILL ", 0 },
                    { 11, 2, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9794), "AIR JORDAN 1 LOW GS TRIPLE WHITE ", 0m, 3850000m, 1000, 0, "AIR JORDAN 1 LOW GS TRIPLE WHITE ", 0 },
                    { 10, 2, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9792), "AIR JORDAN 1 HIGH ZOOM ‘CANYON RUST’ ", 0m, 5550000m, 1000, 0, "AIR JORDAN 1 HIGH ZOOM ‘CANYON RUST’ ", 0 },
                    { 18, 3, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9809), "NIKE AIR FORCE 1 LOW ’07 ESSENTIAL WHITE METALLIC SILVER BLACK ", 0m, 3200000m, 1000, 0, "NIKE AIR FORCE 1 LOW ’07 ESSENTIAL WHITE METALLIC SILVER BLACK ", 0 },
                    { 7, 2, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9785), "AIR JORDAN 1 HIGH ‘BORDEAUX’", 0m, 6100000m, 1000, 0, "AIR JORDAN 1 HIGH ‘BORDEAUX’", 0 },
                    { 6, 1, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9783), "ADIDAS ULTRA BOOST 20 NASA CLOUD WHITE ", 0m, 2550000m, 1000, 0, "ADIDAS ULTRA BOOST 20 NASA CLOUD WHITE ", 0 },
                    { 5, 1, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9781), "ADIDAS NMD R1 TOKYO DRAGON", 0m, 1850000m, 1000, 0, "ADIDAS NMD R1 TOKYO DRAGON", 0 },
                    { 4, 1, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9778), "ADIDAS SUPERSTAR OG ‘VINTAGE WHITE’", 0m, 1650000m, 1000, 0, "ADIDAS SUPERSTAR OG ‘VINTAGE WHITE’", 0 },
                    { 3, 1, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9679), "ADIDAS SEAN WOTHERSPOON X SUPERSTAR ‘SUPER EARTH – BLACK’", 0m, 3250000m, 1000, 0, "ADIDAS SEAN WOTHERSPOON X SUPERSTAR ‘SUPER EARTH – BLACK’", 0 },
                    { 2, 1, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9657), "ADIDAS NMD R1 SERIAL PACK METAL GREY", 0m, 1650000m, 1000, 0, "ADIDAS NMD R1 SERIAL PACK METAL GREY", 0 },
                    { 9, 2, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9789), "AIR JORDAN 1 HIGH RETRO ‘HERITAGE’ GS ", 0m, 4850000m, 1000, 0, "AIR JORDAN 1 HIGH RETRO ‘HERITAGE’ GS ", 0 },
                    { 8, 2, new DateTime(2022, 9, 17, 17, 21, 27, 102, DateTimeKind.Local).AddTicks(9787), "AIR JORDAN 1 HIGH OG “BUBBLE GUM”", 0m, 6450000m, 1000, 0, "AIR JORDAN 1 HIGH OG “BUBBLE GUM”", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 15 },
                    { 3, 14 },
                    { 3, 13 },
                    { 2, 12 },
                    { 2, 11 },
                    { 2, 10 },
                    { 3, 16 },
                    { 2, 9 },
                    { 2, 7 },
                    { 1, 6 },
                    { 1, 5 },
                    { 1, 4 },
                    { 1, 3 },
                    { 1, 2 },
                    { 2, 8 },
                    { 3, 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCategories_ProductId",
                table: "ProductInCategories",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductInCategories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
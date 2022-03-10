using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoStrada.API.Data
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    CodeProduct = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateFabrication = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateValidity = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CodeSupplier = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.CodeProduct);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    CodeSupplier = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescriptionSupplier = table.Column<string>(type: "TEXT", nullable: true),
                    TelephoneSupplier = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.CodeSupplier);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 10, 0, 47, 29, 87, DateTimeKind.Local).AddTicks(3944), new DateTime(2023, 3, 10, 0, 47, 29, 89, DateTimeKind.Local).AddTicks(59), "Aceite de bacalao", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 2, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1030), "jabon de cocina", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 3, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1105), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1106), "Leche Pasteurizada Entera", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 4, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1113), "Azúcar Blanca", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 5, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1118), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1119), "Atún en Lata", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 6, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1130), "Crema de cebolla", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 7, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1133), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1134), "Espinacas precocidas", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 8, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1137), "Guantes eterna", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 9, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1140), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1141), "Esponjilla Brillamas", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 10, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1146), "Lustrador de botas", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 11, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1149), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1150), "Bolsas Resellables", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "CodeProduct", "CodeSupplier", "DateFabrication", "DateValidity", "Description", "State" },
                values: new object[] { 12, 1, new DateTime(2022, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1152), new DateTime(2023, 3, 10, 0, 47, 29, 90, DateTimeKind.Local).AddTicks(1153), "Papel Absorvente", true });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "CodeSupplier", "DescriptionSupplier", "Status", "TelephoneSupplier" },
                values: new object[] { 1, "Superbodega del rincon", true, "3123061932" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}

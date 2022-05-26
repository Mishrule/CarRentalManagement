using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 5, 26, 18, 21, 19, 647, DateTimeKind.Local).AddTicks(9154), "Black", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 2, "System", new DateTime(2022, 5, 26, 18, 21, 19, 648, DateTimeKind.Local).AddTicks(6263), "Blue", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(5782), "BMW", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6063), "System" },
                    { 2, "System", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6832), "Ford", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6836), "System" },
                    { 3, "System", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6838), "Toyota", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6839), "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9229), "Vitz", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9496), "System" },
                    { 2, "System", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9501), "3 Series", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9503), "System" },
                    { 3, "System", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9504), "X4", new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9505), "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

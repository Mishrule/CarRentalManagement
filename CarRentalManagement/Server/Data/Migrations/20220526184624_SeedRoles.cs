using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "b40d8caa-73fb-49a4-be85-c94ea32bbda3", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "7f8f2494-fe1b-4fc1-9124-ee5eec748811", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 26, 18, 46, 23, 995, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 26, 18, 46, 23, 995, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 46, 23, 996, DateTimeKind.Local).AddTicks(8349), new DateTime(2022, 5, 26, 18, 46, 23, 996, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 46, 23, 996, DateTimeKind.Local).AddTicks(8899), new DateTime(2022, 5, 26, 18, 46, 23, 996, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 46, 23, 996, DateTimeKind.Local).AddTicks(8904), new DateTime(2022, 5, 26, 18, 46, 23, 996, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 46, 23, 997, DateTimeKind.Local).AddTicks(1266), new DateTime(2022, 5, 26, 18, 46, 23, 997, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 46, 23, 997, DateTimeKind.Local).AddTicks(1551), new DateTime(2022, 5, 26, 18, 46, 23, 997, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 46, 23, 997, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 5, 26, 18, 46, 23, 997, DateTimeKind.Local).AddTicks(1554) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 26, 18, 21, 19, 647, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 26, 18, 21, 19, 648, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(5782), new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6832), new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6838), new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9229), new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9501), new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9504), new DateTime(2022, 5, 26, 18, 21, 19, 649, DateTimeKind.Local).AddTicks(9505) });
        }
    }
}

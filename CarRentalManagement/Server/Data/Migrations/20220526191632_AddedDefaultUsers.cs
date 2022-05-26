using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "008063d3-3aa4-4671-a722-d4c01b330894");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "6f4a97ba-eaf6-4dc2-9a15-3452d7fecbf5");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "c844f5b5-2cc8-40f8-b0d7-f07d3f17c4a8", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDqCGcnnlSIA63XGso7QVPZC+grMACEpvhtpVZ7heY/lw1IJ6VC0o7kEkffOIvZyLw==", null, false, "9d48d8b8-c2b4-424b-b88e-dc1cf0861f3b", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "40c80150-723d-4a90-91eb-b852c61d3efb", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOcnVR1u9yIEhHP1FsqP1ayWvVTZF+/BuLRzSTeQPfNxHScAjt+xc4lq9ixl4mPy6g==", null, false, "e6f6216b-4041-4eda-8ad9-ea3fc338b505", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 26, 19, 16, 31, 759, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 26, 19, 16, 31, 759, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 19, 16, 31, 760, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 5, 26, 19, 16, 31, 760, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 19, 16, 31, 760, DateTimeKind.Local).AddTicks(9622), new DateTime(2022, 5, 26, 19, 16, 31, 760, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 19, 16, 31, 760, DateTimeKind.Local).AddTicks(9628), new DateTime(2022, 5, 26, 19, 16, 31, 760, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 19, 16, 31, 761, DateTimeKind.Local).AddTicks(1924), new DateTime(2022, 5, 26, 19, 16, 31, 761, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 19, 16, 31, 761, DateTimeKind.Local).AddTicks(2194), new DateTime(2022, 5, 26, 19, 16, 31, 761, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 19, 16, 31, 761, DateTimeKind.Local).AddTicks(2197), new DateTime(2022, 5, 26, 19, 16, 31, 761, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b40d8caa-73fb-49a4-be85-c94ea32bbda3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "7f8f2494-fe1b-4fc1-9124-ee5eec748811");

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
    }
}

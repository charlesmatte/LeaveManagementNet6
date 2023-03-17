using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "f791ee49-eebf-4825-beb5-ba1e371d4ce0", "Administrator", "ADMINISTRATOR" },
                    { "ddd43e6e-f9bb-4448-baaf-1abb443ccfef", "c2ab58f7-14a3-45d3-b8ef-acbede560ee5", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "edf41a6e-f7ac-1238-baef-1add523ccbbf", 0, "ff1cb524-dd95-426e-bc4d-9830eb71df29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@domain.com", false, "System", "Admin", false, null, "ADMIN@DOMAIN.COM", null, "AQAAAAEAACcQAAAAEG4vjmgRnd5/Wb1+e2LLX+3c9Smqu1qfV2BVFn1Etf9Be24byRwTyeIWQKs9BkK4dg==", null, false, "0fa310cb-283e-4acb-901e-2ef3a8645520", null, false, null },
                    { "edf41a6e-f7ac-1238-baef-1add523ccccf", 0, "273fe964-a2b1-4130-bd04-97a51b19ffc0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@domain.com", false, "System", "User", false, null, "USER@DOMAIN.COM", null, "AQAAAAEAACcQAAAAEMjRDkrJKJjS6DH8C5NntP3YS9c4i8gDRJiB/GNnSAhHxoU1LnVTp/s6dduVIQycKA==", null, false, "241b6615-b353-4d16-8e32-ddd9e025259c", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "edf41a6e-f7ac-1238-baef-1add523ccbbf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ddd43e6e-f9bb-4448-baaf-1abb443ccfef", "edf41a6e-f7ac-1238-baef-1add523ccccf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "edf41a6e-f7ac-1238-baef-1add523ccbbf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddd43e6e-f9bb-4448-baaf-1abb443ccfef", "edf41a6e-f7ac-1238-baef-1add523ccccf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddd43e6e-f9bb-4448-baaf-1abb443ccfef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccccf");
        }
    }
}

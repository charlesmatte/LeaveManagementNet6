using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "8e24045b-4a17-468f-9f11-8da92c26a9f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddd43e6e-f9bb-4448-baaf-1abb443ccfef",
                column: "ConcurrencyStamp",
                value: "098146c3-1dbb-402d-8b92-5e60162100f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccbbf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "805d7c78-8e1a-4ea6-92da-78bdb8143342", true, "ADMIN@DOMAIN.COM", "AQAAAAEAACcQAAAAENC8ZuU+uyl6uiORiRsuudN+UNpL/Jrztbir2kbdXIqcXOQmTvt+U+qKOwx8wtcuoQ==", "7b9171ed-8604-44fb-8e8a-aeb4c58f5b25", "admin@domain.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccccf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6755a875-7328-4f4e-af4d-e27d5b7015a2", true, "USER@DOMAIN.COM", "AQAAAAEAACcQAAAAEMJL/9qxj+VIgSxpw5XAutEId9SzIeIAgMhwLCHmMC/ThCMIyxrDJ8HlhHZgj/8l/g==", "bcdf9784-7170-42cd-bbfa-166c10bf7e35", "user@domain.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f791ee49-eebf-4825-beb5-ba1e371d4ce0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddd43e6e-f9bb-4448-baaf-1abb443ccfef",
                column: "ConcurrencyStamp",
                value: "c2ab58f7-14a3-45d3-b8ef-acbede560ee5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccbbf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ff1cb524-dd95-426e-bc4d-9830eb71df29", false, null, "AQAAAAEAACcQAAAAEG4vjmgRnd5/Wb1+e2LLX+3c9Smqu1qfV2BVFn1Etf9Be24byRwTyeIWQKs9BkK4dg==", "0fa310cb-283e-4acb-901e-2ef3a8645520", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccccf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "273fe964-a2b1-4130-bd04-97a51b19ffc0", false, null, "AQAAAAEAACcQAAAAEMjRDkrJKJjS6DH8C5NntP3YS9c4i8gDRJiB/GNnSAhHxoU1LnVTp/s6dduVIQycKA==", "241b6615-b353-4d16-8e32-ddd9e025259c", null });
        }
    }
}

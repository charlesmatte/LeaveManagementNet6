using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a13258b7-fb3f-40c1-bc06-5dc867aeb437");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddd43e6e-f9bb-4448-baaf-1abb443ccfef",
                column: "ConcurrencyStamp",
                value: "9744bd73-7aa3-44f1-901a-2713c7ee277a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c703e57-9d62-4d7e-8bc5-ff738f935d2e", "AQAAAAEAACcQAAAAEOU2NMGLypwg088TrlgFVb5wnA4qCVALufdWEvJdMrJgW6lGLQtIJYHi6HBVoBfWVA==", "be574435-71ba-4265-8c2f-759d25cc0fbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccccf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba981f8e-89f0-45f6-a1f5-6b9faff34204", "AQAAAAEAACcQAAAAENN4vG/BXEIU0ZCY+kfYIMRxzhUUlhP/KdEJmrl2HNIuNsE/k/juUrAT4VZoeRwqJQ==", "2994664c-d490-4b8d-84d7-665bb6ff15c5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "805d7c78-8e1a-4ea6-92da-78bdb8143342", "AQAAAAEAACcQAAAAENC8ZuU+uyl6uiORiRsuudN+UNpL/Jrztbir2kbdXIqcXOQmTvt+U+qKOwx8wtcuoQ==", "7b9171ed-8604-44fb-8e8a-aeb4c58f5b25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccccf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6755a875-7328-4f4e-af4d-e27d5b7015a2", "AQAAAAEAACcQAAAAEMJL/9qxj+VIgSxpw5XAutEId9SzIeIAgMhwLCHmMC/ThCMIyxrDJ8HlhHZgj/8l/g==", "bcdf9784-7170-42cd-bbfa-166c10bf7e35" });
        }
    }
}

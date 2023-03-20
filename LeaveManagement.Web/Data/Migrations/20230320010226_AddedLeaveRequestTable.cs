using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "86581ce3-b7ef-4a21-904f-a57caa66abd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddd43e6e-f9bb-4448-baaf-1abb443ccfef",
                column: "ConcurrencyStamp",
                value: "2cda3b6e-bccb-4bcf-9067-a087a16d8627");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19be855c-11c6-45fe-8067-bbc5d6d06562", "AQAAAAEAACcQAAAAEASlbySlw/+RTdoIUPJQDrfWoIDf70VKEX0HCiwhTjJVX8QfuCJfQWWltxshHd8Hew==", "b230fe62-1354-4ee4-be4b-b7b22f72f277" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccccf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0441916-3c8d-42c7-b91d-ff01bb4ed34f", "AQAAAAEAACcQAAAAEH9Btk2d0C0km5dh+bblJKubTzsyU6HNvIrzX1mC8YDJwgIAvQhHjePmRVFxl2vH/Q==", "c8ea7c3b-de94-443a-a52a-639466618c29" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "99143f3f-1b39-4d21-ac20-0bc99b375901");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddd43e6e-f9bb-4448-baaf-1abb443ccfef",
                column: "ConcurrencyStamp",
                value: "ba37460f-6f5c-4a2b-9d8f-8375334ed9a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61ab5531-595b-4ee1-8736-1414e53a7d5f", "AQAAAAEAACcQAAAAEMnRjrq+2j+ZDWILs758k8+ir6IyTwco/J2lLCQIBdJapiJAbhYH/YqzPhfNlUo6pA==", "3aa71cab-4a79-4277-9611-f7fd6a732fec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf41a6e-f7ac-1238-baef-1add523ccccf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53357085-cd92-4417-9125-e30c97bf2680", "AQAAAAEAACcQAAAAEKRbanGqrE9yB8tjVSgVaQU54yzyWn177WZU6+Ev/KZK/PDbUvBBDqMZzBWQML7DNA==", "db9365bd-854f-47e1-8133-2f880bb8d6c3" });
        }
    }
}

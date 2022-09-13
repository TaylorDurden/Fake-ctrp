using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fake_ctrip.API.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Description", "DiscountPresent", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("ed65d81f-a2ba-4c66-b29e-9e613b1c967d"), new DateTime(2022, 9, 13, 14, 46, 26, 858, DateTimeKind.Utc).AddTicks(6167), null, "desc", null, "Features Features Features", "Fees Fees Fees", "Notes Notes Notes", 0m, "title title", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("ed65d81f-a2ba-4c66-b29e-9e613b1c967d"));
        }
    }
}

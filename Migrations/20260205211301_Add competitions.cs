using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Athlitix.Migrations
{
    /// <inheritdoc />
    public partial class Addcompetitions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Competition",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "FinishDate", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "OrganizationId", "StartDate" },
                values: new object[,]
                {
                    { new Guid("8f3a2c1b-4d7e-4a9f-8b2d-1c0e9f7a6b5d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A thrilling summer event bringing together top amateurs for fast-paced bouts.", new DateTimeOffset(new DateTime(2026, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), true, null, null, "Summer Showdown", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1"), new DateTimeOffset(new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("d4e7a1b2-3c8f-4d5a-9e7b-2f1c0a8d9e6b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kicking off August with fierce matchups across all weight categories.", new DateTimeOffset(new DateTime(2026, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), true, null, null, "August Clash", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1"), new DateTimeOffset(new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competition",
                keyColumn: "Id",
                keyValue: new Guid("8f3a2c1b-4d7e-4a9f-8b2d-1c0e9f7a6b5d"));

            migrationBuilder.DeleteData(
                table: "Competition",
                keyColumn: "Id",
                keyValue: new Guid("d4e7a1b2-3c8f-4d5a-9e7b-2f1c0a8d9e6b"));
        }
    }
}

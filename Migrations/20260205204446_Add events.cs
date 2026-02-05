using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Athlitix.Migrations
{
    /// <inheritdoc />
    public partial class Addevents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3f2dbfda-3842-4bd9-a063-00d5fde0c9a0"));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CompetitionId", "CreatedAt", "CreatedBy", "Description", "EventTypeId", "FinishDate", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("101a7f3c-9c2b-4f1a-9e3d-6c5a4b3d2e01"), new Guid("561e6139-413c-4de6-bbdc-6c58bb3b61aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Men's amateur lightweight division (Under 60kg).", new Guid("dbc5f1de-fcba-4d0a-8a71-eeb1f209eeff"), new DateTimeOffset(new DateTime(2026, 7, 7, 20, 15, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, null, null, "Men's Under 60kg Open", new DateTimeOffset(new DateTime(2026, 7, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("202b8e4d-1a3c-4b2d-8f9e-7d6c5b4a3e02"), new Guid("561e6139-413c-4de6-bbdc-6c58bb3b61aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Men's amateur light-middleweight division (Under 71kg).", new Guid("d9fdad56-2c37-4be7-89ab-1af3cf1142c7"), new DateTimeOffset(new DateTime(2026, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, null, null, "Men's Under 71kg Open", new DateTimeOffset(new DateTime(2026, 7, 7, 20, 15, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("303c9d5e-2b4d-4c3e-9a8f-8e7d6c5b4a03"), new Guid("561e6139-413c-4de6-bbdc-6c58bb3b61aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Men's amateur bantamweight division (Under 54kg).", new Guid("dbc5f1de-fcba-4d0a-8a71-eeb1f209eeff"), new DateTimeOffset(new DateTime(2026, 7, 7, 20, 45, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, null, null, "Men's Under 54kg Open", new DateTimeOffset(new DateTime(2026, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("404d0c6f-3c5e-4d4f-8b7a-9f8e7d6c5b04"), new Guid("561e6139-413c-4de6-bbdc-6c58bb3b61aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Men's amateur light-heavyweight division (Under 80kg).", new Guid("d9fdad56-2c37-4be7-89ab-1af3cf1142c7"), new DateTimeOffset(new DateTime(2026, 7, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, null, null, "Men's Under 80kg Open", new DateTimeOffset(new DateTime(2026, 7, 7, 20, 45, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("505e1b7a-4d6f-4e5a-9c8b-0a9f8e7d6c05"), new Guid("561e6139-413c-4de6-bbdc-6c58bb3b61aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Men's amateur light-welterweight division (Under 63.5kg).", new Guid("dbc5f1de-fcba-4d0a-8a71-eeb1f209eeff"), new DateTimeOffset(new DateTime(2026, 7, 7, 21, 15, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, null, null, "Men's Under 63.5kg Open", new DateTimeOffset(new DateTime(2026, 7, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("606f2a8b-5e7a-4f6b-8d9c-1b0a9f8e7d06"), new Guid("561e6139-413c-4de6-bbdc-6c58bb3b61aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Men's amateur heavyweight division (Under 92kg).", new Guid("d9fdad56-2c37-4be7-89ab-1af3cf1142c7"), new DateTimeOffset(new DateTime(2026, 7, 7, 21, 30, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, null, null, "Men's Under 92kg Open", new DateTimeOffset(new DateTime(2026, 7, 7, 21, 15, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("707a3b9c-6f8b-4a7c-9e0d-2c1b0a9f8e07"), new Guid("561e6139-413c-4de6-bbdc-6c58bb3b61aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Men's amateur featherweight division (Under 57kg).", new Guid("dbc5f1de-fcba-4d0a-8a71-eeb1f209eeff"), new DateTimeOffset(new DateTime(2026, 7, 7, 21, 45, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, null, null, "Men's Under 57kg Open", new DateTimeOffset(new DateTime(2026, 7, 7, 21, 30, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("808b4cad-7a9c-4b8d-8f1e-3d2c1b0a9f08"), new Guid("561e6139-413c-4de6-bbdc-6c58bb3b61aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Men's amateur super-heavyweight division (Over 92kg).", new Guid("d9fdad56-2c37-4be7-89ab-1af3cf1142c7"), new DateTimeOffset(new DateTime(2026, 7, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, null, null, "Men's Over 92kg Open", new DateTimeOffset(new DateTime(2026, 7, 7, 21, 45, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("101a7f3c-9c2b-4f1a-9e3d-6c5a4b3d2e01"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("202b8e4d-1a3c-4b2d-8f9e-7d6c5b4a3e02"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("303c9d5e-2b4d-4c3e-9a8f-8e7d6c5b4a03"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("404d0c6f-3c5e-4d4f-8b7a-9f8e7d6c5b04"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("505e1b7a-4d6f-4e5a-9c8b-0a9f8e7d6c05"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("606f2a8b-5e7a-4f6b-8d9c-1b0a9f8e7d06"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("707a3b9c-6f8b-4a7c-9e0d-2c1b0a9f8e07"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("808b4cad-7a9c-4b8d-8f1e-3d2c1b0a9f08"));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CompetitionId", "CreatedAt", "CreatedBy", "Description", "EventTypeId", "FinishDate", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "StartDate" },
                values: new object[] { new Guid("3f2dbfda-3842-4bd9-a063-00d5fde0c9a0"), new Guid("561e6139-413c-4de6-bbdc-6c58bb3b61aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", new Guid("dbc5f1de-fcba-4d0a-8a71-eeb1f209eeff"), new DateTimeOffset(new DateTime(2026, 7, 1, 19, 45, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), true, null, null, "70kg - Skate McCartney vs Abdul Mohadeen", new DateTimeOffset(new DateTime(2026, 7, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)) });
        }
    }
}

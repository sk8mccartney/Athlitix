using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Athlitix.Migrations
{
    /// <inheritdoc />
    public partial class Addteams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "OrganizationId" },
                values: new object[,]
                {
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fearless fighters roaring out of central Leeds", true, null, null, "LS1 Leeds Lions", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grit-fueled brawlers built for pressure fights", true, null, null, "M1 Manchester Maulers", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Forged tough with relentless knockout power", true, null, null, "S6 Sheffield Steel", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fast-handed fighters with championship ambition", true, null, null, "L2 Liverpool Legends", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Late-round warriors with ruthless finishes", true, null, null, "NE1 Newcastle Nightfall", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Midlands muscle with heavy-hitting intent", true, null, null, "B1 Birmingham Brutes", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Precision punchers with outlaw mentality", true, null, null, "NG1 Nottingham Knockout", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Explosive speed and high-volume attacks", true, null, null, "LE1 Leicester Lightning", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Breakdown specialists who wear opponents out", true, null, null, "CV1 Coventry Crushers", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ring control experts with suffocating pressure", true, null, null, "DE1 Derby Dominators", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elite-level fighters chasing national dominance", true, null, null, "EC1 London Empire", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Smooth operators with sudden knockout power", true, null, null, "BN1 Brighton Breakers", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sharp-shooting south coast contenders", true, null, null, "SO14 Southampton Strikers", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hard-nosed fighters with navy-town toughness", true, null, null, "PO1 Portsmouth Punishers", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Modern warriors with old-school grit", true, null, null, "GU1 Guildford Gladiators", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Smart, technical fighters with killer instinct", true, null, null, "CB1 Cambridge Combat", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Street-bred toughness with pro-level skill", true, null, null, "BS1 Bristol Brawlers", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Southern grit with relentless pressure style", true, null, null, "EX1 Exeter Enforcers", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tidal-force punchers from the southwest", true, null, null, "PL1 Plymouth Power", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Calculated destruction with elite ring IQ", true, null, null, "OX1 Oxford Overlords", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"));
        }
    }
}

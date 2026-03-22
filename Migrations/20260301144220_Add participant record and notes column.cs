using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Athlitix.Migrations
{
    /// <inheritdoc />
    public partial class Addparticipantrecordandnotescolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Participant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Record",
                table: "Participant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000001-1111-4111-8111-111111111001"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000002-1111-4111-8111-111111111002"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000003-1111-4111-8111-111111111003"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000004-1111-4111-8111-111111111004"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000005-1111-4111-8111-111111111005"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000006-1111-4111-8111-111111111006"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000007-1111-4111-8111-111111111007"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000008-1111-4111-8111-111111111008"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000009-1111-4111-8111-111111111009"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000010-1111-4111-8111-111111111010"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000011-1111-4111-8111-111111111011"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000012-1111-4111-8111-111111111012"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000013-1111-4111-8111-111111111013"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000014-1111-4111-8111-111111111014"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000015-1111-4111-8111-111111111015"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000016-1111-4111-8111-111111111016"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000017-1111-4111-8111-111111111017"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000018-1111-4111-8111-111111111018"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000019-1111-4111-8111-111111111019"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000020-1111-4111-8111-111111111020"),
                columns: new[] { "Notes", "Record" },
                values: new object[] { "Taken 3 months off", "Win = 3, Loss 2, Draw 0" });

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FirstName", "HeightCm", "IsActive", "LastName", "ModifiedAt", "ModifiedBy", "NickName", "Notes", "PasswordHash", "PhoneNumber", "Record", "TeamId", "WeightKg" },
                values: new object[,]
                {
                    { new Guid("0095cb38-8917-4fcf-8a45-86fa72831a51"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "rhys.stewart149@example.com", "Rhys", 193m, true, "Stewart", null, null, "Voltage", "", "", "07470100049", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 100.8m },
                    { new Guid("028c5d72-cdf3-486f-bd69-201fdfb6c3bc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reece.cox257@example.com", "Reece", 174m, true, "Cox", null, null, "Steel", "", "", "07470100157", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 82.2m },
                    { new Guid("03722e19-a1f5-4362-90b9-748211dfabeb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alex.allen148@example.com", "Alex", 179m, true, "Allen", null, null, "Fang", "", "", "07470100048", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 109.5m },
                    { new Guid("04971b0f-c5ca-4f43-b8e0-d789eed3072d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "henry.barnes123@example.com", "Henry", 189m, true, "Barnes", null, null, "Cutlass", "", "", "07470100023", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 96.1m },
                    { new Guid("060dfebd-e962-474d-a19c-5bf859ecb735"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "evan.hamilton154@example.com", "Evan", 198m, true, "Hamilton", null, null, "Nightfall", "", "", "07470100054", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 86.5m },
                    { new Guid("08c6b3e1-249c-47da-96b9-c515c1adcfc0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ryan.ramirez224@example.com", "Ryan", 180m, true, "Ramirez", null, null, "Echo", "", "", "07470100124", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 95.7m },
                    { new Guid("0b02bfec-2b64-4731-8dab-b1a025d5037c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "sean.sanchez280@example.com", "Sean", 166m, true, "Sanchez", null, null, "Panther", "", "", "07470100180", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 65.1m },
                    { new Guid("0b03a8a3-bb3b-48ab-b871-bc3bd47b23d1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "isaac.turner120@example.com", "Isaac", 167m, true, "Turner", null, null, "Nightfall", "", "", "07470100020", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 55.0m },
                    { new Guid("0c07250b-0d0d-4c75-b0fa-082a0d53ff3b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "max.washington246@example.com", "Max", 187m, true, "Washington", null, null, "Longshot", "", "", "07470100146", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 119.8m },
                    { new Guid("0d23a3e3-89f3-46ec-85ab-7fe71ca05140"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "oscar.griffin128@example.com", "Oscar", 169m, true, "Griffin", null, null, "Cosmo", "", "", "07470100028", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 70.1m },
                    { new Guid("0df3a89b-70af-495b-bf63-76572f513adb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "tyler.griffin115@example.com", "Tyler", 166m, true, "Griffin", null, null, "Dagger", "", "", "07470100015", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 94.2m },
                    { new Guid("0fe87b77-310e-492f-a6f1-3409ee0f00e6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jaxon.wood100@example.com", "Jaxon", 183m, true, "Wood", null, null, "Fang", "", "", "07470100000", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 91.7m },
                    { new Guid("1089a7db-398c-486a-82c2-e37e653e06e0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "nathan.carter253@example.com", "Nathan", 171m, true, "Carter", null, null, "Bruiser", "", "", "07470100153", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 78.9m },
                    { new Guid("1150f395-8252-44dc-b55a-b59d23d6b9fa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "aiden.phillips233@example.com", "Aiden", 177m, true, "Phillips", null, null, "Hatchet", "", "", "07470100133", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 90.7m },
                    { new Guid("117ced77-d6fa-478a-96aa-691e9fc89cf5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jordan.henderson167@example.com", "Jordan", 174m, true, "Henderson", null, null, "Comet", "", "", "07470100067", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 58.5m },
                    { new Guid("12d6b9db-bce8-45d1-a691-f6df409954ec"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "corey.hamilton200@example.com", "Corey", 193m, true, "Hamilton", null, null, "Sniper", "", "", "07470100100", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 74.3m },
                    { new Guid("1858ad63-7472-4a54-86c9-967aa935f6b9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "grayson.collins238@example.com", "Grayson", 183m, true, "Collins", null, null, "Ace", "", "", "07470100138", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 81.4m },
                    { new Guid("187bda49-0935-4e06-9d00-ca0730a3289b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hugo.cooper250@example.com", "Hugo", 174m, true, "Cooper", null, null, "Bandit", "", "", "07470100150", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 99.9m },
                    { new Guid("18f16c3d-9753-4550-bf8c-b403671e1ee5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "liam.ford284@example.com", "Liam", 196m, true, "Ford", null, null, "Flash", "", "", "07470100184", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 100.0m },
                    { new Guid("1a1e0b8a-050b-4804-8eda-cd761e767524"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "keaton.hughes271@example.com", "Keaton", 167m, true, "Hughes", null, null, "Longshot", "", "", "07470100171", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 95.4m },
                    { new Guid("1bc86530-8c22-4718-b2f3-122bf131c2cc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jaxon.turner179@example.com", "Jaxon", 179m, true, "Turner", null, null, "Rogue", "", "", "07470100079", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 90.5m },
                    { new Guid("1c7e403d-bd10-4d80-8d6a-1f0aa07bf40d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tyler.ford189@example.com", "Tyler", 188m, true, "Ford", null, null, "Chaos", "", "", "07470100089", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 85.8m },
                    { new Guid("1cda8c74-c5d3-43c5-9924-683b08b6ae28"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "miles.long277@example.com", "Miles", 188m, true, "Long", null, null, "Bandit", "", "", "07470100177", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 61.9m },
                    { new Guid("20498909-74da-45ea-8e72-e6d96fc8a24c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "lucas.perez226@example.com", "Lucas", 176m, true, "Perez", null, null, "Ammo", "", "", "07470100126", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 78.4m },
                    { new Guid("2352d310-2c0e-4d3b-8b89-f7d1f3834e78"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "elijah.murphy221@example.com", "Elijah", 182m, true, "Murphy", null, null, "Storm", "", "", "07470100121", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 105.3m },
                    { new Guid("25c7a6d2-a986-4b48-bd85-9e68912d1d31"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ashton.torres219@example.com", "Ashton", 173m, true, "Torres", null, null, "Nitro", "", "", "07470100119", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 117.8m },
                    { new Guid("25e1a5db-0deb-41d1-9053-6defc685d24f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elijah.gonzalez215@example.com", "Elijah", 174m, true, "Gonzalez", null, null, "Captain", "", "", "07470100115", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 61.9m },
                    { new Guid("29cf5184-861a-47a0-8e80-822a4da68321"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "austin.powell281@example.com", "Austin", 199m, true, "Powell", null, null, "Raptor", "", "", "07470100181", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 58.2m },
                    { new Guid("2a59ef55-9d1d-4d0c-ba62-f60409a41ed0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "grayson.myers232@example.com", "Grayson", 171m, true, "Myers", null, null, "Atlas", "", "", "07470100132", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 62.4m },
                    { new Guid("2b49f566-09a4-48ea-a5f1-67466ec25e83"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "mason.hughes294@example.com", "Mason", 185m, true, "Hughes", null, null, "Draco", "", "", "07470100194", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 78.9m },
                    { new Guid("2b9d304d-0875-4df3-8706-99159ba9757c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jesse.bennett240@example.com", "Jesse", 180m, true, "Bennett", null, null, "Rumble", "", "", "07470100140", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 114.4m },
                    { new Guid("2c7f8e30-9eb4-4900-81fa-9493626ba0e6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "theo.flores142@example.com", "Theo", 184m, true, "Flores", null, null, "Darkstar", "", "", "07470100042", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 99.4m },
                    { new Guid("2ce7a02d-181e-487d-8716-7d8e26974431"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reece.powell245@example.com", "Reece", 180m, true, "Powell", null, null, "Razor", "", "", "07470100145", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 113.3m },
                    { new Guid("2dbb6f5f-d708-4969-9e88-744e629d622d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rowan.turner272@example.com", "Rowan", 171m, true, "Turner", null, null, "Specter", "", "", "07470100172", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 97.2m },
                    { new Guid("2fbf41d4-f262-4854-b9e1-600fb6e59182"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "lucas.stewart101@example.com", "Lucas", 195m, true, "Stewart", null, null, "Longshot", "", "", "07470100001", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 60.8m },
                    { new Guid("305cfff9-e7f6-4923-8442-3002f2e39686"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "theo.james173@example.com", "Theo", 178m, true, "James", null, null, "Captain", "", "", "07470100073", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 93.2m },
                    { new Guid("30fd031e-51a5-42f8-9f3a-e524523a03b4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "theo.cooper121@example.com", "Theo", 174m, true, "Cooper", null, null, "Major", "", "", "07470100021", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 108.8m },
                    { new Guid("329e7417-5dc4-44e8-91f4-f712208aca1a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "callum.carter130@example.com", "Callum", 199m, true, "Carter", null, null, "Bullet", "", "", "07470100030", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 68.0m },
                    { new Guid("32b3264c-a934-416f-8ecc-db2e4d10b1eb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "adam.bell162@example.com", "Adam", 199m, true, "Bell", null, null, "Bruiser", "", "", "07470100062", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 99.7m },
                    { new Guid("32feb229-a10c-45ed-87b9-3f5c38580fa2"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "austin.ford132@example.com", "Austin", 196m, true, "Ford", null, null, "Bandit", "", "", "07470100032", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 76.8m },
                    { new Guid("33589452-0c12-435a-aa1d-8634d21ff2b9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "lewis.cox150@example.com", "Lewis", 190m, true, "Cox", null, null, "Venator", "", "", "07470100050", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 92.8m },
                    { new Guid("342896db-85e3-47a3-b041-eefc0a659674"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "toby.bryant186@example.com", "Toby", 165m, true, "Bryant", null, null, "Saber", "", "", "07470100086", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 111.4m },
                    { new Guid("355acabe-371c-48be-9e5c-e1b70bb3f4f9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "adam.bennett118@example.com", "Adam", 199m, true, "Bennett", null, null, "Cyclone", "", "", "07470100018", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 76.8m },
                    { new Guid("38ebe455-042d-4ff4-9ba6-00c763929e5a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "evan.robinson208@example.com", "Evan", 188m, true, "Robinson", null, null, "Cinder", "", "", "07470100108", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 100.8m },
                    { new Guid("395a0dcb-895a-4c17-9037-05bbc5a6a6fb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tristan.cooper248@example.com", "Tristan", 192m, true, "Cooper", null, null, "Kodiak", "", "", "07470100148", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 56.6m },
                    { new Guid("39b67d8f-f709-4486-b66b-892dabb55c4c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jude.long102@example.com", "Jude", 195m, true, "Long", null, null, "Maverick", "", "", "07470100002", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 101.5m },
                    { new Guid("3a544b40-d9cd-4634-af8f-498e4999f6fb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "brody.evans188@example.com", "Brody", 165m, true, "Evans", null, null, "Knuckles", "", "", "07470100088", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 102.8m },
                    { new Guid("3a8aaabf-3b7a-4764-ac3d-82fec3b8006f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "joel.richardson268@example.com", "Joel", 183m, true, "Richardson", null, null, "Byte", "", "", "07470100168", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 119.3m },
                    { new Guid("3b33ceaf-ca76-423f-8eba-fa0a3a0cee87"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hunter.thomas177@example.com", "Hunter", 166m, true, "Thomas", null, null, "Outlaw", "", "", "07470100077", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 75.2m },
                    { new Guid("3c0ac6e4-3176-4dbc-aaf2-2f99956ea83e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zane.nelson172@example.com", "Zane", 175m, true, "Nelson", null, null, "Ace", "", "", "07470100072", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 119.1m },
                    { new Guid("3c5fd25f-2edd-414a-a9d9-6d166b633699"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hunter.wilson187@example.com", "Hunter", 178m, true, "Wilson", null, null, "Striker", "", "", "07470100087", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 75.2m },
                    { new Guid("3d196e3e-3441-4e3c-9db1-abbf31eaa32c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "finn.scott117@example.com", "Finn", 176m, true, "Scott", null, null, "Falcon", "", "", "07470100017", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 64.8m },
                    { new Guid("3fd0fe4f-d444-4a14-8da1-e75e8a10b6e9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "blake.peterson174@example.com", "Blake", 179m, true, "Peterson", null, null, "Sentinel", "", "", "07470100074", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 118.6m },
                    { new Guid("41a4de83-c4cc-4ca5-9c28-c644d2890fc2"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hunter.ward131@example.com", "Hunter", 182m, true, "Ward", null, null, "Orion", "", "", "07470100031", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 109.3m },
                    { new Guid("42b9b8b6-4a03-4aa8-a1dc-e27ab99dc57a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "freddie.torres270@example.com", "Freddie", 183m, true, "Torres", null, null, "Oblivion", "", "", "07470100170", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 60.0m },
                    { new Guid("458a09f9-d6b1-45cc-a247-4a4b46dd2b93"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "rowan.scott220@example.com", "Rowan", 180m, true, "Scott", null, null, "Spark", "", "", "07470100120", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 82.5m },
                    { new Guid("48012155-6cd5-4637-a2a6-2500c097962b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "grayson.hayes122@example.com", "Grayson", 170m, true, "Hayes", null, null, "Alpha", "", "", "07470100022", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 96.0m },
                    { new Guid("48f0b545-b532-496a-a10e-a589cda48739"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "corey.wood182@example.com", "Corey", 167m, true, "Wood", null, null, "Berserker", "", "", "07470100082", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 107.8m },
                    { new Guid("4c09735c-6dbc-4ef3-b859-c744b45852ee"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "austin.mitchell242@example.com", "Austin", 170m, true, "Mitchell", null, null, "Riot", "", "", "07470100142", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 64.7m },
                    { new Guid("4dc0366c-c5fd-4db6-8db9-00b1e528f7cb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "george.ford139@example.com", "George", 194m, true, "Ford", null, null, "Sniper", "", "", "07470100039", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 88.7m },
                    { new Guid("4de232b2-bfb1-47f7-bad3-d7b63fa865c5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "brody.flores136@example.com", "Brody", 185m, true, "Flores", null, null, "Blaze", "", "", "07470100036", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 75.6m },
                    { new Guid("4e59452d-93d9-40a8-a29c-e5567a98d638"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "cody.cox138@example.com", "Cody", 167m, true, "Cox", null, null, "Mantis", "", "", "07470100038", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 79.1m },
                    { new Guid("50a35a6f-1636-442e-be84-0dc86d49d5eb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "noah.myers168@example.com", "Noah", 180m, true, "Myers", null, null, "Kraken", "", "", "07470100068", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 119.5m },
                    { new Guid("50e6611e-2504-488d-af7c-bdda0891ccb8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "blake.parker254@example.com", "Blake", 194m, true, "Parker", null, null, "Rogue", "", "", "07470100154", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 103.8m },
                    { new Guid("52466e7e-87df-48da-8d01-a08c280a286b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "zane.evans267@example.com", "Zane", 196m, true, "Evans", null, null, "Mantis", "", "", "07470100167", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 56.0m },
                    { new Guid("527549f5-cfab-4ac2-9ba7-307470601a80"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "rhys.jenkins156@example.com", "Rhys", 184m, true, "Jenkins", null, null, "Ranger", "", "", "07470100056", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 73.8m },
                    { new Guid("529c6412-0616-4745-8075-eb6f20bbd519"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "elliot.wood262@example.com", "Elliot", 172m, true, "Wood", null, null, "Rumble", "", "", "07470100162", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 87.1m },
                    { new Guid("5314bb3b-47bb-49f8-89f4-56b0cf61d371"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bradley.henderson106@example.com", "Bradley", 182m, true, "Henderson", null, null, "Ghost", "", "", "07470100006", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 83.1m },
                    { new Guid("54d32219-46d2-4b9c-8868-d6a7b449490b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zack.henderson108@example.com", "Zack", 189m, true, "Henderson", null, null, "Pixel", "", "", "07470100008", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 57.2m },
                    { new Guid("5535033c-58a0-4c8f-a8b3-7111a3b3af22"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ethan.phillips297@example.com", "Ethan", 189m, true, "Phillips", null, null, "Frost", "", "", "07470100197", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 101.1m },
                    { new Guid("555b35bd-0407-40ff-984a-22050abef07d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "logan.peterson228@example.com", "Logan", 181m, true, "Peterson", null, null, "Shadow", "", "", "07470100128", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 74.8m },
                    { new Guid("558a356a-0744-4c66-bf5b-8ce2955ccf45"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bobby.hayes244@example.com", "Bobby", 194m, true, "Hayes", null, null, "Saber", "", "", "07470100144", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 120.0m },
                    { new Guid("5625d697-3658-4dce-acc3-b2e1af0b6931"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jacob.alexander252@example.com", "Jacob", 195m, true, "Alexander", null, null, "Hunter", "", "", "07470100152", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 93.0m },
                    { new Guid("5a7e8a25-8cfe-4642-b90b-ba71e24dfd3c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jasper.watson258@example.com", "Jasper", 194m, true, "Watson", null, null, "Predator", "", "", "07470100158", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 114.0m },
                    { new Guid("5b5efb36-13be-49ee-a0e2-dbc6401700f6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "oscar.diaz293@example.com", "Oscar", 165m, true, "Diaz", null, null, "Jinx", "", "", "07470100193", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 69.1m },
                    { new Guid("5ba7371d-2cfc-40af-863e-6160c0024ff1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jaxon.bell196@example.com", "Jaxon", 199m, true, "Bell", null, null, "Warlord", "", "", "07470100096", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 66.0m },
                    { new Guid("61f62c93-bd23-4b49-8d52-27a915c60635"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elijah.king201@example.com", "Elijah", 190m, true, "King", null, null, "Glitch", "", "", "07470100101", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 81.3m },
                    { new Guid("62b55d92-61ad-4a1a-9a30-c37e35a3636f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "noah.gonzalez279@example.com", "Noah", 188m, true, "Gonzalez", null, null, "Raptor", "", "", "07470100179", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 117.1m },
                    { new Guid("65078d6e-6146-4fb1-b95e-a28682e976c8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alex.coleman160@example.com", "Alex", 187m, true, "Coleman", null, null, "Ash", "", "", "07470100060", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 93.5m },
                    { new Guid("657b90f5-9f28-430f-a0c8-2383346cd244"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "evan.diaz103@example.com", "Evan", 189m, true, "Diaz", null, null, "Flash", "", "", "07470100003", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 91.1m },
                    { new Guid("6612abd8-25fb-4ff0-88b2-1e8cc3be7cbb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "harley.baker283@example.com", "Harley", 177m, true, "Baker", null, null, "Tempest", "", "", "07470100183", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 72.6m },
                    { new Guid("67781d2a-5f9d-4d6b-a1e4-489e044127b4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "toby.campbell229@example.com", "Toby", 177m, true, "Campbell", null, null, "Lightning", "", "", "07470100129", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 73.8m },
                    { new Guid("690f4a54-9c79-4e24-b313-22bdb95e37d9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "luca.hamilton127@example.com", "Luca", 179m, true, "Hamilton", null, null, "Deadshot", "", "", "07470100027", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 116.2m },
                    { new Guid("6967e18a-b062-4326-ac45-50725aec328e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "evan.walker155@example.com", "Evan", 174m, true, "Walker", null, null, "Spark", "", "", "07470100055", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 116.3m },
                    { new Guid("696dce26-d094-49bf-88cb-fa35427b63f9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "joel.barnes289@example.com", "Joel", 173m, true, "Barnes", null, null, "Brick", "", "", "07470100189", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 87.8m },
                    { new Guid("6b8a3c24-1a31-49a6-a852-fa382f7e7d87"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "leon.diaz110@example.com", "Leon", 170m, true, "Diaz", null, null, "Cosmo", "", "", "07470100010", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 83.5m },
                    { new Guid("6c5fe342-7346-464b-9eeb-66f5bbbcf69b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "nathan.cooper282@example.com", "Nathan", 184m, true, "Cooper", null, null, "Fury", "", "", "07470100182", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 76.1m },
                    { new Guid("6d47e92b-1cba-4722-8e28-62f5f03883fa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jude.morris292@example.com", "Jude", 166m, true, "Morris", null, null, "Phoenix", "", "", "07470100192", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 112.9m },
                    { new Guid("6d7327c2-8ee0-4ebf-8e33-32729387b9d0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "max.ross216@example.com", "Max", 186m, true, "Ross", null, null, "Cinder", "", "", "07470100116", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 114.6m },
                    { new Guid("72ce129f-f9e0-4069-97ec-a3769a5ad8d3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "finn.phillips184@example.com", "Finn", 177m, true, "Phillips", null, null, "Mantis", "", "", "07470100084", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 58.5m },
                    { new Guid("73086826-f75f-43dc-aa00-909cdcb7974c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "grayson.stewart206@example.com", "Grayson", 165m, true, "Stewart", null, null, "Havoc", "", "", "07470100106", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 68.2m },
                    { new Guid("73bbe402-7955-4053-8316-9c420d921b56"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "miles.scott209@example.com", "Miles", 170m, true, "Scott", null, null, "Tsunami", "", "", "07470100109", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 85.3m },
                    { new Guid("748d478e-ce4d-47af-a98d-3522af515049"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "sean.adams152@example.com", "Sean", 183m, true, "Adams", null, null, "Zephyr", "", "", "07470100052", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 95.1m },
                    { new Guid("774a5414-8f06-4587-9d0b-1fcc4ca8d974"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "caleb.torres181@example.com", "Caleb", 190m, true, "Torres", null, null, "Kraken", "", "", "07470100081", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 60.9m },
                    { new Guid("791eb302-08a4-4c70-9439-ee41b8eedca3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "leon.green169@example.com", "Leon", 174m, true, "Green", null, null, "Fang", "", "", "07470100069", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 61.4m },
                    { new Guid("792f9f23-80d8-4776-8fe0-a8afeda00435"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "theo.ford239@example.com", "Theo", 195m, true, "Ford", null, null, "Missile", "", "", "07470100139", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 92.5m },
                    { new Guid("79ba1b71-fce0-42f9-9953-e2876a1e2304"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bradley.hayes298@example.com", "Bradley", 185m, true, "Hayes", null, null, "Deadshot", "", "", "07470100198", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 86.3m },
                    { new Guid("79f29fdb-ad0a-4a48-93ce-8ed016d50126"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "tristan.cox166@example.com", "Tristan", 196m, true, "Cox", null, null, "Talon", "", "", "07470100066", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 86.0m },
                    { new Guid("7bcaede2-cde1-4d15-90c5-f57a82c8d1e4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "theo.myers225@example.com", "Theo", 197m, true, "Myers", null, null, "Cyclone", "", "", "07470100125", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 71.4m },
                    { new Guid("7beccd53-8276-4a5e-9d2e-2c131897f9c4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jaxon.baker218@example.com", "Jaxon", 179m, true, "Baker", null, null, "Mantis", "", "", "07470100118", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 61.1m },
                    { new Guid("7ca5d180-b858-4f11-81cb-a6d4b980afec"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reuben.griffin231@example.com", "Reuben", 172m, true, "Griffin", null, null, "Bandit", "", "", "07470100131", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 89.4m },
                    { new Guid("7dc5944c-5325-4388-8db4-5d10cbaee9bc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jacob.scott137@example.com", "Jacob", 200m, true, "Scott", null, null, "Specter", "", "", "07470100037", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 81.0m },
                    { new Guid("80069448-b01d-4322-a68b-54045b0fb265"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jacob.young207@example.com", "Jacob", 199m, true, "Young", null, null, "Fang", "", "", "07470100107", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 101.0m },
                    { new Guid("80c2b4c5-40b0-48f6-8038-47c5861ca73b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "noah.nelson261@example.com", "Noah", 175m, true, "Nelson", null, null, "Mace", "", "", "07470100161", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 88.9m },
                    { new Guid("8198c8c5-ab48-4fbe-a7e8-fbe1f275d7ea"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "owen.ford126@example.com", "Owen", 166m, true, "Ford", null, null, "Riptide", "", "", "07470100026", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 69.6m },
                    { new Guid("82d9de36-c27b-484e-bafe-99e994dba53a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "charlie.gray227@example.com", "Charlie", 174m, true, "Gray", null, null, "Major", "", "", "07470100127", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 102.4m },
                    { new Guid("82e3d7f4-6bb7-44a8-841c-d3478c31485b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ezra.ward134@example.com", "Ezra", 189m, true, "Ward", null, null, "Blackout", "", "", "07470100034", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 113.4m },
                    { new Guid("82ed60dc-b5b0-4189-b980-b8a0e8545425"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "declan.jenkins185@example.com", "Declan", 171m, true, "Jenkins", null, null, "Rampage", "", "", "07470100085", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 102.0m },
                    { new Guid("851c785e-bc12-48eb-a726-0b85b181f604"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reece.hall105@example.com", "Reece", 166m, true, "Hall", null, null, "Hunter", "", "", "07470100005", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 56.2m },
                    { new Guid("851e68b9-1ab3-44a1-8aaf-80a56cb21a46"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "luca.cooper236@example.com", "Luca", 171m, true, "Cooper", null, null, "Tempest", "", "", "07470100136", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 105.4m },
                    { new Guid("8607ef5c-57a3-400e-8190-ea2e4444d8db"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hugo.taylor230@example.com", "Hugo", 198m, true, "Taylor", null, null, "Current", "", "", "07470100130", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 75.0m },
                    { new Guid("8617c081-cf66-4d51-a8be-d4c2efb61b99"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "mitchell.gonzalez214@example.com", "Mitchell", 169m, true, "Gonzalez", null, null, "Alpha", "", "", "07470100114", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 107.0m },
                    { new Guid("88552593-7926-47e6-b36c-ae6e35471c61"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "connor.barnes140@example.com", "Connor", 193m, true, "Barnes", null, null, "Razor", "", "", "07470100040", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 119.0m },
                    { new Guid("88a4a0d5-9a97-4a94-9908-34761a6c9b17"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "rhys.king264@example.com", "Rhys", 165m, true, "King", null, null, "Ricochet", "", "", "07470100164", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 64.9m },
                    { new Guid("88a726d2-2c1d-48f1-a821-a366af938be3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tristan.jenkins291@example.com", "Tristan", 170m, true, "Jenkins", null, null, "Grizzly", "", "", "07470100191", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 60.9m },
                    { new Guid("8a99dd65-77db-4e2f-8558-86ab85743220"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "cody.young265@example.com", "Cody", 176m, true, "Young", null, null, "Dagger", "", "", "07470100165", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 91.9m },
                    { new Guid("8aa37933-080a-4671-81e9-af87f533b845"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "miles.diaz198@example.com", "Miles", 166m, true, "Diaz", null, null, "Diesel", "", "", "07470100098", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 75.0m },
                    { new Guid("8ab9ac70-36c0-4f84-b9f9-986b8e63c849"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "elijah.ross263@example.com", "Elijah", 188m, true, "Ross", null, null, "Cutlass", "", "", "07470100163", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 56.3m },
                    { new Guid("904460a4-46c5-4f06-a8e6-0e6cdc076fd4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "isaac.baker269@example.com", "Isaac", 166m, true, "Baker", null, null, "Circuit", "", "", "07470100169", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 69.3m },
                    { new Guid("90c941b3-5a35-47a7-a9de-2c47b616719d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elliot.cook141@example.com", "Elliot", 168m, true, "Cook", null, null, "Cinder", "", "", "07470100041", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 70.4m },
                    { new Guid("90dd103a-b3d1-439e-92b7-df14aa595b2a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "austin.jenkins237@example.com", "Austin", 170m, true, "Jenkins", null, null, "Specter", "", "", "07470100137", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 66.3m },
                    { new Guid("90dd47bb-4161-4adb-8982-ea9e73242598"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "luca.sanders205@example.com", "Luca", 194m, true, "Sanders", null, null, "Boss", "", "", "07470100105", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 68.1m },
                    { new Guid("96542c30-cc58-48f7-bc87-3c0e2b09f518"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "henry.gonzalez256@example.com", "Henry", 190m, true, "Gonzalez", null, null, "Blade", "", "", "07470100156", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 72.4m },
                    { new Guid("97919f67-5113-4d65-8b10-e61d8a0463c5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reuben.collins234@example.com", "Reuben", 189m, true, "Collins", null, null, "Omega", "", "", "07470100134", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 76.4m },
                    { new Guid("9a940b79-9c29-4ba0-b036-06ba8e104661"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "toby.brooks124@example.com", "Toby", 199m, true, "Brooks", null, null, "Blizzard", "", "", "07470100024", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 118.8m },
                    { new Guid("9b002fc6-c871-4dbd-a089-21135e0e3aa3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "felix.long286@example.com", "Felix", 174m, true, "Long", null, null, "Mayhem", "", "", "07470100186", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 55.2m },
                    { new Guid("9c9e1be3-4a76-4c82-b344-1d95198b9f44"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "oscar.gonzalez259@example.com", "Oscar", 169m, true, "Gonzalez", null, null, "Quake", "", "", "07470100159", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 107.1m },
                    { new Guid("9cadef55-3197-4b07-858b-7a27f2632f81"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ryan.sanchez223@example.com", "Ryan", 172m, true, "Sanchez", null, null, "Ember", "", "", "07470100123", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 110.8m },
                    { new Guid("9cb879b5-6940-4029-9156-628cbb583d8a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "toby.coleman290@example.com", "Toby", 195m, true, "Coleman", null, null, "Claw", "", "", "07470100190", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 94.2m },
                    { new Guid("a0ef7953-4ea1-44e8-9e5f-fb6ddde37346"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "leon.foster176@example.com", "Leon", 196m, true, "Foster", null, null, "Specter", "", "", "07470100076", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 107.1m },
                    { new Guid("a2676620-d5be-4c2b-9722-8d683716528d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reuben.watson217@example.com", "Reuben", 181m, true, "Watson", null, null, "Draco", "", "", "07470100117", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 101.4m },
                    { new Guid("a32960cf-e21a-415a-8860-c6ad74bb52cc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "miles.perez249@example.com", "Miles", 192m, true, "Perez", null, null, "Chrome", "", "", "07470100149", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 88.4m },
                    { new Guid("a34d0f9e-ec51-4746-a8c8-bfe7eac8f2bf"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kai.coleman278@example.com", "Kai", 168m, true, "Coleman", null, null, "Razor", "", "", "07470100178", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 63.4m },
                    { new Guid("a3675eac-0ed8-4436-94cb-ac0651e3ce21"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "finn.griffin274@example.com", "Finn", 166m, true, "Griffin", null, null, "Bruiser", "", "", "07470100174", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 101.6m },
                    { new Guid("a4fd0c11-8167-4364-858a-73a5f5624701"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "miles.king157@example.com", "Miles", 199m, true, "King", null, null, "Brawler", "", "", "07470100057", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 85.5m },
                    { new Guid("a795750e-a166-4af5-a6f3-027d93d51859"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "cameron.campbell255@example.com", "Cameron", 180m, true, "Campbell", null, null, "Nitro", "", "", "07470100155", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 92.4m },
                    { new Guid("a9f63ce6-a3d1-4f2d-a6d7-4c6c26c0e98f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ashton.turner151@example.com", "Ashton", 176m, true, "Turner", null, null, "Mayhem", "", "", "07470100051", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 78.2m },
                    { new Guid("aac58567-c963-4455-90c1-030af42e641e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reuben.hamilton129@example.com", "Reuben", 200m, true, "Hamilton", null, null, "Zephyr", "", "", "07470100029", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 89.2m },
                    { new Guid("ab5245da-d583-41b1-bf37-29fefe2ee4f8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "sean.long191@example.com", "Sean", 187m, true, "Long", null, null, "Current", "", "", "07470100091", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 62.9m },
                    { new Guid("ab810a22-9885-4452-bd89-2fa88a3db4a3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ezra.reed161@example.com", "Ezra", 176m, true, "Reed", null, null, "Hydra", "", "", "07470100061", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 101.8m },
                    { new Guid("acdb9109-5c1a-4632-af8d-91b569d48c3f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alex.evans170@example.com", "Alex", 199m, true, "Evans", null, null, "Outlaw", "", "", "07470100070", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 93.0m },
                    { new Guid("ad1608d3-f27e-4969-9a06-ad1401a74969"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "marcus.long199@example.com", "Marcus", 168m, true, "Long", null, null, "Zephyr", "", "", "07470100099", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 59.4m },
                    { new Guid("ad805c07-bbc0-4f12-844d-9d91c9128fe5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "adam.sanders210@example.com", "Adam", 191m, true, "Sanders", null, null, "Predator", "", "", "07470100110", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 90.2m },
                    { new Guid("ae621a2d-4a2c-4b86-8b23-c496708e713b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "charlie.hamilton158@example.com", "Charlie", 197m, true, "Hamilton", null, null, "Chief", "", "", "07470100058", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 94.6m },
                    { new Guid("b2c37c4b-60e8-431c-b582-5d04b29b0bd6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "adam.kelly153@example.com", "Adam", 194m, true, "Kelly", null, null, "Iron", "", "", "07470100053", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 89.8m },
                    { new Guid("b48e4cbf-e502-4ca0-b59f-0c209aef30cd"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ryan.perry295@example.com", "Ryan", 180m, true, "Perry", null, null, "Ghost", "", "", "07470100195", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 100.2m },
                    { new Guid("b4f92856-03fb-4675-9ebe-9077de941677"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "miles.murphy204@example.com", "Miles", 176m, true, "Murphy", null, null, "Overdrive", "", "", "07470100104", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 85.6m },
                    { new Guid("b782f4c1-3afd-40ff-a04b-ba8f49df2991"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "nathan.campbell287@example.com", "Nathan", 197m, true, "Campbell", null, null, "Falcon", "", "", "07470100187", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 111.2m },
                    { new Guid("b8b48a67-c942-4ebb-9e99-8ac9c428f883"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kieran.washington144@example.com", "Kieran", 184m, true, "Washington", null, null, "Static", "", "", "07470100044", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 83.6m },
                    { new Guid("b8fe7f38-ddd4-41a3-8675-885fc8adde66"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "george.baker193@example.com", "George", 174m, true, "Baker", null, null, "Echo", "", "", "07470100093", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 104.6m },
                    { new Guid("b9f9ccf8-744a-4c32-bd43-8b6b78d092c9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "harrison.kelly145@example.com", "Harrison", 178m, true, "Kelly", null, null, "Draco", "", "", "07470100045", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 73.2m },
                    { new Guid("bf0e5675-6bd6-4eea-87e7-e556c0d18320"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "max.howard222@example.com", "Max", 169m, true, "Howard", null, null, "Ranger", "", "", "07470100122", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 90.5m },
                    { new Guid("c1dc41da-6571-4c3e-b21e-2494cb70349b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elijah.phillips211@example.com", "Elijah", 192m, true, "Phillips", null, null, "Cobra", "", "", "07470100111", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 55.4m },
                    { new Guid("c1f88591-a136-4b00-b1a5-61d5061e3881"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "riley.phillips125@example.com", "Riley", 189m, true, "Phillips", null, null, "Darkstar", "", "", "07470100025", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 118.5m },
                    { new Guid("c2c161e4-6101-4205-ae06-937d921f3b1f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "cody.carter285@example.com", "Cody", 181m, true, "Carter", null, null, "Maverick", "", "", "07470100185", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 62.0m },
                    { new Guid("c33703c1-a798-4f62-b435-0e37f4341632"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "evan.morgan104@example.com", "Evan", 193m, true, "Morgan", null, null, "Vortex", "", "", "07470100004", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 90.4m },
                    { new Guid("c4d069d7-b5e6-4013-a2f5-155eb27f21f9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "grayson.richardson109@example.com", "Grayson", 196m, true, "Richardson", null, null, "Cipher", "", "", "07470100009", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 91.7m },
                    { new Guid("c540c3a4-fef8-42c6-95a4-620f224386b9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jacob.hughes276@example.com", "Jacob", 195m, true, "Hughes", null, null, "Blackout", "", "", "07470100176", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 58.8m },
                    { new Guid("c5700f1b-23f9-4f23-9c11-e853ad6aafba"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "oscar.green175@example.com", "Oscar", 176m, true, "Green", null, null, "Guardian", "", "", "07470100075", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 65.5m },
                    { new Guid("c7daa73c-eeff-4224-a5a6-76127db24e44"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reece.hughes194@example.com", "Reece", 181m, true, "Hughes", null, null, "Dagger", "", "", "07470100094", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 56.2m },
                    { new Guid("c9ad3bae-cddf-4271-aba6-751382206c25"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "sean.gray135@example.com", "Sean", 193m, true, "Gray", null, null, "Nightfall", "", "", "07470100035", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 68.3m },
                    { new Guid("ca0bc9ab-71df-410e-ac26-8d0e8c51e23c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "connor.campbell197@example.com", "Connor", 170m, true, "Campbell", null, null, "Major", "", "", "07470100097", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 109.6m },
                    { new Guid("caeb8e88-ea7c-45db-b44f-bad9cd824fd5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jayden.robinson112@example.com", "Jayden", 177m, true, "Robinson", null, null, "Fury", "", "", "07470100012", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 69.1m },
                    { new Guid("caeefb22-51d2-4237-82b6-9d28d374b7e9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "harley.washington143@example.com", "Harley", 194m, true, "Washington", null, null, "Warlord", "", "", "07470100043", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 86.3m },
                    { new Guid("cb46cb30-09f9-45ff-9476-c6067e5f0c6c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "freddie.howard213@example.com", "Freddie", 189m, true, "Howard", null, null, "Tempest", "", "", "07470100113", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 90.9m },
                    { new Guid("cc7febb2-6948-4ae3-a3dd-a0f54c46f880"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "logan.jenkins147@example.com", "Logan", 181m, true, "Jenkins", null, null, "Knuckles", "", "", "07470100047", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 67.3m },
                    { new Guid("cdc92229-fc2e-4443-b790-c57c40449a49"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "dylan.king133@example.com", "Dylan", 168m, true, "King", null, null, "Rocket", "", "", "07470100033", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 103.4m },
                    { new Guid("cf1d82fc-0124-4557-8e7b-724c4e99ac2a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "spencer.parker203@example.com", "Spencer", 196m, true, "Parker", null, null, "Major", "", "", "07470100103", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 106.8m },
                    { new Guid("cf95e17f-c12c-4667-8d0d-e2dca358a9b8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reece.king251@example.com", "Reece", 192m, true, "King", null, null, "Circuit", "", "", "07470100151", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 95.2m },
                    { new Guid("d200c9a1-2bfd-49fa-9ccc-7809b48e2b01"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "harley.hamilton190@example.com", "Harley", 184m, true, "Hamilton", null, null, "Byte", "", "", "07470100090", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 87.5m },
                    { new Guid("d5a4ecc8-7923-4656-8e43-93c406097d1e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ezra.rivera266@example.com", "Ezra", 196m, true, "Rivera", null, null, "Goliath", "", "", "07470100166", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 55.7m },
                    { new Guid("d7579ef5-ff21-41af-a4de-50ae98228f6c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "adam.hamilton113@example.com", "Adam", 166m, true, "Hamilton", null, null, "Talon", "", "", "07470100013", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 117.0m },
                    { new Guid("d82e23c1-564b-44e1-881e-38a6c3b85ba0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "bobby.simmons202@example.com", "Bobby", 187m, true, "Simmons", null, null, "Captain", "", "", "07470100102", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 87.4m },
                    { new Guid("dc809498-68f8-4b2f-b92d-2c1d0b40d0df"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zack.bennett146@example.com", "Zack", 165m, true, "Bennett", null, null, "Iron", "", "", "07470100046", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 90.5m },
                    { new Guid("dda9711b-f8da-4098-a25d-081fd84c6b69"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tyler.mitchell260@example.com", "Tyler", 172m, true, "Mitchell", null, null, "Berserker", "", "", "07470100160", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 65.1m },
                    { new Guid("e0ca7e50-ef31-4ce1-a3ee-2d7c4f7fef3f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jayden.powell116@example.com", "Jayden", 169m, true, "Powell", null, null, "Hydra", "", "", "07470100016", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 60.2m },
                    { new Guid("e19dbb67-95db-44c6-99b0-3a524ebe2ef4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dominic.richardson114@example.com", "Dominic", 185m, true, "Richardson", null, null, "Crusher", "", "", "07470100014", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 68.3m },
                    { new Guid("e2f710f7-23dc-4d0f-be3e-6705209dc75a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "noah.griffin247@example.com", "Noah", 175m, true, "Griffin", null, null, "Wraith", "", "", "07470100147", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 79.3m },
                    { new Guid("e365d3bb-ac01-4dbd-aef1-db51defcfcac"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "cody.richardson178@example.com", "Cody", 168m, true, "Richardson", null, null, "Longshot", "", "", "07470100078", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 82.2m },
                    { new Guid("e4070cb9-9133-4889-a77a-dd3302521dd1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "cameron.richardson241@example.com", "Cameron", 165m, true, "Richardson", null, null, "Flash", "", "", "07470100141", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 107.0m },
                    { new Guid("ea513a18-7e9b-42f4-b313-1f5c1ca5fc3d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kieran.jenkins192@example.com", "Kieran", 172m, true, "Jenkins", null, null, "Pixel", "", "", "07470100092", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 114.5m },
                    { new Guid("ed03b401-a7b6-4b77-9e84-1baec230e30d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kieran.perez235@example.com", "Kieran", 172m, true, "Perez", null, null, "Razor", "", "", "07470100135", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 105.2m },
                    { new Guid("ee913746-4a40-41ee-b868-5e06f546c6a1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "marcus.adams119@example.com", "Marcus", 165m, true, "Adams", null, null, "Zephyr", "", "", "07470100019", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 67.5m },
                    { new Guid("eeb0bb33-0e2b-4249-86bb-a7dd0710a5d4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "nathan.wright273@example.com", "Nathan", 197m, true, "Wright", null, null, "Quake", "", "", "07470100173", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 111.7m },
                    { new Guid("f0346006-694a-41a1-b64f-ac0de1977896"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "freddie.gonzalez195@example.com", "Freddie", 190m, true, "Gonzalez", null, null, "Stalker", "", "", "07470100095", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 99.2m },
                    { new Guid("f25abb3a-78c2-4908-a0d2-291b062aeff1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "luca.richardson296@example.com", "Luca", 165m, true, "Richardson", null, null, "Havoc", "", "", "07470100196", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 119.1m },
                    { new Guid("f3c1ec4c-8c94-413b-8ce6-44c0a42de9af"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "spencer.brooks165@example.com", "Spencer", 176m, true, "Brooks", null, null, "Tank", "", "", "07470100065", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 112.9m },
                    { new Guid("f425f025-9720-4125-8646-bd03b517c7d0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zack.sanders183@example.com", "Zack", 187m, true, "Sanders", null, null, "Darkstar", "", "", "07470100083", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 115.5m },
                    { new Guid("f86e33e9-51e0-4537-9c3f-531bb8963365"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hunter.russell180@example.com", "Hunter", 177m, true, "Russell", null, null, "Scorpion", "", "", "07470100080", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 71.4m },
                    { new Guid("f8fbd995-cdb3-4002-86b0-e6211ef51c2b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "finn.peterson299@example.com", "Finn", 190m, true, "Peterson", null, null, "Inferno", "", "", "07470100199", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 85.3m },
                    { new Guid("f90e7f12-21b6-4c29-803b-811e0c89abef"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jordan.stewart212@example.com", "Jordan", 184m, true, "Stewart", null, null, "Titan", "", "", "07470100112", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 105.2m },
                    { new Guid("f9589915-201f-49fc-9171-0362f43cf54e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "oscar.james275@example.com", "Oscar", 193m, true, "James", null, null, "Pixel", "", "", "07470100175", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 79.4m },
                    { new Guid("f9b9c677-79eb-4ac4-9a9b-1e0da19b82db"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "grayson.bryant159@example.com", "Grayson", 196m, true, "Bryant", null, null, "Zephyr", "", "", "07470100059", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 92.0m },
                    { new Guid("faed2460-c0d9-4ba9-b15e-33f33267eab9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bradley.adams107@example.com", "Bradley", 181m, true, "Adams", null, null, "Nitro", "", "", "07470100007", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 67.9m },
                    { new Guid("fbcd5c5f-cec9-4442-9d10-37deff760838"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "mason.ramirez163@example.com", "Mason", 180m, true, "Ramirez", null, null, "Savage", "", "", "07470100063", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 96.6m },
                    { new Guid("fca2ca10-0767-48ad-b305-cc7b03d7df67"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "cody.parker171@example.com", "Cody", 190m, true, "Parker", null, null, "Aftershock", "", "", "07470100071", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 59.6m },
                    { new Guid("fd78b766-36b1-4324-9fe8-4cc8210c6c30"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "aaron.diaz288@example.com", "Aaron", 175m, true, "Diaz", null, null, "Specter", "", "", "07470100188", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 117.8m },
                    { new Guid("feb9b111-7f4b-4146-b1a0-2c84ef7964a6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "adam.morgan243@example.com", "Adam", 187m, true, "Morgan", null, null, "Major", "", "", "07470100143", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 110.5m },
                    { new Guid("feec1acc-13af-4120-82da-110c445d3ba5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "sean.ward164@example.com", "Sean", 197m, true, "Ward", null, null, "Specter", "", "", "07470100064", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 69.1m },
                    { new Guid("ffb63add-9e0e-44df-ab3f-e75a52f14a14"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "logan.adams111@example.com", "Logan", 189m, true, "Adams", null, null, "Nova", "", "", "07470100011", "", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 118.1m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0095cb38-8917-4fcf-8a45-86fa72831a51"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("028c5d72-cdf3-486f-bd69-201fdfb6c3bc"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("03722e19-a1f5-4362-90b9-748211dfabeb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("04971b0f-c5ca-4f43-b8e0-d789eed3072d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("060dfebd-e962-474d-a19c-5bf859ecb735"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("08c6b3e1-249c-47da-96b9-c515c1adcfc0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0b02bfec-2b64-4731-8dab-b1a025d5037c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0b03a8a3-bb3b-48ab-b871-bc3bd47b23d1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0c07250b-0d0d-4c75-b0fa-082a0d53ff3b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0d23a3e3-89f3-46ec-85ab-7fe71ca05140"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0df3a89b-70af-495b-bf63-76572f513adb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0fe87b77-310e-492f-a6f1-3409ee0f00e6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1089a7db-398c-486a-82c2-e37e653e06e0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1150f395-8252-44dc-b55a-b59d23d6b9fa"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("117ced77-d6fa-478a-96aa-691e9fc89cf5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("12d6b9db-bce8-45d1-a691-f6df409954ec"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1858ad63-7472-4a54-86c9-967aa935f6b9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("187bda49-0935-4e06-9d00-ca0730a3289b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("18f16c3d-9753-4550-bf8c-b403671e1ee5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1a1e0b8a-050b-4804-8eda-cd761e767524"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1bc86530-8c22-4718-b2f3-122bf131c2cc"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1c7e403d-bd10-4d80-8d6a-1f0aa07bf40d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1cda8c74-c5d3-43c5-9924-683b08b6ae28"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("20498909-74da-45ea-8e72-e6d96fc8a24c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2352d310-2c0e-4d3b-8b89-f7d1f3834e78"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("25c7a6d2-a986-4b48-bd85-9e68912d1d31"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("25e1a5db-0deb-41d1-9053-6defc685d24f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("29cf5184-861a-47a0-8e80-822a4da68321"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2a59ef55-9d1d-4d0c-ba62-f60409a41ed0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2b49f566-09a4-48ea-a5f1-67466ec25e83"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2b9d304d-0875-4df3-8706-99159ba9757c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2c7f8e30-9eb4-4900-81fa-9493626ba0e6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2ce7a02d-181e-487d-8716-7d8e26974431"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2dbb6f5f-d708-4969-9e88-744e629d622d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2fbf41d4-f262-4854-b9e1-600fb6e59182"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("305cfff9-e7f6-4923-8442-3002f2e39686"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("30fd031e-51a5-42f8-9f3a-e524523a03b4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("329e7417-5dc4-44e8-91f4-f712208aca1a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("32b3264c-a934-416f-8ecc-db2e4d10b1eb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("32feb229-a10c-45ed-87b9-3f5c38580fa2"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("33589452-0c12-435a-aa1d-8634d21ff2b9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("342896db-85e3-47a3-b041-eefc0a659674"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("355acabe-371c-48be-9e5c-e1b70bb3f4f9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("38ebe455-042d-4ff4-9ba6-00c763929e5a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("395a0dcb-895a-4c17-9037-05bbc5a6a6fb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("39b67d8f-f709-4486-b66b-892dabb55c4c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3a544b40-d9cd-4634-af8f-498e4999f6fb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3a8aaabf-3b7a-4764-ac3d-82fec3b8006f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3b33ceaf-ca76-423f-8eba-fa0a3a0cee87"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3c0ac6e4-3176-4dbc-aaf2-2f99956ea83e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3c5fd25f-2edd-414a-a9d9-6d166b633699"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3d196e3e-3441-4e3c-9db1-abbf31eaa32c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3fd0fe4f-d444-4a14-8da1-e75e8a10b6e9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("41a4de83-c4cc-4ca5-9c28-c644d2890fc2"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("42b9b8b6-4a03-4aa8-a1dc-e27ab99dc57a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("458a09f9-d6b1-45cc-a247-4a4b46dd2b93"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("48012155-6cd5-4637-a2a6-2500c097962b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("48f0b545-b532-496a-a10e-a589cda48739"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4c09735c-6dbc-4ef3-b859-c744b45852ee"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4dc0366c-c5fd-4db6-8db9-00b1e528f7cb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4de232b2-bfb1-47f7-bad3-d7b63fa865c5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4e59452d-93d9-40a8-a29c-e5567a98d638"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("50a35a6f-1636-442e-be84-0dc86d49d5eb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("50e6611e-2504-488d-af7c-bdda0891ccb8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("52466e7e-87df-48da-8d01-a08c280a286b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("527549f5-cfab-4ac2-9ba7-307470601a80"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("529c6412-0616-4745-8075-eb6f20bbd519"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5314bb3b-47bb-49f8-89f4-56b0cf61d371"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("54d32219-46d2-4b9c-8868-d6a7b449490b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5535033c-58a0-4c8f-a8b3-7111a3b3af22"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("555b35bd-0407-40ff-984a-22050abef07d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("558a356a-0744-4c66-bf5b-8ce2955ccf45"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5625d697-3658-4dce-acc3-b2e1af0b6931"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5a7e8a25-8cfe-4642-b90b-ba71e24dfd3c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5b5efb36-13be-49ee-a0e2-dbc6401700f6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5ba7371d-2cfc-40af-863e-6160c0024ff1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("61f62c93-bd23-4b49-8d52-27a915c60635"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("62b55d92-61ad-4a1a-9a30-c37e35a3636f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("65078d6e-6146-4fb1-b95e-a28682e976c8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("657b90f5-9f28-430f-a0c8-2383346cd244"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6612abd8-25fb-4ff0-88b2-1e8cc3be7cbb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("67781d2a-5f9d-4d6b-a1e4-489e044127b4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("690f4a54-9c79-4e24-b313-22bdb95e37d9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6967e18a-b062-4326-ac45-50725aec328e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("696dce26-d094-49bf-88cb-fa35427b63f9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6b8a3c24-1a31-49a6-a852-fa382f7e7d87"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6c5fe342-7346-464b-9eeb-66f5bbbcf69b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6d47e92b-1cba-4722-8e28-62f5f03883fa"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6d7327c2-8ee0-4ebf-8e33-32729387b9d0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("72ce129f-f9e0-4069-97ec-a3769a5ad8d3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("73086826-f75f-43dc-aa00-909cdcb7974c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("73bbe402-7955-4053-8316-9c420d921b56"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("748d478e-ce4d-47af-a98d-3522af515049"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("774a5414-8f06-4587-9d0b-1fcc4ca8d974"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("791eb302-08a4-4c70-9439-ee41b8eedca3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("792f9f23-80d8-4776-8fe0-a8afeda00435"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("79ba1b71-fce0-42f9-9953-e2876a1e2304"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("79f29fdb-ad0a-4a48-93ce-8ed016d50126"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7bcaede2-cde1-4d15-90c5-f57a82c8d1e4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7beccd53-8276-4a5e-9d2e-2c131897f9c4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7ca5d180-b858-4f11-81cb-a6d4b980afec"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7dc5944c-5325-4388-8db4-5d10cbaee9bc"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("80069448-b01d-4322-a68b-54045b0fb265"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("80c2b4c5-40b0-48f6-8038-47c5861ca73b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8198c8c5-ab48-4fbe-a7e8-fbe1f275d7ea"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("82d9de36-c27b-484e-bafe-99e994dba53a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("82e3d7f4-6bb7-44a8-841c-d3478c31485b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("82ed60dc-b5b0-4189-b980-b8a0e8545425"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("851c785e-bc12-48eb-a726-0b85b181f604"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("851e68b9-1ab3-44a1-8aaf-80a56cb21a46"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8607ef5c-57a3-400e-8190-ea2e4444d8db"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8617c081-cf66-4d51-a8be-d4c2efb61b99"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("88552593-7926-47e6-b36c-ae6e35471c61"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("88a4a0d5-9a97-4a94-9908-34761a6c9b17"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("88a726d2-2c1d-48f1-a821-a366af938be3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8a99dd65-77db-4e2f-8558-86ab85743220"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8aa37933-080a-4671-81e9-af87f533b845"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8ab9ac70-36c0-4f84-b9f9-986b8e63c849"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("904460a4-46c5-4f06-a8e6-0e6cdc076fd4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("90c941b3-5a35-47a7-a9de-2c47b616719d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("90dd103a-b3d1-439e-92b7-df14aa595b2a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("90dd47bb-4161-4adb-8982-ea9e73242598"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("96542c30-cc58-48f7-bc87-3c0e2b09f518"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("97919f67-5113-4d65-8b10-e61d8a0463c5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9a940b79-9c29-4ba0-b036-06ba8e104661"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9b002fc6-c871-4dbd-a089-21135e0e3aa3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9c9e1be3-4a76-4c82-b344-1d95198b9f44"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9cadef55-3197-4b07-858b-7a27f2632f81"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9cb879b5-6940-4029-9156-628cbb583d8a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a0ef7953-4ea1-44e8-9e5f-fb6ddde37346"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a2676620-d5be-4c2b-9722-8d683716528d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a32960cf-e21a-415a-8860-c6ad74bb52cc"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a34d0f9e-ec51-4746-a8c8-bfe7eac8f2bf"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a3675eac-0ed8-4436-94cb-ac0651e3ce21"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a4fd0c11-8167-4364-858a-73a5f5624701"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a795750e-a166-4af5-a6f3-027d93d51859"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a9f63ce6-a3d1-4f2d-a6d7-4c6c26c0e98f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("aac58567-c963-4455-90c1-030af42e641e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ab5245da-d583-41b1-bf37-29fefe2ee4f8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ab810a22-9885-4452-bd89-2fa88a3db4a3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("acdb9109-5c1a-4632-af8d-91b569d48c3f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ad1608d3-f27e-4969-9a06-ad1401a74969"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ad805c07-bbc0-4f12-844d-9d91c9128fe5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ae621a2d-4a2c-4b86-8b23-c496708e713b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b2c37c4b-60e8-431c-b582-5d04b29b0bd6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b48e4cbf-e502-4ca0-b59f-0c209aef30cd"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b4f92856-03fb-4675-9ebe-9077de941677"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b782f4c1-3afd-40ff-a04b-ba8f49df2991"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b8b48a67-c942-4ebb-9e99-8ac9c428f883"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b8fe7f38-ddd4-41a3-8675-885fc8adde66"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b9f9ccf8-744a-4c32-bd43-8b6b78d092c9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("bf0e5675-6bd6-4eea-87e7-e556c0d18320"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c1dc41da-6571-4c3e-b21e-2494cb70349b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c1f88591-a136-4b00-b1a5-61d5061e3881"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c2c161e4-6101-4205-ae06-937d921f3b1f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c33703c1-a798-4f62-b435-0e37f4341632"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c4d069d7-b5e6-4013-a2f5-155eb27f21f9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c540c3a4-fef8-42c6-95a4-620f224386b9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c5700f1b-23f9-4f23-9c11-e853ad6aafba"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c7daa73c-eeff-4224-a5a6-76127db24e44"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c9ad3bae-cddf-4271-aba6-751382206c25"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ca0bc9ab-71df-410e-ac26-8d0e8c51e23c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("caeb8e88-ea7c-45db-b44f-bad9cd824fd5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("caeefb22-51d2-4237-82b6-9d28d374b7e9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cb46cb30-09f9-45ff-9476-c6067e5f0c6c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cc7febb2-6948-4ae3-a3dd-a0f54c46f880"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cdc92229-fc2e-4443-b790-c57c40449a49"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cf1d82fc-0124-4557-8e7b-724c4e99ac2a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cf95e17f-c12c-4667-8d0d-e2dca358a9b8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d200c9a1-2bfd-49fa-9ccc-7809b48e2b01"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d5a4ecc8-7923-4656-8e43-93c406097d1e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d7579ef5-ff21-41af-a4de-50ae98228f6c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d82e23c1-564b-44e1-881e-38a6c3b85ba0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("dc809498-68f8-4b2f-b92d-2c1d0b40d0df"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("dda9711b-f8da-4098-a25d-081fd84c6b69"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e0ca7e50-ef31-4ce1-a3ee-2d7c4f7fef3f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e19dbb67-95db-44c6-99b0-3a524ebe2ef4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e2f710f7-23dc-4d0f-be3e-6705209dc75a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e365d3bb-ac01-4dbd-aef1-db51defcfcac"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e4070cb9-9133-4889-a77a-dd3302521dd1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ea513a18-7e9b-42f4-b313-1f5c1ca5fc3d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ed03b401-a7b6-4b77-9e84-1baec230e30d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ee913746-4a40-41ee-b868-5e06f546c6a1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("eeb0bb33-0e2b-4249-86bb-a7dd0710a5d4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f0346006-694a-41a1-b64f-ac0de1977896"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f25abb3a-78c2-4908-a0d2-291b062aeff1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f3c1ec4c-8c94-413b-8ce6-44c0a42de9af"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f425f025-9720-4125-8646-bd03b517c7d0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f86e33e9-51e0-4537-9c3f-531bb8963365"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f8fbd995-cdb3-4002-86b0-e6211ef51c2b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f90e7f12-21b6-4c29-803b-811e0c89abef"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f9589915-201f-49fc-9171-0362f43cf54e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f9b9c677-79eb-4ac4-9a9b-1e0da19b82db"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("faed2460-c0d9-4ba9-b15e-33f33267eab9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fbcd5c5f-cec9-4442-9d10-37deff760838"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fca2ca10-0767-48ad-b305-cc7b03d7df67"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fd78b766-36b1-4324-9fe8-4cc8210c6c30"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("feb9b111-7f4b-4146-b1a0-2c84ef7964a6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("feec1acc-13af-4120-82da-110c445d3ba5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ffb63add-9e0e-44df-ab3f-e75a52f14a14"));

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Record",
                table: "Participant");
        }
    }
}

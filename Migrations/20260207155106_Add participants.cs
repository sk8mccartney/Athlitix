using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Athlitix.Migrations
{
    /// <inheritdoc />
    public partial class Addparticipants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("09c7c50f-b897-4586-be37-719fd9d11893"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7e6db761-6057-427b-afe5-d575f97c00e7"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("93d6abd2-4651-4a21-9fc5-e9695fc66821"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f4e127d6-6af7-43c9-a471-cf944364f892"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("0e37b6b5-2a35-4e33-907e-f1c6c0ad7423"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("caccb9c5-7556-47a2-848c-176cee5dc643"));

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FirstName", "HeightCm", "IsActive", "LastName", "ModifiedAt", "ModifiedBy", "NickName", "PasswordHash", "PhoneNumber", "TeamId", "WeightKg" },
                values: new object[,]
                {
                    { new Guid("b1000001-1111-4111-8111-111111111001"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jack.smith1@example.com", "Jack", 172m, true, "Smith", null, null, "Tank", "", "07470000001", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 67m },
                    { new Guid("b1000002-1111-4111-8111-111111111002"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "tom.jones2@example.com", "Tom", 178m, true, "Jones", null, null, "Flash", "", "07470000002", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 71m },
                    { new Guid("b1000003-1111-4111-8111-111111111003"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "harry.brown3@example.com", "Harry", 180m, true, "Brown", null, null, "Hammer", "", "07470000003", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 75m },
                    { new Guid("b1000004-1111-4111-8111-111111111004"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "liam.taylor4@example.com", "Liam", 175m, true, "Taylor", null, null, "Ace", "", "07470000004", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 63.5m },
                    { new Guid("b1000005-1111-4111-8111-111111111005"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "josh.wilson5@example.com", "Josh", 182m, true, "Wilson", null, null, "Crusher", "", "07470000005", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 80m },
                    { new Guid("b1000006-1111-4111-8111-111111111006"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ben.walker6@example.com", "Ben", 170m, true, "Walker", null, null, "Spike", "", "07470000006", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 60m },
                    { new Guid("b1000007-1111-4111-8111-111111111007"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "sam.white7@example.com", "Sam", 176m, true, "White", null, null, "Storm", "", "07470000007", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 67m },
                    { new Guid("b1000008-1111-4111-8111-111111111008"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ryan.hall8@example.com", "Ryan", 185m, true, "Hall", null, null, "Blade", "", "07470000008", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 85m },
                    { new Guid("b1000009-1111-4111-8111-111111111009"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "luke.turner9@example.com", "Luke", 179m, true, "Turner", null, null, "Beast", "", "07470000009", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 75m },
                    { new Guid("b1000010-1111-4111-8111-111111111010"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "callum.harris10@example.com", "Callum", 183m, true, "Harris", null, null, "Bulldog", "", "07470000010", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 90m },
                    { new Guid("b1000011-1111-4111-8111-111111111011"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jake.roberts11@example.com", "Jake", 174m, true, "Roberts", null, null, "Rocket", "", "07470000011", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 63.5m },
                    { new Guid("b1000012-1111-4111-8111-111111111012"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "connor.clarke12@example.com", "Connor", 181m, true, "Clarke", null, null, "Iron", "", "07470000012", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 75m },
                    { new Guid("b1000013-1111-4111-8111-111111111013"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dan.wood13@example.com", "Dan", 177m, true, "Wood", null, null, "Knuckles", "", "07470000013", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 71m },
                    { new Guid("b1000014-1111-4111-8111-111111111014"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "alex.thompson14@example.com", "Alex", 184m, true, "Thompson", null, null, "Shadow", "", "07470000014", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 85m },
                    { new Guid("b1000015-1111-4111-8111-111111111015"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "max.jackson15@example.com", "Max", 179m, true, "Jackson", null, null, "Hammer", "", "07470000015", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 80m },
                    { new Guid("b1000016-1111-4111-8111-111111111016"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ollie.turner16@example.com", "Ollie", 171m, true, "Turner", null, null, "Flash", "", "07470000016", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 60m },
                    { new Guid("b1000017-1111-4111-8111-111111111017"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "charlie.wright17@example.com", "Charlie", 176m, true, "Wright", null, null, "Ace", "", "07470000017", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 67m },
                    { new Guid("b1000018-1111-4111-8111-111111111018"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "theo.patel18@example.com", "Theo", 182m, true, "Patel", null, null, "Storm", "", "07470000018", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 75m },
                    { new Guid("b1000019-1111-4111-8111-111111111019"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ethan.davies19@example.com", "Ethan", 186m, true, "Davies", null, null, "Bulldog", "", "07470000019", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 90m },
                    { new Guid("b1000020-1111-4111-8111-111111111020"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ryan.green20@example.com", "Ryan", 188m, true, "Green", null, null, "Beast", "", "07470000020", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 100m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participant_TeamId",
                table: "Participant",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_Team_TeamId",
                table: "Participant",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participant_Team_TeamId",
                table: "Participant");

            migrationBuilder.DropIndex(
                name: "IX_Participant_TeamId",
                table: "Participant");

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000001-1111-4111-8111-111111111001"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000002-1111-4111-8111-111111111002"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000003-1111-4111-8111-111111111003"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000004-1111-4111-8111-111111111004"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000005-1111-4111-8111-111111111005"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000006-1111-4111-8111-111111111006"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000007-1111-4111-8111-111111111007"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000008-1111-4111-8111-111111111008"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000009-1111-4111-8111-111111111009"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000010-1111-4111-8111-111111111010"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000011-1111-4111-8111-111111111011"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000012-1111-4111-8111-111111111012"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000013-1111-4111-8111-111111111013"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000014-1111-4111-8111-111111111014"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000015-1111-4111-8111-111111111015"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000016-1111-4111-8111-111111111016"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000017-1111-4111-8111-111111111017"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000018-1111-4111-8111-111111111018"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000019-1111-4111-8111-111111111019"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000020-1111-4111-8111-111111111020"));

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FirstName", "HeightCm", "IsActive", "LastName", "ModifiedAt", "ModifiedBy", "NickName", "PasswordHash", "PhoneNumber", "TeamId", "WeightKg" },
                values: new object[,]
                {
                    { new Guid("09c7c50f-b897-4586-be37-719fd9d11893"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "matt@hotmail.com", "Matthew", 173m, true, "McCartney", null, null, "Matt", "", "07470797908", new Guid("00000000-0000-0000-0000-000000000000"), 75m },
                    { new Guid("7e6db761-6057-427b-afe5-d575f97c00e7"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "chunkz@hotmail.com", "Joe", 170m, true, "McCartney", null, null, "Chunkz", "", "07470797908", new Guid("00000000-0000-0000-0000-000000000000"), 65m },
                    { new Guid("93d6abd2-4651-4a21-9fc5-e9695fc66821"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "moron@hotmail.com", "Elon", 169m, true, "Musk", null, null, "Moron", "", "07470797908", new Guid("00000000-0000-0000-0000-000000000000"), 66m },
                    { new Guid("f4e127d6-6af7-43c9-a471-cf944364f892"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "chuck@hotmail.com", "Chuck", 165m, true, "Norris", null, null, "Chuck", "", "07470797908", new Guid("00000000-0000-0000-0000-000000000000"), 61m }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "OrganizationId" },
                values: new object[,]
                {
                    { new Guid("0e37b6b5-2a35-4e33-907e-f1c6c0ad7423"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Guisleys premiere boxing club", true, null, null, "Henrys Boxing", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") },
                    { new Guid("caccb9c5-7556-47a2-848c-176cee5dc643"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Guisleys premiere boxing club", true, null, null, "LS20 Boxing", new Guid("5835ca66-1356-42a5-a36a-cf1a019189f1") }
                });
        }
    }
}

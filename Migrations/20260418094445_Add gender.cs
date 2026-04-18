using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Athlitix.Migrations
{
    /// <inheritdoc />
    public partial class Addgender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("01a783a4-fff0-4225-813f-f85a2d2786c0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("01a826ec-2729-4443-a04d-ed8b0ad7b0cb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("02ba356f-8525-4080-86f6-c86184320afc"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("053e6a61-c2ce-4676-8dc4-88ce1a357029"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0543df3f-9e51-4ed4-8681-07ec240065af"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("068a6a93-d1bd-47a2-b563-462f7f689be6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("06e6322e-bdc2-4d09-bbaa-18110bdd3ea4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0748251d-adea-4e79-849a-29067fd7f97a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0759510d-028c-455a-9993-4ae792877c58"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("09154876-044b-480d-9cc7-b6880b30a1e0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("09c843ea-0395-4092-b887-34b978e62191"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0c8fd745-02cc-4c6c-843f-a388e85fd81e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0eb86f1f-0eb5-4a5e-9519-1c44cbc78476"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0fadd6b1-4973-4444-9540-201136297997"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1093d639-b36a-44ca-a43f-b847f980d1c9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("11b61bcf-5338-44bc-90e4-a1ba2448bc0f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("11c4a574-13f5-47cb-a713-f645bdb6f3b1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("12a66c0f-51f2-4310-a327-1fc46943ae51"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("13d433fa-4a2b-41a8-a697-f1835a6165ec"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1957b481-157d-49a6-b603-2b025df42bb8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("19c7f2ce-8576-4cfb-ac44-9cc2128d7047"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1a8e37fe-de29-4e3a-9d9c-e76068a86d8d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1ad3c1df-19f5-4173-8d47-30a4cd62c36f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1b740e3c-b687-4d03-946d-f1d305c94056"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1bb29835-1671-4f03-88e7-47638d46472b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1c7f6b2d-7f1c-4c46-aa00-cc9c8c5d223b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("20314264-ee00-4720-b623-6af45a27a5e0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("20876f80-6da0-47e5-b262-abd173e71d26"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("21154c89-3099-4b86-a9ea-597e607b425a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2162549d-99bd-4121-a6d2-469e53fd4b04"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("23165a69-4307-4261-a1da-afe7764e751d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("24d10aeb-3742-45d7-a2f0-c0dd4f70034e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("24d42484-ecca-4645-880d-8d2a85c97b2a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("254c2dbf-d073-42fe-ae44-28b790dffbe4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("26fb3b05-9656-4984-bfa8-3dfde478b540"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("26ff13be-eb47-4925-8c57-692daaff9ca5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2a1757f0-281b-4baa-94bb-89d258b4c880"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2a1f3fd0-0c3b-47b9-9e0b-a78f4b391023"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2b3b813a-7d54-4f27-9aaf-282f70958b2a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2bde1c75-d4f6-4980-a874-c834a37a03c8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2da75fb5-f4b2-4c90-a0e1-690fde932d47"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2f067c1d-173c-4a0e-9e28-acf719bd7d10"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2f13c3e6-a918-4112-bb44-4ab72e0f5c63"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2f797113-79b5-4d02-9748-49e20ca7d5bd"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("302072c7-3829-41ea-989b-c51b81ba9401"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("31786f82-bc22-4c6a-8028-1f040730984d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("31929bf9-1fc9-47d6-9ae8-164349a668d0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("31af23c0-c38a-49bd-850c-f529851c1ca7"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("328b34eb-d0ed-4f1d-82f0-73e8122c0c91"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("33f51b71-6fbd-42dc-87a2-4b06e7b80744"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("37963008-3e54-4b20-9547-6d04d16e60c8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("39fb74bd-14bd-41de-aac4-009d1f89ff0a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3a4d8d44-86a0-4238-a652-f5deb0b9fcb8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3bd0d4a0-7e2d-4ca7-a625-bca7ab86b773"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3d82fd34-7946-4ac6-8248-6a9a28ffb694"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("40847179-3ef9-4de6-a082-90998d7b28eb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("423adf03-b171-4e5f-88ac-68e967e55d24"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("423d0d92-488c-40f3-8863-f39f86c972a4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("426c45c6-84c3-4bf5-a79d-f52f54a205e5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("45b4bcba-ade4-4086-8316-0923ec41da5c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("46fa5147-1e9c-48b8-be04-ef58e7a0abc0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4730120c-5374-4578-8eed-c7db818f27d9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4ade1ea3-5f58-4de6-92ef-b13f3b08b4cd"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4b49cf15-47a8-46f0-bb58-63f66b9338cf"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4fb3852d-c58b-4215-9813-e6ee4fce9edc"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5095cc3d-d0f1-41d5-9a00-a9ff7d091c52"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("52816730-ffd3-4b18-92c7-d9feac024c2f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5295f2f1-2940-406a-a2a2-ff035f57546b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("536142b6-d199-485d-8864-9ae38a96e924"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("54830c20-9bd8-483c-a997-52075336a647"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("56ed4707-74b5-4684-9cfc-7f67e7119c12"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("57fdca99-0a4b-4ca1-978e-a47208596c97"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("58e93fe5-2e3a-403e-a27d-6b6465ab2955"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5a175f48-c395-4cc2-9b1b-d911fd46f6a0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5c58a1f5-0732-4764-b7ff-63d5667e11f8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5e2647e8-e6b4-4a75-8581-e0c35744807f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5ff3f58b-1f90-410c-92a4-f7416407e634"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("61e1d4fd-a412-4e7c-9ae1-80f9a76e6467"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("64b1c80a-33d3-4b07-9bf3-b00f2c0654ac"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6720b4f5-d5f7-4784-8eae-7dbef791aef3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("67568bde-97a5-4a09-b2ef-a3a14ee3c606"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6ae5dadc-2399-47ce-af4d-e258a2a45867"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6dc99cce-c125-4e16-8a86-0a14342376a2"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6ef133a3-ee5a-4509-b334-26bc8f7c17de"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6f120796-e0a8-4008-89e1-f45d27b5c989"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6f3013f0-b277-4c8a-8a81-f6cbae63edd0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6f98a2b9-863d-46a6-aba3-189902132f47"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("70732cc3-9e9c-4334-aef4-f90e876bcd97"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("724c91ca-b93f-4119-83fb-de31150fae1a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("727122a4-0b01-4ab1-af39-6a063b4bcdbe"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("730717a5-ac83-4068-80b5-b3739edd97de"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7376aba8-16fd-4087-90c4-7f9c8947ec36"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("742e1c2b-0444-44e2-a4b2-5e275eab7ac8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("760e2ac1-55cf-4ea4-bbed-f119e4d5caba"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("764589fd-148b-42fc-9cfc-f3a5c39ad69a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7948f704-daae-425e-8b63-91da608ac304"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7994add2-5fb8-4d6d-a6fb-be95f1b5d934"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("79b3e157-4d51-4231-849f-3e4d2e040d72"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7c9023a3-f7d7-45b6-a604-1c77450813a0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7d850e73-9a02-4234-9f3e-fc8f7b0504c3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7f06b50f-3c21-4d44-8b53-c7e434338059"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7f18aa63-04e9-420e-a68c-bce657b8d0b8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("80210db7-ed4b-4e45-ba40-ed7b05fd6e82"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("83426b61-ff08-4844-a2c2-316fef81b704"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("838b6df1-dc8e-49c6-8693-2903f87ffbee"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("85767b22-6321-4f18-b595-a2dd223ccc3e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("86b0d59d-68e5-45e2-a971-2468a37c6500"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8c50de97-9a51-42df-b0e7-4d962a063680"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8dd6e3d2-0f6c-4b5f-a302-66f51254321a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("907eed8e-944b-41e1-94f7-6a300eb72aef"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("90a00fc3-5d1e-4323-b77f-cd2b197e8ac4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("915747ee-253e-44e8-bfef-96ad69df2efc"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("92046394-0859-4661-b215-e7dc40822d38"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9245939a-b3c4-4d8c-b5de-5779c93b6994"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("928022c5-34f4-43ea-8744-a31cc2ca9e5d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("942d35e6-791b-42db-9ef4-89d491368c3d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("94c2af5b-73de-425b-8b36-ddff8c69af36"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("954e4d33-59c4-4941-8079-41d9e4410a5f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("968c4ce5-c857-4f46-bccb-9126986efce6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9c6def24-3bb3-444c-80c7-15b55955c121"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9c772ef9-1a29-4f07-815a-c019b6d1d1ea"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9e55d888-243b-433d-a33e-c7488ecc228f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a1c3135b-c210-4999-9041-10ce982386a5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a37f7be2-3f35-48af-8108-87686aa66f27"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a750c406-1210-48b0-84d3-240649b58833"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a811277a-d17b-43ef-9ee3-7af026a5f9db"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a84139fd-fa3e-4256-9a3e-bacddcaee932"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a97daf37-960d-46fc-bf48-05acd7f5fe52"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a98cc025-0aa6-4771-b05a-091e2895a47c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("aa00216d-3754-4e17-addf-3f2df41f1073"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("aa18335b-bb28-4f33-a3c6-8328066c7b86"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ac1f5d10-10ba-4c00-9a08-b7c64a28d8fd"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("aca014e2-c914-48d4-93e8-9c7e61325e65"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ad03f835-92d5-4826-87a6-21434d3a56bf"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("af4e32bb-cf7a-4576-b0b7-4b7e9a48236c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b0755979-d65f-42e8-9c3b-91072a36616e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1bf4e7a-44cd-488c-8e32-7914c64654ac"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b28c5bf0-566a-4d8f-893b-92944ec1c874"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b4135485-289b-46dc-a274-c1221936c2e5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b5631802-4750-4f4b-aa9c-05d7c6e3b9f9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b5bbd9ca-a508-4194-a3d8-9a2fa1a93339"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b7a6f082-1c23-445b-a143-f7a93173e671"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b84f62f3-02ce-479c-b53b-b72ecfc904c0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b9446c6c-d427-4bd6-8108-568a6ed1d581"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("baf64036-0f53-41be-b9d4-40dc37b9eece"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("bcc96d6c-05ec-4816-9f89-da51315ef023"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("bd0996b6-b4d0-41bb-9557-2640796de986"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("be338bb5-a9da-4af0-a71a-68db60a81d46"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c0d19665-ec52-4597-ade3-b60c586c5263"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c41aab29-146f-42df-b01d-66181c9efb91"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c4e99bba-ab03-4ea5-a0ee-c7fa8aea5173"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c57a0c7b-91d2-405c-9fab-dd3feee73e7a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c59cb820-15e3-4897-a2e5-87fed0ee1df7"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c59f9fd5-af9a-4bfc-b3d2-6e704fe00d45"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c65c593c-79cd-4c7d-8d9d-21c4cf7ebfa2"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c670f207-a583-49f4-a2f3-a4edc12e3b21"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c7beefdc-3f5c-4711-9987-55de4d586e94"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c8182ebd-1070-4b3e-9ebb-550b1f9ca34a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c973545b-5156-49bf-9bc6-52acc1843e82"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c989c8d9-1bdf-43ae-8824-6234e4d6c57f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ca1e6589-3943-446a-9880-240151d4cd3b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ca25a3d9-888e-48ad-a3c7-323bdea3ee8c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cbcf9114-6598-46ff-9faa-ac57ea537d13"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cbd89d26-7a62-43af-8411-d7fda1224d75"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cc1f9c0c-e32d-45ec-9f36-a5e2a0b1d4ad"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cc509690-8a0e-4042-93d7-d697d89ac14f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ce4175c2-1dff-4c2a-8e5c-15f082a0a95d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cf8b34a7-0047-4577-aeca-1e82a3004abb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cf90ac21-70b0-463a-9f97-ac7f6b809e23"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cfb5f34f-08e5-41e3-a46c-5d428252867c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cfc48504-6f03-4f29-a406-ef95d3fc3f5e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cfcae534-dd1a-4f19-8054-06e28ef35112"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d0f4c939-e3bb-4aff-aceb-7d6c64cbb9fb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d170db0a-49af-4f03-9b60-fc1d8327f450"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d2f3c42d-cb9b-4223-b373-9ea2f25e7215"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d48556e3-f78e-4947-8775-afbc3d4abf21"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d620cc19-60f4-4923-a150-8cd442639a64"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d7707e94-e1bb-468c-932c-7d736175fcde"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d8947f96-4b82-4bea-b8be-746ce6902ba2"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("dbf823b0-a997-43d7-841b-6f37a657104c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("dce5d0d1-ab18-4cb3-a126-34f145a6e6c8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("df0cbe48-2c0a-49d8-8081-54a02684504c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e1e3a92b-df58-4f90-81c3-9008fb3dab9a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e2211f92-5d95-4148-a733-afc5a629f773"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e239ac4f-021b-4352-95e8-23080c1f8971"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e5e87710-57b9-46a1-8d46-0420eff4cb27"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e7854f5e-f24c-41e0-961a-f7f058b760e9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("eb9e42f1-c9aa-479b-af9f-5fbd370fe166"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ec35ca0b-2fa1-4615-828d-cd57829bb696"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ee1e3338-3ce4-4b32-ae09-6ecc3b249c44"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("eeca9dc5-febb-48d8-b769-1d4b30d9b16e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("efb977ce-cea7-4655-811f-1b9b7c0f0f36"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f52fd703-ae80-48ea-954b-22bba5c961e9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f7ab789b-b7de-4971-aa67-0cd65a37111f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f7d22d28-baa2-4808-bd06-fad63657bd91"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f8517214-51e2-4c09-b128-cd68b760184b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f95cc604-6093-4f1a-ac4b-6d781e5a6e9e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fab1790b-22b4-4d5a-bfd9-1168ce7d3d98"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fee54a80-78a6-4665-8b5f-8e6b12227319"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ffdd196f-38a9-4517-b419-e58475a36e9e"));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Participant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000001-1111-4111-8111-111111111001"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000002-1111-4111-8111-111111111002"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000003-1111-4111-8111-111111111003"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000004-1111-4111-8111-111111111004"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000005-1111-4111-8111-111111111005"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000006-1111-4111-8111-111111111006"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000007-1111-4111-8111-111111111007"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000008-1111-4111-8111-111111111008"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000009-1111-4111-8111-111111111009"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000010-1111-4111-8111-111111111010"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000011-1111-4111-8111-111111111011"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000012-1111-4111-8111-111111111012"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000013-1111-4111-8111-111111111013"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000014-1111-4111-8111-111111111014"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000015-1111-4111-8111-111111111015"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000016-1111-4111-8111-111111111016"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000017-1111-4111-8111-111111111017"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000018-1111-4111-8111-111111111018"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000019-1111-4111-8111-111111111019"),
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b1000020-1111-4111-8111-111111111020"),
                column: "Gender",
                value: "Male");

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FirstName", "Gender", "HeightCm", "IsActive", "LastName", "ModifiedAt", "ModifiedBy", "NickName", "Notes", "PasswordHash", "PhoneNumber", "Record", "TeamId", "WeightKg" },
                values: new object[,]
                {
                    { new Guid("01233513-ab20-4128-93ac-6bc1d9b77e06"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "toby.taylor293@example.com", "Toby", "Male", 177m, true, "Taylor", null, null, "Lightning", "", "", "07470100193", "Win = 4, Loss = 5, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 58.3m },
                    { new Guid("05387d97-2073-46e1-89f8-87bbd9aa1a96"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elliot.torres241@example.com", "Elliot", "Male", 171m, true, "Torres", null, null, "Reaper", "", "", "07470100141", "Win = 2, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 108.1m },
                    { new Guid("0631bb27-7ad2-47ae-a588-2b2807f0b9dc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "adam.ross136@example.com", "Adam", "Male", 170m, true, "Ross", null, null, "Berserker", "", "", "07470100036", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 84.5m },
                    { new Guid("0b24e281-f632-4b93-b85e-1ccc4c8ec971"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ivan.henderson259@example.com", "Ivan", "Male", 176m, true, "Henderson", null, null, "Rampage", "", "", "07470100159", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 112.0m },
                    { new Guid("0b6cd75d-cede-4d4b-8dec-af8d91d1d938"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "cody.bailey222@example.com", "Cody", "Male", 186m, true, "Bailey", null, null, "Zero", "", "", "07470100122", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 109.3m },
                    { new Guid("0deb802a-501f-49fc-b496-add31b144f28"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rowan.cox273@example.com", "Rowan", "Male", 170m, true, "Cox", null, null, "Chrome", "", "", "07470100173", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 71.4m },
                    { new Guid("0eebd475-cbe9-4c9e-b23d-b13e78402955"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "keaton.myers207@example.com", "Keaton", "Male", 167m, true, "Myers", null, null, "Berserker", "", "", "07470100107", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 76.3m },
                    { new Guid("0fab3aa2-aa5c-4847-9a2a-dbf4e775f83e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jasper.sanders246@example.com", "Jasper", "Male", 181m, true, "Sanders", null, null, "Titan", "", "", "07470100146", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 104.4m },
                    { new Guid("0fcfc664-7787-48ed-9295-a7cacd34b432"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "evan.price284@example.com", "Evan", "Male", 165m, true, "Price", null, null, "Kraken", "", "", "07470100184", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 68.5m },
                    { new Guid("10f7d2d8-4307-4a33-a380-136aeafa37c7"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "oscar.alexander102@example.com", "Oscar", "Male", 187m, true, "Alexander", null, null, "Ghost", "", "", "07470100002", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 89.7m },
                    { new Guid("12fd9fba-e5c6-4144-ae37-3ec9b5119c2c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "aiden.cox100@example.com", "Aiden", "Male", 182m, true, "Cox", null, null, "Shadow", "", "", "07470100000", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 92.3m },
                    { new Guid("1451a541-74e8-4d82-88d0-5aa7d5cae749"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "callum.torres166@example.com", "Callum", "Male", 168m, true, "Torres", null, null, "Cobra", "", "", "07470100066", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 113.8m },
                    { new Guid("182add32-9d12-4d49-acb8-efb4eae6d4fb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "keaton.edwards125@example.com", "Keaton", "Male", 199m, true, "Edwards", null, null, "Riot", "", "", "07470100025", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 119.0m },
                    { new Guid("182d830c-7dc7-4cc5-bffa-d896fb4a6b78"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "archie.peterson121@example.com", "Archie", "Male", 165m, true, "Peterson", null, null, "Riot", "", "", "07470100021", "Win = 0, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 109.8m },
                    { new Guid("18537d74-1c1d-4ab4-9d2f-c168faebad6b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "mitchell.collins216@example.com", "Mitchell", "Male", 193m, true, "Collins", null, null, "Nightfall", "", "", "07470100116", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 62.9m },
                    { new Guid("18fb42ed-48b6-4084-a7ad-761e941515e3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "freddie.diaz164@example.com", "Freddie", "Male", 199m, true, "Diaz", null, null, "Echo", "", "", "07470100064", "Win = 2, Loss = 3, Draw = 5", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 115.5m },
                    { new Guid("19c8aa86-57de-421a-8412-9d4383b19e67"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "cameron.adams201@example.com", "Cameron", "Male", 187m, true, "Adams", null, null, "Matrix", "", "", "07470100101", "Win = 6, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 58.0m },
                    { new Guid("1ad94d18-1fcd-482e-8038-8edca1e7a4cb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "harley.butler169@example.com", "Harley", "Male", 174m, true, "Butler", null, null, "Cutlass", "", "", "07470100069", "Win = 5, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 93.4m },
                    { new Guid("1ae3787c-0880-4668-b350-a9e23b001491"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "isaac.campbell206@example.com", "Isaac", "Male", 196m, true, "Campbell", null, null, "Crusher", "", "", "07470100106", "Win = 0, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 82.0m },
                    { new Guid("1ae6325b-5dba-4870-9ef0-2fcaff3a1194"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "corey.rogers295@example.com", "Corey", "Male", 189m, true, "Rogers", null, null, "Chaos", "", "", "07470100195", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 79.4m },
                    { new Guid("1b0bd879-3860-4eba-b1a5-9804208123b5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hunter.nelson165@example.com", "Hunter", "Male", 195m, true, "Nelson", null, null, "Static", "", "", "07470100065", "Win = 2, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 56.8m },
                    { new Guid("1d494f2d-bcbc-47d1-85f2-afc8d44bcb5a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "evan.ramirez134@example.com", "Evan", "Male", 184m, true, "Ramirez", null, null, "Spark", "", "", "07470100034", "Win = 5, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 60.9m },
                    { new Guid("1f141adb-dc32-4676-a3b6-a72e628bbb0a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "aiden.hamilton204@example.com", "Aiden", "Male", 174m, true, "Hamilton", null, null, "Havoc", "", "", "07470100104", "Win = 1, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 71.1m },
                    { new Guid("2276ae19-09ba-4740-b226-96f7e0e95cba"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elliot.foster230@example.com", "Elliot", "Male", 192m, true, "Foster", null, null, "Knuckles", "", "", "07470100130", "Win = 3, Loss = 2, Draw = 3", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 67.2m },
                    { new Guid("22c60df3-2be2-4365-8f33-c2bb1e2342a1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bradley.thomas143@example.com", "Bradley", "Male", 177m, true, "Thomas", null, null, "Cutlass", "", "", "07470100043", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 105.0m },
                    { new Guid("24512110-5cc5-45b0-9fb9-2934e4adf3c9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "leon.bryant189@example.com", "Leon", "Male", 178m, true, "Bryant", null, null, "Knuckles", "", "", "07470100089", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 66.7m },
                    { new Guid("25ab70f9-132a-4c90-b196-cb4cc9d70ea3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "george.russell177@example.com", "George", "Male", 176m, true, "Russell", null, null, "Boss", "", "", "07470100077", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 115.8m },
                    { new Guid("271f7a43-0c56-4f8e-ba9a-fe356f45e70f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zack.mitchell196@example.com", "Zack", "Male", 182m, true, "Mitchell", null, null, "Wolf", "", "", "07470100096", "Win = 1, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 92.2m },
                    { new Guid("276f8f0b-9733-4acc-afbb-6de1e73ddab8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "theo.watson118@example.com", "Theo", "Male", 168m, true, "Watson", null, null, "Circuit", "", "", "07470100018", "Win = 6, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 95.5m },
                    { new Guid("2a3826b6-ec99-4596-8c10-bafd9de643ef"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "adam.long202@example.com", "Adam", "Male", 179m, true, "Long", null, null, "Grizzly", "", "", "07470100102", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 94.0m },
                    { new Guid("2bd1b90c-6955-4f8a-9873-3f3ed4b01a1c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "charlie.griffin221@example.com", "Charlie", "Male", 199m, true, "Griffin", null, null, "Ricochet", "", "", "07470100121", "Win = 4, Loss = 5, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 86.2m },
                    { new Guid("2f713b04-c419-47b8-8cf9-bf0f1c81aa39"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dominic.green200@example.com", "Dominic", "Male", 185m, true, "Green", null, null, "Wraith", "", "", "07470100100", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 83.5m },
                    { new Guid("32983fd4-dc78-4ada-834d-7586c83c1f84"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "rowan.young117@example.com", "Rowan", "Male", 167m, true, "Young", null, null, "Scorpion", "", "", "07470100017", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 90.2m },
                    { new Guid("3354a507-eb36-4c57-bad9-42975d4c588d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reuben.collins180@example.com", "Reuben", "Male", 192m, true, "Collins", null, null, "Anvil", "", "", "07470100080", "Win = 0, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 91.7m },
                    { new Guid("33a1e49c-fe55-45ec-82db-e39f2f1a1fa6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "adam.cooper277@example.com", "Adam", "Male", 167m, true, "Cooper", null, null, "Specter", "", "", "07470100177", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 95.4m },
                    { new Guid("3511541a-438a-4a32-b88d-5857d44a0c82"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bobby.alexander263@example.com", "Bobby", "Male", 174m, true, "Alexander", null, null, "Tsunami", "", "", "07470100163", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 103.4m },
                    { new Guid("351ac9d7-ad96-43f5-92d2-a2a053cdf54c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "logan.adams278@example.com", "Logan", "Male", 199m, true, "Adams", null, null, "Longshot", "", "", "07470100178", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 72.5m },
                    { new Guid("35d56b70-2cea-4a98-8d89-2b197ff5e437"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "freddie.henderson247@example.com", "Freddie", "Male", 193m, true, "Henderson", null, null, "Bandit", "", "", "07470100147", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 60.4m },
                    { new Guid("36586b5d-2d10-46b3-8f7f-4dc7befc5de3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "toby.mitchell144@example.com", "Toby", "Male", 170m, true, "Mitchell", null, null, "Rocket", "", "", "07470100044", "Win = 0, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 62.6m },
                    { new Guid("39de48c6-27d6-4db5-ab13-4c7264b23adb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jesse.wright213@example.com", "Jesse", "Male", 166m, true, "Wright", null, null, "Tornado", "", "", "07470100113", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 112.2m },
                    { new Guid("3d6de972-8652-40f4-becf-332984800550"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "mason.james218@example.com", "Mason", "Male", 190m, true, "James", null, null, "Anvil", "", "", "07470100118", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 75.6m },
                    { new Guid("3f340a66-ebda-4003-bd43-ce03140202db"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "lucas.stewart104@example.com", "Lucas", "Male", 186m, true, "Stewart", null, null, "Smokes", "", "", "07470100004", "Win = 1, Loss = 0, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 68.4m },
                    { new Guid("40ace9c9-f60c-41ec-a084-6029f3eb240c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hunter.collins175@example.com", "Hunter", "Male", 182m, true, "Collins", null, null, "Steel", "", "", "07470100075", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 70.5m },
                    { new Guid("40f83788-6ce1-4ef1-aec7-eec25b5280d9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kieran.wood112@example.com", "Kieran", "Male", 165m, true, "Wood", null, null, "Berserker", "", "", "07470100012", "Win = 4, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 100.9m },
                    { new Guid("434f19e5-0494-431b-9c4d-59ddc3080fd9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jacob.powell145@example.com", "Jacob", "Male", 185m, true, "Powell", null, null, "Cobra", "", "", "07470100045", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 101.8m },
                    { new Guid("438bf331-1aef-4d12-84de-e8211eb5b72c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jayden.gray168@example.com", "Jayden", "Male", 194m, true, "Gray", null, null, "Kraken", "", "", "07470100068", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 68.4m },
                    { new Guid("44e572a9-c84b-4710-9ae8-53256585e29d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "finn.bell228@example.com", "Finn", "Male", 192m, true, "Bell", null, null, "Falcon", "", "", "07470100128", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 57.8m },
                    { new Guid("462d07a8-b9df-49ab-9f03-057bbe15e70d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "charlie.bryant105@example.com", "Charlie", "Male", 178m, true, "Bryant", null, null, "Tsunami", "", "", "07470100005", "Win = 3, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 57.9m },
                    { new Guid("4726340f-3e0c-4fb0-8c06-f88ec917b9a7"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "cameron.myers142@example.com", "Cameron", "Male", 166m, true, "Myers", null, null, "Rampage", "", "", "07470100042", "Win = 6, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 66.7m },
                    { new Guid("4959642a-6f6a-4600-a89f-9a2bd167293c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "lewis.morgan114@example.com", "Lewis", "Male", 184m, true, "Morgan", null, null, "Darkstar", "", "", "07470100014", "Win = 4, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 84.3m },
                    { new Guid("4a41127f-8d92-4c3f-b9a6-7c18ef19633f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "grayson.rivera240@example.com", "Grayson", "Male", 174m, true, "Rivera", null, null, "Storm", "", "", "07470100140", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 74.7m },
                    { new Guid("4b1b628a-c298-4f80-9e1b-a9585b5035d1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "archie.bryant271@example.com", "Archie", "Male", 166m, true, "Bryant", null, null, "Cipher", "", "", "07470100171", "Win = 3, Loss = 5, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 99.3m },
                    { new Guid("4b8a8213-2b1a-42e7-a592-5500db1c8680"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "toby.collins161@example.com", "Toby", "Male", 177m, true, "Collins", null, null, "Kraken", "", "", "07470100061", "Win = 5, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 108.5m },
                    { new Guid("4dcc752e-26f1-42ba-9584-bce40d7c9162"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "miles.carter120@example.com", "Miles", "Male", 193m, true, "Carter", null, null, "Fang", "", "", "07470100020", "Win = 3, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 64.4m },
                    { new Guid("4f0b405c-029b-4380-818c-d7330a8a2ebb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "callum.foster186@example.com", "Callum", "Male", 187m, true, "Foster", null, null, "Titan", "", "", "07470100086", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 63.9m },
                    { new Guid("4f48d61d-f30c-4657-a75d-1b91ccb634ba"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "nathan.butler194@example.com", "Nathan", "Male", 171m, true, "Butler", null, null, "Kraken", "", "", "07470100094", "Win = 2, Loss = 5, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 95.6m },
                    { new Guid("5038aac8-f286-491f-bee4-13e0371c154f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reece.cox187@example.com", "Reece", "Male", 183m, true, "Cox", null, null, "Diesel", "", "", "07470100087", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 107.9m },
                    { new Guid("50e14681-cb8c-47ef-96e2-65d52dc8fcbf"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "blake.scott296@example.com", "Blake", "Male", 189m, true, "Scott", null, null, "Grizzly", "", "", "07470100196", "Win = 2, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 104.8m },
                    { new Guid("510ccd40-7a4c-478f-9d89-dcec2a2a2c77"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kai.washington174@example.com", "Kai", "Male", 170m, true, "Washington", null, null, "Jinx", "", "", "07470100074", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 64.6m },
                    { new Guid("534cec36-aa53-480a-a824-1c4568c50480"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "callum.butler219@example.com", "Callum", "Male", 176m, true, "Butler", null, null, "Zephyr", "", "", "07470100119", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 75.4m },
                    { new Guid("5446f6f1-bb49-4322-8d76-65532c43e841"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "leon.evans191@example.com", "Leon", "Male", 199m, true, "Evans", null, null, "Byte", "", "", "07470100091", "Win = 13, Loss = 17, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 56.9m },
                    { new Guid("57286e31-917d-49c3-ad15-7efd09746dd2"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "max.diaz151@example.com", "Max", "Male", 176m, true, "Diaz", null, null, "Striker", "", "", "07470100051", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 60.5m },
                    { new Guid("57bf4812-8e89-4b09-a2e8-a3a0284e5801"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rhys.hughes244@example.com", "Rhys", "Male", 191m, true, "Hughes", null, null, "Nightfall", "", "", "07470100144", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 73.5m },
                    { new Guid("5823db2c-ae34-4285-9d8b-5d90c64b91aa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ezra.brooks131@example.com", "Ezra", "Male", 187m, true, "Brooks", null, null, "Beast", "", "", "07470100031", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 114.0m },
                    { new Guid("583536bb-3a8d-4a66-ae94-82b1382465cb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "oscar.wright176@example.com", "Oscar", "Male", 177m, true, "Wright", null, null, "Overdrive", "", "", "07470100076", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 107.8m },
                    { new Guid("584e4284-760f-4614-817c-2e8f174e4029"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "lewis.phillips129@example.com", "Lewis", "Male", 190m, true, "Phillips", null, null, "Oblivion", "", "", "07470100029", "Win = 6, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 82.0m },
                    { new Guid("5919ef3b-fad5-4f6d-a319-6f022ef9ad4c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "callum.price253@example.com", "Callum", "Male", 185m, true, "Price", null, null, "Iron", "", "", "07470100153", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 55.2m },
                    { new Guid("5951f876-e04b-4310-9546-0deb58f4165c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reuben.walker225@example.com", "Reuben", "Male", 185m, true, "Walker", null, null, "Cipher", "", "", "07470100125", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 68.2m },
                    { new Guid("5b8c24a2-d6bb-4938-add0-2e2e1a06f25b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "blake.butler243@example.com", "Blake", "Male", 200m, true, "Butler", null, null, "Vandal", "", "", "07470100143", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 94.8m },
                    { new Guid("5c1e2d04-cfea-43db-972f-dae2cc7b977a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "mitchell.sanders254@example.com", "Mitchell", "Male", 198m, true, "Sanders", null, null, "Fang", "", "", "07470100154", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 113.7m },
                    { new Guid("5c5ec9f6-7a70-4e0b-aeb7-e07da8f3df4f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ethan.gonzalez297@example.com", "Ethan", "Male", 167m, true, "Gonzalez", null, null, "Tsunami", "", "", "07470100197", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 80.8m },
                    { new Guid("5d1acd76-97de-4b46-a665-482bce9aaba4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reece.parker126@example.com", "Reece", "Male", 174m, true, "Parker", null, null, "Thunder", "", "", "07470100026", "Win = 2, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 72.2m },
                    { new Guid("5e2e185e-1f09-4169-80f3-5c7ea9c4a344"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "henry.coleman101@example.com", "Henry", "Male", 186m, true, "Coleman", null, null, "Rocket", "", "", "07470100001", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 116.3m },
                    { new Guid("5ea4026d-be62-4d87-9f82-78a99afe5868"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jacob.adams107@example.com", "Jacob", "Male", 168m, true, "Adams", null, null, "Brawler", "", "", "07470100007", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 85.0m },
                    { new Guid("5f67be8f-8b67-4c10-b16b-d9e36f858a55"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jude.powell190@example.com", "Jude", "Male", 182m, true, "Powell", null, null, "Vortex", "", "", "07470100090", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 106.0m },
                    { new Guid("60b127c5-8c00-4cbf-9b9b-0955fd578548"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kyle.king261@example.com", "Kyle", "Male", 175m, true, "King", null, null, "Missile", "", "", "07470100161", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 57.8m },
                    { new Guid("629c0b5f-56f0-45d1-9fa4-009f96d4cc6d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "elijah.reed154@example.com", "Elijah", "Male", 172m, true, "Reed", null, null, "Forge", "", "", "07470100054", "Win = 10, Loss = 5, Draw = 6", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 59.7m },
                    { new Guid("62b5a46d-1d7c-407d-b04d-10c3d1bfa91b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "evan.morris108@example.com", "Evan", "Male", 170m, true, "Morris", null, null, "Ghost", "", "", "07470100008", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 68.8m },
                    { new Guid("638158dc-6762-4c27-8d2f-3368fd94b656"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "harley.james236@example.com", "Harley", "Male", 179m, true, "James", null, null, "Circuit", "", "", "07470100136", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 97.2m },
                    { new Guid("651211b3-24be-4107-870c-6586a97fc0f8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hunter.wilson141@example.com", "Hunter", "Male", 168m, true, "Wilson", null, null, "Jaguar", "", "", "07470100041", "Win = 3, Loss = 5, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 118.4m },
                    { new Guid("69022c57-f630-4f0a-84c6-302d1d0d2ba3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "owen.kelly182@example.com", "Owen", "Male", 183m, true, "Kelly", null, null, "Mantis", "", "", "07470100082", "Win = 5, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 71.1m },
                    { new Guid("6bcd0d8b-191a-47c1-96e6-ba1af248eb95"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "callum.long224@example.com", "Callum", "Male", 193m, true, "Long", null, null, "Crossfire", "", "", "07470100124", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 71.0m },
                    { new Guid("6ceea851-5d49-4e44-9bec-fd785f388b0a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ethan.diaz276@example.com", "Ethan", "Male", 188m, true, "Diaz", null, null, "Bandit", "", "", "07470100176", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 109.4m },
                    { new Guid("6e60ee36-db8e-4037-b0f4-df2a54fe1090"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kyle.robinson163@example.com", "Kyle", "Male", 183m, true, "Robinson", null, null, "Wraith", "", "", "07470100063", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 70.6m },
                    { new Guid("6f46172a-855d-4173-8f78-94409d762501"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "charlie.young205@example.com", "Charlie", "Male", 192m, true, "Young", null, null, "Bulldog", "", "", "07470100105", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 109.3m },
                    { new Guid("720d0dfb-0d38-4ae6-aac9-0253e5074457"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "alex.washington270@example.com", "Alex", "Male", 199m, true, "Washington", null, null, "Berserker", "", "", "07470100170", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 74.4m },
                    { new Guid("743f93f0-6b3b-4a78-9cf4-953c3e5cfb29"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "alex.myers188@example.com", "Alex", "Male", 190m, true, "Myers", null, null, "Cipher", "", "", "07470100088", "Win = 2, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 56.5m },
                    { new Guid("74cb1aaa-36b8-4e8b-b3a8-1084c474a63c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "brody.mitchell148@example.com", "Brody", "Male", 169m, true, "Mitchell", null, null, "Specter", "", "", "07470100048", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 73.3m },
                    { new Guid("74dfbc73-a70b-4273-ab1b-cb6a5458f9d1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ezra.hall158@example.com", "Ezra", "Male", 180m, true, "Hall", null, null, "Hammer", "", "", "07470100058", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 106.7m },
                    { new Guid("75afaf47-f030-4a38-b2a2-27a8ebdd9cce"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kai.bailey153@example.com", "Kai", "Male", 184m, true, "Bailey", null, null, "Boss", "", "", "07470100053", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 87.0m },
                    { new Guid("76e9b097-d56b-4cd2-9b72-5d664e27878a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elijah.wood209@example.com", "Elijah", "Male", 174m, true, "Wood", null, null, "Crusher", "", "", "07470100109", "Win = 3, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 63.5m },
                    { new Guid("776c86c3-af03-4d59-a9bf-9c9ef17325e5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "finn.ford149@example.com", "Finn", "Male", 196m, true, "Ford", null, null, "Spartan", "", "", "07470100049", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 66.4m },
                    { new Guid("778df382-9ce2-413f-81b0-b344b804455c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kai.richardson109@example.com", "Kai", "Male", 187m, true, "Richardson", null, null, "Axe", "", "", "07470100009", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 79.7m },
                    { new Guid("787181c1-f431-4d31-8f61-41bdf6ddacb5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "dominic.baker287@example.com", "Dominic", "Male", 192m, true, "Baker", null, null, "Hatchet", "", "", "07470100187", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 66.6m },
                    { new Guid("788c6efe-7f01-40c3-b369-5a69a6058f07"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "miles.nelson103@example.com", "Miles", "Male", 186m, true, "Nelson", null, null, "Cyclone", "", "", "07470100003", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 62.0m },
                    { new Guid("79cfe0bf-7bde-4d73-8a59-2a308a6ed5cd"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "george.baker248@example.com", "George", "Male", 174m, true, "Baker", null, null, "Sharpshot", "", "", "07470100148", "Win = 4, Loss = 4, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 79.6m },
                    { new Guid("7d291849-b27e-457e-a3aa-b178af776350"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "evan.gonzalez132@example.com", "Evan", "Male", 192m, true, "Gonzalez", null, null, "Beast", "", "", "07470100032", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 115.1m },
                    { new Guid("8011926b-03a0-4287-8ef4-89cc62ae3eed"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "max.coleman223@example.com", "Max", "Male", 178m, true, "Coleman", null, null, "Kingpin", "", "", "07470100123", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 118.8m },
                    { new Guid("801e3f3f-1559-4c86-94d9-10140aaa76d2"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "liam.sanders290@example.com", "Liam", "Male", 200m, true, "Sanders", null, null, "Echo", "", "", "07470100190", "Win = 6, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 58.8m },
                    { new Guid("80b5829e-46cf-453a-a692-914447f27e4a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "mitchell.sanchez195@example.com", "Mitchell", "Male", 189m, true, "Sanchez", null, null, "Rampage", "", "", "07470100095", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 88.9m },
                    { new Guid("812d0d50-8da2-47a0-995a-5eec90ea597e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "freddie.baker152@example.com", "Freddie", "Male", 196m, true, "Baker", null, null, "Thunder", "", "", "07470100052", "Win = 2, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 94.6m },
                    { new Guid("82103260-cfd0-4f2e-b9b1-00c230087350"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jasper.kelly242@example.com", "Jasper", "Male", 198m, true, "Kelly", null, null, "Cobra", "", "", "07470100142", "Win = 6, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 103.9m },
                    { new Guid("84eee0ef-4485-4ea6-a400-23a8e850c603"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "spencer.henderson294@example.com", "Spencer", "Male", 190m, true, "Henderson", null, null, "Chrome", "", "", "07470100194", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 76.2m },
                    { new Guid("85810cda-7473-40a2-abe0-7ebfbe96e168"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jayden.nelson122@example.com", "Jayden", "Male", 182m, true, "Nelson", null, null, "Bruiser", "", "", "07470100022", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 56.5m },
                    { new Guid("8618db07-a15f-4216-b098-4e1fe7197ab4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "adam.bryant133@example.com", "Adam", "Male", 167m, true, "Bryant", null, null, "Claw", "", "", "07470100033", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 81.6m },
                    { new Guid("861b7665-3032-4022-8bf7-38c5eca69473"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kai.coleman245@example.com", "Kai", "Male", 177m, true, "Coleman", null, null, "Riot", "", "", "07470100145", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 61.8m },
                    { new Guid("86a0d8e2-785b-4125-a2f7-c8e7b6a223f7"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "noah.washington268@example.com", "Noah", "Male", 190m, true, "Washington", null, null, "Blackout", "", "", "07470100168", "Win = 3, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 64.8m },
                    { new Guid("86d0306b-9a3a-4197-8075-e3e280b2d6bf"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "leon.bell116@example.com", "Leon", "Male", 167m, true, "Bell", null, null, "Orion", "", "", "07470100016", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 79.4m },
                    { new Guid("876c10cc-5712-402c-8fb2-82b51850b7ba"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "zack.hayes282@example.com", "Zack", "Male", 191m, true, "Hayes", null, null, "Draco", "", "", "07470100182", "Win = 3, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 108.4m },
                    { new Guid("8a8e0097-3356-408f-8cb4-6284690755cf"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jordan.ford155@example.com", "Jordan", "Male", 198m, true, "Ford", null, null, "Saber", "", "", "07470100055", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 62.8m },
                    { new Guid("8a96870e-cdcd-4130-8679-783bae34ec83"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kieran.reed258@example.com", "Kieran", "Male", 182m, true, "Reed", null, null, "Viper", "", "", "07470100158", "Win = 5, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 88.5m },
                    { new Guid("8aaee9e4-54de-4fc9-a5a2-66ba1282c9c6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "austin.russell255@example.com", "Austin", "Male", 177m, true, "Russell", null, null, "Major", "", "", "07470100155", "Win = 1, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 115.0m },
                    { new Guid("8b78843b-f9f1-4e11-a666-ea57965dfd5c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jacob.rivera272@example.com", "Jacob", "Male", 173m, true, "Rivera", null, null, "Rumble", "", "", "07470100172", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 59.1m },
                    { new Guid("8cd38e0f-21d3-4792-bf41-5fde94e2dfec"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dylan.washington178@example.com", "Dylan", "Male", 165m, true, "Washington", null, null, "Viper", "", "", "07470100078", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 62.2m },
                    { new Guid("8deb4c1f-973b-459b-b627-5222af59f011"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "zane.myers289@example.com", "Zane", "Male", 184m, true, "Myers", null, null, "Wolf", "", "", "07470100189", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 75.7m },
                    { new Guid("8e6c2cce-cd8f-42ca-8d5a-0a7fd9c1d480"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bobby.allen211@example.com", "Bobby", "Male", 184m, true, "Allen", null, null, "Orion", "", "", "07470100111", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 90.6m },
                    { new Guid("8f5ad8fc-67ea-4a51-8318-bf88bdc27d70"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "sean.campbell184@example.com", "Sean", "Male", 169m, true, "Campbell", null, null, "Hammer", "", "", "07470100084", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 70.1m },
                    { new Guid("93707255-7526-4043-a2f6-b547db02839e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "logan.bryant167@example.com", "Logan", "Male", 181m, true, "Bryant", null, null, "Pulse", "", "", "07470100067", "Win = 0, Loss = 0, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 100.5m },
                    { new Guid("9404ca1b-05d0-4da9-aa2a-a1da85c926be"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reuben.turner234@example.com", "Reuben", "Male", 177m, true, "Turner", null, null, "Raptor", "", "", "07470100134", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 99.3m },
                    { new Guid("953391e8-9ea0-4800-b52a-2598fa261202"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "mason.green299@example.com", "Mason", "Male", 200m, true, "Green", null, null, "Grizzly", "", "", "07470100199", "Win = 0, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 65.8m },
                    { new Guid("96d5da79-7cfe-4209-b19e-20a9cb825967"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "noah.king264@example.com", "Noah", "Male", 168m, true, "King", null, null, "Talon", "", "", "07470100164", "Win = 3, Loss = 2, Draw = 3", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 118.8m },
                    { new Guid("972427da-4596-43cf-8f23-1fa6fd8574d9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "brody.washington159@example.com", "Brody", "Male", 179m, true, "Washington", null, null, "Jaguar", "", "", "07470100059", "Win = 1, Loss = 1, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 96.7m },
                    { new Guid("98166883-c184-43a1-8610-63fe205fcdec"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zack.hughes292@example.com", "Zack", "Male", 181m, true, "Hughes", null, null, "Major", "", "", "07470100192", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 78.9m },
                    { new Guid("9849df93-9e9f-484e-b0e7-bcc875436bd8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "logan.green252@example.com", "Logan", "Male", 166m, true, "Green", null, null, "Meteor", "", "", "07470100152", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 89.3m },
                    { new Guid("986b610a-2bda-4a96-a1c1-68e74d246fb5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "brody.gray193@example.com", "Brody", "Male", 172m, true, "Gray", null, null, "Ember", "", "", "07470100093", "Win = 4, Loss = 4, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 69.7m },
                    { new Guid("99e33982-6d72-4e16-960c-4efd09a66182"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "corey.brooks210@example.com", "Corey", "Male", 195m, true, "Brooks", null, null, "Boss", "", "", "07470100110", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 106.6m },
                    { new Guid("9c03fb86-334a-4eb5-94b1-0a037b18cce7"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "cameron.robinson203@example.com", "Cameron", "Male", 199m, true, "Robinson", null, null, "Gladiator", "", "", "07470100103", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 108.6m },
                    { new Guid("9c70602e-6faa-4531-b40f-2cd48345c841"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "declan.reed220@example.com", "Declan", "Male", 181m, true, "Reed", null, null, "Crusher", "", "", "07470100120", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 98.2m },
                    { new Guid("9cf8fe01-40af-4521-ba14-b1afd7110060"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "max.stewart140@example.com", "Max", "Male", 169m, true, "Stewart", null, null, "Kraken", "", "", "07470100040", "Win = 2, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 73.9m },
                    { new Guid("9f61b3ea-2447-4e28-90a7-dcfad78a4ec6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jude.russell291@example.com", "Jude", "Male", 166m, true, "Russell", null, null, "Matrix", "", "", "07470100191", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 90.3m },
                    { new Guid("9fb5c5a8-dd2a-4f8f-a2f3-1a2469b7b431"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jayden.perez266@example.com", "Jayden", "Male", 165m, true, "Perez", null, null, "Cipher", "", "", "07470100166", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 83.8m },
                    { new Guid("a1e7bcf7-bc77-4e38-8132-36f88d271d94"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tristan.carter172@example.com", "Tristan", "Male", 176m, true, "Carter", null, null, "Smokes", "", "", "07470100072", "Win = 2, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 75.0m },
                    { new Guid("a2007bb0-389e-458c-9ed5-872c23d7aaa9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "declan.adams251@example.com", "Declan", "Male", 167m, true, "Adams", null, null, "Hammer", "", "", "07470100151", "Win = 2, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 98.5m },
                    { new Guid("a23b03f5-70e8-4f98-8b54-cc550bb3e587"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "sean.nelson267@example.com", "Sean", "Male", 166m, true, "Nelson", null, null, "Hydra", "", "", "07470100167", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 113.3m },
                    { new Guid("a2e61d5c-0aa9-462e-b057-74f5072ad1f6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ivan.howard197@example.com", "Ivan", "Male", 181m, true, "Howard", null, null, "Crusher", "", "", "07470100097", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 73.1m },
                    { new Guid("a340f65b-336a-4c69-a4de-9e652834a746"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "austin.jenkins275@example.com", "Austin", "Male", 186m, true, "Jenkins", null, null, "Overdrive", "", "", "07470100175", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 97.1m },
                    { new Guid("a34f4db8-f88c-43b6-b85d-3b1010be764d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zane.torres226@example.com", "Zane", "Male", 193m, true, "Torres", null, null, "Ash", "", "", "07470100126", "Win = 11, Loss = 17, Draw = 3", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 62.2m },
                    { new Guid("a42594a7-88bf-4e12-9b73-6e436c499fa6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "lewis.diaz229@example.com", "Lewis", "Male", 173m, true, "Diaz", null, null, "Mantis", "", "", "07470100129", "Win = 3, Loss = 2, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 62.0m },
                    { new Guid("a567fc42-2e71-4641-9920-a0805978b544"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "cameron.hamilton215@example.com", "Cameron", "Male", 171m, true, "Hamilton", null, null, "Smokes", "", "", "07470100115", "Win = 5, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 96.8m },
                    { new Guid("a697b832-f34d-4909-96e3-80925950d1ef"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "declan.powell135@example.com", "Declan", "Male", 199m, true, "Powell", null, null, "Vortex", "", "", "07470100035", "Win = 2, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 62.3m },
                    { new Guid("a6a55b37-29e7-4895-9ba5-2fba98dfa992"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reece.barnes138@example.com", "Reece", "Male", 197m, true, "Barnes", null, null, "Striker", "", "", "07470100038", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 56.0m },
                    { new Guid("a6b77ff1-5bf8-4fd9-b97a-b849347944dc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "corey.butler113@example.com", "Corey", "Male", 190m, true, "Butler", null, null, "Voltage", "", "", "07470100013", "Win = 14, Loss = 17, Draw = 4", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 64.7m },
                    { new Guid("a6fee421-0798-4d62-b3b2-bba89f701307"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "callum.price192@example.com", "Callum", "Male", 171m, true, "Price", null, null, "Outlaw", "", "", "07470100092", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 96.9m },
                    { new Guid("a701bab4-1508-4b92-8db1-4c2d1f99821f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "leon.jenkins249@example.com", "Leon", "Male", 183m, true, "Jenkins", null, null, "Pulse", "", "", "07470100149", "Win = 1, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 82.6m },
                    { new Guid("a99a8a26-7ed8-492b-8579-55fb028bb979"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "grayson.stewart181@example.com", "Grayson", "Male", 168m, true, "Stewart", null, null, "Rhino", "", "", "07470100081", "Win = 0, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 80.1m },
                    { new Guid("afabc43d-dada-467d-87cd-3a03432373d7"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "lucas.hall260@example.com", "Lucas", "Male", 172m, true, "Hall", null, null, "Nova", "", "", "07470100160", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 60.3m },
                    { new Guid("afae732c-06a7-4548-ac1b-b9d776258c1e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hunter.robinson170@example.com", "Hunter", "Male", 194m, true, "Robinson", null, null, "Bruiser", "", "", "07470100070", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 117.7m },
                    { new Guid("b201416b-d9e3-48d3-a25e-4c02f54f6a20"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ethan.henderson183@example.com", "Ethan", "Male", 197m, true, "Henderson", null, null, "Phantom", "", "", "07470100083", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 58.0m },
                    { new Guid("b2994cab-e1be-4a44-81c6-49ece3cb4d69"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kyle.butler123@example.com", "Kyle", "Male", 169m, true, "Butler", null, null, "Gladiator", "", "", "07470100023", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 94.6m },
                    { new Guid("b4a274d1-2d7b-454f-984b-a88c4466aa64"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jasper.morris157@example.com", "Jasper", "Male", 170m, true, "Morris", null, null, "Riot", "", "", "07470100057", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 68.0m },
                    { new Guid("b7b2a5dc-9ea9-4394-8595-5438f6e44e78"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reuben.cox269@example.com", "Reuben", "Male", 165m, true, "Cox", null, null, "Glitch", "", "", "07470100169", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 100.2m },
                    { new Guid("b86ea6e1-c724-4247-8ba6-727c47b083d1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "keaton.reed250@example.com", "Keaton", "Male", 181m, true, "Reed", null, null, "Inferno", "", "", "07470100150", "Win = 0, Loss = 0, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 86.7m },
                    { new Guid("ba5a4252-0c9f-4494-878c-1b641a9571b0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jayden.taylor232@example.com", "Jayden", "Male", 173m, true, "Taylor", null, null, "Atlas", "", "", "07470100132", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 64.0m },
                    { new Guid("bbc8ca68-49f1-4ea3-8c3d-88de4bd4cd24"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "caleb.hall239@example.com", "Caleb", "Male", 184m, true, "Hall", null, null, "Byte", "", "", "07470100139", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 82.0m },
                    { new Guid("bd78bc80-2a50-4f83-9b50-3e75ec3180e4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "archie.kelly147@example.com", "Archie", "Male", 180m, true, "Kelly", null, null, "Ghost", "", "", "07470100047", "Win = 3, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 68.1m },
                    { new Guid("c037c422-0887-42f8-9096-d9f66d15f943"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "callum.brooks279@example.com", "Callum", "Male", 196m, true, "Brooks", null, null, "Titan", "", "", "07470100179", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 93.9m },
                    { new Guid("c052c4cf-1226-49af-be6b-4b2b710ab93c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reuben.hayes160@example.com", "Reuben", "Male", 171m, true, "Hayes", null, null, "Havoc", "", "", "07470100060", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 110.5m },
                    { new Guid("c127d076-876b-4afc-ab19-f2e3500fec10"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "bradley.coleman280@example.com", "Bradley", "Male", 175m, true, "Coleman", null, null, "Draco", "", "", "07470100180", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 94.7m },
                    { new Guid("c36d3f86-a9ca-44b5-8171-1ccd77739c9f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "harrison.foster256@example.com", "Harrison", "Male", 186m, true, "Foster", null, null, "Hawk", "", "", "07470100156", "Win = 1, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 78.0m },
                    { new Guid("c555e659-6ca5-4e57-9d8f-48ec67184923"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dominic.james171@example.com", "Dominic", "Male", 169m, true, "James", null, null, "Riot", "", "", "07470100071", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 95.1m },
                    { new Guid("c88ad0f7-a79a-43ce-9bd6-feedc6ebc032"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "isaac.sanchez235@example.com", "Isaac", "Male", 174m, true, "Sanchez", null, null, "Byte", "", "", "07470100135", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 82.4m },
                    { new Guid("c9d16459-dbf6-4c1b-8874-09021ab5993f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alex.simmons262@example.com", "Alex", "Male", 172m, true, "Simmons", null, null, "Ricochet", "", "", "07470100162", "Win = 2, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 77.8m },
                    { new Guid("cc08057a-ef09-43df-aa30-2b2c68b02c4d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reece.ross146@example.com", "Reece", "Male", 176m, true, "Ross", null, null, "Savage", "", "", "07470100046", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 68.7m },
                    { new Guid("cc32fbdf-5f29-496b-8b59-ab4135e3cec5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "miles.coleman298@example.com", "Miles", "Male", 178m, true, "Coleman", null, null, "Bullseye", "", "", "07470100198", "Win = 5, Loss = 3, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 61.8m },
                    { new Guid("ccfe2816-134f-492e-a9a4-127eaf37c623"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "felix.rogers127@example.com", "Felix", "Male", 178m, true, "Rogers", null, null, "Rampage", "", "", "07470100027", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 118.7m },
                    { new Guid("cd397557-3fbe-4829-843c-77bc73703428"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jaxon.barnes150@example.com", "Jaxon", "Male", 181m, true, "Barnes", null, null, "Colossus", "", "", "07470100050", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 70.2m },
                    { new Guid("cf2f365e-885d-4d10-ba6e-a0653239ef8d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "archie.morgan111@example.com", "Archie", "Male", 180m, true, "Morgan", null, null, "General", "", "", "07470100011", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 92.1m },
                    { new Guid("d392c08f-5e2f-4d73-874d-124a60efae08"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ryan.myers281@example.com", "Ryan", "Male", 199m, true, "Myers", null, null, "Storm", "", "", "07470100181", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 118.8m },
                    { new Guid("d4ba7e37-b6b8-4027-a36a-3b049265e41e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jaxon.kelly274@example.com", "Jaxon", "Male", 177m, true, "Kelly", null, null, "Missile", "", "", "07470100174", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 84.7m },
                    { new Guid("d6c3fd1b-dd28-4c0f-8dfb-6e37a992a068"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "marcus.baker283@example.com", "Marcus", "Male", 175m, true, "Baker", null, null, "Saber", "", "", "07470100183", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 96.9m },
                    { new Guid("d80c4399-2a4a-46cb-91a6-2eefc8c05dd2"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "harrison.green185@example.com", "Harrison", "Male", 166m, true, "Green", null, null, "Hunter", "", "", "07470100085", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 55.8m },
                    { new Guid("d933e805-d002-4e8f-b215-26f14b8d807f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "cody.robinson139@example.com", "Cody", "Male", 180m, true, "Robinson", null, null, "Inferno", "", "", "07470100039", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 95.2m },
                    { new Guid("dfa8fda2-dc63-44d2-9fae-afb9b1a36f42"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hunter.allen156@example.com", "Hunter", "Male", 185m, true, "Allen", null, null, "Mayhem", "", "", "07470100056", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 119.9m },
                    { new Guid("dfdae262-bbd1-4aa7-82a6-9ab4d2c8904d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "elliot.hall115@example.com", "Elliot", "Male", 189m, true, "Hall", null, null, "Smokes", "", "", "07470100015", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 104.8m },
                    { new Guid("e03b4fa1-22fe-4c62-a286-f12d4d552cde"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ivan.carter265@example.com", "Ivan", "Male", 167m, true, "Carter", null, null, "Outlaw", "", "", "07470100165", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 102.6m },
                    { new Guid("e0ed91ca-e264-4d59-8f92-920067d2cc1f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "declan.richardson110@example.com", "Declan", "Male", 173m, true, "Richardson", null, null, "Circuit", "", "", "07470100010", "Win = 1, Loss = 0, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 119.8m },
                    { new Guid("e216be64-9235-49be-908b-d4ebb8dd3b14"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "leon.price231@example.com", "Leon", "Male", 198m, true, "Price", null, null, "Goliath", "", "", "07470100131", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 82.9m },
                    { new Guid("e374951a-d369-473f-8e34-4bd205815b90"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "mason.baker199@example.com", "Mason", "Male", 197m, true, "Baker", null, null, "Hatchet", "", "", "07470100099", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 90.0m },
                    { new Guid("e67fcd9f-cf2e-4062-9d19-b17048ead253"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "harley.simmons106@example.com", "Harley", "Male", 196m, true, "Simmons", null, null, "Wraith", "", "", "07470100006", "Win = 3, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 86.7m },
                    { new Guid("eaf3046f-3184-42d6-812c-f807a6d5feeb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hunter.morgan137@example.com", "Hunter", "Male", 184m, true, "Morgan", null, null, "Sentinel", "", "", "07470100037", "Win = 14, Loss = 15, Draw = 4", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 65.6m },
                    { new Guid("ec3feb6f-e1e7-4125-b8cc-ade91f16ba1d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "liam.washington227@example.com", "Liam", "Male", 196m, true, "Washington", null, null, "Dagger", "", "", "07470100127", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 79.0m },
                    { new Guid("eefd2cab-7a0d-4ce3-8289-b8482e92b9fa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elliot.nelson173@example.com", "Elliot", "Male", 171m, true, "Nelson", null, null, "Mayhem", "", "", "07470100073", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 110.8m },
                    { new Guid("f164ea96-f7d2-4d17-9898-f23a76ee8c70"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kyle.torres217@example.com", "Kyle", "Male", 171m, true, "Torres", null, null, "Ghost", "", "", "07470100117", "Win = 2, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 74.3m },
                    { new Guid("f1c4eaa4-cefe-4047-8840-f6e9fc4e4a59"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "oscar.coleman288@example.com", "Oscar", "Male", 191m, true, "Coleman", null, null, "Talon", "", "", "07470100188", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 90.0m },
                    { new Guid("f3047183-24ec-4349-aacd-18fa8f00454e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "austin.brooks208@example.com", "Austin", "Male", 193m, true, "Brooks", null, null, "Tornado", "", "", "07470100108", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 113.4m },
                    { new Guid("f315604e-9f1b-47fe-a117-d52f7c43b4bd"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "tristan.ward238@example.com", "Tristan", "Male", 166m, true, "Ward", null, null, "Cyclone", "", "", "07470100138", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 93.9m },
                    { new Guid("f3d484b5-a40a-4e35-ad4e-8f1dd40b105b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hunter.king285@example.com", "Hunter", "Male", 193m, true, "King", null, null, "Jinx", "", "", "07470100185", "Win = 2, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 103.9m },
                    { new Guid("f3f61abf-b49d-4390-9533-ac4327dcc7f5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ashton.bell130@example.com", "Ashton", "Male", 179m, true, "Bell", null, null, "Zephyr", "", "", "07470100030", "Win = 2, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 111.6m },
                    { new Guid("f4010cfc-cf36-4f56-8e10-49fab7233913"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ethan.myers212@example.com", "Ethan", "Male", 189m, true, "Myers", null, null, "Nova", "", "", "07470100112", "Win = 4, Loss = 6, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 118.8m },
                    { new Guid("f4a17d51-8a2e-4b39-897f-c97f71c0a991"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jasper.hayes198@example.com", "Jasper", "Male", 182m, true, "Hayes", null, null, "Crusher", "", "", "07470100098", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 89.6m },
                    { new Guid("f54ac912-a16c-46ae-bfe6-d803a4b0c76f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "noah.reed119@example.com", "Noah", "Male", 175m, true, "Reed", null, null, "Orion", "", "", "07470100019", "Win = 13, Loss = 10, Draw = 3", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 77.2m },
                    { new Guid("f5f931ac-13d4-47bc-aeb0-53da850b10d6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ashton.green257@example.com", "Ashton", "Male", 171m, true, "Green", null, null, "Nitro", "", "", "07470100157", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 107.3m },
                    { new Guid("f6dbe53a-2925-4dd3-8520-dc2ad09d856b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "sean.sanders237@example.com", "Sean", "Male", 198m, true, "Sanders", null, null, "Nova", "", "", "07470100137", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 99.4m },
                    { new Guid("fae980ce-c530-4833-be32-b65fa8e05fc1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dominic.long124@example.com", "Dominic", "Male", 195m, true, "Long", null, null, "Predator", "", "", "07470100024", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 84.0m },
                    { new Guid("fce6eaf0-8c51-4350-ace5-9f850d9cda2a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "charlie.bailey128@example.com", "Charlie", "Male", 186m, true, "Bailey", null, null, "Deadshot", "", "", "07470100028", "Win = 5, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 97.0m },
                    { new Guid("fd7b4a47-cd7b-43f7-b010-232724b7d946"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reece.allen286@example.com", "Reece", "Male", 171m, true, "Allen", null, null, "Drift", "", "", "07470100186", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 87.2m },
                    { new Guid("fd97a7e3-af41-4225-a0cc-3e7cf39bc91e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "elliot.simmons214@example.com", "Elliot", "Male", 197m, true, "Simmons", null, null, "Diesel", "", "", "07470100114", "Win = 3, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 119.4m },
                    { new Guid("fe2e3be0-719f-40c5-8315-ad99938b4c07"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zane.jenkins233@example.com", "Zane", "Male", 197m, true, "Jenkins", null, null, "Maverick", "", "", "07470100133", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 63.8m },
                    { new Guid("feef525a-4f42-42f5-9c78-043a7ddf1a3f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "freddie.butler179@example.com", "Freddie", "Male", 191m, true, "Butler", null, null, "Omega", "", "", "07470100079", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 83.0m },
                    { new Guid("ff540ecd-0725-4837-8e15-db708df01521"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "aaron.murphy162@example.com", "Aaron", "Male", 197m, true, "Murphy", null, null, "Nightfall", "", "", "07470100062", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 65.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("01233513-ab20-4128-93ac-6bc1d9b77e06"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("05387d97-2073-46e1-89f8-87bbd9aa1a96"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0631bb27-7ad2-47ae-a588-2b2807f0b9dc"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0b24e281-f632-4b93-b85e-1ccc4c8ec971"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0b6cd75d-cede-4d4b-8dec-af8d91d1d938"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0deb802a-501f-49fc-b496-add31b144f28"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0eebd475-cbe9-4c9e-b23d-b13e78402955"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0fab3aa2-aa5c-4847-9a2a-dbf4e775f83e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("0fcfc664-7787-48ed-9295-a7cacd34b432"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("10f7d2d8-4307-4a33-a380-136aeafa37c7"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("12fd9fba-e5c6-4144-ae37-3ec9b5119c2c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1451a541-74e8-4d82-88d0-5aa7d5cae749"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("182add32-9d12-4d49-acb8-efb4eae6d4fb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("182d830c-7dc7-4cc5-bffa-d896fb4a6b78"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("18537d74-1c1d-4ab4-9d2f-c168faebad6b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("18fb42ed-48b6-4084-a7ad-761e941515e3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("19c8aa86-57de-421a-8412-9d4383b19e67"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1ad94d18-1fcd-482e-8038-8edca1e7a4cb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1ae3787c-0880-4668-b350-a9e23b001491"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1ae6325b-5dba-4870-9ef0-2fcaff3a1194"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1b0bd879-3860-4eba-b1a5-9804208123b5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1d494f2d-bcbc-47d1-85f2-afc8d44bcb5a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("1f141adb-dc32-4676-a3b6-a72e628bbb0a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2276ae19-09ba-4740-b226-96f7e0e95cba"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("22c60df3-2be2-4365-8f33-c2bb1e2342a1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("24512110-5cc5-45b0-9fb9-2934e4adf3c9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("25ab70f9-132a-4c90-b196-cb4cc9d70ea3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("271f7a43-0c56-4f8e-ba9a-fe356f45e70f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("276f8f0b-9733-4acc-afbb-6de1e73ddab8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2a3826b6-ec99-4596-8c10-bafd9de643ef"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2bd1b90c-6955-4f8a-9873-3f3ed4b01a1c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("2f713b04-c419-47b8-8cf9-bf0f1c81aa39"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("32983fd4-dc78-4ada-834d-7586c83c1f84"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3354a507-eb36-4c57-bad9-42975d4c588d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("33a1e49c-fe55-45ec-82db-e39f2f1a1fa6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3511541a-438a-4a32-b88d-5857d44a0c82"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("351ac9d7-ad96-43f5-92d2-a2a053cdf54c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("35d56b70-2cea-4a98-8d89-2b197ff5e437"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("36586b5d-2d10-46b3-8f7f-4dc7befc5de3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("39de48c6-27d6-4db5-ab13-4c7264b23adb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3d6de972-8652-40f4-becf-332984800550"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("3f340a66-ebda-4003-bd43-ce03140202db"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("40ace9c9-f60c-41ec-a084-6029f3eb240c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("40f83788-6ce1-4ef1-aec7-eec25b5280d9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("434f19e5-0494-431b-9c4d-59ddc3080fd9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("438bf331-1aef-4d12-84de-e8211eb5b72c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("44e572a9-c84b-4710-9ae8-53256585e29d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("462d07a8-b9df-49ab-9f03-057bbe15e70d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4726340f-3e0c-4fb0-8c06-f88ec917b9a7"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4959642a-6f6a-4600-a89f-9a2bd167293c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4a41127f-8d92-4c3f-b9a6-7c18ef19633f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4b1b628a-c298-4f80-9e1b-a9585b5035d1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4b8a8213-2b1a-42e7-a592-5500db1c8680"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4dcc752e-26f1-42ba-9584-bce40d7c9162"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4f0b405c-029b-4380-818c-d7330a8a2ebb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("4f48d61d-f30c-4657-a75d-1b91ccb634ba"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5038aac8-f286-491f-bee4-13e0371c154f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("50e14681-cb8c-47ef-96e2-65d52dc8fcbf"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("510ccd40-7a4c-478f-9d89-dcec2a2a2c77"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("534cec36-aa53-480a-a824-1c4568c50480"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5446f6f1-bb49-4322-8d76-65532c43e841"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("57286e31-917d-49c3-ad15-7efd09746dd2"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("57bf4812-8e89-4b09-a2e8-a3a0284e5801"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5823db2c-ae34-4285-9d8b-5d90c64b91aa"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("583536bb-3a8d-4a66-ae94-82b1382465cb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("584e4284-760f-4614-817c-2e8f174e4029"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5919ef3b-fad5-4f6d-a319-6f022ef9ad4c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5951f876-e04b-4310-9546-0deb58f4165c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5b8c24a2-d6bb-4938-add0-2e2e1a06f25b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5c1e2d04-cfea-43db-972f-dae2cc7b977a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5c5ec9f6-7a70-4e0b-aeb7-e07da8f3df4f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5d1acd76-97de-4b46-a665-482bce9aaba4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5e2e185e-1f09-4169-80f3-5c7ea9c4a344"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5ea4026d-be62-4d87-9f82-78a99afe5868"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("5f67be8f-8b67-4c10-b16b-d9e36f858a55"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("60b127c5-8c00-4cbf-9b9b-0955fd578548"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("629c0b5f-56f0-45d1-9fa4-009f96d4cc6d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("62b5a46d-1d7c-407d-b04d-10c3d1bfa91b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("638158dc-6762-4c27-8d2f-3368fd94b656"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("651211b3-24be-4107-870c-6586a97fc0f8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("69022c57-f630-4f0a-84c6-302d1d0d2ba3"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6bcd0d8b-191a-47c1-96e6-ba1af248eb95"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6ceea851-5d49-4e44-9bec-fd785f388b0a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6e60ee36-db8e-4037-b0f4-df2a54fe1090"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("6f46172a-855d-4173-8f78-94409d762501"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("720d0dfb-0d38-4ae6-aac9-0253e5074457"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("743f93f0-6b3b-4a78-9cf4-953c3e5cfb29"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("74cb1aaa-36b8-4e8b-b3a8-1084c474a63c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("74dfbc73-a70b-4273-ab1b-cb6a5458f9d1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("75afaf47-f030-4a38-b2a2-27a8ebdd9cce"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("76e9b097-d56b-4cd2-9b72-5d664e27878a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("776c86c3-af03-4d59-a9bf-9c9ef17325e5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("778df382-9ce2-413f-81b0-b344b804455c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("787181c1-f431-4d31-8f61-41bdf6ddacb5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("788c6efe-7f01-40c3-b369-5a69a6058f07"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("79cfe0bf-7bde-4d73-8a59-2a308a6ed5cd"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("7d291849-b27e-457e-a3aa-b178af776350"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8011926b-03a0-4287-8ef4-89cc62ae3eed"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("801e3f3f-1559-4c86-94d9-10140aaa76d2"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("80b5829e-46cf-453a-a692-914447f27e4a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("812d0d50-8da2-47a0-995a-5eec90ea597e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("82103260-cfd0-4f2e-b9b1-00c230087350"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("84eee0ef-4485-4ea6-a400-23a8e850c603"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("85810cda-7473-40a2-abe0-7ebfbe96e168"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8618db07-a15f-4216-b098-4e1fe7197ab4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("861b7665-3032-4022-8bf7-38c5eca69473"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("86a0d8e2-785b-4125-a2f7-c8e7b6a223f7"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("86d0306b-9a3a-4197-8075-e3e280b2d6bf"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("876c10cc-5712-402c-8fb2-82b51850b7ba"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8a8e0097-3356-408f-8cb4-6284690755cf"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8a96870e-cdcd-4130-8679-783bae34ec83"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8aaee9e4-54de-4fc9-a5a2-66ba1282c9c6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8b78843b-f9f1-4e11-a666-ea57965dfd5c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8cd38e0f-21d3-4792-bf41-5fde94e2dfec"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8deb4c1f-973b-459b-b627-5222af59f011"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8e6c2cce-cd8f-42ca-8d5a-0a7fd9c1d480"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("8f5ad8fc-67ea-4a51-8318-bf88bdc27d70"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("93707255-7526-4043-a2f6-b547db02839e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9404ca1b-05d0-4da9-aa2a-a1da85c926be"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("953391e8-9ea0-4800-b52a-2598fa261202"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("96d5da79-7cfe-4209-b19e-20a9cb825967"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("972427da-4596-43cf-8f23-1fa6fd8574d9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("98166883-c184-43a1-8610-63fe205fcdec"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9849df93-9e9f-484e-b0e7-bcc875436bd8"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("986b610a-2bda-4a96-a1c1-68e74d246fb5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("99e33982-6d72-4e16-960c-4efd09a66182"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9c03fb86-334a-4eb5-94b1-0a037b18cce7"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9c70602e-6faa-4531-b40f-2cd48345c841"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9cf8fe01-40af-4521-ba14-b1afd7110060"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9f61b3ea-2447-4e28-90a7-dcfad78a4ec6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("9fb5c5a8-dd2a-4f8f-a2f3-1a2469b7b431"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a1e7bcf7-bc77-4e38-8132-36f88d271d94"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a2007bb0-389e-458c-9ed5-872c23d7aaa9"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a23b03f5-70e8-4f98-8b54-cc550bb3e587"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a2e61d5c-0aa9-462e-b057-74f5072ad1f6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a340f65b-336a-4c69-a4de-9e652834a746"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a34f4db8-f88c-43b6-b85d-3b1010be764d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a42594a7-88bf-4e12-9b73-6e436c499fa6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a567fc42-2e71-4641-9920-a0805978b544"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a697b832-f34d-4909-96e3-80925950d1ef"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a6a55b37-29e7-4895-9ba5-2fba98dfa992"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a6b77ff1-5bf8-4fd9-b97a-b849347944dc"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a6fee421-0798-4d62-b3b2-bba89f701307"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a701bab4-1508-4b92-8db1-4c2d1f99821f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("a99a8a26-7ed8-492b-8579-55fb028bb979"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("afabc43d-dada-467d-87cd-3a03432373d7"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("afae732c-06a7-4548-ac1b-b9d776258c1e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b201416b-d9e3-48d3-a25e-4c02f54f6a20"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b2994cab-e1be-4a44-81c6-49ece3cb4d69"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b4a274d1-2d7b-454f-984b-a88c4466aa64"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b7b2a5dc-9ea9-4394-8595-5438f6e44e78"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("b86ea6e1-c724-4247-8ba6-727c47b083d1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ba5a4252-0c9f-4494-878c-1b641a9571b0"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("bbc8ca68-49f1-4ea3-8c3d-88de4bd4cd24"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("bd78bc80-2a50-4f83-9b50-3e75ec3180e4"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c037c422-0887-42f8-9096-d9f66d15f943"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c052c4cf-1226-49af-be6b-4b2b710ab93c"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c127d076-876b-4afc-ab19-f2e3500fec10"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c36d3f86-a9ca-44b5-8171-1ccd77739c9f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c555e659-6ca5-4e57-9d8f-48ec67184923"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c88ad0f7-a79a-43ce-9bd6-feedc6ebc032"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("c9d16459-dbf6-4c1b-8874-09021ab5993f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cc08057a-ef09-43df-aa30-2b2c68b02c4d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cc32fbdf-5f29-496b-8b59-ab4135e3cec5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ccfe2816-134f-492e-a9a4-127eaf37c623"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cd397557-3fbe-4829-843c-77bc73703428"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("cf2f365e-885d-4d10-ba6e-a0653239ef8d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d392c08f-5e2f-4d73-874d-124a60efae08"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d4ba7e37-b6b8-4027-a36a-3b049265e41e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d6c3fd1b-dd28-4c0f-8dfb-6e37a992a068"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d80c4399-2a4a-46cb-91a6-2eefc8c05dd2"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("d933e805-d002-4e8f-b215-26f14b8d807f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("dfa8fda2-dc63-44d2-9fae-afb9b1a36f42"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("dfdae262-bbd1-4aa7-82a6-9ab4d2c8904d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e03b4fa1-22fe-4c62-a286-f12d4d552cde"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e0ed91ca-e264-4d59-8f92-920067d2cc1f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e216be64-9235-49be-908b-d4ebb8dd3b14"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e374951a-d369-473f-8e34-4bd205815b90"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("e67fcd9f-cf2e-4062-9d19-b17048ead253"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("eaf3046f-3184-42d6-812c-f807a6d5feeb"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ec3feb6f-e1e7-4125-b8cc-ade91f16ba1d"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("eefd2cab-7a0d-4ce3-8289-b8482e92b9fa"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f164ea96-f7d2-4d17-9898-f23a76ee8c70"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f1c4eaa4-cefe-4047-8840-f6e9fc4e4a59"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f3047183-24ec-4349-aacd-18fa8f00454e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f315604e-9f1b-47fe-a117-d52f7c43b4bd"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f3d484b5-a40a-4e35-ad4e-8f1dd40b105b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f3f61abf-b49d-4390-9533-ac4327dcc7f5"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f4010cfc-cf36-4f56-8e10-49fab7233913"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f4a17d51-8a2e-4b39-897f-c97f71c0a991"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f54ac912-a16c-46ae-bfe6-d803a4b0c76f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f5f931ac-13d4-47bc-aeb0-53da850b10d6"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("f6dbe53a-2925-4dd3-8520-dc2ad09d856b"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fae980ce-c530-4833-be32-b65fa8e05fc1"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fce6eaf0-8c51-4350-ace5-9f850d9cda2a"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fd7b4a47-cd7b-43f7-b010-232724b7d946"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fd97a7e3-af41-4225-a0cc-3e7cf39bc91e"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("fe2e3be0-719f-40c5-8315-ad99938b4c07"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("feef525a-4f42-42f5-9c78-043a7ddf1a3f"));

            migrationBuilder.DeleteData(
                table: "Participant",
                keyColumn: "Id",
                keyValue: new Guid("ff540ecd-0725-4837-8e15-db708df01521"));

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Participant");

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FirstName", "HeightCm", "IsActive", "LastName", "ModifiedAt", "ModifiedBy", "NickName", "Notes", "PasswordHash", "PhoneNumber", "Record", "TeamId", "WeightKg" },
                values: new object[,]
                {
                    { new Guid("01a783a4-fff0-4225-813f-f85a2d2786c0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jude.hayes106@example.com", "Jude", 199m, true, "Hayes", null, null, "Fury", "", "", "07470100006", "Win = 1, Loss = 2, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 103.1m },
                    { new Guid("01a826ec-2729-4443-a04d-ed8b0ad7b0cb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "finn.evans117@example.com", "Finn", 194m, true, "Evans", null, null, "Steel", "", "", "07470100017", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 76.8m },
                    { new Guid("02ba356f-8525-4080-86f6-c86184320afc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "keaton.washington299@example.com", "Keaton", 180m, true, "Washington", null, null, "Vandal", "", "", "07470100199", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 105.6m },
                    { new Guid("053e6a61-c2ce-4676-8dc4-88ce1a357029"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jordan.price266@example.com", "Jordan", 190m, true, "Price", null, null, "Saber", "", "", "07470100166", "Win = 8, Loss = 10, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 66.3m },
                    { new Guid("0543df3f-9e51-4ed4-8681-07ec240065af"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jordan.price141@example.com", "Jordan", 195m, true, "Price", null, null, "Deadshot", "", "", "07470100041", "Win = 1, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 94.7m },
                    { new Guid("068a6a93-d1bd-47a2-b563-462f7f689be6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tyler.russell182@example.com", "Tyler", 185m, true, "Russell", null, null, "Bruiser", "", "", "07470100082", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 70.4m },
                    { new Guid("06e6322e-bdc2-4d09-bbaa-18110bdd3ea4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "marcus.gray296@example.com", "Marcus", 169m, true, "Gray", null, null, "Cutlass", "", "", "07470100196", "Win = 2, Loss = 4, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 105.6m },
                    { new Guid("0748251d-adea-4e79-849a-29067fd7f97a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reece.taylor105@example.com", "Reece", 190m, true, "Taylor", null, null, "Frost", "", "", "07470100005", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 59.9m },
                    { new Guid("0759510d-028c-455a-9993-4ae792877c58"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "tyler.flores205@example.com", "Tyler", 198m, true, "Flores", null, null, "Circuit", "", "", "07470100105", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 117.3m },
                    { new Guid("09154876-044b-480d-9cc7-b6880b30a1e0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "evan.sanders153@example.com", "Evan", 192m, true, "Sanders", null, null, "Spartan", "", "", "07470100053", "Win = 2, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 109.0m },
                    { new Guid("09c843ea-0395-4092-b887-34b978e62191"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rhys.morris172@example.com", "Rhys", 192m, true, "Morris", null, null, "Boss", "", "", "07470100072", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 98.0m },
                    { new Guid("0c8fd745-02cc-4c6c-843f-a388e85fd81e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "blake.robinson223@example.com", "Blake", 180m, true, "Robinson", null, null, "Steel", "", "", "07470100123", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 82.4m },
                    { new Guid("0eb86f1f-0eb5-4a5e-9519-1c44cbc78476"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "liam.green128@example.com", "Liam", 180m, true, "Green", null, null, "Omega", "", "", "07470100028", "Win = 4, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 66.0m },
                    { new Guid("0fadd6b1-4973-4444-9540-201136297997"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jesse.green239@example.com", "Jesse", 180m, true, "Green", null, null, "Quake", "", "", "07470100139", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 88.4m },
                    { new Guid("1093d639-b36a-44ca-a43f-b847f980d1c9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "riley.richardson180@example.com", "Riley", 187m, true, "Richardson", null, null, "Cinder", "", "", "07470100080", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 70.0m },
                    { new Guid("11b61bcf-5338-44bc-90e4-a1ba2448bc0f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "brody.washington150@example.com", "Brody", 167m, true, "Washington", null, null, "Kingpin", "", "", "07470100050", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 83.5m },
                    { new Guid("11c4a574-13f5-47cb-a713-f645bdb6f3b1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "keaton.gray132@example.com", "Keaton", 183m, true, "Gray", null, null, "Specter", "", "", "07470100032", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 65.2m },
                    { new Guid("12a66c0f-51f2-4310-a327-1fc46943ae51"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jesse.stewart248@example.com", "Jesse", 195m, true, "Stewart", null, null, "Mace", "", "", "07470100148", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 99.2m },
                    { new Guid("13d433fa-4a2b-41a8-a697-f1835a6165ec"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "nathan.parker195@example.com", "Nathan", 179m, true, "Parker", null, null, "Riptide", "", "", "07470100095", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 112.5m },
                    { new Guid("1957b481-157d-49a6-b603-2b025df42bb8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "liam.young272@example.com", "Liam", 171m, true, "Young", null, null, "Cutlass", "", "", "07470100172", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 96.5m },
                    { new Guid("19c7f2ce-8576-4cfb-ac44-9cc2128d7047"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "isaac.butler287@example.com", "Isaac", 193m, true, "Butler", null, null, "Cobra", "", "", "07470100187", "Win = 4, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 119.4m },
                    { new Guid("1a8e37fe-de29-4e3a-9d9c-e76068a86d8d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "theo.wright144@example.com", "Theo", 169m, true, "Wright", null, null, "Orion", "", "", "07470100044", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 89.8m },
                    { new Guid("1ad3c1df-19f5-4173-8d47-30a4cd62c36f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "evan.baker116@example.com", "Evan", 185m, true, "Baker", null, null, "Anvil", "", "", "07470100016", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 112.4m },
                    { new Guid("1b740e3c-b687-4d03-946d-f1d305c94056"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "keaton.hall269@example.com", "Keaton", 170m, true, "Hall", null, null, "Talon", "", "", "07470100169", "Win = 6, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 90.3m },
                    { new Guid("1bb29835-1671-4f03-88e7-47638d46472b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "caleb.cox103@example.com", "Caleb", 196m, true, "Cox", null, null, "Goliath", "", "", "07470100003", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 103.7m },
                    { new Guid("1c7f6b2d-7f1c-4c46-aa00-cc9c8c5d223b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "nathan.cooper156@example.com", "Nathan", 195m, true, "Cooper", null, null, "Omega", "", "", "07470100056", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 71.9m },
                    { new Guid("20314264-ee00-4720-b623-6af45a27a5e0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "henry.henderson197@example.com", "Henry", 193m, true, "Henderson", null, null, "Draco", "", "", "07470100097", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 74.9m },
                    { new Guid("20876f80-6da0-47e5-b262-abd173e71d26"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "bradley.green229@example.com", "Bradley", 193m, true, "Green", null, null, "Cobra", "", "", "07470100129", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 89.5m },
                    { new Guid("21154c89-3099-4b86-a9ea-597e607b425a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rhys.watson167@example.com", "Rhys", 171m, true, "Watson", null, null, "Frost", "", "", "07470100067", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 81.9m },
                    { new Guid("2162549d-99bd-4121-a6d2-469e53fd4b04"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reuben.collins207@example.com", "Reuben", 194m, true, "Collins", null, null, "Cannon", "", "", "07470100107", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 57.1m },
                    { new Guid("23165a69-4307-4261-a1da-afe7764e751d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "cody.price213@example.com", "Cody", 176m, true, "Price", null, null, "Kraken", "", "", "07470100113", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 118.8m },
                    { new Guid("24d10aeb-3742-45d7-a2f0-c0dd4f70034e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tristan.evans278@example.com", "Tristan", 182m, true, "Evans", null, null, "Glitch", "", "", "07470100178", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 87.6m },
                    { new Guid("24d42484-ecca-4645-880d-8d2a85c97b2a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "luca.robinson273@example.com", "Luca", 172m, true, "Robinson", null, null, "Jinx", "", "", "07470100173", "Win = 2, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 99.0m },
                    { new Guid("254c2dbf-d073-42fe-ae44-28b790dffbe4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "miles.cook162@example.com", "Miles", 191m, true, "Cook", null, null, "Predator", "", "", "07470100062", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 117.0m },
                    { new Guid("26fb3b05-9656-4984-bfa8-3dfde478b540"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rowan.diaz151@example.com", "Rowan", 188m, true, "Diaz", null, null, "Sniper", "", "", "07470100051", "Win = 0, Loss = 0, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 97.5m },
                    { new Guid("26ff13be-eb47-4925-8c57-692daaff9ca5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "brody.alexander298@example.com", "Brody", 185m, true, "Alexander", null, null, "Smokes", "", "", "07470100198", "Win = 3, Loss = 5, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 118.3m },
                    { new Guid("2a1757f0-281b-4baa-94bb-89d258b4c880"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dominic.foster209@example.com", "Dominic", 167m, true, "Foster", null, null, "Comet", "", "", "07470100109", "Win = 1, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 93.8m },
                    { new Guid("2a1f3fd0-0c3b-47b9-9e0b-a78f4b391023"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "miles.rivera217@example.com", "Miles", 165m, true, "Rivera", null, null, "Saber", "", "", "07470100117", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 110.8m },
                    { new Guid("2b3b813a-7d54-4f27-9aaf-282f70958b2a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "declan.rivera127@example.com", "Declan", 187m, true, "Rivera", null, null, "Berserker", "", "", "07470100027", "Win = 4, Loss = 5, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 56.5m },
                    { new Guid("2bde1c75-d4f6-4980-a874-c834a37a03c8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "connor.cox251@example.com", "Connor", 200m, true, "Cox", null, null, "Oblivion", "", "", "07470100151", "Win = 2, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 58.4m },
                    { new Guid("2da75fb5-f4b2-4c90-a0e1-690fde932d47"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "rhys.howard185@example.com", "Rhys", 194m, true, "Howard", null, null, "Hawk", "", "", "07470100085", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 114.0m },
                    { new Guid("2f067c1d-173c-4a0e-9e28-acf719bd7d10"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "keaton.morgan165@example.com", "Keaton", 185m, true, "Morgan", null, null, "Fury", "", "", "07470100065", "Win = 2, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 88.9m },
                    { new Guid("2f13c3e6-a918-4112-bb44-4ab72e0f5c63"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "tyler.hughes184@example.com", "Tyler", 173m, true, "Hughes", null, null, "Colossus", "", "", "07470100084", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 64.0m },
                    { new Guid("2f797113-79b5-4d02-9748-49e20ca7d5bd"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "grayson.cox234@example.com", "Grayson", 174m, true, "Cox", null, null, "Striker", "", "", "07470100134", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 92.2m },
                    { new Guid("302072c7-3829-41ea-989b-c51b81ba9401"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "max.james129@example.com", "Max", 180m, true, "James", null, null, "Knuckles", "", "", "07470100029", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 113.8m },
                    { new Guid("31786f82-bc22-4c6a-8028-1f040730984d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kieran.torres260@example.com", "Kieran", 192m, true, "Torres", null, null, "Kingpin", "", "", "07470100160", "Win = 2, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 88.7m },
                    { new Guid("31929bf9-1fc9-47d6-9ae8-164349a668d0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hugo.sanchez148@example.com", "Hugo", 190m, true, "Sanchez", null, null, "Tank", "", "", "07470100048", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 56.2m },
                    { new Guid("31af23c0-c38a-49bd-850c-f529851c1ca7"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "brody.green102@example.com", "Brody", 195m, true, "Green", null, null, "Slate", "", "", "07470100002", "Win = 3, Loss = 0, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 75.7m },
                    { new Guid("328b34eb-d0ed-4f1d-82f0-73e8122c0c91"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "declan.ward120@example.com", "Declan", 184m, true, "Ward", null, null, "Blackout", "", "", "07470100020", "Win = 2, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 111.7m },
                    { new Guid("33f51b71-6fbd-42dc-87a2-4b06e7b80744"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "logan.wright212@example.com", "Logan", 181m, true, "Wright", null, null, "Wolf", "", "", "07470100112", "Win = 4, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 78.0m },
                    { new Guid("37963008-3e54-4b20-9547-6d04d16e60c8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zane.sanchez214@example.com", "Zane", 194m, true, "Sanchez", null, null, "Brick", "", "", "07470100114", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 93.5m },
                    { new Guid("39fb74bd-14bd-41de-aac4-009d1f89ff0a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "austin.ward191@example.com", "Austin", 166m, true, "Ward", null, null, "Bruiser", "", "", "07470100091", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 85.4m },
                    { new Guid("3a4d8d44-86a0-4238-a652-f5deb0b9fcb8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "blake.murphy169@example.com", "Blake", 172m, true, "Murphy", null, null, "Blade", "", "", "07470100069", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 76.6m },
                    { new Guid("3bd0d4a0-7e2d-4ca7-a625-bca7ab86b773"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "cody.brooks297@example.com", "Cody", 171m, true, "Brooks", null, null, "Byte", "", "", "07470100197", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 105.9m },
                    { new Guid("3d82fd34-7946-4ac6-8248-6a9a28ffb694"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alex.stewart177@example.com", "Alex", 184m, true, "Stewart", null, null, "Razor", "", "", "07470100077", "Win = 5, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 98.7m },
                    { new Guid("40847179-3ef9-4de6-a082-90998d7b28eb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reuben.patterson219@example.com", "Reuben", 195m, true, "Patterson", null, null, "Quake", "", "", "07470100119", "Win = 2, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 90.2m },
                    { new Guid("423adf03-b171-4e5f-88ac-68e967e55d24"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kai.watson176@example.com", "Kai", 169m, true, "Watson", null, null, "Grizzly", "", "", "07470100076", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 76.0m },
                    { new Guid("423d0d92-488c-40f3-8863-f39f86c972a4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "spencer.nelson218@example.com", "Spencer", 175m, true, "Nelson", null, null, "Ranger", "", "", "07470100118", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 110.7m },
                    { new Guid("426c45c6-84c3-4bf5-a79d-f52f54a205e5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "grayson.bell157@example.com", "Grayson", 190m, true, "Bell", null, null, "Blade", "", "", "07470100057", "Win = 7, Loss = 1, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 80.0m },
                    { new Guid("45b4bcba-ade4-4086-8316-0923ec41da5c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "noah.bell133@example.com", "Noah", 178m, true, "Bell", null, null, "Fang", "", "", "07470100033", "Win = 4, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 109.1m },
                    { new Guid("46fa5147-1e9c-48b8-be04-ef58e7a0abc0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "adam.ford284@example.com", "Adam", 171m, true, "Ford", null, null, "Rampage", "", "", "07470100184", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 68.8m },
                    { new Guid("4730120c-5374-4578-8eed-c7db818f27d9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tristan.reed203@example.com", "Tristan", 177m, true, "Reed", null, null, "Omega", "", "", "07470100103", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 55.6m },
                    { new Guid("4ade1ea3-5f58-4de6-92ef-b13f3b08b4cd"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "luca.king108@example.com", "Luca", 197m, true, "King", null, null, "Pulse", "", "", "07470100008", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 94.0m },
                    { new Guid("4b49cf15-47a8-46f0-bb58-63f66b9338cf"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ethan.james211@example.com", "Ethan", 165m, true, "James", null, null, "Tracker", "", "", "07470100111", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 70.1m },
                    { new Guid("4fb3852d-c58b-4215-9813-e6ee4fce9edc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "freddie.perry283@example.com", "Freddie", 180m, true, "Perry", null, null, "Nitro", "", "", "07470100183", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 113.0m },
                    { new Guid("5095cc3d-d0f1-41d5-9a00-a9ff7d091c52"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kieran.morris134@example.com", "Kieran", 185m, true, "Morris", null, null, "Predator", "", "", "07470100034", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 102.2m },
                    { new Guid("52816730-ffd3-4b18-92c7-d9feac024c2f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "adam.bell279@example.com", "Adam", 179m, true, "Bell", null, null, "Zephyr", "", "", "07470100179", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 66.3m },
                    { new Guid("5295f2f1-2940-406a-a2a2-ff035f57546b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "harrison.hamilton226@example.com", "Harrison", 198m, true, "Hamilton", null, null, "Zephyr", "", "", "07470100126", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 81.5m },
                    { new Guid("536142b6-d199-485d-8864-9ae38a96e924"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "liam.griffin171@example.com", "Liam", 200m, true, "Griffin", null, null, "Havoc", "", "", "07470100071", "Win = 1, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 57.2m },
                    { new Guid("54830c20-9bd8-483c-a997-52075336a647"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "elliot.bryant216@example.com", "Elliot", 173m, true, "Bryant", null, null, "Omega", "", "", "07470100116", "Win = 3, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 110.7m },
                    { new Guid("56ed4707-74b5-4684-9cfc-7f67e7119c12"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "luca.baker265@example.com", "Luca", 168m, true, "Baker", null, null, "Bandit", "", "", "07470100165", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 99.8m },
                    { new Guid("57fdca99-0a4b-4ca1-978e-a47208596c97"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "connor.flores113@example.com", "Connor", 178m, true, "Flores", null, null, "Cyclone", "", "", "07470100013", "Win = 1, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 65.0m },
                    { new Guid("58e93fe5-2e3a-403e-a27d-6b6465ab2955"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "nathan.parker114@example.com", "Nathan", 184m, true, "Parker", null, null, "Bruiser", "", "", "07470100014", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 75.6m },
                    { new Guid("5a175f48-c395-4cc2-9b1b-d911fd46f6a0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "theo.butler208@example.com", "Theo", 180m, true, "Butler", null, null, "Pixel", "", "", "07470100108", "Win = 1, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 71.3m },
                    { new Guid("5c58a1f5-0732-4764-b7ff-63d5667e11f8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "riley.stewart247@example.com", "Riley", 167m, true, "Stewart", null, null, "Rampage", "", "", "07470100147", "Win = 0, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 72.7m },
                    { new Guid("5e2647e8-e6b4-4a75-8581-e0c35744807f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "nathan.myers112@example.com", "Nathan", 190m, true, "Myers", null, null, "Overdrive", "", "", "07470100012", "Win = 3, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 110.8m },
                    { new Guid("5ff3f58b-1f90-410c-92a4-f7416407e634"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "spencer.cook139@example.com", "Spencer", 167m, true, "Cook", null, null, "Rampage", "", "", "07470100039", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 62.7m },
                    { new Guid("61e1d4fd-a412-4e7c-9ae1-80f9a76e6467"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hugo.nelson210@example.com", "Hugo", 181m, true, "Nelson", null, null, "Samurai", "", "", "07470100110", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 117.1m },
                    { new Guid("64b1c80a-33d3-4b07-9bf3-b00f2c0654ac"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "harley.henderson215@example.com", "Harley", 167m, true, "Henderson", null, null, "Cutlass", "", "", "07470100115", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 75.0m },
                    { new Guid("6720b4f5-d5f7-4784-8eae-7dbef791aef3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "caleb.phillips200@example.com", "Caleb", 199m, true, "Phillips", null, null, "Turbo", "", "", "07470100100", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 112.2m },
                    { new Guid("67568bde-97a5-4a09-b2ef-a3a14ee3c606"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "oscar.patterson245@example.com", "Oscar", 179m, true, "Patterson", null, null, "Zero", "", "", "07470100145", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 90.3m },
                    { new Guid("6ae5dadc-2399-47ce-af4d-e258a2a45867"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "finn.russell232@example.com", "Finn", 199m, true, "Russell", null, null, "Major", "", "", "07470100132", "Win = 5, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 84.2m },
                    { new Guid("6dc99cce-c125-4e16-8a86-0a14342376a2"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kieran.russell268@example.com", "Kieran", 166m, true, "Russell", null, null, "Rogue", "", "", "07470100168", "Win = 2, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 62.2m },
                    { new Guid("6ef133a3-ee5a-4509-b334-26bc8f7c17de"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "austin.rivera285@example.com", "Austin", 166m, true, "Rivera", null, null, "Bulldog", "", "", "07470100185", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 72.1m },
                    { new Guid("6f120796-e0a8-4008-89e1-f45d27b5c989"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "zack.ward138@example.com", "Zack", 180m, true, "Ward", null, null, "Berserker", "", "", "07470100038", "Win = 1, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 104.1m },
                    { new Guid("6f3013f0-b277-4c8a-8a81-f6cbae63edd0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "harrison.evans186@example.com", "Harrison", 165m, true, "Evans", null, null, "Nitro", "", "", "07470100086", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 85.2m },
                    { new Guid("6f98a2b9-863d-46a6-aba3-189902132f47"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "mason.foster181@example.com", "Mason", 165m, true, "Foster", null, null, "Echo", "", "", "07470100081", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 82.9m },
                    { new Guid("70732cc3-9e9c-4334-aef4-f90e876bcd97"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ivan.rogers131@example.com", "Ivan", 188m, true, "Rogers", null, null, "Rhino", "", "", "07470100031", "Win = 5, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 110.4m },
                    { new Guid("724c91ca-b93f-4119-83fb-de31150fae1a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jaxon.wilson276@example.com", "Jaxon", 182m, true, "Wilson", null, null, "Wraith", "", "", "07470100176", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 88.8m },
                    { new Guid("727122a4-0b01-4ab1-af39-6a063b4bcdbe"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "miles.ross237@example.com", "Miles", 184m, true, "Ross", null, null, "Bulldog", "", "", "07470100137", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 58.6m },
                    { new Guid("730717a5-ac83-4068-80b5-b3739edd97de"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "miles.jenkins163@example.com", "Miles", 174m, true, "Jenkins", null, null, "Tracker", "", "", "07470100063", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 75.6m },
                    { new Guid("7376aba8-16fd-4087-90c4-7f9c8947ec36"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "tristan.parker257@example.com", "Tristan", 198m, true, "Parker", null, null, "Boss", "", "", "07470100157", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 85.4m },
                    { new Guid("742e1c2b-0444-44e2-a4b2-5e275eab7ac8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "alex.hamilton281@example.com", "Alex", 182m, true, "Hamilton", null, null, "Quake", "", "", "07470100181", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 111.4m },
                    { new Guid("760e2ac1-55cf-4ea4-bbed-f119e4d5caba"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hunter.long110@example.com", "Hunter", 170m, true, "Long", null, null, "Goliath", "", "", "07470100010", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 79.2m },
                    { new Guid("764589fd-148b-42fc-9cfc-f3a5c39ad69a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jude.sanchez255@example.com", "Jude", 194m, true, "Sanchez", null, null, "Diesel", "", "", "07470100155", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 55.7m },
                    { new Guid("7948f704-daae-425e-8b63-91da608ac304"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "harley.diaz274@example.com", "Harley", 172m, true, "Diaz", null, null, "Zero", "", "", "07470100174", "Win = 1, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 91.7m },
                    { new Guid("7994add2-5fb8-4d6d-a6fb-be95f1b5d934"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "harley.ramirez198@example.com", "Harley", 173m, true, "Ramirez", null, null, "Smokes", "", "", "07470100098", "Win = 6, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 84.2m },
                    { new Guid("79b3e157-4d51-4231-849f-3e4d2e040d72"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "joel.bell192@example.com", "Joel", 195m, true, "Bell", null, null, "Zero", "", "", "07470100092", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 77.9m },
                    { new Guid("7c9023a3-f7d7-45b6-a604-1c77450813a0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ezra.hamilton173@example.com", "Ezra", 186m, true, "Hamilton", null, null, "Jaguar", "", "", "07470100073", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 60.0m },
                    { new Guid("7d850e73-9a02-4234-9f3e-fc8f7b0504c3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "max.walker228@example.com", "Max", 186m, true, "Walker", null, null, "Mayhem", "", "", "07470100128", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 85.8m },
                    { new Guid("7f06b50f-3c21-4d44-8b53-c7e434338059"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jordan.washington250@example.com", "Jordan", 187m, true, "Washington", null, null, "Storm", "", "", "07470100150", "Win = 6, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 96.0m },
                    { new Guid("7f18aa63-04e9-420e-a68c-bce657b8d0b8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "declan.taylor119@example.com", "Declan", 200m, true, "Taylor", null, null, "Glitch", "", "", "07470100019", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 106.9m },
                    { new Guid("80210db7-ed4b-4e45-ba40-ed7b05fd6e82"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "evan.sanchez295@example.com", "Evan", 171m, true, "Sanchez", null, null, "Oblivion", "", "", "07470100195", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 59.6m },
                    { new Guid("83426b61-ff08-4844-a2c2-316fef81b704"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "joel.baker236@example.com", "Joel", 184m, true, "Baker", null, null, "Samurai", "", "", "07470100136", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 83.3m },
                    { new Guid("838b6df1-dc8e-49c6-8693-2903f87ffbee"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "declan.taylor190@example.com", "Declan", 200m, true, "Taylor", null, null, "Comet", "", "", "07470100090", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 63.3m },
                    { new Guid("85767b22-6321-4f18-b595-a2dd223ccc3e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elijah.sanchez152@example.com", "Elijah", 196m, true, "Sanchez", null, null, "Cannon", "", "", "07470100052", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 69.7m },
                    { new Guid("86b0d59d-68e5-45e2-a971-2468a37c6500"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ivan.morgan121@example.com", "Ivan", 183m, true, "Morgan", null, null, "Cutlass", "", "", "07470100021", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 103.3m },
                    { new Guid("8c50de97-9a51-42df-b0e7-4d962a063680"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "lewis.bailey143@example.com", "Lewis", 189m, true, "Bailey", null, null, "Drift", "", "", "07470100043", "Win = 2, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 76.6m },
                    { new Guid("8dd6e3d2-0f6c-4b5f-a302-66f51254321a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "leon.murphy294@example.com", "Leon", 195m, true, "Murphy", null, null, "Turbo", "", "", "07470100194", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 107.5m },
                    { new Guid("907eed8e-944b-41e1-94f7-6a300eb72aef"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "harley.hughes149@example.com", "Harley", 168m, true, "Hughes", null, null, "Rhino", "", "", "07470100049", "Win = 1, Loss = 8, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 106.3m },
                    { new Guid("90a00fc3-5d1e-4323-b77f-cd2b197e8ac4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kai.green293@example.com", "Kai", 166m, true, "Green", null, null, "Pixel", "", "", "07470100193", "Win = 3, Loss = 4, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 103.5m },
                    { new Guid("915747ee-253e-44e8-bfef-96ad69df2efc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "connor.cox189@example.com", "Connor", 167m, true, "Cox", null, null, "Knuckles", "", "", "07470100089", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 86.9m },
                    { new Guid("92046394-0859-4661-b215-e7dc40822d38"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "zane.jenkins179@example.com", "Zane", 188m, true, "Jenkins", null, null, "Meteor", "", "", "07470100079", "Win = 2, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 73.7m },
                    { new Guid("9245939a-b3c4-4d8c-b5de-5779c93b6994"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jasper.flores111@example.com", "Jasper", 176m, true, "Flores", null, null, "Flash", "", "", "07470100011", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 75.9m },
                    { new Guid("928022c5-34f4-43ea-8744-a31cc2ca9e5d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "caleb.perez258@example.com", "Caleb", 176m, true, "Perez", null, null, "Dagger", "", "", "07470100158", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 114.5m },
                    { new Guid("942d35e6-791b-42db-9ef4-89d491368c3d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "evan.howard267@example.com", "Evan", 171m, true, "Howard", null, null, "Bullet", "", "", "07470100167", "Win = 6, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 72.0m },
                    { new Guid("94c2af5b-73de-425b-8b36-ddff8c69af36"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jordan.collins183@example.com", "Jordan", 195m, true, "Collins", null, null, "Reaper", "", "", "07470100083", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 87.2m },
                    { new Guid("954e4d33-59c4-4941-8079-41d9e4410a5f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "grayson.turner130@example.com", "Grayson", 166m, true, "Turner", null, null, "Savage", "", "", "07470100030", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 80.9m },
                    { new Guid("968c4ce5-c857-4f46-bccb-9126986efce6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jasper.alexander225@example.com", "Jasper", 193m, true, "Alexander", null, null, "Thunder", "", "", "07470100125", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 70.0m },
                    { new Guid("9c6def24-3bb3-444c-80c7-15b55955c121"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elijah.ward194@example.com", "Elijah", 177m, true, "Ward", null, null, "Mayhem", "", "", "07470100094", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 67.0m },
                    { new Guid("9c772ef9-1a29-4f07-815a-c019b6d1d1ea"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reuben.perry166@example.com", "Reuben", 175m, true, "Perry", null, null, "Oblivion", "", "", "07470100066", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 119.0m },
                    { new Guid("9e55d888-243b-433d-a33e-c7488ecc228f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "liam.brooks240@example.com", "Liam", 189m, true, "Brooks", null, null, "Lightning", "", "", "07470100140", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 115.8m },
                    { new Guid("a1c3135b-c210-4999-9041-10ce982386a5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "brody.edwards290@example.com", "Brody", 193m, true, "Edwards", null, null, "Cannon", "", "", "07470100190", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 80.0m },
                    { new Guid("a37f7be2-3f35-48af-8108-87686aa66f27"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "grayson.russell196@example.com", "Grayson", 179m, true, "Russell", null, null, "Phantom", "", "", "07470100096", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 89.3m },
                    { new Guid("a750c406-1210-48b0-84d3-240649b58833"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elijah.jenkins227@example.com", "Elijah", 197m, true, "Jenkins", null, null, "Bruiser", "", "", "07470100127", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 94.1m },
                    { new Guid("a811277a-d17b-43ef-9ee3-7af026a5f9db"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bradley.sanchez145@example.com", "Bradley", 198m, true, "Sanchez", null, null, "Echo", "", "", "07470100045", "Win = 0, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 63.4m },
                    { new Guid("a84139fd-fa3e-4256-9a3e-bacddcaee932"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1996, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "evan.mitchell270@example.com", "Evan", 181m, true, "Mitchell", null, null, "Jaguar", "", "", "07470100170", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 82.8m },
                    { new Guid("a97daf37-960d-46fc-bf48-05acd7f5fe52"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "harley.ross242@example.com", "Harley", 192m, true, "Ross", null, null, "Nova", "", "", "07470100142", "Win = 4, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 66.9m },
                    { new Guid("a98cc025-0aa6-4771-b05a-091e2895a47c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "lucas.foster292@example.com", "Lucas", 188m, true, "Foster", null, null, "Bullseye", "", "", "07470100192", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 105.3m },
                    { new Guid("aa00216d-3754-4e17-addf-3f2df41f1073"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "owen.bailey220@example.com", "Owen", 180m, true, "Bailey", null, null, "Ghost", "", "", "07470100120", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 116.7m },
                    { new Guid("aa18335b-bb28-4f33-a3c6-8328066c7b86"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tyler.young254@example.com", "Tyler", 168m, true, "Young", null, null, "Static", "", "", "07470100154", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 96.1m },
                    { new Guid("ac1f5d10-10ba-4c00-9a08-b7c64a28d8fd"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "reece.walker246@example.com", "Reece", 196m, true, "Walker", null, null, "Falcon", "", "", "07470100146", "Win = 3, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 106.5m },
                    { new Guid("aca014e2-c914-48d4-93e8-9c7e61325e65"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "luca.evans233@example.com", "Luca", 184m, true, "Evans", null, null, "Ember", "", "", "07470100133", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 110.8m },
                    { new Guid("ad03f835-92d5-4826-87a6-21434d3a56bf"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "adam.howard201@example.com", "Adam", 188m, true, "Howard", null, null, "Stalker", "", "", "07470100101", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 104.0m },
                    { new Guid("af4e32bb-cf7a-4576-b0b7-4b7e9a48236c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "reece.nelson252@example.com", "Reece", 173m, true, "Nelson", null, null, "Rampage", "", "", "07470100152", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 63.3m },
                    { new Guid("b0755979-d65f-42e8-9c3b-91072a36616e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jude.hall168@example.com", "Jude", 179m, true, "Hall", null, null, "Razor", "", "", "07470100068", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 75.9m },
                    { new Guid("b1bf4e7a-44cd-488c-8e32-7914c64654ac"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "freddie.ross238@example.com", "Freddie", 171m, true, "Ross", null, null, "Flash", "", "", "07470100138", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 81.6m },
                    { new Guid("b28c5bf0-566a-4d8f-893b-92944ec1c874"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jude.butler161@example.com", "Jude", 175m, true, "Butler", null, null, "Kodiak", "", "", "07470100061", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 106.7m },
                    { new Guid("b4135485-289b-46dc-a274-c1221936c2e5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "owen.taylor262@example.com", "Owen", 193m, true, "Taylor", null, null, "Chaos", "", "", "07470100162", "Win = 3, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 92.4m },
                    { new Guid("b5631802-4750-4f4b-aa9c-05d7c6e3b9f9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "oscar.walker124@example.com", "Oscar", 191m, true, "Walker", null, null, "Berserker", "", "", "07470100024", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 70.8m },
                    { new Guid("b5bbd9ca-a508-4194-a3d8-9a2fa1a93339"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ivan.bennett123@example.com", "Ivan", 197m, true, "Bennett", null, null, "Hydra", "", "", "07470100023", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), 114.8m },
                    { new Guid("b7a6f082-1c23-445b-a143-f7a93173e671"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rhys.ross253@example.com", "Rhys", 192m, true, "Ross", null, null, "Longshot", "", "", "07470100153", "Win = 8, Loss = 13, Draw = 3", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 84.2m },
                    { new Guid("b84f62f3-02ce-479c-b53b-b72ecfc904c0"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hugo.peterson230@example.com", "Hugo", 193m, true, "Peterson", null, null, "Dagger", "", "", "07470100130", "Win = 7, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 111.9m },
                    { new Guid("b9446c6c-d427-4bd6-8108-568a6ed1d581"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "caleb.wilson178@example.com", "Caleb", 179m, true, "Wilson", null, null, "Stalker", "", "", "07470100078", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 100.4m },
                    { new Guid("baf64036-0f53-41be-b9d4-40dc37b9eece"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "elliot.turner249@example.com", "Elliot", 199m, true, "Turner", null, null, "Sniper", "", "", "07470100149", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 75.7m },
                    { new Guid("bcc96d6c-05ec-4816-9f89-da51315ef023"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "charlie.wilson222@example.com", "Charlie", 191m, true, "Wilson", null, null, "Phantom", "", "", "07470100122", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 94.7m },
                    { new Guid("bd0996b6-b4d0-41bb-9557-2640796de986"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "felix.james155@example.com", "Felix", 169m, true, "James", null, null, "Draco", "", "", "07470100055", "Win = 0, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 116.6m },
                    { new Guid("be338bb5-a9da-4af0-a71a-68db60a81d46"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zane.gonzalez235@example.com", "Zane", 197m, true, "Gonzalez", null, null, "Wraith", "", "", "07470100135", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 79.0m },
                    { new Guid("c0d19665-ec52-4597-ade3-b60c586c5263"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "harley.butler224@example.com", "Harley", 194m, true, "Butler", null, null, "Cosmo", "", "", "07470100124", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 62.9m },
                    { new Guid("c41aab29-146f-42df-b01d-66181c9efb91"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "luca.rivera199@example.com", "Luca", 198m, true, "Rivera", null, null, "Thunder", "", "", "07470100099", "Win = 0, Loss = 0, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 108.6m },
                    { new Guid("c4e99bba-ab03-4ea5-a0ee-c7fa8aea5173"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "ezra.robinson104@example.com", "Ezra", 190m, true, "Robinson", null, null, "Sniper", "", "", "07470100004", "Win = 1, Loss = 4, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 82.9m },
                    { new Guid("c57a0c7b-91d2-405c-9fab-dd3feee73e7a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rhys.cox263@example.com", "Rhys", 169m, true, "Cox", null, null, "Tempest", "", "", "07470100163", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 90.5m },
                    { new Guid("c59cb820-15e3-4897-a2e5-87fed0ee1df7"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "adam.perry146@example.com", "Adam", 184m, true, "Perry", null, null, "Oblivion", "", "", "07470100046", "Win = 1, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), 80.3m },
                    { new Guid("c59f9fd5-af9a-4bfc-b3d2-6e704fe00d45"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kyle.hughes136@example.com", "Kyle", 166m, true, "Hughes", null, null, "Wraith", "", "", "07470100036", "Win = 9, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 58.6m },
                    { new Guid("c65c593c-79cd-4c7d-8d9d-21c4cf7ebfa2"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "dominic.evans109@example.com", "Dominic", 186m, true, "Evans", null, null, "Anvil", "", "", "07470100009", "Win = 12, Loss = 10, Draw = 4", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 116.3m },
                    { new Guid("c670f207-a583-49f4-a2f3-a4edc12e3b21"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jude.taylor221@example.com", "Jude", 176m, true, "Taylor", null, null, "Grizzly", "", "", "07470100121", "Win = 0, Loss = 3, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 57.9m },
                    { new Guid("c7beefdc-3f5c-4711-9987-55de4d586e94"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "spencer.ross135@example.com", "Spencer", 186m, true, "Ross", null, null, "Berserker", "", "", "07470100035", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 104.8m },
                    { new Guid("c8182ebd-1070-4b3e-9ebb-550b1f9ca34a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2008, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "logan.griffin100@example.com", "Logan", 197m, true, "Griffin", null, null, "Mace", "", "", "07470100000", "Win = 4, Loss = 4, Draw = 2", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 57.3m },
                    { new Guid("c973545b-5156-49bf-9bc6-52acc1843e82"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "lucas.brooks140@example.com", "Lucas", 173m, true, "Brooks", null, null, "Chief", "", "", "07470100040", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 88.8m },
                    { new Guid("c989c8d9-1bdf-43ae-8824-6234e4d6c57f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bradley.bailey261@example.com", "Bradley", 185m, true, "Bailey", null, null, "Diesel", "", "", "07470100161", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 110.4m },
                    { new Guid("ca1e6589-3943-446a-9880-240151d4cd3b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "spencer.reed282@example.com", "Spencer", 197m, true, "Reed", null, null, "Fang", "", "", "07470100182", "Win = 3, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 108.1m },
                    { new Guid("ca25a3d9-888e-48ad-a3c7-323bdea3ee8c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hunter.price289@example.com", "Hunter", 175m, true, "Price", null, null, "Fang", "", "", "07470100189", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 114.8m },
                    { new Guid("cbcf9114-6598-46ff-9faa-ac57ea537d13"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "leon.carter147@example.com", "Leon", 166m, true, "Carter", null, null, "Blaze", "", "", "07470100047", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 95.0m },
                    { new Guid("cbd89d26-7a62-43af-8411-d7fda1224d75"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "aaron.rogers256@example.com", "Aaron", 165m, true, "Rogers", null, null, "Onyx", "", "", "07470100156", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), 94.8m },
                    { new Guid("cc1f9c0c-e32d-45ec-9f36-a5e2a0b1d4ad"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jayden.torres160@example.com", "Jayden", 184m, true, "Torres", null, null, "Ammo", "", "", "07470100060", "Win = 0, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), 81.9m },
                    { new Guid("cc509690-8a0e-4042-93d7-d697d89ac14f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elijah.long137@example.com", "Elijah", 170m, true, "Long", null, null, "Rumble", "", "", "07470100037", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 92.9m },
                    { new Guid("ce4175c2-1dff-4c2a-8e5c-15f082a0a95d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "lewis.jenkins115@example.com", "Lewis", 178m, true, "Jenkins", null, null, "Panther", "", "", "07470100015", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), 87.6m },
                    { new Guid("cf8b34a7-0047-4577-aeca-1e82a3004abb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rhys.turner107@example.com", "Rhys", 188m, true, "Turner", null, null, "Jaguar", "", "", "07470100007", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 110.8m },
                    { new Guid("cf90ac21-70b0-463a-9f97-ac7f6b809e23"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "cameron.patterson241@example.com", "Cameron", 172m, true, "Patterson", null, null, "Havoc", "", "", "07470100141", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 89.0m },
                    { new Guid("cfb5f34f-08e5-41e3-a46c-5d428252867c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "brody.wright275@example.com", "Brody", 186m, true, "Wright", null, null, "Fang", "", "", "07470100175", "Win = 3, Loss = 4, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 58.2m },
                    { new Guid("cfc48504-6f03-4f29-a406-ef95d3fc3f5e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2006, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "keaton.ward259@example.com", "Keaton", 183m, true, "Ward", null, null, "Talon", "", "", "07470100159", "Win = 3, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), 82.7m },
                    { new Guid("cfcae534-dd1a-4f19-8054-06e28ef35112"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2010, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "toby.coleman280@example.com", "Toby", 195m, true, "Coleman", null, null, "Crusher", "", "", "07470100180", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 111.8m },
                    { new Guid("d0f4c939-e3bb-4aff-aceb-7d6c64cbb9fb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kieran.green204@example.com", "Kieran", 170m, true, "Green", null, null, "Bulldog", "", "", "07470100104", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 59.9m },
                    { new Guid("d170db0a-49af-4f03-9b60-fc1d8327f450"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kyle.bailey170@example.com", "Kyle", 172m, true, "Bailey", null, null, "Hammer", "", "", "07470100070", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 76.9m },
                    { new Guid("d2f3c42d-cb9b-4223-b373-9ea2f25e7215"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2007, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ivan.young142@example.com", "Ivan", 184m, true, "Young", null, null, "Guardian", "", "", "07470100042", "Win = 0, Loss = 2, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), 113.3m },
                    { new Guid("d48556e3-f78e-4947-8775-afbc3d4abf21"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "max.alexander243@example.com", "Max", 185m, true, "Alexander", null, null, "Bulldog", "", "", "07470100143", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), 78.0m },
                    { new Guid("d620cc19-60f4-4923-a150-8cd442639a64"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2000, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "charlie.perez286@example.com", "Charlie", 176m, true, "Perez", null, null, "Missile", "", "", "07470100186", "Win = 2, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 84.6m },
                    { new Guid("d7707e94-e1bb-468c-932c-7d736175fcde"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "caleb.hayes126@example.com", "Caleb", 188m, true, "Hayes", null, null, "Rumble", "", "", "07470100026", "Win = 2, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 77.3m },
                    { new Guid("d8947f96-4b82-4bea-b8be-746ce6902ba2"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "jude.washington159@example.com", "Jude", 174m, true, "Washington", null, null, "Predator", "", "", "07470100059", "Win = 5, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 72.5m },
                    { new Guid("dbf823b0-a997-43d7-841b-6f37a657104c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2001, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kieran.patterson118@example.com", "Kieran", 184m, true, "Patterson", null, null, "Mantis", "", "", "07470100018", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 95.8m },
                    { new Guid("dce5d0d1-ab18-4cb3-a126-34f145a6e6c8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2003, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "kieran.watson125@example.com", "Kieran", 195m, true, "Watson", null, null, "Grizzly", "", "", "07470100025", "Win = 3, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), 107.8m },
                    { new Guid("df0cbe48-2c0a-49d8-8081-54a02684504c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "elijah.mitchell187@example.com", "Elijah", 170m, true, "Mitchell", null, null, "Mayhem", "", "", "07470100087", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 58.8m },
                    { new Guid("e1e3a92b-df58-4f90-81c3-9008fb3dab9a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "hugo.bell288@example.com", "Hugo", 193m, true, "Bell", null, null, "Beast", "", "", "07470100188", "Win = 0, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), 101.8m },
                    { new Guid("e2211f92-5d95-4148-a733-afc5a629f773"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "tristan.king244@example.com", "Tristan", 171m, true, "King", null, null, "Longshot", "", "", "07470100144", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), 105.6m },
                    { new Guid("e239ac4f-021b-4352-95e8-23080c1f8971"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "liam.sanders154@example.com", "Liam", 178m, true, "Sanders", null, null, "Nova", "", "", "07470100054", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), 77.5m },
                    { new Guid("e5e87710-57b9-46a1-8d46-0420eff4cb27"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1998, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "rowan.wilson193@example.com", "Rowan", 167m, true, "Wilson", null, null, "Riot", "", "", "07470100093", "Win = 4, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 60.4m },
                    { new Guid("e7854f5e-f24c-41e0-961a-f7f058b760e9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "jude.washington122@example.com", "Jude", 189m, true, "Washington", null, null, "Kodiak", "", "", "07470100022", "Win = 3, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 100.7m },
                    { new Guid("eb9e42f1-c9aa-479b-af9f-5fbd370fe166"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "oscar.price101@example.com", "Oscar", 195m, true, "Price", null, null, "Venom", "", "", "07470100001", "Win = 1, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 85.2m },
                    { new Guid("ec35ca0b-2fa1-4615-828d-cd57829bb696"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "blake.patterson231@example.com", "Blake", 199m, true, "Patterson", null, null, "Jaguar", "", "", "07470100131", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 62.3m },
                    { new Guid("ee1e3338-3ce4-4b32-ae09-6ecc3b249c44"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "austin.hall202@example.com", "Austin", 167m, true, "Hall", null, null, "Jaguar", "", "", "07470100102", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 101.8m },
                    { new Guid("eeca9dc5-febb-48d8-b769-1d4b30d9b16e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1991, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "zack.peterson271@example.com", "Zack", 175m, true, "Peterson", null, null, "Chaos", "", "", "07470100171", "Win = 0, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"), 85.8m },
                    { new Guid("efb977ce-cea7-4655-811f-1b9b7c0f0f36"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2005, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "owen.hamilton264@example.com", "Owen", 181m, true, "Hamilton", null, null, "Smokes", "", "", "07470100164", "Win = 0, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), 83.1m },
                    { new Guid("f52fd703-ae80-48ea-954b-22bba5c961e9"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ezra.simmons188@example.com", "Ezra", 190m, true, "Simmons", null, null, "Saber", "", "", "07470100088", "Win = 3, Loss = 0, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 82.5m },
                    { new Guid("f7ab789b-b7de-4971-aa67-0cd65a37111f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "joel.ramirez174@example.com", "Joel", 165m, true, "Ramirez", null, null, "Current", "", "", "07470100074", "Win = 3, Loss = 4, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), 81.5m },
                    { new Guid("f7d22d28-baa2-4808-bd06-fad63657bd91"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1993, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "tristan.foster175@example.com", "Tristan", 196m, true, "Foster", null, null, "Comet", "", "", "07470100075", "Win = 1, Loss = 1, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), 72.4m },
                    { new Guid("f8517214-51e2-4c09-b128-cd68b760184b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2004, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "owen.torres164@example.com", "Owen", 195m, true, "Torres", null, null, "Predator", "", "", "07470100064", "Win = 1, Loss = 2, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), 67.8m },
                    { new Guid("f95cc604-6093-4f1a-ac4b-6d781e5a6e9e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1999, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "ashton.brooks277@example.com", "Ashton", 186m, true, "Brooks", null, null, "Rampage", "", "", "07470100177", "Win = 1, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), 73.2m },
                    { new Guid("fab1790b-22b4-4d5a-bfd9-1168ce7d3d98"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1995, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "cameron.collins158@example.com", "Cameron", 180m, true, "Collins", null, null, "VenatorX", "", "", "07470100058", "Win = 0, Loss = 0, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 93.8m },
                    { new Guid("fee54a80-78a6-4665-8b5f-8e6b12227319"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(2002, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "nathan.scott291@example.com", "Nathan", 166m, true, "Scott", null, null, "Warlord", "", "", "07470100191", "Win = 0, Loss = 3, Draw = 1", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), 76.0m },
                    { new Guid("ffdd196f-38a9-4517-b419-e58475a36e9e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTimeOffset(new DateTime(1994, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "miles.flores206@example.com", "Miles", 194m, true, "Flores", null, null, "Knight", "", "", "07470100106", "Win = 3, Loss = 1, Draw = 0", new Guid("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"), 72.5m }
                });
        }
    }
}

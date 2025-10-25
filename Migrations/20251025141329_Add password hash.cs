using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Athlitix.Migrations
{
    /// <inheritdoc />
    public partial class Addpasswordhash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("df283585-df16-42d2-aa51-b10eb2861b7e"),
                column: "PasswordHash",
                value: "YQORdMCqDS1x+FTFEClDB19c0XD5YtlrKSHGVfUR0/I=");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("df283585-df16-42d2-aa51-b10eb2861b7e"),
                column: "PasswordHash",
                value: "letmein");
        }
    }
}

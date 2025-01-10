using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVersionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Versions",
                keyColumn: "VersionId",
                keyValue: "v1",
                column: "IsPublished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Versions",
                keyColumn: "VersionId",
                keyValue: "v2",
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 12, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Versions",
                keyColumn: "VersionId",
                keyValue: "v1",
                column: "IsPublished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Versions",
                keyColumn: "VersionId",
                keyValue: "v2",
                column: "CreatedAt",
                value: new DateTime(2025, 1, 3, 12, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixQuestionRulesForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "QuestionId",
                table: "QuestionRules",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRules_QuestionId_VersionId",
                table: "QuestionRules",
                columns: new[] { "QuestionId", "VersionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRules_Questions_QuestionId_VersionId",
                table: "QuestionRules",
                columns: new[] { "QuestionId", "VersionId" },
                principalTable: "Questions",
                principalColumns: new[] { "QuestionId", "VersionId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRules_Questions_QuestionId_VersionId",
                table: "QuestionRules");

            migrationBuilder.DropIndex(
                name: "IX_QuestionRules_QuestionId_VersionId",
                table: "QuestionRules");

            migrationBuilder.AlterColumn<string>(
                name: "QuestionId",
                table: "QuestionRules",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
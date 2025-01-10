using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SetIdentityColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionRules",
                table: "QuestionRules");

            migrationBuilder.DropColumn(
                name: "RuleId",
                table: "QuestionRules");

            migrationBuilder.AddColumn<int>(
                name: "RuleId",
                table: "QuestionRules",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionRules",
                table: "QuestionRules",
                column: "RuleId");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Answers",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "AnswerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionRules",
                table: "QuestionRules");

            migrationBuilder.DropColumn(
                name: "RuleId",
                table: "QuestionRules");

            migrationBuilder.AddColumn<int>(
                name: "RuleId",
                table: "QuestionRules",
                type: "int",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionRules",
                table: "QuestionRules",
                column: "RuleId");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Answers",
                type: "int",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "AnswerId");
        }
    }
}
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddQuestionRulesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRules_AnswerOptions_ParentOptionId",
                table: "QuestionRules");

            migrationBuilder.DropIndex(
                name: "IX_QuestionRules_ParentOptionId",
                table: "QuestionRules");

            migrationBuilder.DropColumn(
                name: "ParentOptionId",
                table: "QuestionRules");

            migrationBuilder.AlterColumn<string>(
                name: "QuestionId",
                table: "QuestionRules",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "QuestionRules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "QuestionRules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Operator",
                table: "QuestionRules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Sequence",
                table: "QuestionRules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "QuestionRules",
                columns: ["RuleId", "Condition", "Description", "Operator", "ParentQuestionId", "QuestionId", "Sequence"],
                values: [1, "{\"Comparison\":\"=\",\"OptionsCountOperator\":\"=\",\"ParentOptionsCount\":1,\"ParentOptions\":[\"OPT0004\"]}", "Please answer the following question, if you have answered Yes to Q5", "And", "IQA0005", "IQA0006", 1]);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRules_QuestionId",
                table: "QuestionRules",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRules_Questions_QuestionId",
                table: "QuestionRules",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRules_Questions_QuestionId",
                table: "QuestionRules");

            migrationBuilder.DropIndex(
                name: "IX_QuestionRules_QuestionId",
                table: "QuestionRules");

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "QuestionRules");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "QuestionRules");

            migrationBuilder.DropColumn(
                name: "Operator",
                table: "QuestionRules");

            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "QuestionRules");

            migrationBuilder.AlterColumn<string>(
                name: "QuestionId",
                table: "QuestionRules",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ParentOptionId",
                table: "QuestionRules",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRules_ParentOptionId",
                table: "QuestionRules",
                column: "ParentOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRules_AnswerOptions_ParentOptionId",
                table: "QuestionRules",
                column: "ParentOptionId",
                principalTable: "AnswerOptions",
                principalColumn: "OptionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreDataForRules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 1,
                column: "Description",
                value: "Please answer the following question, if you have answered Yes to Project Details:Q6");

            migrationBuilder.InsertData(
                table: "QuestionRules",
                columns: new[] { "RuleId", "Condition", "Description", "Operator", "ParentQuestionId", "QuestionId", "Sequence" },
                values: new object[,]
                {
                    { 2, "{\"Comparison\":\"=\",\"OptionsCountOperator\":\"=\",\"ParentOptionsCount\":1,\"ParentOptions\":[\"OPT0004\"]}", "Please answer the following question, if you have answered Yes to Project Scope:Q3", "And", "IQA0014", "IQA0017", 1 },
                    { 3, "{\"Comparison\":\"=\",\"OptionsCountOperator\":\"=\",\"ParentOptionsCount\":1,\"ParentOptions\":[\"OPT0004\"]}", "Please answer the following question, if you have answered Yes to Project Scope:Q4", "And", "IQA0017", "IQA0018", 1 },
                    { 4, "{\"Comparison\":\"=\",\"OptionsCountOperator\":\"=\",\"ParentOptionsCount\":1,\"ParentOptions\":[\"OPT0004\"]}", "Please answer the following question, if you have answered Yes to Project Scope:Q4", "And", "IQA0017", "IQA03282", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 1,
                column: "Description",
                value: "Please answer the following question, if you have answered Yes to Q5");
        }
    }
}

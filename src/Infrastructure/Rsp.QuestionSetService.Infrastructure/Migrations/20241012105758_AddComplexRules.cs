using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddComplexRules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Operator",
                table: "QuestionRules",
                newName: "Mode");

            migrationBuilder.RenameColumn(
                name: "Condition",
                table: "QuestionRules",
                newName: "Conditions");

            migrationBuilder.AlterColumn<string>(
                name: "ParentQuestionId",
                table: "QuestionRules",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 1,
                columns: new[] { "Conditions", "Description", "Mode", "ParentQuestionId", "QuestionId" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,100\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null}]", "Short project title should be between 15 and 100 characters", "AND", null, "IQA0002" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 2,
                columns: new[] { "Conditions", "Description", "Mode", "ParentQuestionId", "QuestionId" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,2000\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null}]", "Full project title should be between 15 and 2000 characters", "AND", null, "IQA0003" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 3,
                columns: new[] { "Conditions", "Description", "Mode", "ParentQuestionId", "QuestionId" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Project Details:Q6", "AND", "IQA0005", "IQA0006" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 4,
                columns: new[] { "Conditions", "Description", "Mode", "ParentQuestionId", "QuestionId" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0008\",\"OPT0009\",\"OPT0013\"],\"OptionType\":\"Single\"}]", "Based on your answers to Q2 under Project Scope, the following question should be answered", "AND", "IQA0061", "IQA0014" });

            migrationBuilder.InsertData(
                table: "QuestionRules",
                columns: new[] { "RuleId", "Conditions", "Description", "Mode", "ParentQuestionId", "QuestionId", "Sequence" },
                values: new object[,]
                {
                    { 5, "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Q3 under Project Scope", "AND", "IQA0014", "IQA0015", 1 },
                    { 6, "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0009\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have selected any of these options under Project Scope: Q2, ", "OR", "IQA0061", "IQA0017", 1 },
                    { 7, "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "or if you have answered Yes to Project Scope:Q3", "OR", "IQA0014", "IQA0017", 2 },
                    { 8, "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Q4 under Project Scope", "AND", "IQA0017", "IQA0018", 1 },
                    { 9, "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Q4a under Project Scope", "AND", "IQA0018", "IQA03282", 1 },
                    { 10, "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Q4a under Project Scope", "AND", "IQA0018", "IQA0020", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "Mode",
                table: "QuestionRules",
                newName: "Operator");

            migrationBuilder.RenameColumn(
                name: "Conditions",
                table: "QuestionRules",
                newName: "Condition");

            migrationBuilder.AlterColumn<string>(
                name: "ParentQuestionId",
                table: "QuestionRules",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 1,
                columns: new[] { "Condition", "Description", "Operator", "ParentQuestionId", "QuestionId" },
                values: new object[] { "{\"Comparison\":\"=\",\"OptionsCountOperator\":\"=\",\"ParentOptionsCount\":1,\"ParentOptions\":[\"OPT0004\"]}", "Please answer the following question, if you have answered Yes to Project Details:Q6", "And", "IQA0005", "IQA0006" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 2,
                columns: new[] { "Condition", "Description", "Operator", "ParentQuestionId", "QuestionId" },
                values: new object[] { "{\"Comparison\":\"=\",\"OptionsCountOperator\":\"=\",\"ParentOptionsCount\":1,\"ParentOptions\":[\"OPT0004\"]}", "Please answer the following question, if you have answered Yes to Project Scope:Q3", "And", "IQA0014", "IQA0017" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 3,
                columns: new[] { "Condition", "Description", "Operator", "ParentQuestionId", "QuestionId" },
                values: new object[] { "{\"Comparison\":\"=\",\"OptionsCountOperator\":\"=\",\"ParentOptionsCount\":1,\"ParentOptions\":[\"OPT0004\"]}", "Please answer the following question, if you have answered Yes to Project Scope:Q4", "And", "IQA0017", "IQA0018" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 4,
                columns: new[] { "Condition", "Description", "Operator", "ParentQuestionId", "QuestionId" },
                values: new object[] { "{\"Comparison\":\"=\",\"OptionsCountOperator\":\"=\",\"ParentOptionsCount\":1,\"ParentOptions\":[\"OPT0004\"]}", "Please answer the following question, if you have answered Yes to Project Scope:Q4", "And", "IQA0017", "IQA03282" });
        }
    }
}

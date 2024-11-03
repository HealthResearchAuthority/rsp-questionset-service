using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateComplexRulesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 1,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,100\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Short project title should be between the specified characters limit\"}]", "Provide project title between 15 and 100 characters" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 2,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,2000\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Full project title should be between the specified characters limit\"}]", "Provide full project title between 15 and 2000 characters" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 3,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Provide a valid email address\"},{\"Mode\":\"AND\",\"Operator\":\"REGEX\",\"Value\":\"^(?=.{6,50}$)[\\\\w\\\\.\\\\-]\\u002B@[a-zA-Z\\\\d\\\\-]\\u002B\\\\.[a-zA-Z]{2,}$\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Should be a valid email address between 6 and 50 characters \"}]", "Answer the following question, if you have answered Yes to Project Details:Q6" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 4,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\",\"OPT0009\",\"OPT0013\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers Project Scope:Q2, the following question should be answered" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 5,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Answer the following question, if you have answered Yes to Q3 under Project Scope" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 6,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers Project Scope:Q2, the following question should be answered" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 7,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", " or if you have answered No to Project Scope:Q3" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 8,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q4" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 9,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q4a" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 10,
                columns: new[] { "Conditions", "Description", "ParentQuestionId" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "IQA0061" });

            migrationBuilder.InsertData(
                table: "QuestionRules",
                columns: new[] { "RuleId", "Conditions", "Description", "Mode", "ParentQuestionId", "QuestionId", "Sequence" },
                values: new object[,]
                {
                    { 11, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", " and if you have answered No to Project Scope:Q3", "AND", "IQA0014", "IQA0020", 2 },
                    { 12, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", " or if you have answered No to Project Scope:Q4", "OR", "IQA0017", "IQA0020", 3 },
                    { 13, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0012\",\"OPT0013\"],\"OptionType\":\"Multiple\",\"Description\":\"Select an option\"},{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\",\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0021", 1 },
                    { 14, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\",\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0022", 1 },
                    { 15, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0024", 1 },
                    { 16, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0025", 1 },
                    { 17, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0026", 1 },
                    { 18, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0017\"],\"OptionType\":\"Single\",\"Description\":\"Select at least one option\"}]", "Answer the following question, if you have answered Multi-national to Research location:Q1", "AND", "IQA0142", "IQA0143", 1 },
                    { 19, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select at least one option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q3", "AND", "IQA0014", "IQA0033", 1 },
                    { 20, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select at least one option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q3", "AND", "IQA0014", "IQA0034", 1 },
                    { 21, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0033\"],\"OptionType\":\"Single\",\"Description\":\"Provide an answer to this question\"},{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,2000\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Should be between 100 and 2000 characters\"}]", "Answer the following question, if you have answered Other to Research Location:Q4", "AND", "IQA0144", "IQA0145", 1 },
                    { 22, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select one option\"}]", "Answer the following question, if you have answered No to Project Scope:Q3", "AND", "IQA0014", "IQA0146", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 1,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,100\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null}]", "Short project title should be between 15 and 100 characters" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 2,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,2000\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null}]", "Full project title should be between 15 and 2000 characters" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 3,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Project Details:Q6" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 4,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0008\",\"OPT0009\",\"OPT0013\"],\"OptionType\":\"Single\"}]", "Based on your answers to Q2 under Project Scope, the following question should be answered" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 5,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Q3 under Project Scope" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 6,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0009\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have selected any of these options under Project Scope: Q2, " });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 7,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "or if you have answered Yes to Project Scope:Q3" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 8,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Q4 under Project Scope" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 9,
                columns: new[] { "Conditions", "Description" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Q4a under Project Scope" });

            migrationBuilder.UpdateData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 10,
                columns: new[] { "Conditions", "Description", "ParentQuestionId" },
                values: new object[] { "[{\"Mode\":\"AND\",\"Operator\":\"EQUAL\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\"}]", "Please answer the following question, if you have answered Yes to Q4a under Project Scope", "IQA0018" });
        }
    }
}

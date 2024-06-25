using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuestionIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0019");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0067");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 28,
                column: "QuestionId",
                value: "IQA03282");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 29,
                column: "QuestionId",
                value: "IQA03282");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 199,
                column: "QuestionId",
                value: "IQA03273");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 200,
                column: "QuestionId",
                value: "IQA03273");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 201,
                column: "QuestionId",
                value: "IQA03273");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 202,
                column: "QuestionId",
                value: "IQA03273");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: ["QuestionId", "Conformance", "DataType", "EndDate", "Heading", "QuestionCategoryId", "QuestionSectionId", "QuestionText", "QuestionType", "StartDate", "Version"],
                values: new object[,]
                {
                    { "IQA03273", "Mandatory", "Checkbox", null, "5", "B", "IQT0008", "What type of questionnaires are you using in this project? Select all that apply:", "Look-up list", null, null },
                    { "IQA03282", "Conditional", "Boolean", null, "4b", "A", "IQT0003", "Does any investigational medicinal product contain genetically modified organisms?", "Boolean", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03273");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03282");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 28,
                column: "QuestionId",
                value: "IQA0019");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 29,
                column: "QuestionId",
                value: "IQA0019");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 199,
                column: "QuestionId",
                value: "IQA0067");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 200,
                column: "QuestionId",
                value: "IQA0067");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 201,
                column: "QuestionId",
                value: "IQA0067");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 202,
                column: "QuestionId",
                value: "IQA0067");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: ["QuestionId", "Conformance", "DataType", "EndDate", "Heading", "QuestionCategoryId", "QuestionSectionId", "QuestionText", "QuestionType", "StartDate", "Version"],
                values: new object[,]
                {
                    { "IQA0019", "Conditional", "Boolean", null, "4b", "A", "IQT0003", "Does any investigational medicinal product contain genetically modified organisms?", "Boolean", null, null },
                    { "IQA0067", "Mandatory", "Checkbox", null, "5", "B", "IQT0008", "What type of questionnaires are you using in this project? Select all that apply:", "Look-up list", null, null }
                });
        }
    }
}
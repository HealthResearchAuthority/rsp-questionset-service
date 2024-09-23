using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDataForMissingAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerOptionId", "EndDate", "QuestionId", "StartDate", "Version" },
                values: new object[,]
                {
                    { 28, "OPT0004", null, "IQA03282", null, null },
                    { 29, "OPT0005", null, "IQA03282", null, null },
                    { 199, "OPT0128", null, "IQA03273", null, null },
                    { 200, "OPT0129", null, "IQA03273", null, null },
                    { 201, "OPT0130", null, "IQA03273", null, null },
                    { 202, "OPT0131", null, "IQA03273", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 202);
        }
    }
}
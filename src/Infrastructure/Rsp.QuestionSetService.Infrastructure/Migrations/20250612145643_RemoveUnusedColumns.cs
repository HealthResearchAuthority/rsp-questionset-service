using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnusedColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "QuestionSections");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "QuestionSections");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "QuestionCategories");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "QuestionCategories");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "AnswerOptions");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "AnswerOptions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "QuestionSections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "QuestionSections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Questions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Questions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "QuestionCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "QuestionCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Answers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Answers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "AnswerOptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "AnswerOptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0001", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0002", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0003", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0004", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0005", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0006", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0007", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0008", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0009", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0010", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0011", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0012", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0013", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0014", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0015", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0016", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0017", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0018", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0019", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0020", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0021", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0022", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0023", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0024", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0025", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0026", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0027", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0028", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0029", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0030", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0031", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0032", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0033", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0034", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0035", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0036", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0037", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0038", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0039", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0040", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0041", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0042", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0043", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0044", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0045", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0046", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0047", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0048", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0049", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0050", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0051", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0052", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0053", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0054", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0055", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0056", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0057", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0058", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0059", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0060", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0061", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0062", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0063", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0064", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0065", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0066", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0067", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0068", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0069", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0070", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0071", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0072", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0073", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0074", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0075", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0076", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0077", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0078", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0079", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0080", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0081", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0082", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0083", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0084", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0085", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0086", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0087", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0088", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0089", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0090", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0091", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0092", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0093", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0094", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0095", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0096", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0097", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0098", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0099", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0100", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0101", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0102", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0103", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0104", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0105", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0106", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0107", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0108", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0109", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0110", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0111", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0112", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0113", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0114", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0115", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0116", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0117", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0118", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0119", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0120", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0121", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0122", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0123", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0124", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0125", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0126", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0127", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0128", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0129", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0130", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0131", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0132", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0133", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0134", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0135", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0136", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0137", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0138", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0139", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0140", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0141", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0142", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0143", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0144", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0145", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0146", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0147", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0148", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0149", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0150", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0151", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0152", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0153", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0154", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0155", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0156", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0157", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0158", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0159", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0160", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0161", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0162", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0163", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0164", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0165", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0166", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0167", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0168", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0169", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0170", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0171", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0172", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0173", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0174", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0175", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0176", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0177", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0178", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0179", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0180", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0181", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0182", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0183", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0184", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0185", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0186", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0187", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0188", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0189", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0190", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0191", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0192", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0193", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0194", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0195", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0196", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0197", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0198", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0199", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0200", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0201", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0202", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0203", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0204", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0205", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0206", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0207", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0208", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0209", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0210", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0211", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0212", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0213", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0214", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0215", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0216", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0217", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0218", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0219", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0220", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0221", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0222", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0223", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0224", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0225", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0226", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0227", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0228", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0229", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0230", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0231", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0232", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0233", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0234", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0235", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0236", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0237", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0238", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0239", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0240", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0241", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0242", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0243", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0244", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0245", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0246", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0247", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0248", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0249", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0250", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0251", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0252", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0253", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0254", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0255", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0256", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0257", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0258", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0259", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0260", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0261", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0262", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0263", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0264", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0265", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0266", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0267", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0268", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0269", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0270", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0271", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0272", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0273", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0274", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0275", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0276", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0277", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0278", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0279", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0280", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0281", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0282", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0283", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0284", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0285", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0286", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0287", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0288", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0289", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0290", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0291", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0292", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0293", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0294", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0295", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0296", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0297", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0298", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0299", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0300", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0301", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0302", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0303", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0304", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0305", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0306", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0307", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0308", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0309", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0310", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0311", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0312", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0313", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0314", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0315", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0316", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyValues: new object[] { "OPT0317", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 1, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 2, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 3, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 4, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 5, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 6, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 7, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 8, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 9, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 10, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 11, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 12, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 13, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 14, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 15, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 16, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 17, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 18, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 19, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 20, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 21, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 22, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 23, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 24, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 25, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 26, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 27, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 28, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 29, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 30, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 31, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 32, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 33, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 34, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 35, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 36, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 37, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 38, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 39, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 40, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 41, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 42, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 43, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 44, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 45, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 46, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 47, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 48, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 49, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 51, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 52, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 53, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 54, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 55, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 56, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 57, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 58, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 59, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 60, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 61, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 62, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 63, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 64, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 65, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 66, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 67, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 68, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 69, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 70, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 71, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 72, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 73, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 74, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 75, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 76, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 77, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 78, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 79, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 80, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 81, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 82, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 83, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 84, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 85, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 86, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 87, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 88, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 89, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 90, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 91, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 92, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 93, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 94, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 95, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 96, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 97, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 98, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 99, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 100, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 101, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 102, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 103, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 104, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 105, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 106, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 107, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 108, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 109, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 110, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 111, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 112, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 113, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 114, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 115, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 116, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 117, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 118, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 119, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 120, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 121, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 122, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 123, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 124, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 125, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 126, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 127, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 128, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 129, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 130, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 131, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 132, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 133, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 134, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 135, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 136, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 137, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 138, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 139, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 140, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 141, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 142, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 143, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 144, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 145, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 146, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 147, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 148, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 149, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 150, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 151, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 152, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 153, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 154, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 155, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 156, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 157, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 158, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 159, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 160, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 161, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 162, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 163, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 164, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 165, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 166, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 167, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 168, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 169, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 170, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 171, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 172, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 173, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 174, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 175, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 176, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 177, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 178, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 179, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 180, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 181, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 182, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 183, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 184, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 185, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 186, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 187, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 188, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 189, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 190, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 191, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 192, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 193, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 194, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 195, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 196, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 197, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 198, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 199, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 200, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 201, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 202, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 203, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 204, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 205, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 206, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 207, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 208, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 209, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 210, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 211, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 212, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 213, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 214, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 215, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 216, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 217, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 218, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 219, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 220, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 221, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 222, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 223, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 224, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 225, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 226, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 227, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 228, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 229, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 230, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 231, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 232, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 233, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 234, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 235, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 236, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 237, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 238, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 239, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 240, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 241, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 242, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 243, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 244, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 245, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 246, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 247, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 248, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 249, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 250, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 251, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 252, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 253, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 254, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 255, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 256, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 257, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 258, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 259, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 260, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 261, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 262, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 263, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 264, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 265, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 266, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 267, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 268, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 269, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 270, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 271, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 272, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 273, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 274, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 275, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 276, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 277, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 278, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 279, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 280, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 281, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 282, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 283, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 284, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 285, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 286, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 287, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 288, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 289, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 290, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 291, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 292, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 293, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 294, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 295, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 296, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 297, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 298, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 299, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 300, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 301, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 302, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 303, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 304, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 305, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 306, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 307, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 308, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 309, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 310, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 311, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 312, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 313, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 314, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 315, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 316, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 317, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 318, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 319, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 320, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 321, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 322, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 323, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 324, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 325, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 326, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 327, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 328, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 329, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 330, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 331, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 332, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 333, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 334, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 335, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 336, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 337, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 338, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 339, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 340, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 341, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 342, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 343, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 344, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 345, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 346, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 347, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 348, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 349, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 350, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 351, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 352, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 353, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 354, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 355, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 356, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 357, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 358, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 359, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 360, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 361, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 362, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 363, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 364, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 365, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 366, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 367, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 368, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 369, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 370, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 371, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 372, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 373, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 374, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 375, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 376, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 377, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 378, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 379, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 380, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 381, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 382, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 383, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 384, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 385, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 386, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 387, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 388, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 389, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 390, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 391, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 392, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 393, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 394, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 395, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 396, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 397, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 398, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 399, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 400, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 401, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 402, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 403, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 404, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 405, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 406, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 407, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 408, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 409, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 410, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 411, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 412, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 413, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 414, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 415, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 416, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 417, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 418, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 419, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 420, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 421, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 422, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 423, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 424, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 425, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 426, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 427, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 428, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 429, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 430, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 431, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 432, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 433, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 434, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 435, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 436, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 437, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 438, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 439, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 440, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 441, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 442, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 443, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 444, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 445, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 446, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 447, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 448, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 449, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 450, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 451, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 452, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 453, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 454, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 455, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 456, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 457, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 458, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 459, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 460, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 461, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 462, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 463, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 464, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 465, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 466, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 467, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 468, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyValues: new object[] { 469, "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "A", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "A", "v2" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "B", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "C1", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "C2", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "C3", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "C4", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "C5", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "C6", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "C7", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "C8", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyValues: new object[] { "D", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0001", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0001", "v2" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0003", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0004", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0005", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0006", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0007", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0008", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0009", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0010", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0011", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0012", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0013", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0014", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0015", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0019", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0020", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0021", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0022", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0022.3", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0023", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0024", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0025", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0053", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0054", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0055", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0056", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyValues: new object[] { "IQT0057", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0001", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0002", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0002", "v2" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0003", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0004", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0005", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0006", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0012", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0014", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0015", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0017", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0018", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0020", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0021", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0022", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0023", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0024", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0025", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0026", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0027", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0028", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0029", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0032", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0033", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0034", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0036", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0037", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0039", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0040", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0042", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0043", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0044", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0045", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0046", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0048", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0049", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0050", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0051", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0052", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0053", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0054", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0055", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0056", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0057", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0058", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0060", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0061", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0062", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0063", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0064", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0065", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0066", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0068", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0070", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0071", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0072", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0073", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0074", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0075", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0076", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0077", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0078", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0079", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0080", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0081", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0082", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0083", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0084", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0085", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0086", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0087", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0088", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0089", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0090", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0091", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0092", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0093", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0095", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0096", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0097", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0098", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0099", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA00D1", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0100", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0102", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0103", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0104", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0105", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0106", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0107", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0108", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0109", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0110", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0111", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0112", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0113", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0114", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0115", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0116", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0117", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0118", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0119", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0120", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0121", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0122", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0123", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0124", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0125", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0126", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0127", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0128", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0129", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0130", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0131", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0132", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0139", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0140", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0142", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0143", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0144", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0145", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0146", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0147", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0148", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0149", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0150", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0151", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0152", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0153", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0154", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0155", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0156", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0157", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0158", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0159", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0162", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0163", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0165", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0166", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0167", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0168", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0169", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0170", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0171", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0172", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0173", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0174", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0175", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0176", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0177", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0178", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0179", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0180", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0181", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0182", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0183", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0184", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0185", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0186", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0187", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0188", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0189", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0190", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0191", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0218", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0219", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0220", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0221", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0222", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0223", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0224", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0225", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0226", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0227", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0228", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0229", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0230", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0231", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0232", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0233", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0234", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0235", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0236", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0237", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0238", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0239", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0240", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0241", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0242", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0243", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0245", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0246", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0247", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0248", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0249", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0250", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0251", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0253", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0254", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0255", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0256", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0257", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0258", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0259", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0260", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0261", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0262", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0263", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0264", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0265", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0266", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0267", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0268", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0269", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0270", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0271", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0272", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0273", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0278", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0279", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0280", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0281", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0282", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0283", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0284", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0285", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0286", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0287", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0288", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0289", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0290", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0291", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0292", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0293", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0294", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0295", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0296", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0297", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0298", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0299", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0300", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0301", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03010", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03011", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03012", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03013", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03014", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03015", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0302", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0303", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0304", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0305", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0306", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0307", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0308", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0309", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03247", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03248", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03249", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03250", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03251", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03252", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03253", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03254", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03255", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03256", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03257", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03258", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03259", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03260", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03261", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03262", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03263", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03264", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03265", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03266", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03271", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03273", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03274", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03275", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03276", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03277", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03278", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03279", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03280", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03281", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03282", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0001", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0002", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0003", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0004", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0005", "v1" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });
        }
    }
}

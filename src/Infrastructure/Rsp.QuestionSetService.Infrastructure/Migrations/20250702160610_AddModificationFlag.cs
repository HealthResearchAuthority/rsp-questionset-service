using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddModificationFlag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsModificationQuestion",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0001", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0002", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0002", "v2" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0003", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0004", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0005", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0006", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0012", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0014", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0015", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0017", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0018", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0020", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0021", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0022", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0023", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0024", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0025", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0026", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0027", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0028", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0029", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0032", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0033", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0034", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0036", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0037", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0039", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0040", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0042", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0043", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0044", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0045", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0046", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0048", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0049", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0050", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0051", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0052", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0053", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0054", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0055", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0056", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0057", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0058", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0060", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0061", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0062", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0063", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0064", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0065", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0066", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0068", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0070", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0071", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0072", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0073", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0074", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0075", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0076", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0077", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0078", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0079", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0080", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0081", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0082", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0083", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0084", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0085", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0086", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0087", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0088", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0089", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0090", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0091", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0092", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0093", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0095", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0096", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0097", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0098", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0099", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA00D1", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0100", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0102", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0103", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0104", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0105", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0106", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0107", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0108", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0109", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0110", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0111", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0112", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0113", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0114", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0115", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0116", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0117", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0118", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0119", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0120", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0121", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0122", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0123", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0124", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0125", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0126", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0127", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0128", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0129", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0130", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0131", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0132", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0139", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0140", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0142", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0143", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0144", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0145", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0146", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0147", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0148", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0149", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0150", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0151", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0152", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0153", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0154", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0155", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0156", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0157", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0158", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0159", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0162", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0163", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0165", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0166", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0167", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0168", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0169", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0170", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0171", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0172", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0173", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0174", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0175", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0176", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0177", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0178", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0179", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0180", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0181", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0182", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0183", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0184", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0185", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0186", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0187", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0188", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0189", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0190", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0191", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0218", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0219", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0220", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0221", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0222", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0223", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0224", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0225", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0226", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0227", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0228", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0229", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0230", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0231", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0232", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0233", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0234", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0235", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0236", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0237", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0238", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0239", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0240", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0241", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0242", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0243", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0245", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0246", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0247", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0248", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0249", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0250", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0251", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0253", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0254", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0255", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0256", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0257", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0258", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0259", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0260", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0261", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0262", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0263", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0264", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0265", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0266", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0267", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0268", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0269", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0270", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0271", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0272", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0273", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0278", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0279", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0280", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0281", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0282", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0283", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0284", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0285", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0286", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0287", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0288", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0289", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0290", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0291", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0292", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0293", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0294", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0295", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0296", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0297", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0298", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0299", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0300", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0301", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03010", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03011", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03012", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03013", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03014", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03015", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0302", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0303", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0304", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0305", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0306", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0307", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0308", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA0309", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03247", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03248", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03249", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03250", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03251", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03252", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03253", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03254", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03255", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03256", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03257", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03258", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03259", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03260", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03261", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03262", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03263", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03264", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03265", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03266", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03271", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03273", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03274", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03275", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03276", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03277", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03278", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03279", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03280", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03281", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQA03282", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0001", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0002", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0003", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0004", "v1" },
                column: "IsModificationQuestion",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyValues: new object[] { "IQG0005", "v1" },
                column: "IsModificationQuestion",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsModificationQuestion",
                table: "Questions");
        }
    }
}

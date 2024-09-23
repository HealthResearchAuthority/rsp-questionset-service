using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRespondentAnswerModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OptionId",
                table: "RespondentAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RespondentAnswers",
                table: "RespondentAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResearchApplications",
                table: "ResearchApplications");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "ResearchApplications");

            migrationBuilder.AlterColumn<string>(
                name: "Response",
                table: "RespondentAnswers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationId",
                table: "RespondentAnswers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "SelectedOptions",
                table: "RespondentAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationId",
                table: "ResearchApplications",
                type: "nvarchar(450)",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResearchApplications",
                table: "ResearchApplications",
                column: "ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RespondentAnswers",
                table: "RespondentAnswers",
                columns: ["RespondentId", "QuestionId", "ApplicationId"]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedOptions",
                table: "RespondentAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RespondentAnswers",
                table: "RespondentAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResearchApplications",
                table: "ResearchApplications");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "ResearchApplications");

            migrationBuilder.AlterColumn<string>(
                name: "Response",
                table: "RespondentAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "RespondentAnswers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "OptionId",
                table: "RespondentAnswers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "ResearchApplications",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResearchApplications",
                table: "ResearchApplications",
                column: "ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RespondentAnswers",
                table: "RespondentAnswers",
                columns: ["RespondentId", "QuestionId", "ApplicationId"]);
        }
    }
}
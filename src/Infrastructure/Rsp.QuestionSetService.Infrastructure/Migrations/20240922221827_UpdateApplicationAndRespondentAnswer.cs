using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApplicationAndRespondentAnswer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
               name: "PK_RespondentAnswers",
               table: "RespondentAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_RespondentAnswers_Respondents_RespondentId",
                table: "RespondentAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Respondents",
                table: "Respondents");

            migrationBuilder.DropColumn(
                name: "RespondentId",
                table: "Respondents");

            migrationBuilder.AddColumn<string>(
                name: "RespondentId",
                table: "Respondents",
                type: "nvarchar(450)",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "RespondentId",
                table: "RespondentAnswers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "RespondentAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "RespondentAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_RespondentAnswers_ApplicationId",
                table: "RespondentAnswers",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_RespondentAnswers_QuestionId",
                table: "RespondentAnswers",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_RespondentAnswers_Questions_QuestionId",
                table: "RespondentAnswers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RespondentAnswers_ResearchApplications_ApplicationId",
                table: "RespondentAnswers",
                column: "ApplicationId",
                principalTable: "ResearchApplications",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Respondents",
                table: "Respondents",
                column: "RespondentId");

            migrationBuilder.AddPrimaryKey(
               name: "PK_RespondentAnswers",
               table: "RespondentAnswers",
               columns: ["RespondentId", "QuestionId", "ApplicationId"]);

            migrationBuilder.AddForeignKey(
                name: "FK_RespondentAnswers_Respondents_RespondentId",
                table: "RespondentAnswers",
                column: "RespondentId",
                principalTable: "Respondents",
                principalColumn: "RespondentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RespondentAnswers",
                table: "RespondentAnswers");

            migrationBuilder.DropForeignKey(
               name: "FK_RespondentAnswers_Respondents_RespondentId",
               table: "RespondentAnswers");

            migrationBuilder.DropPrimaryKey(
               name: "PK_Respondents",
               table: "Respondents");

            migrationBuilder.DropForeignKey(
                name: "FK_RespondentAnswers_Questions_QuestionId",
                table: "RespondentAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_RespondentAnswers_ResearchApplications_ApplicationId",
                table: "RespondentAnswers");

            migrationBuilder.DropIndex(
                name: "IX_RespondentAnswers_ApplicationId",
                table: "RespondentAnswers");

            migrationBuilder.DropIndex(
                name: "IX_RespondentAnswers_QuestionId",
                table: "RespondentAnswers");

            migrationBuilder.DropColumn(
                name: "RespondentId",
                table: "Respondents");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "RespondentAnswers");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "RespondentAnswers");

            migrationBuilder.AddColumn<int>(
                name: "RespondentId",
                table: "Respondents",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "RespondentId",
                table: "RespondentAnswers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Respondents",
                table: "Respondents",
                column: "RespondentId");

            migrationBuilder.AddPrimaryKey(
               name: "PK_RespondentAnswers",
               table: "RespondentAnswers",
               columns: ["RespondentId", "QuestionId", "ApplicationId"]);

            migrationBuilder.AddForeignKey(
                name: "FK_RespondentAnswers_Respondents_RespondentId",
                table: "RespondentAnswers",
                column: "RespondentId",
                principalTable: "Respondents",
                principalColumn: "RespondentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
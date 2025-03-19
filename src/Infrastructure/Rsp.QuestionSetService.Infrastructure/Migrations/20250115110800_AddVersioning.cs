using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVersioning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_AnswerOptions_AnswerOptionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRules_Questions_ParentQuestionId",
                table: "QuestionRules");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRules_Questions_QuestionId",
                table: "QuestionRules");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionCategories_QuestionCategoryId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionSections_QuestionSectionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionSections_QuestionCategories_QuestionCategoryId",
                table: "QuestionSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionSections",
                table: "QuestionSections");

            migrationBuilder.DropIndex(
                name: "IX_QuestionSections_QuestionCategoryId",
                table: "QuestionSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionCategoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionSectionId",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionRules",
                table: "QuestionRules");

            migrationBuilder.DropIndex(
                name: "IX_QuestionRules_ParentQuestionId",
                table: "QuestionRules");

            migrationBuilder.DropIndex(
                name: "IX_QuestionRules_QuestionId",
                table: "QuestionRules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionCategories",
                table: "QuestionCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_AnswerOptionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerOptions",
                table: "AnswerOptions");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0260");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0261");

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 27);

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
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 198);

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

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumn: "RuleId",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0054");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0055");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0056");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0023");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0036");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0037");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0039");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0040");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0043");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0044");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0046");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0048");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0050");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0052");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0053");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0057");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0058");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0060");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0062");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0066");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0071");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0072");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0073");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0074");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0075");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0076");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0078");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0080");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0081");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0082");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0084");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0085");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0086");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0087");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0089");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0090");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0091");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0092");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0099");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA00D1");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0100");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0102");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0103");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0104");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0105");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0106");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0107");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0109");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0110");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0112");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0116");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0117");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0119");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0120");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0122");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0123");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0125");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0127");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0128");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0129");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0130");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0131");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0132");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0139");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0140");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0148");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0149");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0150");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0151");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0152");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0154");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0156");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0158");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0159");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0163");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0166");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0168");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0170");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0171");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0172");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0174");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0175");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0177");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0178");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0180");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0183");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0184");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0185");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0186");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0187");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0188");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0189");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0190");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0191");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0218");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0220");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0221");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0225");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0226");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0227");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0228");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0229");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0230");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0231");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0232");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0233");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0234");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0235");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0236");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0240");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0241");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0242");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0243");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0245");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0247");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0248");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0249");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0250");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0253");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0256");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0259");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0264");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0266");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0269");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0270");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0273");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0278");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0279");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0280");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0281");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0282");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0283");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0284");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0286");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0287");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0288");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0289");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0290");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0291");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0292");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0294");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0295");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0296");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0297");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0298");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0299");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0300");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0301");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03013");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0302");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0304");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0305");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0306");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0307");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0308");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03248");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03249");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03250");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03251");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03252");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03253");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03254");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03255");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03258");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03259");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03260");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03261");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03263");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03264");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03265");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03266");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03274");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03275");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03276");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03279");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03281");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0001");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0002");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0003");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0004");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0005");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0001");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0002");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0003");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0004");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0005");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0006");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0007");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0008");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0009");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0010");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0011");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0012");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0013");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0014");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0015");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0016");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0017");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0018");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0019");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0020");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0021");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0022");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0023");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0024");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0025");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0026");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0027");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0028");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0029");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0030");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0031");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0032");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0033");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0034");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0035");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0036");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0037");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0038");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0039");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0040");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0041");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0042");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0043");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0044");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0045");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0046");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0047");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0048");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0049");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0050");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0051");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0052");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0053");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0054");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0055");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0056");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0057");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0058");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0059");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0060");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0061");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0062");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0063");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0064");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0065");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0066");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0067");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0068");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0069");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0070");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0071");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0072");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0073");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0074");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0075");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0076");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0077");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0078");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0079");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0080");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0081");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0082");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0083");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0084");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0085");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0086");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0087");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0088");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0089");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0090");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0091");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0092");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0093");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0094");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0095");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0096");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0097");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0098");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0099");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0100");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0101");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0102");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0103");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0104");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0105");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0106");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0107");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0108");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0109");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0110");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0111");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0112");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0113");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0114");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0115");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0116");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0117");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0118");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0119");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0120");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0121");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0122");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0123");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0124");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0125");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0126");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0127");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0128");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0129");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0130");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0131");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0132");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0133");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0134");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0135");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0136");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0137");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0138");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0139");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0140");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0141");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0142");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0143");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0144");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0145");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0146");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0147");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0148");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0149");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0150");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0151");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0152");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0153");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0154");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0155");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0156");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0157");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0158");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0159");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0160");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0161");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0162");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0163");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0164");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0165");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0166");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0167");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0168");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0169");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0170");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0171");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0172");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0173");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0174");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0175");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0176");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0177");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0178");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0179");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0180");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0181");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0182");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0183");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0184");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0185");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0186");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0187");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0188");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0189");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0190");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0191");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0192");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0193");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0194");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0195");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0196");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0197");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0198");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0199");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0200");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0201");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0202");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0203");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0204");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0205");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0206");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0207");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0208");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0209");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0210");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0211");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0212");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0213");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0214");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0215");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0216");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0217");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0218");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0219");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0220");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0221");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0222");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0223");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0224");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0225");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0226");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0227");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0228");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0229");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0230");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0231");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0232");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0233");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0234");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0235");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0236");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0237");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0238");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0239");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0240");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0241");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0242");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0243");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0244");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0245");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0246");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0247");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0248");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0249");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0250");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0251");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0252");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0253");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0254");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0255");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0256");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0257");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0258");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0259");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0262");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0263");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0264");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0265");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0266");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0267");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0268");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0269");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0270");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0271");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0272");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0273");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0274");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0275");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0276");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0277");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0278");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0279");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0280");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0281");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0282");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0283");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0284");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0285");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0286");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0287");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0288");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0289");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0290");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0291");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0292");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0293");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0294");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0295");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0296");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0297");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0298");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0299");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0300");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0301");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0302");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0303");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0304");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0305");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0306");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0307");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0308");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0309");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0310");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0311");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0312");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0313");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0314");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0315");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0316");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumn: "OptionId",
                keyValue: "OPT0317");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "C2");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "C3");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "C5");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0005");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0057");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0001");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0002");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0003");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0004");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0005");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0006");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0012");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0014");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0015");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0017");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0018");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0020");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0021");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0022");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0024");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0025");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0026");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0027");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0028");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0029");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0032");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0033");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0034");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0042");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0045");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0049");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0051");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0054");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0055");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0056");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0061");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0063");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0064");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0065");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0068");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0070");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0077");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0079");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0083");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0088");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0093");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0095");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0096");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0097");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0098");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0108");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0111");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0113");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0114");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0115");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0118");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0121");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0124");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0126");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0142");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0143");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0144");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0145");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0146");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0147");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0153");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0155");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0157");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0162");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0165");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0167");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0169");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0173");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0176");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0179");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0181");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0182");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0219");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0222");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0223");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0224");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0237");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0238");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0239");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0246");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0251");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0254");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0255");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0257");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0258");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0260");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0261");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0262");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0263");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0265");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0267");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0268");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0271");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0272");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0285");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0293");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03010");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03011");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03012");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03014");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03015");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0303");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0309");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03247");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03256");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03257");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03262");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03271");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03273");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03277");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03278");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03280");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03282");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "D");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0001");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0003");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0004");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0006");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0007");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0008");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0009");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0010");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0011");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0012");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0013");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0014");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0015");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0019");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0020");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0021");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0022");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0022.3");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0023");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0024");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0025");

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumn: "SectionId",
                keyValue: "IQT0053");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "B");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "C1");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "C4");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "C6");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "C7");

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "CategoryId",
                keyValue: "C8");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "QuestionSections");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "QuestionCategories");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "AnswerOptions");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "RuleId",
                table: "QuestionRules");

            migrationBuilder.AddColumn<string>(
                name: "VersionId",
                table: "QuestionSections",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VersionId",
                table: "Questions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RuleId",
                table: "QuestionRules",
                type: "int",
                nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "QuestionId",
                table: "QuestionRules",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "VersionId",
                table: "QuestionRules",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VersionId",
                table: "QuestionCategories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Answers",
                type: "int",
                nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "VersionId",
                table: "Answers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VersionId",
                table: "AnswerOptions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionSections",
                table: "QuestionSections",
                columns: new[] { "SectionId", "VersionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                columns: new[] { "QuestionId", "VersionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionRules",
                table: "QuestionRules",
                columns: new[] { "RuleId", "VersionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionCategories",
                table: "QuestionCategories",
                columns: new[] { "CategoryId", "VersionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                columns: new[] { "AnswerId", "VersionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerOptions",
                table: "AnswerOptions",
                columns: new[] { "OptionId", "VersionId" });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    VersionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublishedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDraft = table.Column<bool>(type: "bit", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.VersionId);
                });

            migrationBuilder.InsertData(
                table: "Versions",
                columns: new[] { "VersionId", "CreatedAt", "IsDraft", "IsPublished", "PublishedAt", "PublishedBy" },
                values: new object[,]
                {
                    { "v1", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), false, false, new DateTime(2025, 1, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "admin" },
                    { "v2", new DateTime(2025, 1, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AnswerOptions",
                columns: new[] { "OptionId", "VersionId", "EndDate", "OptionText", "StartDate" },
                values: new object[,]
                {
                    { "OPT0001", "v1", null, "Project deputy", null },
                    { "OPT0002", "v1", null, "Chief investigator", null },
                    { "OPT0003", "v1", null, "Sponsor contact", null },
                    { "OPT0004", "v1", null, "Yes", null },
                    { "OPT0005", "v1", null, "No", null },
                    { "OPT0006", "v1", null, "Use of previously collected data about people", null },
                    { "OPT0007", "v1", null, "Use of previously collected human biological samples", null },
                    { "OPT0008", "v1", null, "Research involving staff only", null },
                    { "OPT0009", "v1", null, "Non-clinical activities with staff, such as interviews, questionnaires or observation", null },
                    { "OPT0010", "v1", null, "Non-clinical activities with people (other than staff), such as interviews or surveys", null },
                    { "OPT0011", "v1", null, "Non-clinical activities with people, such as non-clinical assessments, observations or care procedures", null },
                    { "OPT0012", "v1", null, "Clinical activities with people, such as collecting human biological samples, imaging investigations or diagnostics", null },
                    { "OPT0013", "v1", null, "Treatment, such as medicines, devices, surgery, vaccines or therapies", null },
                    { "OPT0014", "v1", null, "clinical trial of an investigational medicinal product", null },
                    { "OPT0015", "v1", null, "combined trial of an investigational medicinal product and an investigational medical device", null },
                    { "OPT0016", "v1", null, "UK only", null },
                    { "OPT0017", "v1", null, "Multi-national", null },
                    { "OPT0018", "v1", null, "England", null },
                    { "OPT0019", "v1", null, "Northern Ireland", null },
                    { "OPT0020", "v1", null, "Scotland", null },
                    { "OPT0021", "v1", null, "Wales", null },
                    { "OPT0022", "v1", null, "Independent primary care contractors", null },
                    { "OPT0023", "v1", null, "Independent research units", null },
                    { "OPT0024", "v1", null, "Local councils", null },
                    { "OPT0025", "v1", null, "NHS or HSC organisations", null },
                    { "OPT0026", "v1", null, "Phase 1 trial units (non-NHS or HSC organisation)", null },
                    { "OPT0027", "v1", null, "Prison or probation setting", null },
                    { "OPT0028", "v1", null, "Schools or other educational establishments", null },
                    { "OPT0029", "v1", null, "Social care settings", null },
                    { "OPT0030", "v1", null, "University", null },
                    { "OPT0031", "v1", null, "Voluntary sector or private organisations", null },
                    { "OPT0032", "v1", null, "Community settings", null },
                    { "OPT0033", "v1", null, "Other", null },
                    { "OPT0034", "v1", null, "Not applicable", null },
                    { "OPT0035", "v1", null, "identifying, developing, or prioritising the research question", null },
                    { "OPT0036", "v1", null, "being a member of a research advisory or reference group", null },
                    { "OPT0037", "v1", null, "being a member of the Trial Management Group or Data Monitoring Committee", null },
                    { "OPT0038", "v1", null, "developing the research methods (for example, designing questionnaires, or defining endpoints or outcome measures)", null },
                    { "OPT0039", "v1", null, "ensuring that the design of the research is feasible from the perspective of the participants (for example, identifying potential emotional or practical obstacles for research participants)", null },
                    { "OPT0040", "v1", null, "designing the inclusion and exclusion criteria including consideration of the demographic diversity of the study population", null },
                    { "OPT0041", "v1", null, "developing the risk or benefit analysis (for example, identifying and evaluating the probable risks and burden involved for research participants)", null },
                    { "OPT0042", "v1", null, "developing the recruitment and consent process (for example, how and when to approach potential participants)", null },
                    { "OPT0043", "v1", null, "developing participant information sheets, the consent forms, and other documents which are used to communicate with potential research participants", null },
                    { "OPT0044", "v1", null, "developing plain language research summaries", null },
                    { "OPT0045", "v1", null, "developing or delivering training to staff", null },
                    { "OPT0046", "v1", null, "developing the dissemination plan for the research", null },
                    { "OPT0047", "v1", null, "preparing regulatory submissions", null },
                    { "OPT0048", "v1", null, "planning to attend the Research Ethics Committee meetings to help explain how and why the research design is likely to be acceptable to research participants", null },
                    { "OPT0049", "v1", null, "patients, service users or their carers, or members of the public have not been involved", null },
                    { "OPT0050", "v1", null, "we have existing arrangements in our organisation or team for involving patients, carers, service users or members of the public", null },
                    { "OPT0051", "v1", null, "we asked an existing patient and public involvement group external to our organisation or team (for example, run by an NHS Trust, university, charity, local councils)", null },
                    { "OPT0052", "v1", null, "we set up a new arrangement to involve patients, carers, service users or members of the public in our project (for example, posted the opportunity on the People in Research website, local noticeboards, or through a community organisation)", null },
                    { "OPT0053", "v1", null, "we were approached by some patients, carers, service users, a patient group, or a charity with a suggestion for this research and we have worked with them to develop it", null },
                    { "OPT0054", "v1", null, "being a member of research advisory or reference group", null },
                    { "OPT0055", "v1", null, "helping to promote this research", null },
                    { "OPT0056", "v1", null, "carrying out research activities (for example, facilitating focus groups, interviewing or administering questionnaires)", null },
                    { "OPT0057", "v1", null, "analysing the research findings", null },
                    { "OPT0058", "v1", null, "contributing to further regulatory submissions (such as amendments)", null },
                    { "OPT0059", "v1", null, "sharing research results (for example, by presenting at conferences or disseminating the research findings via social media)", null },
                    { "OPT0060", "v1", null, "developing plain language summaries of the results", null },
                    { "OPT0061", "v1", null, "there is no plan to involve public contributors in the remaining stages of the research process", null },
                    { "OPT0062", "v1", null, "case series or case note review", null },
                    { "OPT0063", "v1", null, "case control", null },
                    { "OPT0064", "v1", null, "cohort observation", null },
                    { "OPT0065", "v1", null, "controlled trial without randomisation", null },
                    { "OPT0066", "v1", null, "cross-sectional study", null },
                    { "OPT0067", "v1", null, "database analysis", null },
                    { "OPT0068", "v1", null, "epidemiology", null },
                    { "OPT0069", "v1", null, "feasibility or pilot study", null },
                    { "OPT0070", "v1", null, "laboratory study", null },
                    { "OPT0071", "v1", null, "metanalysis", null },
                    { "OPT0072", "v1", null, "qualitative research", null },
                    { "OPT0073", "v1", null, "questionnaire, interview or observation study", null },
                    { "OPT0074", "v1", null, "randomised controlled trial", null },
                    { "OPT0075", "v1", null, "basket trial", null },
                    { "OPT0076", "v1", null, "bayesian", null },
                    { "OPT0077", "v1", null, "blinded", null },
                    { "OPT0078", "v1", null, "cluster-randomised", null },
                    { "OPT0079", "v1", null, "comparative", null },
                    { "OPT0080", "v1", null, "cross-over", null },
                    { "OPT0081", "v1", null, "double-blinded", null },
                    { "OPT0082", "v1", null, "open", null },
                    { "OPT0083", "v1", null, "other complex or innovative design", null },
                    { "OPT0084", "v1", null, "parallel arms", null },
                    { "OPT0085", "v1", null, "platform trial", null },
                    { "OPT0086", "v1", null, "real-world", null },
                    { "OPT0087", "v1", null, "targeted or stratified", null },
                    { "OPT0088", "v1", null, "umbrella trial", null },
                    { "OPT0089", "v1", null, "designing, developing or testing an AI product or tool", null },
                    { "OPT0090", "v1", null, "using an existing AI product or tool for its intended purpose", null },
                    { "OPT0091", "v1", null, "the project does not involve the use of AI", null },
                    { "OPT0092", "v1", null, "image analysis", null },
                    { "OPT0093", "v1", null, "other machine learning applications", null },
                    { "OPT0094", "v1", null, "natural language processing", null },
                    { "OPT0095", "v1", null, "generative AI or large language models", null },
                    { "OPT0096", "v1", null, "robotics", null },
                    { "OPT0097", "v1", null, "blood", null },
                    { "OPT0098", "v1", null, "cancer and neoplasms", null },
                    { "OPT0099", "v1", null, "cardiovascular", null },
                    { "OPT0100", "v1", null, "congenital disorders", null },
                    { "OPT0101", "v1", null, "ear", null },
                    { "OPT0102", "v1", null, "eye", null },
                    { "OPT0103", "v1", null, "infection", null },
                    { "OPT0104", "v1", null, "inflammatory and immune system", null },
                    { "OPT0105", "v1", null, "injuries and accidents", null },
                    { "OPT0106", "v1", null, "mental health", null },
                    { "OPT0107", "v1", null, "metabolic and endocrine", null },
                    { "OPT0108", "v1", null, "musculoskeletal", null },
                    { "OPT0109", "v1", null, "neurological", null },
                    { "OPT0110", "v1", null, "oral and gastrointestinal", null },
                    { "OPT0111", "v1", null, "renal and urogenital", null },
                    { "OPT0112", "v1", null, "reproductive health and childbirth", null },
                    { "OPT0113", "v1", null, "respiratory", null },
                    { "OPT0114", "v1", null, "skin", null },
                    { "OPT0115", "v1", null, "stroke", null },
                    { "OPT0116", "v1", null, "generic health relevance", null },
                    { "OPT0117", "v1", null, "disputed aetiology and other", null },
                    { "OPT0118", "v1", null, "Carers, parents or legal guardians of patients or participants", null },
                    { "OPT0119", "v1", null, "Healthy volunteers or controls", null },
                    { "OPT0120", "v1", null, "Members of the public", null },
                    { "OPT0121", "v1", null, "Patients or service users of NHS or HSC provided or commissioned services", null },
                    { "OPT0122", "v1", null, "Patients in nursing homes or independent health care clinics in Northern Ireland", null },
                    { "OPT0123", "v1", null, "People who are known to be deceased prior to the project starting", null },
                    { "OPT0124", "v1", null, "Residents in residential care homes in Northern Ireland", null },
                    { "OPT0125", "v1", null, "Residents in nursing homes, care homes or residential care in England, Scotland or Wales", null },
                    { "OPT0126", "v1", null, "Service users in other social care settings", null },
                    { "OPT0127", "v1", null, "Staff working in NHS or HSC provided or commissioned services", null },
                    { "OPT0128", "v1", null, "use of validated questionnaires within their intended purpose and intended population", null },
                    { "OPT0129", "v1", null, "use of validated questionnaires outside of their intended purpose and population", null },
                    { "OPT0130", "v1", null, "use of non-validated questionnaires", null },
                    { "OPT0131", "v1", null, "no questionnaires included in project", null },
                    { "OPT0132", "v1", null, "Treatment will continue to be provided once the project has finished", null },
                    { "OPT0133", "v1", null, "Treatment will not continue to be provided once the project has finished", null },
                    { "OPT0134", "v1", null, "only adults with capacity to consent for themselves as participants", null },
                    { "OPT0135", "v1", null, "only adults lacking capacity to consent for themselves", null },
                    { "OPT0136", "v1", null, "both adults with capacity and lacking capacity to consent for themselves", null },
                    { "OPT0137", "v1", null, "Consent will be obtained from all participants\n", null },
                    { "OPT0138", "v1", null, "Consent will not be obtained from any participants", null },
                    { "OPT0139", "v1", null, "Consent will not be obtained in some situations", null },
                    { "OPT0140", "v1", null, "Consent will not be obtained for the use of non-identifiable data or samples", null },
                    { "OPT0141", "v1", null, "Consent will not be obtained for access to data by the usual care team", null },
                    { "OPT0142", "v1", null, "The participant would be withdrawn from the project. Identifiable data or tissue already collected with consent would be retained and used. No further data or tissue would be collected or any other research procedures carried out on or in relation to the participant.", null },
                    { "OPT0143", "v1", null, "The participant would continue to be included in the project.", null },
                    { "OPT0144", "v1", null, "Not applicable - informed consent will not be sought from any participants in this project.", null },
                    { "OPT0145", "v1", null, "East Midlands - Derby", null },
                    { "OPT0146", "v1", null, "East Midlands - Leicester Central", null },
                    { "OPT0147", "v1", null, "East Midlands - Leicester South", null },
                    { "OPT0148", "v1", null, "East Midlands - Nottingham 1", null },
                    { "OPT0149", "v1", null, "East Midlands - Nottingham 2", null },
                    { "OPT0150", "v1", null, "East of England - Cambridgeshire and Hertfordshire", null },
                    { "OPT0151", "v1", null, "East of England - Essex", null },
                    { "OPT0152", "v1", null, "East of England - Cambridge Central", null },
                    { "OPT0153", "v1", null, "East of England - Cambridge East", null },
                    { "OPT0154", "v1", null, "East of England - Cambridge South", null },
                    { "OPT0155", "v1", null, "East of Scotland Research Ethics Service REC 1", null },
                    { "OPT0156", "v1", null, "East of Scotland Research Ethics Service REC 2", null },
                    { "OPT0157", "v1", null, "Health and Social Care Research Ethics Committee A (HSC REC A)", null },
                    { "OPT0158", "v1", null, "Health and Social Care Research Ethics Committee B (HSC REC B)", null },
                    { "OPT0159", "v1", null, "London - Bloomsbury", null },
                    { "OPT0160", "v1", null, "London - Camden and Kings Cross", null },
                    { "OPT0161", "v1", null, "London - Central", null },
                    { "OPT0162", "v1", null, "London - Brent", null },
                    { "OPT0163", "v1", null, "London - Brighton and Sussex", null },
                    { "OPT0164", "v1", null, "London - Bromley", null },
                    { "OPT0165", "v1", null, "London - Camberwell St Giles", null },
                    { "OPT0166", "v1", null, "London - Chelsea", null },
                    { "OPT0167", "v1", null, "London - City and East", null },
                    { "OPT0168", "v1", null, "London - Dulwich", null },
                    { "OPT0169", "v1", null, "London - Fulham", null },
                    { "OPT0170", "v1", null, "London - Hampstead", null },
                    { "OPT0171", "v1", null, "London - Harrow", null },
                    { "OPT0172", "v1", null, "London - London Bridge", null },
                    { "OPT0173", "v1", null, "London - Queen Square", null },
                    { "OPT0174", "v1", null, "London - Riverside", null },
                    { "OPT0175", "v1", null, "London - South East", null },
                    { "OPT0176", "v1", null, "London - Stanmore", null },
                    { "OPT0177", "v1", null, "London - Surrey", null },
                    { "OPT0178", "v1", null, "London - Surrey Borders", null },
                    { "OPT0179", "v1", null, "London - West London & GTAC", null },
                    { "OPT0180", "v1", null, "London - Westminster", null },
                    { "OPT0181", "v1", null, "Social Care Research Ethics Committee", null },
                    { "OPT0182", "v1", null, "North East - Newcastle and North Tyneside 1", null },
                    { "OPT0183", "v1", null, "North East - Newcastle and North Tyneside 2", null },
                    { "OPT0184", "v1", null, "North East - Tyne & Wear South", null },
                    { "OPT0185", "v1", null, "North East - York", null },
                    { "OPT0186", "v1", null, "North of Scotland Research Ethics Committee 1", null },
                    { "OPT0187", "v1", null, "North of Scotland Research Ethics Committee 2", null },
                    { "OPT0188", "v1", null, "North West - Greater Manchester (GM) Central", null },
                    { "OPT0189", "v1", null, "North West - Greater Manchester (GM) East", null },
                    { "OPT0190", "v1", null, "North West - Greater Manchester (GM) South", null },
                    { "OPT0191", "v1", null, "North West - Greater Manchester (GM) West", null },
                    { "OPT0192", "v1", null, "North West - Haydock", null },
                    { "OPT0193", "v1", null, "North West - Liverpool Central", null },
                    { "OPT0194", "v1", null, "North West - Liverpool East", null },
                    { "OPT0195", "v1", null, "North West - Preston", null },
                    { "OPT0196", "v1", null, "Scotland A Research Ethics Committee", null },
                    { "OPT0197", "v1", null, "South Central - Berkshire B", null },
                    { "OPT0198", "v1", null, "South Central - Hampshire A", null },
                    { "OPT0199", "v1", null, "South Central - Hampshire B", null },
                    { "OPT0200", "v1", null, "South Central - Berkshire", null },
                    { "OPT0201", "v1", null, "South Central - Oxford A", null },
                    { "OPT0202", "v1", null, "South Central - Oxford B", null },
                    { "OPT0203", "v1", null, "South Central - Oxford C", null },
                    { "OPT0204", "v1", null, "South East Scotland Research Ethics Committee 1", null },
                    { "OPT0205", "v1", null, "South East Scotland Research Ethics Committee 2", null },
                    { "OPT0206", "v1", null, "South West - Central Bristol", null },
                    { "OPT0207", "v1", null, "South West - Cornwall and Plymouth", null },
                    { "OPT0208", "v1", null, "South West - Exeter", null },
                    { "OPT0209", "v1", null, "South West - Frenchay", null },
                    { "OPT0210", "v1", null, "Wales REC 1", null },
                    { "OPT0211", "v1", null, "Wales REC 2", null },
                    { "OPT0212", "v1", null, "Wales REC 3", null },
                    { "OPT0213", "v1", null, "Wales REC 4", null },
                    { "OPT0214", "v1", null, "Wales REC 5", null },
                    { "OPT0215", "v1", null, "Wales REC 6", null },
                    { "OPT0216", "v1", null, "Wales REC 7", null },
                    { "OPT0217", "v1", null, "West Midlands - Edgbaston", null },
                    { "OPT0218", "v1", null, "West Midlands - Coventry and Warwickshire", null },
                    { "OPT0219", "v1", null, "West Midlands - Solihull", null },
                    { "OPT0220", "v1", null, "West Midlands - South Birmingham", null },
                    { "OPT0221", "v1", null, "West Midlands - The Black Country", null },
                    { "OPT0222", "v1", null, "West of Scotland REC 1", null },
                    { "OPT0223", "v1", null, "West of Scotland REC 3", null },
                    { "OPT0224", "v1", null, "West of Scotland REC 4", null },
                    { "OPT0225", "v1", null, "West of Scotland REC 5", null },
                    { "OPT0226", "v1", null, "Yorkshire and the Humber - Bradford Leeds", null },
                    { "OPT0227", "v1", null, "Yorkshire and the Humber - Leeds East", null },
                    { "OPT0228", "v1", null, "Yorkshire and the Humber - Leeds West", null },
                    { "OPT0229", "v1", null, "Yorkshire and the Humber - Sheffield", null },
                    { "OPT0230", "v1", null, "Yorkshire and the Humber - South Yorkshire", null },
                    { "OPT0231", "v1", null, "has previously received an unfavourable opinion by a REC in the UK", null },
                    { "OPT0232", "v1", null, "has previously received an unfavourable opinion by a REC in another country", null },
                    { "OPT0233", "v1", null, "linked to another project", null },
                    { "OPT0234", "v1", null, "none of the above", null },
                    { "OPT0235", "v1", null, "Independent external review", null },
                    { "OPT0236", "v1", null, "Review within a company", null },
                    { "OPT0237", "v1", null, "Review within a multi−centre research group", null },
                    { "OPT0238", "v1", null, "Review within the Chief Investigator's institution or host organisation", null },
                    { "OPT0239", "v1", null, "Review within the research team", null },
                    { "OPT0240", "v1", null, "Review by educational supervisor", null },
                    { "OPT0241", "v1", null, "Qualititative", null },
                    { "OPT0242", "v1", null, "Quantitative", null },
                    { "OPT0243", "v1", null, "Review by independent statistician commissioned by funder or sponsor", null },
                    { "OPT0244", "v1", null, "Other review by independent statistician", null },
                    { "OPT0245", "v1", null, "Review by company statistician", null },
                    { "OPT0246", "v1", null, "Review by a statistician within the Chief Investigator’s institution", null },
                    { "OPT0247", "v1", null, "Review by a statistician within the research team or multi−centre group", null },
                    { "OPT0248", "v1", null, "Other review by individual with relevant statistical expertise", null },
                    { "OPT0249", "v1", null, "No review necessary as only frequencies and associations will be assessed", null },
                    { "OPT0250", "v1", null, "Remote monitoring by sponsor or delegate", null },
                    { "OPT0251", "v1", null, "Self-monitoring by site", null },
                    { "OPT0252", "v1", null, "On-site monitoring by sponsor or delegate", null },
                    { "OPT0253", "v1", null, "No deferral requested", null },
                    { "OPT0254", "v1", null, "I request a deferral of registration and research summary publication - for protection of commercially confidential information", null },
                    { "OPT0255", "v1", null, "I request a deferral of registration and research summary publication - other reason", null },
                    { "OPT0256", "v1", null, "The project will be registered in a registry", null },
                    { "OPT0257", "v1", null, "Other arrangements are in place", null },
                    { "OPT0258", "v1", null, "ISRCTN", null },
                    { "OPT0259", "v1", null, "Clinicaltrials.gov", null },
                    { "OPT0260", "v1", null, "I request a deferral of research summary publication - for protection of commercially confidential information", null },
                    { "OPT0261", "v1", null, "I request deferral of research summary publication - other reason", null },
                    { "OPT0262", "v1", null, "Peer reviewed scientific journals", null },
                    { "OPT0263", "v1", null, "Internal report", null },
                    { "OPT0264", "v1", null, "Conference presentation", null },
                    { "OPT0265", "v1", null, "Publication on website", null },
                    { "OPT0266", "v1", null, "Other publication", null },
                    { "OPT0267", "v1", null, "Submission to regulatory authorities", null },
                    { "OPT0268", "v1", null, "Access to raw data and right to publish freely by all investigators in study or by Independent Steering Committee on behalf of all investigators", null },
                    { "OPT0269", "v1", null, "No plans to report or disseminate the results", null },
                    { "OPT0270", "v1", null, "Undergraduate or below", null },
                    { "OPT0271", "v1", null, "Masters or equivalent", null },
                    { "OPT0272", "v1", null, "Doctoral or equivalent", null },
                    { "OPT0273", "v1", null, "Eligible and Supplementary Declaration A included", null },
                    { "OPT0274", "v1", null, "Eligible and Supplementary Declaration B included", null },
                    { "OPT0275", "v1", null, "Eligible and Supplementary Declaration C included", null },
                    { "OPT0276", "v1", null, "Academic supervisor\n", null },
                    { "OPT0277", "v1", null, "Student", null },
                    { "OPT0278", "v1", null, "Clinical investigation for UKCA/CE UKNI/CE marking purposes (includes investigation of a UKCA/CE UKNI/CE marked device outside its current intended purposes or in modified form)", null },
                    { "OPT0279", "v1", null, "Combined clinical investigation for UKCA/CE UKNI/CE marking purposes and clinical trial of an investigational medicinal product", null },
                    { "OPT0280", "v1", null, "Post-market clinical study of one or more UKCA/CE UKNI/CE marked devices within intended purposes, involving a change to standard care or randomisation between groups", null },
                    { "OPT0281", "v1", null, "Registry of a UKCA/CE UKNI/CE marked device in clinical use, involving no change to standard care or randomisation", null },
                    { "OPT0282", "v1", null, "Performance evaluation of an in vitro diagnostic device (PEIVDD)", null },
                    { "OPT0283", "v1", null, "Clinical study of a non-UKCA/CE UKNI/CE marked device", null },
                    { "OPT0284", "v1", null, "Clinical study of a non-UKCA/CE UKNI/CE marked device for use within the institution, where commercialisation is not intended", null },
                    { "OPT0285", "v1", null, "Clinical study of one or more UKCA/CE UKNI/CE marked devices for an off-label indication", null },
                    { "OPT0286", "v1", null, "Clinical study of one or more UKCA/CE UKNI/CE marked devices for a labelled indication, involving a change to standard care or randomisation between groups", null },
                    { "OPT0287", "v1", null, "Clinical study of one or more UKCA/CE UKNI/CE marked devices for a labelled indication, involving no change to standard care or randomisation between groups", null },
                    { "OPT0288", "v1", null, "Pre-clinical device development or performance testing", null },
                    { "OPT0289", "v1", null, "MHRA and REC", null },
                    { "OPT0290", "v1", null, "REC only", null },
                    { "OPT0291", "v1", null, "Investigation of a new medical device", null },
                    { "OPT0292", "v1", null, "Investigation of a new implantable material", null },
                    { "OPT0293", "v1", null, "Use of an existing product outside the terms of its UKCA/CE marked intended purpose", null },
                    { "OPT0294", "v1", null, "Use of a modified product", null },
                    { "OPT0295", "v1", null, "Use of an existing product within its UKCA/CE UKNI/CE intended purpose.", null },
                    { "OPT0296", "v1", null, "Living", null },
                    { "OPT0297", "v1", null, "Deceased", null },
                    { "OPT0298", "v1", null, "Study-specific arrangements", null },
                    { "OPT0299", "v1", null, "In line with normal clinical arrangements for the organisation", null },
                    { "OPT0300", "v1", null, "Transfer to research tissue bank", null },
                    { "OPT0301", "v1", null, "Storage by research team pending ethical approval for use in another project", null },
                    { "OPT0302", "v1", null, "Storage by research team as part of a new research tissue bank", null },
                    { "OPT0303", "v1", null, "Storage by research team of biological material which is not “relevant material” for the purposes of the Human Tissue Act", null },
                    { "OPT0304", "v1", null, "Disposal in accordance with the Human Tissue Authority’s Code of Practice", null },
                    { "OPT0305", "v1", null, "Not yet known", null },
                    { "OPT0306", "v1", null, "Potential to benefit the participant without imposing a disproportionate burden", null },
                    { "OPT0307", "v1", null, "Provide knowledge of the causes of, or treatment or care of others with, the same or a similar condition", null },
                    { "OPT0308", "v1", null, "In utero", null },
                    { "OPT0309", "v1", null, "Preterm newborn infants (up to gestational age less than 37 weeks)", null },
                    { "OPT0310", "v1", null, "Newborn (0 to 27 days)", null },
                    { "OPT0311", "v1", null, "28 days to 23 months", null },
                    { "OPT0312", "v1", null, "2 to 11 years", null },
                    { "OPT0313", "v1", null, "12 to 17 years", null },
                    { "OPT0314", "v1", null, "12 to 15 years", null },
                    { "OPT0315", "v1", null, "16 years", null },
                    { "OPT0316", "v1", null, "Children who will be unable to fully understand", null },
                    { "OPT0317", "v1", null, "Children who will be able to understand", null }
                });

            migrationBuilder.InsertData(
                table: "QuestionCategories",
                columns: new[] { "CategoryId", "VersionId", "CategoryName", "EndDate", "IsActive", "StartDate" },
                values: new object[,]
                {
                    { "A", "v1", "Project Filter", null, true, null },
                    { "A", "v2", "Project Filter v2", null, true, null },
                    { "B", "v1", "Project Details", null, true, null },
                    { "C1", "v1", "Student", null, true, null },
                    { "C2", "v1", "Research Bioresouces", null, true, null },
                    { "C3", "v1", "CTIMP", null, true, null },
                    { "C4", "v1", "Devices", null, true, null },
                    { "C5", "v1", "Ionising Radiation", null, true, null },
                    { "C6", "v1", "Tissue", null, true, null },
                    { "C7", "v1", "Adults lacking capacity (ALC)", null, true, null },
                    { "C8", "v1", "Children", null, true, null },
                    { "D", "v1", "Booking", null, true, null }
                });

            migrationBuilder.InsertData(
                table: "QuestionRules",
                columns: new[] { "RuleId", "VersionId", "Conditions", "Description", "Mode", "ParentQuestionId", "QuestionId", "Sequence" },
                values: new object[,]
                {
                    { 1, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,100\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Short project title should be between the specified characters limit\"}]", "Provide project title between 15 and 100 characters", "AND", null, "IQA0002", 1 },
                    { 2, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,2000\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Full project title should be between the specified characters limit\"}]", "Provide full project title between 15 and 2000 characters", "AND", null, "IQA0003", 1 }
                });

            migrationBuilder.InsertData(
                table: "QuestionSections",
                columns: new[] { "SectionId", "VersionId", "EndDate", "IsActive", "QuestionCategoryId", "SectionName", "StartDate" },
                values: new object[,]
                {
                    { "IQT0001", "v1", null, true, "A", "Project Details", null },
                    { "IQT0001", "v2", null, true, "A", "Project Details", null },
                    { "IQT0003", "v1", null, true, "A", "Project Scope", null },
                    { "IQT0004", "v1", null, true, "A", "Research Location", null },
                    { "IQT0005", "v1", null, true, "B", "Project Information", null },
                    { "IQT0006", "v1", null, true, "B", "Public Involvement", null },
                    { "IQT0007", "v1", null, true, "B", "Research Design and Methodology", null },
                    { "IQT0008", "v1", null, true, "B", "Research Activities", null },
                    { "IQT0009", "v1", null, true, "B", "Participants", null },
                    { "IQT0010", "v1", null, true, "B", "Consent", null },
                    { "IQT0011", "v1", null, true, "B", "Risk and Conflicts of Interest", null },
                    { "IQT0012", "v1", null, true, "B", "Summary Ethical Issues", null },
                    { "IQT0013", "v1", null, true, "B", "Research Analysis", null },
                    { "IQT0014", "v1", null, true, "B", "Governance and Management", null },
                    { "IQT0015", "v1", null, true, "B", "Transparency", null },
                    { "IQT0019", "v1", null, true, "C1", "Educational Project", null },
                    { "IQT0020", "v1", null, true, "C8", "Children", null },
                    { "IQT0021", "v1", null, true, "B", "Confidentiality and Information Governance", null },
                    { "IQT0022", "v1", null, true, "C6", "Human Biological Samples", null },
                    { "IQT0022.3", "v1", null, true, "C6", "Health-related findings", null },
                    { "IQT0023", "v1", null, true, "C7", "Adults Lacking Capacity (CTIMP)", null },
                    { "IQT0024", "v1", null, true, "C7", "Adults Lacking Capacity (Non CTIMP)", null },
                    { "IQT0025", "v1", null, true, "C4", "Devices Filter Questions", null },
                    { "IQT0053", "v1", null, true, "C4", "Device investigations not requiring review by MHRA", null },
                    { "IQT0054", "v1", null, true, "C2", "Research Bioresource", null },
                    { "IQT0055", "v1", null, true, "C3", "CTIMP", null },
                    { "IQT0056", "v1", null, true, "C5", "Ionising Radiation", null },
                    { "IQT0057", "v1", null, true, "D", "Application Booking", null }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "VersionId", "Conformance", "DataType", "DeletedAt", "EndDate", "Heading", "IsDeleted", "QuestionCategoryId", "QuestionSectionId", "QuestionText", "QuestionType", "Sequence", "StartDate" },
                values: new object[,]
                {
                    { "IQA0001", "v1", "Mandatory", "TBC", null, null, "2", false, "A", "IQT0001", "Identify your role", "Look-up list", 2, null },
                    { "IQA0002", "v1", "Mandatory", "Text", null, null, "1", false, "A", "IQT0001", "Short project title", "Text", 1, null },
                    { "IQA0002", "v2", "Mandatory", "Text", null, null, "1", false, "A", "IQT0001", "Short project title", "Text", 1, null },
                    { "IQA0003", "v1", "Mandatory", "Text", null, null, "3", false, "A", "IQT0001", "Full project title", "Text", 3, null },
                    { "IQA0004", "v1", "Mandatory", "Boolean", null, null, "4", false, "A", "IQT0001", "Is this project likely to be managed as commercial research?", "Boolean", 4, null },
                    { "IQA0005", "v1", "Mandatory", "Boolean", null, null, "6", false, "A", "IQT0001", "Do you wish to access one or more of the CPMS services? If you select 'Yes', IRAS will share information with the CPMS once the 'continue' button at the bottom of the page has been pressed.", "Boolean", 7, null },
                    { "IQA0006", "v1", "Conditional", "Email", null, null, "6a", false, "A", "IQT0001", "Provide the email of the person who will be the initial contact for CPMS.", "Text", 8, null },
                    { "IQA0012", "v1", "Mandatory", "Boolean", null, null, "1", false, "A", "IQT0003", "Is the research project or any part of it being undertaken as an educational project?", "Boolean", 1, null },
                    { "IQA0014", "v1", "Conditional", "Boolean", null, null, "3", false, "A", "IQT0003", "Is this application to establis a research bioresource?", "Boolean", 3, null },
                    { "IQA0015", "v1", "Conditional", "Boolean", null, null, "3a", false, "A", "IQT0003", "Will the bioresource be established within a NHS or HSC diagnostic archive?", "Boolean", 4, null },
                    { "IQA0017", "v1", "Conditional", "Boolean", null, null, "4", false, "A", "IQT0003", "Is this project a clinical trial of an investigational medicinal product (CTIMP)?", "Boolean", 5, null },
                    { "IQA0018", "v1", "Conditional", "Boolean", null, null, "4a", false, "A", "IQT0003", "Select the option that applies to your project:", "Boolean", 6, null },
                    { "IQA0020", "v1", "Conditional", "Boolean", null, null, "5", false, "A", "IQT0003", "Is this project a clinical investigation or other study of a medical device (including digital technology)?", "Boolean", 8, null },
                    { "IQA0021", "v1", "Conditional", "Boolean", null, null, "6", false, "A", "IQT0003", "Does the project involve exposing participants to any ionising radiation?", "Boolean", 9, null },
                    { "IQA0022", "v1", "Conditional", "Boolean", null, null, "7", false, "A", "IQT0003", "Will you be taking or using any human biological samples?", "Boolean", 10, null },
                    { "IQA0023", "v1", "Conditional", "Radio button", null, null, "7a", false, "A", "IQT0003", "Select the option that applies to your project:", "Look-up list", 11, null },
                    { "IQA0024", "v1", "Conditional", "Boolean", null, null, "8", false, "A", "IQT0003", "Will identifiable patient data be accessed outside the care team without prior consent at any stage of the project (including identification of potential participants)?", "Boolean", 12, null },
                    { "IQA0025", "v1", "Conditional", "Boolean", null, null, "9", false, "A", "IQT0003", "Do you plan at any stage of the project to undertake research with adults lacking capacity to consent for themselves that would otherwise require consent?", "Boolean", 13, null },
                    { "IQA0026", "v1", "Conditional", "Boolean", null, null, "10", false, "A", "IQT0003", "Will you include any participants who are children?", "Boolean", 14, null },
                    { "IQA0027", "v1", "Mandatory", "Boolean", null, null, "11", false, "A", "IQT0003", "Will you include any participants who are prisoners or young offenders in the custody of His Majesty's Prison and Probation Service (HMPPS) or who are offenders supervised by the probation service in England or Wales?", "Boolean", 15, null },
                    { "IQA0028", "v1", "Mandatory", "Boolean", null, null, "12", false, "A", "IQT0003", "Will this project involve any activity under the responsibility of the Ministry of Defence (MOD)?", "Boolean", 16, null },
                    { "IQA0029", "v1", "Mandatory", "Boolean", null, null, "13", false, "A", "IQT0003", "Will this project involve activities regulated by the Human Fertilisation and Embryology Authority (HFEA)?", "Boolean", 17, null },
                    { "IQA0032", "v1", "Mandatory", "Checkbox", null, null, "2", false, "A", "IQT0004", "In which countries of the UK will the project take place? Select all that apply:", "Look-up list", 3, null },
                    { "IQA0033", "v1", "Conditional", "Checkbox", null, null, "3a", false, "A", "IQT0004", "Where in the UK will the human biologicial samples or data be held? Select all that apply:", "Look-up list", 4, null },
                    { "IQA0034", "v1", "Conditional", "Checkbox", null, null, "3b", false, "A", "IQT0004", "From where in the UK will human biologicial samples or data be obtained? Select all that apply:", "Look-up list", 5, null },
                    { "IQA0036", "v1", "Optional", "Text", null, null, "1a", false, "B", "IQT0005", "Provide protocol reference number", "Text", 1, null },
                    { "IQA0037", "v1", "Conditional", "Text", null, null, "1b", false, "B", "IQT0005", "Provide the EU Clinical Trial (EUCT) number", "Text", 2, null },
                    { "IQA0039", "v1", "Conditional", "Text", null, null, "2c", false, "B", "IQT0012", "Provide any information about the linked project that will help reviewers to understand the background to this application or the decisions you have made in this application.", "Text", 5, null },
                    { "IQA0040", "v1", "Mandatory", "Text", null, null, "2", false, "B", "IQT0005", "Research project public summary:\n* explain why the research is being carried out, the questions it seeks to answer, its design and methodology\n* do not reproduce or refer to the protocol \n* complete this section in language understandable to a member of the public (maximum 300 words)\n\nThis summary will be published on the Health Research Authority (HRA) website following approval.", "Text", 3, null },
                    { "IQA0042", "v1", "Conditional", "Checkbox", null, null, "2", false, "B", "IQT0006", "How did you identify the public contributors that you involved?  Select all that apply", "Look-up list", 4, null },
                    { "IQA0043", "v1", "Conditional", "Text", null, null, "2a", false, "B", "IQT0006", "Give details how you identified the public contributors to that you involved.", "Text", 5, null },
                    { "IQA0044", "v1", "Mandatory", "Text", null, null, "2b", false, "B", "IQT0006", "Tell us about the public contributors you worked with: \n• how many of them were there?\n• were the perspectives those of patients, of carers, of service users, of people with experience of being involved in research, or of members of the public?\n• what was relevant about their skills and experience (this might include their demographic information)?", "Text", 6, null },
                    { "IQA0045", "v1", "Mandatory", "Checkbox", null, null, "1", false, "B", "IQT0006", "In which aspects of the project have you already actively involved patients or their carers, service users or members of the public?\nInclude patient and public involvement from wider programmes that has informed this project. Select all that apply:", "Look-up list", 1, null },
                    { "IQA0046", "v1", "Conditional", "Text", null, null, "1a", false, "B", "IQT0006", "Give details of how you involved public contributors", "Text", 2, null },
                    { "IQA0048", "v1", "Conditional", "Text", null, null, "1b", false, "B", "IQT0006", "Insights from patients, carers, services users or members of the public could have helped to ensure that this research reflects the priorities, needs and concerns of both the intended participant population, and of the people the research is intended to benefit. What are your reasons for not involving these people?", "Text", 3, null },
                    { "IQA0049", "v1", "Mandatory", "Checkbox", null, null, "1", false, "B", "IQT0007", "Select the methodology or methodologies you will be using for this project:", "Look-up list", 1, null },
                    { "IQA0050", "v1", "Conditional", "Text", null, null, "1a", false, "B", "IQT0007", "Give details of the methodologies you will be using", "Text", 2, null },
                    { "IQA0051", "v1", "Conditional", " Checkbox", null, null, "2a", false, "B", "IQT0007", "Select the trial methodology", "Look-up list", 3, null },
                    { "IQA0052", "v1", "Conditional", "Text", null, null, "2b", false, "B", "IQT0007", "Specify the methodology", "Text", 4, null },
                    { "IQA0053", "v1", "Mandatory", "Text", null, null, "2c", false, "B", "IQT0007", "Give more details of the methodology", "Text", 5, null },
                    { "IQA0054", "v1", "Conditional", "Boolean", null, null, "3a", false, "B", "IQT0007", "Is your project a clinical trial to study a novel intervention?", "Boolean", 6, null },
                    { "IQA0055", "v1", "Conditional", "Boolean", null, null, "3b", false, "B", "IQT0007", "Is your project a randomised clinical trial to compare any interventions in clinical practice?", "Boolean", 7, null },
                    { "IQA0056", "v1", "Conditional", "Boolean", null, null, "3c", false, "B", "IQT0007", "Are all the interventions that you are comparing routine 'gold standard' care options in clinical practice?", "Boolean", 8, null },
                    { "IQA0057", "v1", "Mandatory", "Text", null, null, "4", false, "B", "IQT0007", "What is the principal research question or objective? Describe this in language understandable to a member of the public.", "Text", 9, null },
                    { "IQA0058", "v1", "Mandatory", "Text", null, null, "5", false, "B", "IQT0007", "What are the secondary research question or objectives if applicable? Describe this in language understandable to a member of the public.", "Text", 10, null },
                    { "IQA0060", "v1", "Mandatory", "Text", null, null, "7", false, "B", "IQT0007", "State exactly what will happen to participants, their tissue or data, how many times and in what order:\n* complete this in language understandable to a member of the public", "Text", 16, null },
                    { "IQA0061", "v1", "Mandatory", "Checkbox", null, null, "2", false, "A", "IQT0003", "Select all the activities that will be involved in this project:", "Look-up list", 2, null },
                    { "IQA0062", "v1", "Conditional", "Text", null, null, "1", false, "B", "IQT0008", "What is the intervention or treatment being studied? \n* provide the trade name, and brand name where relevant, of any device or medicine. \n* for surgical, psychological or non-clinical interventions briefly describe the nature of the intervention\n* if relevant, include details of any control arm", "Text", 1, null },
                    { "IQA0063", "v1", "Conditional", "Boolean", null, null, "2", false, "B", "IQT0008", "Is this treatment first-in-human?", "Boolean", 2, null },
                    { "IQA0064", "v1", "Conditional", "Boolean", null, null, "3", false, "B", "IQT0008", "Does your project involve a change or a delay to patients’ standard treatment or care?", "Boolean", 3, null },
                    { "IQA0065", "v1", "Conditional", "Boolean", null, null, "4", false, "B", "IQT0008", "Are any of the treatments in this project being compared to standard care?", "Boolean", 4, null },
                    { "IQA0066", "v1", "Conditional", "Text", null, null, "4a", false, "B", "IQT0008", "Describe what arrangements you will put in place to address any changes in standard care during the project, for example resulting from new guidance from the National Institute for Health and Care Excellence (NICE).", "Text", 5, null },
                    { "IQA0068", "v1", "Conditional", "Boolean", null, null, "6", false, "B", "IQT0008", "Is it possible that any interviews, questionnaires or group discussions include topics that might be sensitive, embarrassing or upsetting?", "Boolean", 7, null },
                    { "IQA0070", "v1", "Conditional", "Boolean", null, null, "7", false, "B", "IQT0008", "Is it possible that interviews, questionnaires or group discussions include topics that might result in criminal or other disclosures?", "Boolean", 8, null },
                    { "IQA0071", "v1", "Conditional", "Text", null, null, "7a", false, "B", "IQT0008", "Explain how any requirement for criminal or other disclosures will be dealt with in line with legal obligations, safeguarding arrangements and professional procedures and guidance.", "Text", 9, null },
                    { "IQA0072", "v1", "Mandatory", "Text", null, null, "8", false, "B", "IQT0008", "What are the potential benefits for participants and society (including future patients)?", "Text", 10, null },
                    { "IQA0073", "v1", "n/a", "n/a", null, null, "9", false, "B", "IQT0008", "Describe the potential safety concerns, risks and burdens in the project and how you will minimise these.", "Label", 11, null },
                    { "IQA0074", "v1", "Conditional", "Text", null, null, "9a", false, "B", "IQT0008", "Any risks, side-effects or burdens of any research activities or monitoring of participants:", "Text", 12, null },
                    { "IQA0075", "v1", "Conditional", "Text", null, null, "9b", false, "B", "IQT0008", "Any risks due to a change or delay to standard treatment or care:", "Text", 13, null },
                    { "IQA0076", "v1", "Conditional", "Text", null, null, "9c", false, "B", "IQT0008", "Any risk or burden due to interviews, questionnaires or group discussions that include topics that might be sensitive, embarrassing or upsetting:", "Text", 14, null },
                    { "IQA0077", "v1", "Conditional", "Boolean", null, null, "10", false, "B", "IQT0008", "Will you inform the participants' General Practitioners (or any other health or care professional responsible for their care) that they are taking part in the study?", "Boolean", 15, null },
                    { "IQA0078", "v1", "Conditional", "Text", null, null, "10a", false, "B", "IQT0008", "Explain the circumstances when you will contact General Practitioners or other responsible health or care professionals about a participant. What will you tell participants about this?", "Text", 16, null },
                    { "IQA0079", "v1", "Conditional", "Boolean", null, null, "12", false, "B", "IQT0008", "What will happen with treatment after the project has finished?", "Look-up list", 17, null },
                    { "IQA0080", "v1", "Conditional", "Text", null, null, "12a", false, "B", "IQT0008", "Describe all the arrangements for continuued provision of treatment after the project has finished, including funding. Give details of the parties that have agreed these arrangements.", "Text", 18, null },
                    { "IQA0081", "v1", "Conditional", "Text", null, null, "12b", false, "B", "IQT0008", "Describe the care arrangements after the project has finished.  Justify these arrangements", "Text", 19, null },
                    { "IQA0082", "v1", "Mandatory", "Date", null, null, "13", false, "B", "IQT0008", "When do you plan to finish collecting data for this project in the UK?", "Date", 20, null },
                    { "IQA0083", "v1", "Mandatory", "Checkbox", null, null, "1", false, "B", "IQT0009", "What are the primary conditions or problems being studied? Select all that apply", "Look-up list", 1, null },
                    { "IQA0084", "v1", "Mandatory", "Text", null, null, "2", false, "B", "IQT0009", "List the principal inclusion criteria for selection of participants, data or samples", "Text", 2, null },
                    { "IQA0085", "v1", "Mandatory", "Text", null, null, "3", false, "B", "IQT0009", "List the principal exclusion criteria or selection of participants, data or samples", "Text", 3, null },
                    { "IQA0086", "v1", "Mandatory", "Text", null, null, "4", false, "B", "IQT0009", "How are you making sure that your study sample reflects the real-world population that the research is for and about? Consider people and communities who are often excluded from research in the field you are studying.\nYou may attach evidence or assessments already agreed with funders or sponsors.", "Text", 4, null },
                    { "IQA0087", "v1", "Mandatory", "Text", null, null, "5", false, "B", "IQT0009", "How will you ensure that the people you have chosen to include in your project are able to participate fully?  Consider factors such as health, identity, cultural, socioeconomic factors, literacy, accessibility, or other circumstances to facilitate participation in your research.\nYou may attach evidence or assessments already agreed with funders or sponsors.", "Text", 5, null },
                    { "IQA0088", "v1", "Mandatory", "Checkbox", null, null, "6", false, "B", "IQT0009", "Select which groups will participate or provide data or samples in this project. Select all that apply:", "Look-up list", 6, null },
                    { "IQA0089", "v1", "Conditional", "Text", null, null, "6a", false, "B", "IQT0009", "Give details of the groups participating or providing data or samples in this project", "Text", 7, null },
                    { "IQA0090", "v1", "Mandatory", "Date", null, null, "7", false, "B", "IQT0009", "When do you plan to start recruiting participants or collecting samples or data?", "Date", 8, null },
                    { "IQA0091", "v1", "Conditional", "Text", null, null, "8", false, "B", "IQT0009", "How long do you expect each participant to be in the project in total?", "Text", 9, null },
                    { "IQA0092", "v1", "Conditional", "Text", null, null, "9", false, "B", "IQT0009", "What arrangements will apply to potential participants who are involved in current research or have recently been involved in any research prior to recruitment?", "Text", 10, null },
                    { "IQA0093", "v1", "Conditional", "Boolean", null, null, "10", false, "B", "IQT0009", "Could any of the potential participants for the project be considered to be vulnerable at the time of approach?", "Boolean", 11, null },
                    { "IQA0095", "v1", "Mandatory", "Boolean", null, null, "2", false, "B", "IQT0010", "Will you only include children as participants?", "Boolean", 2, null },
                    { "IQA0096", "v1", "Conditional", "Checkbox", null, null, "1", false, "B", "IQT0010", "Will you only include adults lacking capacity to consent for themselves as participants?", "Look-up list", 1, null },
                    { "IQA0097", "v1", "Mandatory", "Boolean", null, null, "3", false, "B", "IQT0010", "Will you seek consent from participants prior to participation in the project?", "Look-up list", 3, null },
                    { "IQA0098", "v1", "Conditional", "Checkbox", null, null, "3a", false, "B", "IQT0010", "Select the reasons why consent will not be obtained.  Select all that apply:", "Look-up list", 4, null },
                    { "IQA0099", "v1", "Conditional", "Text", null, null, "3b", false, "B", "IQT0010", "Justify why you will not seek consent:", "Text", 5, null },
                    { "IQA00D1", "v1", "Mandatory", "Text", null, null, "1", false, "D", "IQT0057", "I agree for this project application information to be used for:", "Text", 1, null },
                    { "IQA0100", "v1", "Conditional", "Text", null, null, "4", false, "B", "IQT0010", "Describe any arrangements for seeking consent using simplified methods:", "Text", 6, null },
                    { "IQA0102", "v1", "Conditional", "Text", null, null, "5", false, "B", "IQT0010", "How long will you allow potential participants to decide whether or not to take part?", "Text", 7, null },
                    { "IQA0103", "v1", "Conditional", "Text", null, null, "6", false, "B", "IQT0010", "Explain any payments, reimbursement of expenses or any other benefits or incentives to participants:", "Text", 8, null },
                    { "IQA0104", "v1", "Conditional", "Text", null, null, "7", false, "B", "IQT0010", "What arrangements will you make to comply with the principles of the Welsh Language Act in the provision of information to participants in Wales?", "Text", 9, null },
                    { "IQA0105", "v1", "Conditional", "Text", null, null, "8", false, "B", "IQT0010", "What consent arrangements will you make for persons who:\na) might not hear verbal explanations sufficiently, or \nb) might not be able to read written information in English sufficiently, or \nc) have special communication needs?", "Text", 10, null },
                    { "IQA0106", "v1", "Conditional", "Text", null, null, "9", false, "B", "IQT0010", "What arrangements will you make for participants who are unable to confirm their consent in writing?", "Text", 11, null },
                    { "IQA0107", "v1", "Conditional", "Text", null, null, "10", false, "B", "IQT0010", "What arrangements will you make to ensure participants receive any information that becomes available during the course of the project that may be relevant to their continued participation?", "Text", 12, null },
                    { "IQA0108", "v1", "Conditional", "Boolean", null, null, "11", false, "B", "IQT0010", "What steps would you take if a participant, who has given informed consent, loses capacity to consent during the research project? Select one option only.", "Look-up list", 13, null },
                    { "IQA0109", "v1", "n/a", "n/a", null, null, "Note", false, "B", "IQT0010", "Proceed to complete Adults Lacking Capacity\n[final wording TBC]", "Label: on-screen instruction", 14, null },
                    { "IQA0110", "v1", "Mandatory", "Text", null, null, "1", false, "B", "IQT0011", "Describe potential risks to the research team in conducting the project and state how these will be managed", "Text", 1, null },
                    { "IQA0111", "v1", "Mandatory", "Boolean", null, null, "2", false, "B", "IQT0011", "Does the Chief Investigator or any other investigator or collaborator have any direct personal involvement (for example, financial, share-holding, personal relationship) in the organisations sponsoring or funding the project that may give rise to a possible conflict of interest?", "Boolean", 2, null },
                    { "IQA0112", "v1", "Conditional", "Text", null, null, "2a", false, "B", "IQT0011", "Give details of any potential relevant conflict of interest.", "Text", 3, null },
                    { "IQA0113", "v1", "Mandatory", "Boolean", null, null, "3", false, "B", "IQT0011", "Is the Chief Investigator a member of any NHS Research Ethics Committee?", "Boolean", 4, null },
                    { "IQA0114", "v1", "Conditional", "Checkbox", null, null, "3a", false, "B", "IQT0011", "Select all Research Ethics Committees (REC) the Chief Investigator or any other investigators are a member of.  Select all that apply.", "Look-up list", 5, null },
                    { "IQA0115", "v1", "Mandatory", "Boolean", null, null, "4", false, "B", "IQT0011", "Will the Chief Investigator or any other investigator receive any personal payment over and above normal salary, or any other benefits or incentives, for taking part in this project?", "Boolean", 6, null },
                    { "IQA0116", "v1", "Conditional", "Text", null, null, "4a", false, "B", "IQT0011", "Give details of payments, benefits or any other incentives.", "Text", 7, null },
                    { "IQA0117", "v1", "Mandatory", "Text", null, null, "1", false, "B", "IQT0012", "Summarise the main ethical issues arising from the project. \n* consider risks, burdens and benefits involved\n* include justifications for balancing risks and benefits (such as the involvement of potential participants being vulnerable at time of approach) \n* complete this in language understandable to a member of the public.", "Text", 1, null },
                    { "IQA0118", "v1", "Mandatory", "Checkbox", null, null, "2", false, "B", "IQT0012", "Is this application any of the following:", "Look-up list", 2, null },
                    { "IQA0119", "v1", "Conditional", "Text", null, null, "2a", false, "B", "IQT0012", "Provide the IRAS ID of the project that received an unfavourable opinion.", "Text", 3, null },
                    { "IQA0120", "v1", "Conditional", "Text", null, null, "2b", false, "B", "IQT0012", "Explain how the reasons for the unfavourable opinion have been addressed in this application.", "Text", 4, null },
                    { "IQA0121", "v1", "Mandatory", "Checkbox", null, null, "1", false, "B", "IQT0013", "How has the quality of the research been assessed?  Select all that apply.", "Look-up list", 1, null },
                    { "IQA0122", "v1", "Conditional", "Text", null, null, "1a", false, "B", "IQT0013", "Give details of how the quality of the research has been assessed", "Text", 2, null },
                    { "IQA0123", "v1", "Mandatory", "Text", null, null, "2", false, "B", "IQT0013", "Explain why this review process is appropriate to the nature of the project and if any issues raised by the review have not been addressed.  Give details if the review only relates to part of the project.", "Text", 3, null },
                    { "IQA0124", "v1", "Mandatory", "Boolean", null, null, "3", false, "B", "IQT0013", "What will the primary form of analysis be?", "Boolean", 4, null },
                    { "IQA0125", "v1", "Mandatory", "Text", null, null, "3a", false, "B", "IQT0013", "Give details of the methods for analysing the data.", "Text", 5, null },
                    { "IQA0126", "v1", "Conditional", "Checkbox", null, null, "3b", false, "B", "IQT0013", "How have the statistical aspects of the project been reviewed?  Select all that apply.", "Look-up list", 6, null },
                    { "IQA0127", "v1", "Conditional", "Text", null, null, "3c", false, "B", "IQT0013", "Give details of the person or organisation who undertook the statistical review, and how you have addressed their recommendations.", "Text", 7, null },
                    { "IQA0128", "v1", "Conditional", "Text", null, null, "3d", false, "B", "IQT0013", "What is the primary outcome measure for the project?", "Text", 8, null },
                    { "IQA0129", "v1", "Conditional", "Text", null, null, "3e", false, "B", "IQT0013", "What are the secondary outcome measures (if any)?", "Text", 9, null },
                    { "IQA0130", "v1", "Conditional", "Text", null, null, "4a", false, "B", "IQT0013", "How many participants, samples, or data records do you plan to study in total? Describe why you chose this number. If there is more than one group, give further details.", "Text", 10, null },
                    { "IQA0131", "v1", "Conditional", "Text", null, null, "4b", false, "B", "IQT0013", "How was the sample size decided upon? If a formal sample size calculation was used, indicate how this was done, giving sufficient information to justify and reproduce the calculation.", "Text", 11, null },
                    { "IQA0132", "v1", "Mandatory", "Text", null, null, "5", false, "B", "IQT0013", "What are the criteria for electively stopping the project early?", "Text", 12, null },
                    { "IQA0139", "v1", "Mandatory", "Text", null, null, "1", false, "B", "IQT0014", "Give details of the source of all funding or materials supplied.", "Text", 1, null },
                    { "IQA0140", "v1", "Mandatory", "Text", null, null, "2", false, "B", "IQT0014", "Describe any logistical, legal, or management risks relating to your project. State how you are addressing them. Studies that present a minimal risk to participants may still raise complex organisational or legal issues.", "Text", 2, null },
                    { "IQA0142", "v1", "Mandatory", "Boolean", null, null, "1", false, "A", "IQT0004", "Is this project taking place in any countries other than the UK?", "Boolean", 1, null },
                    { "IQA0143", "v1", "Conditional", "Checkbox", null, null, "1a", false, "A", "IQT0004", "List the countries outside the UK participating in this project.", "Look-up list", 2, null },
                    { "IQA0144", "v1", "Mandatory", "Checkbox", null, null, "4", false, "A", "IQT0004", "Where will the project be taking place? Select all that apply:", "Look-up list", 6, null },
                    { "IQA0145", "v1", "Conditional", "Text", null, null, "4a", false, "A", "IQT0004", "Give details of other organisations responsible for conducting the project.", "Look-up list", 7, null },
                    { "IQA0146", "v1", "Conditional", "Boolean", null, null, "5", false, "A", "IQT0004", "Will you allow your research sites to use Participant Identification Centres (PICs)?", "Boolean", 8, null },
                    { "IQA0147", "v1", "Conditional", "Checkbox", null, null, "3", false, "B", "IQT0014", "What arrangements will be put in place for the monitoring and auditing of the conduct of the project?", "Look-up list", 3, null },
                    { "IQA0148", "v1", "Conditional", "Text", null, null, "4", false, "B", "IQT0014", "What arrangements will be made to review interim safety and efficacy data from the project? Will a formal Data Monitoring Committee or equivalent body be convened?", "Text", 4, null },
                    { "IQA0149", "v1", "Mandatory", "Text", null, null, "5", false, "B", "IQT0014", "What arrangements will be made for insurance or indemnity to meet the potential legal liability of the sponsors for harm to participants arising from the management of the project? Provide any insurance certificates.", "Text", 5, null },
                    { "IQA0150", "v1", "Mandatory", "Text", null, null, "6", false, "B", "IQT0014", "What arrangements will be made for insurance or indemnity to meet the potential legal liability of the sponsors or employers for harm to participants arising from the design of the project? Provide any insurance certificates.", "Text", 6, null },
                    { "IQA0151", "v1", "Mandatory", "Text", null, null, "7", false, "B", "IQT0014", "What arrangements will be made for insurance or indemnity to meet the potential legal liability of investigators or collaborators arising from harm to participants in the conduct of the project? \n* Provide details of any time limits to the cover.  \n* Explain the arrangements that would apply if the insurance ceases.\n* Provide any insurance certificates.", "Text", 7, null },
                    { "IQA0152", "v1", "Mandatory", "Text", null, null, "8", false, "B", "IQT0014", "Describe and justify which participant groups are excluded from cover under the insurance.", "Text", 8, null },
                    { "IQA0153", "v1", "Mandatory", "Boolean", null, null, "9", false, "B", "IQT0014", "Have sponsors made arrangements for payment of compensation in the event of harm to the participants where no legal liability arises?", "Boolean", 9, null },
                    { "IQA0154", "v1", "Conditional", "Text", null, null, "9a", false, "B", "IQT0014", "Give details of the arrangements for compensation.", "Text", 10, null },
                    { "IQA0155", "v1", "Conditional", "Boolean", null, null, "10", false, "B", "IQT0014", "Have sponsors delegated any site management responsibilities to a Contract Research Organisation or a Clinical Trials Unit?", "Boolean", 11, null },
                    { "IQA0156", "v1", "Conditional", "Text", null, null, "10a", false, "B", "IQT0014", "Give details of the Contract Research Organisation or Clinical Trials Unit with site management responsibilities.", "Text", 12, null },
                    { "IQA0157", "v1", "Conditional", "Boolean", null, null, "11", false, "B", "IQT0014", "Has responsibility for any specific research activities or procedures been delegated to a subcontractor? ", "Boolean", 13, null },
                    { "IQA0158", "v1", "Conditional", "Text", null, null, "11a", false, "B", "IQT0014", "Give details of subcontractors and the proposed oversight arrangements.", "Text", 14, null },
                    { "IQA0159", "v1", "Mandatory", "Boolean", null, null, "1a", false, "B", "IQT0015", "Is the project already registered elsewhere?", "Boolean", 2, null },
                    { "IQA0162", "v1", "Mandatory", "Checkbox", null, null, "4", false, "B", "IQT0006", "How do you plan to involve public contributors in the remaining stages of the research process?  Select all that apply:", "Look-up list", 8, null },
                    { "IQA0163", "v1", "Conditional", "Text", null, null, "4a", false, "B", "IQT0006", "Give details of other aspects public contributors will advise on or contribute to", "Text", 9, null },
                    { "IQA0165", "v1", "Conditional", "Radio button", null, null, "1b", false, "B", "IQT0015", "Registration and research project public summary publication deferral request. Deferral will only be agreed where a strong justification is provided.", "Look-up list", 3, null },
                    { "IQA0166", "v1", "Conditional", "Text", null, null, "1c", false, "B", "IQT0015", "Provide clear justification for the deferral request.", "Text", 4, null },
                    { "IQA0167", "v1", "Conditional", "Checkbox", null, null, "1d", false, "B", "IQT0015", "Confirm the arrangements for registration of this project. Select all that apply:", "Checkbox", 5, null },
                    { "IQA0168", "v1", "Conditional", "Text", null, null, "1e", false, "B", "IQT0015", "Provide details of other arrangements for project registration.", "Text", 6, null },
                    { "IQA0169", "v1", "Mandatory", "Checkbox", null, null, "1f", false, "B", "IQT0015", "Confirm the arrangements for registration of this project. Select all that apply.", "Look-up list", 7, null },
                    { "IQA0170", "v1", "Conditional", "Text", null, null, "1g", false, "B", "IQT0015", "ISRCTN", "Text", 8, null },
                    { "IQA0171", "v1", "Conditional", "Text", null, null, "1h", false, "B", "IQT0015", "Clinicaltrials.gov", "Text", 9, null },
                    { "IQA0172", "v1", "Conditional", "Text", null, null, "1i", false, "B", "IQT0015", "Provide the name of any other registries and the reference number", "Text", 10, null },
                    { "IQA0173", "v1", "Conditional", "Checkbox", null, null, "2", false, "B", "IQT0015", "Project public summary publication deferral request", "Label", 12, null },
                    { "IQA0174", "v1", "Conditional", "Text", null, null, "2a", false, "B", "IQT0015", "Provide clear justification for the deferral request.", "Text", 13, null },
                    { "IQA0175", "v1", "Mandatory", "Date", null, null, "3", false, "B", "IQT0015", "You should define the end of your project and notify relevant bodies at the end of the project.  What is the planned end date?", "Date", 14, null },
                    { "IQA0176", "v1", "Mandatory", "Checkbox", null, null, "4", false, "B", "IQT0015", "A final report should be submitted to the Research Ethics Committee (REC) within 12 months of the end of the project, including a public summary of results. How else do you intend to report and disseminate the results of the project? Select all that apply:", "Look-up list", 15, null },
                    { "IQA0177", "v1", "Conditional", "Text", null, null, "4a", false, "B", "IQT0015", "Give details of other reporting and dissemination plans", "Text", 16, null },
                    { "IQA0178", "v1", "Mandatory", "Text", null, null, "5", false, "B", "IQT0015", "Results of the research provide feedback to participants on the outcome and how they have contributed.  This information should be accessible and easy to understand.  \n* explain how and when you will inform participants of the results, or give reasons if there are no arrangements to do this", "Text", 17, null },
                    { "IQA0179", "v1", "Mandatory", "Boolean", null, null, "6", false, "B", "IQT0015", "You should enable the sharing of study data, with appropriate safeguards in place, to other interested groups and communities. Sharing data maximises and respects the contribution of participants and enables and supports further re-use. Do you plan to share de-identified individual participant-level data?", "Boolean", 18, null },
                    { "IQA0180", "v1", "Mandatory", "Text", null, null, "7", false, "B", "IQT0015", "Give details of your plans for sharing de-identified individual participant-level data, or describe your alternative plans for making data available for scrutiny or re-use.", "Text", 19, null },
                    { "IQA0181", "v1", "Conditional", "Boolean", null, null, "8", false, "B", "IQT0015", "Will you have any remaining human biological material at the end of the project?", "Boolean", 20, null },
                    { "IQA0182", "v1", "Conditional", "Boolean", null, null, "8a", false, "B", "IQT0015", "The UK Clinical Research Collaboration (UKCRC) Tissue Directory and Coordination Centre advises researchers to register sample collections with them, to maximise the use of the samples. Will you be registering any remaining samples with them?", "Boolean", 21, null },
                    { "IQA0183", "v1", "Conditional", "Text", null, null, "8b", false, "B", "IQT0015", "The Human Tissue Authority and Medical Research Council advise researchers to consider options for maximising use before disposal. You should enable the sharing of tissue samples, with appropriate safeguards in place, to other interested groups and communities. Sharing tissue maximises and respects the contribution of participants and enables and supports further research. Justify the post-study arrangements or destruction of the material.", "Text", 22, null },
                    { "IQA0184", "v1", "Mandatory", "n/a", null, null, "9", false, "B", "IQT0015", "What is the contact point for public queries about this project? This information will be made public so you should use generic contact details rather than naming an individual person.", "Label", 23, null },
                    { "IQA0185", "v1", "Mandatory", "Email", null, null, "9a", false, "B", "IQT0015", "Email", "Email", 24, null },
                    { "IQA0186", "v1", "Mandatory", "Text", null, null, "9b", false, "B", "IQT0015", "Telephone", "Text", 25, null },
                    { "IQA0187", "v1", "Mandatory", "Text", null, null, "9c", false, "B", "IQT0015", "Postal address", "Text", 26, null },
                    { "IQA0188", "v1", "n/a", "n/a", null, null, "10", false, "B", "IQT0015", "What is the contact point for scientific queries about this project? This information will be made public so you should use generic contact details rather than naming an individual person.", "Label", 27, null },
                    { "IQA0189", "v1", "Mandatory", "Email", null, null, "10a", false, "B", "IQT0015", "Email", "Email", 28, null },
                    { "IQA0190", "v1", "Mandatory", "Text", null, null, "10b", false, "B", "IQT0015", "Telephone", "Text", 29, null },
                    { "IQA0191", "v1", "Mandatory", "Text", null, null, "10c", false, "B", "IQT0015", "Postal address", "Text", 30, null },
                    { "IQA0218", "v1", "Mandatory", "Text", null, null, "1", false, "C1", "IQT0019", "Describe the role of the students in the project", "Text", 1, null },
                    { "IQA0219", "v1", "Mandatory", "Boolean", null, null, "2", false, "C1", "IQT0019", "Is the project being undertaken as a group project?", "Boolean", 2, null },
                    { "IQA0220", "v1", "Mandatory", "Text", null, null, "4a", false, "C1", "IQT0019", "University name", "Text", 6, null },
                    { "IQA0221", "v1", "Mandatory", "Text", null, null, "5", false, "C1", "IQT0019", "Course name", "Text", 7, null },
                    { "IQA0222", "v1", "Mandatory", "Boolean", null, null, "3", false, "C1", "IQT0019", "Level of course ", "Look-up list", 3, null },
                    { "IQA0223", "v1", "Conditional", "Radio button", null, null, "4", false, "C1", "IQT0019", "You should complete the student research toolkit and confirm whether you are eligible to proceed with your project. You should include the relevant suplementary declaration form from your supervisor or course leader with your IRAS application. If you are not eligible you cannot proceed with your project.  Indicate which declaration is included as part of your project submission:", "Look-up list", 5, null },
                    { "IQA0224", "v1", "Mandatory", "Boolean", null, null, "6", false, "C1", "IQT0019", "The university is expected to take on the role of sponsor for this project. Is the university the sponsor?", "Boolean", 8, null },
                    { "IQA0225", "v1", "Conditional", "Text", null, null, "6a", false, "C1", "IQT0019", "Justify why the university is not taking on the role of sponsor. If the project will be in the NHS this is not sufficient reason for the sponsor to be an NHS organisation.", "Text", 9, null },
                    { "IQA0226", "v1", "Conditional", "n/a", null, null, "7", false, "C1", "IQT0019", "Student name and contact details", "Label", 10, null },
                    { "IQA0227", "v1", "Conditional", "Text", null, null, "7a", false, "C1", "IQT0019", "First name", "Text", 11, null },
                    { "IQA0228", "v1", "Conditional", "Text", null, null, "7b", false, "C1", "IQT0019", "Last name", "Text", 12, null },
                    { "IQA0229", "v1", "Conditional", "Email", null, null, "7c", false, "C1", "IQT0019", "Email", "Text", 13, null },
                    { "IQA0230", "v1", "Conditional", "n/a", null, null, "Note", false, "C1", "IQT0019", "If your course is masters or equivalent, a supervisor is expected to act as the Chief Investigator", "Label: on-screen instruction", 14, null },
                    { "IQA0231", "v1", "Mandatory", "n/a", null, null, "9", false, "C1", "IQT0019", "Academic supervisor name and contact details. If you have more than one supervisor, list the supervisor acting as Chief Investigator first.", "Label: on-screen instruction", 16, null },
                    { "IQA0232", "v1", "Mandatory", "Text", null, null, "9a", false, "C1", "IQT0019", "First name", "Text", 17, null },
                    { "IQA0233", "v1", "Mandatory", "Text", null, null, "9b", false, "C1", "IQT0019", "Last name", "Text", 18, null },
                    { "IQA0234", "v1", "Mandatory", "Text", null, null, "9c", false, "C1", "IQT0019", "Job title", "Text", 19, null },
                    { "IQA0235", "v1", "Mandatory", "Text", null, null, "9d", false, "C1", "IQT0019", "University", "Text", 20, null },
                    { "IQA0236", "v1", "Mandatory", "Email", null, null, "9e", false, "C1", "IQT0019", "Email", "Text", 21, null },
                    { "IQA0237", "v1", "Conditional", "Boolean", null, null, "8", false, "C1", "IQT0019", "Who will act as Chief Investigator for this project?", "Look-up list", 15, null },
                    { "IQA0238", "v1", "Mandatory", "Checkbox", null, null, "1", false, "C8", "IQT0020", "Specify the ages of children who will be participating in this research project. Select all groups that apply:", "Look-up list", 1, null },
                    { "IQA0239", "v1", "Mandatory", "Checkbox", null, null, "2", false, "C8", "IQT0020", "Will you include children who will be unable to fully understand the details of the project and consequences of their participation? Select all that apply:", "Look-up list", 2, null },
                    { "IQA0240", "v1", "Conditional", "Text", null, null, "2a", false, "C8", "IQT0020", "Describe the arrangements for obtaining consent from a person who has parental rights and responsibility for children who will not be able to fully understand the details of the project and consequences of their participation.", "Text", 3, null },
                    { "IQA0241", "v1", "Conditional", "Text", null, null, "2b", false, "C8", "IQT0020", "Describe how you intend to provide children who will not be able to fully understand the details of the project and consequences of their participation, with information about the project. How will you seek their assent, if they are able? Describe how this process will be adapted to their age and level of understanding.", "Text", 4, null },
                    { "IQA0242", "v1", "Conditional", "Text", null, null, "2c", false, "C8", "IQT0020", "Describe how you intend to seek informed consent from children who will be able to understand the details of the project and the consequences of participation, and willing to give consent on their own behalf, alongside parental agreement. For sites in Scotland, this may include children over the age of 12 years who are willing and able to give consent as the Children (Scotland) Act specifies that a child of 12 years or more should be presumed to be of sufficient age and maturity to form a view.", "Text", 5, null },
                    { "IQA0243", "v1", "Conditional", "Text", null, null, "2d", false, "C8", "IQT0020", "Describe the arrangements for seeking informed consent from a person with parental responsibility or another legal representative for children under 16 years.", "Text", 6, null },
                    { "IQA0245", "v1", "Conditional", "Text", null, null, "2e", false, "C8", "IQT0020", "Describe how you intend to provide children under 16 with information about the trial and seek their assent, where they are able. Describe how this process will be adapted to their age and level of understanding.", "Text", 7, null },
                    { "IQA0246", "v1", "Mandatory", "Boolean", null, null, "3", false, "C8", "IQT0020", "Is it possible that a child might need to be treated urgently as part of the project before it is possible to identify and seek consent from a person with parental rights and responsibility or another legal representative?", "Boolean", 8, null },
                    { "IQA0247", "v1", "Conditional", "Text", null, null, "3a", false, "C8", "IQT0020", "Justify the need for urgent treatment in this project. What arrangements will be put in place to identify and seek consent from a person with parental rights and responsibility or another legal representative, once urgent actions have been completed?", "Text", 9, null },
                    { "IQA0248", "v1", "Conditional", "Text", null, null, "4a", false, "C8", "IQT0020", "What arrangements will you make to seek consent to continue in the project when participating children are able to give consent for themselves?", "Text", 10, null },
                    { "IQA0249", "v1", "Conditional", "Text", null, null, "4b", false, "C8", "IQT0020", "What arrangements will you make to seek consent to continue in the trial when participating children reach the age of 16?", "Text", 11, null },
                    { "IQA0250", "v1", "Mandatory", "Text", null, null, "5", false, "C8", "IQT0020", "Explain how you have tested the materials and resources for explaining this project with children and adults with parental rights and responsibility.", "Text", 12, null },
                    { "IQA0251", "v1", "Mandatory", "Boolean", null, null, "1", false, "B", "IQT0021", "Is this study limited to working with data only?", "Boolean", 1, null },
                    { "IQA0253", "v1", "Mandatory", "Text", null, null, "1", false, "C6", "IQT0022", "Describe this type of materials. Give details of the samples.", "Look-up list", 1, null },
                    { "IQA0254", "v1", "Mandatory", "Boolean", null, null, "2", false, "C6", "IQT0022", "Will you be collecting new samples from participants? This could be new samples collected from participants for the project, or collecting samples for research at the same time as routine clinical samples.", "Boolean", 2, null },
                    { "IQA0255", "v1", "Conditional", "Boolean", null, null, "2a", false, "C6", "IQT0022", "Will the samples be provided as extra or surplus taken during a clinically directed procedure with consent?", "Boolean", 3, null },
                    { "IQA0256", "v1", "Conditional", "Text", null, null, "2b", false, "C6", "IQT0022", "How will the samples be collected? Describe what will happen to participants and how much sample will be collected. ", "text", 4, null },
                    { "IQA0257", "v1", "Conditional", "Radio button", null, null, "2c", false, "C6", "IQT0022", "Will these participants be living or deceased?", "Look-up list", 5, null },
                    { "IQA0258", "v1", "Conditional", "Checkbox", null, null, "2d", false, "C6", "IQT0022", "Will the samples be removed from the deceased in England, Northern Ireland, Scotland or Wales?", "Look-up list", 6, null },
                    { "IQA0259", "v1", "Conditional", "Text", null, null, "2e", false, "C6", "IQT0022", "Give details of any relevant Human Tissue Authority licences covering the premises where samples will be removed from the deceased. If a licence is not yet in place, confirm the arrangements for obtaining a relevant licence.", "Text", 7, null },
                    { "IQA0260", "v1", "Conditional", "Boolean", null, null, "2f", false, "C6", "IQT0022", "Will the material be identifiable to the research team?", "Boolean", 8, null },
                    { "IQA0261", "v1", "Conditional", "Boolean", null, null, "2g", false, "C6", "IQT0022", "Does this project come within the scope of the consent for the use of the material in research?", "Boolean", 9, null },
                    { "IQA0262", "v1", "Mandatory", "Boolean", null, null, "3a", false, "C6", "IQT0022", "The geographical scope of the Human Tissue Act is largely limited to England, Wales and Northern Ireland. Will this material be exported from, or imported into, these nations from another nation outside of the geographical remit of the Human Tissue Act (including to, or from, Scotland)?", "Boolean", 10, null },
                    { "IQA0263", "v1", "Mandatory", "Boolean", null, null, "3b", false, "C6", "IQT0022", "The Human Tissue Act (Scotland) applies to Scotland. Will this material be exported from, or imported into, Scotland from another nation outside of the geographical remit of the Human Tissue Act (Scotland)?", "Boolean", 11, null },
                    { "IQA0264", "v1", "Conditional", "Text", null, null, "3c", false, "C6", "IQT0022", "Give reasons for the import or export activity that will take place and clarify whether a Material Transfer Agreement will be in place to manage this activity.", "Text", 12, null },
                    { "IQA0265", "v1", "Mandatory", "Boolean", null, null, "4", false, "C6", "IQT0022", "What consent arrangements will apply to collection and use of this sample? Where relevant, give details of any prior consent for use of samples from existing collections. If the use of this sample involves the analysis of DNA, or the analysis of RNA with the intention of providing information about DNA, confirm that explicit consent will be in place.", "Boolean", 13, null },
                    { "IQA0266", "v1", "Mandatory", "Text", null, null, "5", false, "C6", "IQT0022", "Give details of where the sample will be stored, who will have access and the custodial arrangements. ", "Text", 14, null },
                    { "IQA0267", "v1", "Mandatory", "Radio button", null, null, "6", false, "C6", "IQT0022", "Will the sample be processed or stored under study-specific arrangements or in line with normal clinical arrangements for the organisation?", "Look-up list", 15, null },
                    { "IQA0268", "v1", "Mandatory", "Checkbox", null, null, "7", false, "C6", "IQT0022", "What will happen to this material following the end of the project?", "Look-up list", 16, null },
                    { "IQA0269", "v1", "Conditional", "Text", null, null, "7a", false, "C6", "IQT0022", "Explain how destruction of the material will be undertaken. If this relates to relevant material describe how it will comply with the Human Tissue Authority Code of Practice. ", "Text", 17, null },
                    { "IQA0270", "v1", "Conditional", "Text", null, null, "7b", false, "C6", "IQT0022", "Give further details of the proposed post-study arrangements including whether any relevant material will be rendered acellular.", "Text", 18, null },
                    { "IQA0271", "v1", "Mandatory", "Boolean", null, null, "1", false, "C6", "IQT0022.3", "Is it possible that the project could produce health related findings of clinical significance for donors or their relatives?", "Boolean", 1, null },
                    { "IQA0272", "v1", "Conditional", "Boolean", null, null, "1a", false, "C6", "IQT0022.3", "Will arrangements be made to notify the individuals concerned?", "Boolean", 2, null },
                    { "IQA0273", "v1", "Conditional", "Text", null, null, "1b", false, "C6", "IQT0022.3", "Explain why individuals concerned will not be notified.", "Text", 3, null },
                    { "IQA0278", "v1", "Mandatory", "Text", null, null, "1", false, "C7", "IQT0023", "The clinical trial must relate directly to a life-threatening or debilitating clinical condition from which the individual suffers.  Describe how your project meets this requirement.", "Text", 1, null },
                    { "IQA0279", "v1", "Mandatory", "Text", null, null, "2", false, "C7", "IQT0023", "Justify why this project is essential to validate data obtained in other clinical trials involving persons able to consent or obtained by other research methods", "Text", 2, null },
                    { "IQA0280", "v1", "Mandatory", "Text", null, null, "3", false, "C7", "IQT0023", "Set out the benefits that the administration of the investigational medicinal products is expected to produce for these participants and the grounds for expecting these benefits.  Detail why the inclusion of adults unable to give informed consent produces no risk at all to these participants, including risks to freedom of action or privacy.", "Text", 3, null },
                    { "IQA0281", "v1", "Mandatory", "Text", null, null, "4", false, "C7", "IQT0023", "Describe how you will ensure that members of the research team who will make decisions on participants' capacity to consent are suitably qualified and experienced to make that decision.", "Text", 4, null },
                    { "IQA0282", "v1", "Mandatory", "Text", null, null, "5", false, "C7", "IQT0023", "What arrangements will be made to identify and seek informed consent from a personal or professional legal representative?", "Text", 5, null },
                    { "IQA0283", "v1", "Mandatory", "Text", null, null, "6", false, "C7", "IQT0023", "What arrangements will be made to continue to consult personal or professional legal representatives during the course of the project where necessary?", "Text", 6, null },
                    { "IQA0284", "v1", "Mandatory", "Text", null, null, "7", false, "C7", "IQT0023", "Where appropriate you should provide information about the trial to participants according to their capacity to understand.  Include in your response:\n* what steps will you take to provide information\n* how will you consider the wishes of participants capable of forming an opinion\n* what arrangements will be put in place where capacity to consent will fluctuate or will be borderline", "Text", 7, null },
                    { "IQA0285", "v1", "Mandatory", "Boolean", null, null, "8", false, "C7", "IQT0023", "Is it possible that a participant requiring urgent treatment might need to be recruited into the trial before it is possible to identify and seek consent from a personal or professional legal representative?", "Boolean", 8, null },
                    { "IQA0286", "v1", "Conditional", "Text", null, null, "8a", false, "C7", "IQT0023", "Outline how decisions will be made on the inclusion of such participants and what arrangements will be made to seek consent from the participant (if capacity has been recovered) or from a legal representative as soon as possible.", "Text", 9, null },
                    { "IQA0287", "v1", "Conditional", "Text", null, null, "8b", false, "C7", "IQT0023", "Describe the arrangements for informing relatives in circumstances where a professional legal representative has to be consulted. If you will not be informing relatives in this circumstance, explain your reasoning.", "Text", 10, null },
                    { "IQA0288", "v1", "conditionally mandatory", "Text", null, null, "8c", false, "C7", "IQT0023", "Where a participant is recruited prior to consent being obtained, and consent is later withheld or the participant dies before consent can be given, what provisions will apply to the study data collected up to this point?", "Text", 11, null },
                    { "IQA0289", "v1", "Mandatory", "Text", null, null, "9", false, "C7", "IQT0023", "Describe what steps will be taken to ensure that nothing is done to which participants appear to object (unless it is to protect them from harm or minimise pain or discomfort).", "Text", 12, null },
                    { "IQA0290", "v1", "Mandatory", "Text", null, null, "10", false, "C7", "IQT0023", "Describe what steps will be taken to ensure that nothing is done which is contrary to any advance decision or statement by the participant", "Text", 13, null },
                    { "IQA0291", "v1", "Mandatory", "Text", null, null, "1", false, "C7", "IQT0024", "The project must be connected with an impairing condition affecting the participant or their treatment. What impairing conditions will the participants have and how does the project relate to the impairing condition?", "Text", 1, null },
                    { "IQA0292", "v1", "Mandatory", "Text", null, null, "2", false, "C7", "IQT0024", "Justify why this project could not be carried out as effectively if confined to adults capable of giving consent.", "Text", 2, null },
                    { "IQA0293", "v1", "Mandatory", "Checkbox", null, null, "3", false, "C7", "IQT0024", "Does the project have the potential to either:\na) benefit the participant without imposing a disproportionate burden, or \nb) provide knowledge of the causes of, or treatment or care of others with, the same or a similar condition? If the project does not meet either requirement you cannot undertake the research with adults lacking capacity.", "Look-up list", 3, null },
                    { "IQA0294", "v1", "Conditional", "Text", null, null, "3a", false, "C7", "IQT0024", "Describe how the project has the potential to benefit the participant without imposing a disproportionate burden.", "Text", 4, null },
                    { "IQA0295", "v1", "Conditional", "Text", null, null, "3b", false, "C7", "IQT0024", "Describe how the project will contribute to the knowledge of:\n* causes of the same or simlar condition\n* treatment or care of others with the same or simliar condition", "Text", 5, null },
                    { "IQA0296", "v1", "Conditional", "Text", null, null, "3c", false, "C7", "IQT0024", "The project must not interfere significantly with participants' freedom of action or privacy.  It also must not be unduly invasive or restrictive.  Describe how the project meets these requirements.", "Text", 6, null },
                    { "IQA0297", "v1", "Mandatory", "Text", null, null, "4", false, "C7", "IQT0024", "Describe how you will ensure that members of the research team who will make decisions on participant's capacity to consent are suitably qualified and experienced to make that decision.", "Text", 7, null },
                    { "IQA0298", "v1", "Conditional", "Text", null, null, "5a", false, "C7", "IQT0024", "For participants in England, Wales or Northern Ireland: What arrangements will be made to identify and consult an individual who is able to advise on the inclusion of the participant in the project who are unable to consent for themselves?  Describe how the individual will advise on the participant's presumed wishes and feelings.", "Text", 8, null },
                    { "IQA0299", "v1", "Conditional", "Text", null, null, "5b", false, "C7", "IQT0024", "For participants in Scotland: what arrangements will be made to consult a Welfare Guardian or Welfare Attorney, or if not appointed the nearest relative able to give consent on behalf of the incapacitated adult?", "Text", 9, null },
                    { "IQA0300", "v1", "Mandatory", "Text", null, null, "6", false, "C7", "IQT0024", "What arrangements will be made to continue to consult these individuals during the course of the project where necessary?", "Text", 10, null },
                    { "IQA0301", "v1", "Mandatory", "Text", null, null, "7", false, "C7", "IQT0024", "What will steps you take, if appropriate, to provide information about the trial to participants, according to their capacity of understanding, and to consider the wishes of participants capable of forming an opinion?", "Text", 11, null },
                    { "IQA03010", "v1", "Conditional", "Boolean", null, null, "1a", false, "C4", "IQT0025", "Select the type of project", "Look-up list", 2, null },
                    { "IQA03011", "v1", "Conditional", "Boolean", null, null, "1b", false, "C4", "IQT0025", "Select the type of project", "Look-up list", 3, null },
                    { "IQA03012", "v1", "Mandatory", "Boolean", null, null, "2", false, "C4", "IQT0025", "Will you be conducting this research project in Northern Ireland?", "Boolean", 4, null },
                    { "IQA03013", "v1", "Mandatory", "n/a", null, null, "3", false, "C4", "IQT0025", "Confirm the review required for your project", "Label", 5, null },
                    { "IQA03014", "v1", "Conditional", "Boolean", null, null, "3a", false, "C4", "IQT0025", "Based on the information you have provided you are likely to need to apply to the Medicines and Healthcare products Regulatory Agency (MHRA) and Research Ethics Committee (REC). Review the guidance and confirm what review is required.", "Boolean", 6, null },
                    { "IQA03015", "v1", "Conditional", "Boolean", null, null, "3b", false, "C4", "IQT0025", "Based on the information you have provided you are likely to need to apply to a Research Ethics Committee (REC) but not to the Medicines and Healthcare products Regulatory Agency (MHRA). Review the guidance and confirm what review is required.", "Boolean", 7, null },
                    { "IQA0302", "v1", "Mandatory", "Text", null, null, "8", false, "C7", "IQT0024", "What arrangements will be put in place where capacity to consent will fluctuate or will be borderline?", "Text", 12, null },
                    { "IQA0303", "v1", "Mandatory", "Boolean", null, null, "9", false, "C7", "IQT0024", "Is it possible that a participant requiring urgent treatment might need to be recruited into this project before it is possible to identify and consult a person able to advise on the presumed wishes and feelings of participants unable to consent for themselves?", "Boolean", 13, null },
                    { "IQA0304", "v1", "Conditional", "Text", null, null, "9a", false, "C7", "IQT0024", "Where possible you should seek agreement from a registered practioner before including the participant.  Outline these arrangments.\n* if this is not feasible to seek agreement from a registered practioner, how will decisions be made on inclusion of participants? \n* what arrangements will be made to seek consent from the participant (if capacity has been recovered) or advice from a consultee as soon as possible", "Text", 14, null },
                    { "IQA0305", "v1", "Conditional", "Text", null, null, "9b", false, "C7", "IQT0024", "Describe the arrangements for informing relatives in circumstances where a nominated consultee has to be approached. If you will not be informing relatives in this circumstance, explain your reasoning.", "Text", 15, null },
                    { "IQA0306", "v1", "Conditional", "Text", null, null, "9c", false, "C7", "IQT0024", "Where a participant is recruited prior to consent being obtained, and consent is later withheld or the participant dies before consent can be given, what provisions will apply to the study data collected up to this point?", "Text", 16, null },
                    { "IQA0307", "v1", "Mandatory", "Text", null, null, "10", false, "C7", "IQT0024", "Describe what steps will be taken to ensure that nothing is done to which participants appear to object (unless it is to protect them from harm or minimise pain or discomfort).", "Text", 17, null },
                    { "IQA0308", "v1", "Mandatory", "Text", null, null, "11", false, "C7", "IQT0024", "Describe what steps will be taken to ensure that nothing is done which is contrary to any advance decision or statement by the participant?", "Text", 18, null },
                    { "IQA0309", "v1", "Mandatory", "Boolean", null, null, "1", false, "C4", "IQT0025", "Is the study sponsored, funded or supported by a device manufacturer or other commercial company?", "Boolean", 1, null },
                    { "IQA03247", "v1", "Mandatory", "Boolean", null, null, "1", false, "C4", "IQT0053", "Is the manufacturer (or other organisation responsible for developing the device) the same organisation named as lead sponsor for this study?", "Boolean", 1, null },
                    { "IQA03248", "v1", "n/a", "n/a", null, null, "2", false, "C4", "IQT0053", "Details of the medical devices to be used in the study", "Label", 2, null },
                    { "IQA03249", "v1", "Mandatory", "Text", null, null, "2a", false, "C4", "IQT0053", "Name of the manufacturer:", "Text", 3, null },
                    { "IQA03250", "v1", "Mandatory", "Text", null, null, "2b", false, "C4", "IQT0053", "Manufacturer's trade name for the device:", "Text", 4, null },
                    { "IQA03251", "v1", "Mandatory", "n/a", null, null, "Note", false, "C4", "IQT0053", "Device identification name and number:", "Label", 5, null },
                    { "IQA03252", "v1", "Mandatory", "Text", null, null, "2c", false, "C4", "IQT0053", "Name:", "Text", 6, null },
                    { "IQA03253", "v1", "Mandatory", "Text", null, null, "2d", false, "C4", "IQT0053", "Number:", "Text", 7, null },
                    { "IQA03254", "v1", "Mandatory", "Text", null, null, "2e", false, "C4", "IQT0053", "Generic name of device and principal intended uses:", "Text", 8, null },
                    { "IQA03255", "v1", "Mandatory", "Text", null, null, "2f", false, "C4", "IQT0053", "Length of time since device came into use:", "Text", 9, null },
                    { "IQA03256", "v1", "Mandatory", "Radio button", null, null, "3", false, "C4", "IQT0053", "Select the type of research project. For all products with UKCA/CE UKNI/CE mark, attach instructions for use.", "Look-up list", 10, null },
                    { "IQA03257", "v1", "Conditional", "Boolean", null, null, "3a", false, "C4", "IQT0053", "Will the device be used within its intended population?", "Boolean", 11, null },
                    { "IQA03258", "v1", "Conditional", "Text", null, null, "3b", false, "C4", "IQT0053", "Description of any new device, materials, method of use or operation with a summary of the intended purpose.", "Text", 12, null },
                    { "IQA03259", "v1", "Conditional", "Text", null, null, "3c", false, "C4", "IQT0053", "Composition of any new implantable materials, including summary of biocompatibility findings from studies to date.", "Text", 13, null },
                    { "IQA03260", "v1", "Conditional", "Text", null, null, "3d", false, "C4", "IQT0053", "A summary of any modifications to UKCA/CE UKNI/CE marked devices.", "Text", 14, null },
                    { "IQA03261", "v1", "Conditional", "Text", null, null, "3e", false, "C4", "IQT0053", "A summary of any proposed changes to the UKCA/CE UKNI/CE marked intended purpose.", "Text", 15, null },
                    { "IQA03262", "v1", "Mandatory", "Boolean", null, null, "4", false, "C4", "IQT0053", "Are the procedures involved non-invasive or minimally invasive?", "Boolean", 16, null },
                    { "IQA03263", "v1", "Conditional", "Text", null, null, "5", false, "C4", "IQT0053", "Describe the arrangements for manufacture of the investigational device. Include details of the quality assurance system in place within the legal entity. Give details of any collaboration with a commercial manufacturer or other sub- contractor. Enclose a copy of the contract.", "Text", 17, null },
                    { "IQA03264", "v1", "Conditional", "Text", null, null, "6", false, "C4", "IQT0053", "What safety and performance testing has been undertaken on the investigational device and its constituents? Give summarised details of appropriate tests (including outcome such as pass or fail), for example mechanical, electrical, biological, toxicological, sterilisation.", "Text", 18, null },
                    { "IQA03265", "v1", "Conditional", "Text", null, null, "7", false, "C4", "IQT0053", "Describe the sponsor’s plans for further development and use of the device. Indicate whether the plans include making it available (whether for a fee or not) to other legal entities or working with a device manufacturer or other company to commercialise the product.", "Text", 19, null },
                    { "IQA03266", "v1", "Conditional", "Text", null, null, "8", false, "C4", "IQT0053", "Give details of the arrangements for ensuring that the device has been manufactured to the standards expected of an equivalent UKCA/CE UKNI/CE marked device, and that all relevant testing to demonstrate compliance with these standards has been undertaken.", "Text", 20, null },
                    { "IQA03271", "v1", "Mandatory", "Boolean", null, null, "5", false, "A", "IQT0001", "Are you seeking NIHR funding for this project?", "Boolean", 5, null },
                    { "IQA03273", "v1", "Mandatory", "Checkbox", null, null, "5", false, "B", "IQT0008", "What type of questionnaires are you using in this project? Select all that apply:", "Look-up list", 6, null },
                    { "IQA03274", "v1", "Conditional", "Text", null, null, "3", false, "B", "IQT0006", "What did your public contributors say was important to them about how this research is done?", "Text", 7, null },
                    { "IQA03275", "v1", "Conditional", "Text", null, null, "4b", false, "B", "IQT0006", "Justify your approach and describe the benefits and challenges of involving public contributors", "Text", 10, null },
                    { "IQA03276", "v1", "Conditional", "Text", null, null, "4c", false, "B", "IQT0006", "Justify the approach and  absence of public involvement", "Text", 11, null },
                    { "IQA03277", "v1", "Mandatory", "Checkbox", null, null, "6", false, "B", "IQT0007", "Does your project use AI (artificial intelligence)?", "Look-up list", 11, null },
                    { "IQA03278", "v1", "Conditional", "Checkbox", null, null, "6a", false, "B", "IQT0007", "In relation to designing, developing or testing an AI product or tool, what best describes the type of AI? Select all that apply:", "Look-up list", 12, null },
                    { "IQA03279", "v1", "Conditional", "Text", null, null, "6a 1", false, "B", "IQT0007", "Describe the type of AI being used in your project.", "Text", 13, null },
                    { "IQA03280", "v1", "Conditional", "Checkbox", null, null, "6b", false, "B", "IQT0007", "In relation to using an existing AI product or tool for its intended purpose, what best describes the type of AI? Select all that apply:", "Look-up list", 14, null },
                    { "IQA03281", "v1", "Conditional", "Text", null, null, "6b 1", false, "B", "IQT0007", "Describe the type of AI being used in your project.", "Text", 15, null },
                    { "IQA03282", "v1", "Conditional", "Boolean", null, null, "4b", false, "A", "IQT0003", "Does any investigational medicinal product contain genetically modified organisms?", "Boolean", 7, null },
                    { "IQG0001", "v1", "Mandatory", "n/a", null, null, "Note", false, "A", "IQT0001", "The following services to support researchers are available via the Central Portfolio Management System (CPMS)\n• creation of a Schedule of Events Cost Attribution Template (SoECAT) to support non-commercial funding applications and the set-up of studies in the NHS or HSC\n• creation of an interactive costing tool (for commercial sponsors) for set up of studies in the NHS or HSC \n• access to feasibility services\n• access to clinical research network support", "Label: on-screen instruction", 6, null },
                    { "IQG0002", "v1", "Conditional", "n/a", null, null, "Note", false, "A", "IQT0001", "The person identified will be able to access CPMS [link to CPMS SIM Homepage Link].", "Label: on-screen instruction", 9, null },
                    { "IQG0003", "v1", "n/a", "n/a", null, null, "Note", false, "B", "IQT0015", "Most research should be registered in a publicly accessible registry and it is expected that all researchers, research sponsors and others meet this fundamental best practice standard. ", "Label: on-screen instruction", 1, null },
                    { "IQG0004", "v1", "Conditional", "n/a", null, null, "Note", false, "B", "IQT0015", "The Health Research Authority will publish a summary of the project, once approved unless a deferral is requested and agreed. Deferral will only be agreed where a strong justification is provided.", "Label/On-screen Instructions", 11, null },
                    { "IQG0005", "v1", "Conditional", "n/a", null, null, "Note", false, "C1", "IQT0019", "You cannot proceed with your project if it is at undergraduate level or below and not a group project led by a supervisor.", "Label: on-screen instruction", 4, null }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "VersionId", "AnswerOptionId", "EndDate", "QuestionId", "StartDate" },
                values: new object[,]
                {
                    { 1, "v1", "OPT0001", null, "IQA0001", null },
                    { 2, "v1", "OPT0002", null, "IQA0001", null },
                    { 3, "v1", "OPT0003", null, "IQA0001", null },
                    { 4, "v1", "OPT0004", null, "IQA0004", null },
                    { 5, "v1", "OPT0005", null, "IQA0004", null },
                    { 6, "v1", "OPT0004", null, "IQA03271", null },
                    { 7, "v1", "OPT0005", null, "IQA03271", null },
                    { 8, "v1", "OPT0004", null, "IQA0005", null },
                    { 9, "v1", "OPT0005", null, "IQA0005", null },
                    { 10, "v1", "OPT0004", null, "IQA0012", null },
                    { 11, "v1", "OPT0005", null, "IQA0012", null },
                    { 12, "v1", "OPT0006", null, "IQA0061", null },
                    { 13, "v1", "OPT0007", null, "IQA0061", null },
                    { 14, "v1", "OPT0008", null, "IQA0061", null },
                    { 15, "v1", "OPT0009", null, "IQA0061", null },
                    { 16, "v1", "OPT0010", null, "IQA0061", null },
                    { 17, "v1", "OPT0011", null, "IQA0061", null },
                    { 18, "v1", "OPT0012", null, "IQA0061", null },
                    { 19, "v1", "OPT0013", null, "IQA0061", null },
                    { 20, "v1", "OPT0004", null, "IQA0014", null },
                    { 21, "v1", "OPT0005", null, "IQA0014", null },
                    { 22, "v1", "OPT0004", null, "IQA0015", null },
                    { 23, "v1", "OPT0005", null, "IQA0015", null },
                    { 24, "v1", "OPT0004", null, "IQA0017", null },
                    { 25, "v1", "OPT0005", null, "IQA0017", null },
                    { 26, "v1", "OPT0014", null, "IQA0018", null },
                    { 27, "v1", "OPT0015", null, "IQA0018", null },
                    { 28, "v1", "OPT0004", null, "IQA03282", null },
                    { 29, "v1", "OPT0005", null, "IQA03282", null },
                    { 30, "v1", "OPT0004", null, "IQA0020", null },
                    { 31, "v1", "OPT0005", null, "IQA0020", null },
                    { 32, "v1", "OPT0004", null, "IQA0021", null },
                    { 33, "v1", "OPT0005", null, "IQA0021", null },
                    { 34, "v1", "OPT0004", null, "IQA0022", null },
                    { 35, "v1", "OPT0005", null, "IQA0022", null },
                    { 36, "v1", "OPT0004", null, "IQA0024", null },
                    { 37, "v1", "OPT0005", null, "IQA0024", null },
                    { 38, "v1", "OPT0004", null, "IQA0025", null },
                    { 39, "v1", "OPT0005", null, "IQA0025", null },
                    { 40, "v1", "OPT0004", null, "IQA0026", null },
                    { 41, "v1", "OPT0005", null, "IQA0026", null },
                    { 42, "v1", "OPT0004", null, "IQA0027", null },
                    { 43, "v1", "OPT0005", null, "IQA0027", null },
                    { 44, "v1", "OPT0004", null, "IQA0028", null },
                    { 45, "v1", "OPT0005", null, "IQA0028", null },
                    { 46, "v1", "OPT0004", null, "IQA0029", null },
                    { 47, "v1", "OPT0005", null, "IQA0029", null },
                    { 48, "v1", "OPT0016", null, "IQA0142", null },
                    { 49, "v1", "OPT0017", null, "IQA0142", null },
                    { 51, "v1", "OPT0018", null, "IQA0032", null },
                    { 52, "v1", "OPT0019", null, "IQA0032", null },
                    { 53, "v1", "OPT0020", null, "IQA0032", null },
                    { 54, "v1", "OPT0021", null, "IQA0032", null },
                    { 55, "v1", "OPT0018", null, "IQA0033", null },
                    { 56, "v1", "OPT0019", null, "IQA0033", null },
                    { 57, "v1", "OPT0020", null, "IQA0033", null },
                    { 58, "v1", "OPT0021", null, "IQA0033", null },
                    { 59, "v1", "OPT0018", null, "IQA0034", null },
                    { 60, "v1", "OPT0019", null, "IQA0034", null },
                    { 61, "v1", "OPT0020", null, "IQA0034", null },
                    { 62, "v1", "OPT0021", null, "IQA0034", null },
                    { 63, "v1", "OPT0022", null, "IQA0144", null },
                    { 64, "v1", "OPT0023", null, "IQA0144", null },
                    { 65, "v1", "OPT0024", null, "IQA0144", null },
                    { 66, "v1", "OPT0025", null, "IQA0144", null },
                    { 67, "v1", "OPT0026", null, "IQA0144", null },
                    { 68, "v1", "OPT0027", null, "IQA0144", null },
                    { 69, "v1", "OPT0028", null, "IQA0144", null },
                    { 70, "v1", "OPT0029", null, "IQA0144", null },
                    { 71, "v1", "OPT0030", null, "IQA0144", null },
                    { 72, "v1", "OPT0031", null, "IQA0144", null },
                    { 73, "v1", "OPT0032", null, "IQA0144", null },
                    { 74, "v1", "OPT0033", null, "IQA0144", null },
                    { 75, "v1", "OPT0004", null, "IQA0146", null },
                    { 76, "v1", "OPT0005", null, "IQA0146", null },
                    { 77, "v1", "OPT0034", null, "IQA0146", null },
                    { 78, "v1", "OPT0035", null, "IQA0045", null },
                    { 79, "v1", "OPT0036", null, "IQA0045", null },
                    { 80, "v1", "OPT0037", null, "IQA0045", null },
                    { 81, "v1", "OPT0038", null, "IQA0045", null },
                    { 82, "v1", "OPT0039", null, "IQA0045", null },
                    { 83, "v1", "OPT0040", null, "IQA0045", null },
                    { 84, "v1", "OPT0041", null, "IQA0045", null },
                    { 85, "v1", "OPT0042", null, "IQA0045", null },
                    { 86, "v1", "OPT0043", null, "IQA0045", null },
                    { 87, "v1", "OPT0044", null, "IQA0045", null },
                    { 88, "v1", "OPT0045", null, "IQA0045", null },
                    { 89, "v1", "OPT0046", null, "IQA0045", null },
                    { 90, "v1", "OPT0047", null, "IQA0045", null },
                    { 91, "v1", "OPT0048", null, "IQA0045", null },
                    { 92, "v1", "OPT0033", null, "IQA0045", null },
                    { 93, "v1", "OPT0049", null, "IQA0045", null },
                    { 94, "v1", "OPT0050", null, "IQA0042", null },
                    { 95, "v1", "OPT0051", null, "IQA0042", null },
                    { 96, "v1", "OPT0052", null, "IQA0042", null },
                    { 97, "v1", "OPT0053", null, "IQA0042", null },
                    { 98, "v1", "OPT0033", null, "IQA0042", null },
                    { 99, "v1", "OPT0054", null, "IQA0162", null },
                    { 100, "v1", "OPT0037", null, "IQA0162", null },
                    { 101, "v1", "OPT0045", null, "IQA0162", null },
                    { 102, "v1", "OPT0055", null, "IQA0162", null },
                    { 103, "v1", "OPT0056", null, "IQA0162", null },
                    { 104, "v1", "OPT0057", null, "IQA0162", null },
                    { 105, "v1", "OPT0058", null, "IQA0162", null },
                    { 106, "v1", "OPT0059", null, "IQA0162", null },
                    { 107, "v1", "OPT0060", null, "IQA0162", null },
                    { 108, "v1", "OPT0061", null, "IQA0162", null },
                    { 109, "v1", "OPT0033", null, "IQA0162", null },
                    { 110, "v1", "OPT0062", null, "IQA0049", null },
                    { 111, "v1", "OPT0063", null, "IQA0049", null },
                    { 112, "v1", "OPT0064", null, "IQA0049", null },
                    { 113, "v1", "OPT0065", null, "IQA0049", null },
                    { 114, "v1", "OPT0066", null, "IQA0049", null },
                    { 115, "v1", "OPT0067", null, "IQA0049", null },
                    { 116, "v1", "OPT0068", null, "IQA0049", null },
                    { 117, "v1", "OPT0069", null, "IQA0049", null },
                    { 118, "v1", "OPT0070", null, "IQA0049", null },
                    { 119, "v1", "OPT0071", null, "IQA0049", null },
                    { 120, "v1", "OPT0072", null, "IQA0049", null },
                    { 121, "v1", "OPT0073", null, "IQA0049", null },
                    { 122, "v1", "OPT0074", null, "IQA0049", null },
                    { 123, "v1", "OPT0033", null, "IQA0049", null },
                    { 124, "v1", "OPT0075", null, "IQA0051", null },
                    { 125, "v1", "OPT0076", null, "IQA0051", null },
                    { 126, "v1", "OPT0077", null, "IQA0051", null },
                    { 127, "v1", "OPT0078", null, "IQA0051", null },
                    { 128, "v1", "OPT0079", null, "IQA0051", null },
                    { 129, "v1", "OPT0080", null, "IQA0051", null },
                    { 130, "v1", "OPT0081", null, "IQA0051", null },
                    { 131, "v1", "OPT0082", null, "IQA0051", null },
                    { 132, "v1", "OPT0083", null, "IQA0051", null },
                    { 133, "v1", "OPT0084", null, "IQA0051", null },
                    { 134, "v1", "OPT0085", null, "IQA0051", null },
                    { 135, "v1", "OPT0086", null, "IQA0051", null },
                    { 136, "v1", "OPT0087", null, "IQA0051", null },
                    { 137, "v1", "OPT0088", null, "IQA0051", null },
                    { 138, "v1", "OPT0004", null, "IQA0054", null },
                    { 139, "v1", "OPT0005", null, "IQA0054", null },
                    { 140, "v1", "OPT0004", null, "IQA0055", null },
                    { 141, "v1", "OPT0005", null, "IQA0055", null },
                    { 142, "v1", "OPT0004", null, "IQA0056", null },
                    { 143, "v1", "OPT0005", null, "IQA0056", null },
                    { 144, "v1", "OPT0089", null, "IQA03277", null },
                    { 145, "v1", "OPT0090", null, "IQA03277", null },
                    { 146, "v1", "OPT0091", null, "IQA03277", null },
                    { 147, "v1", "OPT0092", null, "IQA03278", null },
                    { 148, "v1", "OPT0093", null, "IQA03278", null },
                    { 149, "v1", "OPT0094", null, "IQA03278", null },
                    { 150, "v1", "OPT0095", null, "IQA03278", null },
                    { 151, "v1", "OPT0096", null, "IQA03278", null },
                    { 152, "v1", "OPT0033", null, "IQA03278", null },
                    { 153, "v1", "OPT0092", null, "IQA03280", null },
                    { 154, "v1", "OPT0093", null, "IQA03280", null },
                    { 155, "v1", "OPT0094", null, "IQA03280", null },
                    { 156, "v1", "OPT0095", null, "IQA03280", null },
                    { 157, "v1", "OPT0096", null, "IQA03280", null },
                    { 158, "v1", "OPT0033", null, "IQA03280", null },
                    { 159, "v1", "OPT0097", null, "IQA0083", null },
                    { 160, "v1", "OPT0098", null, "IQA0083", null },
                    { 161, "v1", "OPT0099", null, "IQA0083", null },
                    { 162, "v1", "OPT0100", null, "IQA0083", null },
                    { 163, "v1", "OPT0101", null, "IQA0083", null },
                    { 164, "v1", "OPT0102", null, "IQA0083", null },
                    { 165, "v1", "OPT0103", null, "IQA0083", null },
                    { 166, "v1", "OPT0104", null, "IQA0083", null },
                    { 167, "v1", "OPT0105", null, "IQA0083", null },
                    { 168, "v1", "OPT0106", null, "IQA0083", null },
                    { 169, "v1", "OPT0107", null, "IQA0083", null },
                    { 170, "v1", "OPT0108", null, "IQA0083", null },
                    { 171, "v1", "OPT0109", null, "IQA0083", null },
                    { 172, "v1", "OPT0110", null, "IQA0083", null },
                    { 173, "v1", "OPT0111", null, "IQA0083", null },
                    { 174, "v1", "OPT0112", null, "IQA0083", null },
                    { 175, "v1", "OPT0113", null, "IQA0083", null },
                    { 176, "v1", "OPT0114", null, "IQA0083", null },
                    { 177, "v1", "OPT0115", null, "IQA0083", null },
                    { 178, "v1", "OPT0116", null, "IQA0083", null },
                    { 179, "v1", "OPT0117", null, "IQA0083", null },
                    { 180, "v1", "OPT0118", null, "IQA0088", null },
                    { 181, "v1", "OPT0119", null, "IQA0088", null },
                    { 182, "v1", "OPT0120", null, "IQA0088", null },
                    { 183, "v1", "OPT0121", null, "IQA0088", null },
                    { 184, "v1", "OPT0122", null, "IQA0088", null },
                    { 185, "v1", "OPT0123", null, "IQA0088", null },
                    { 186, "v1", "OPT0124", null, "IQA0088", null },
                    { 187, "v1", "OPT0125", null, "IQA0088", null },
                    { 188, "v1", "OPT0126", null, "IQA0088", null },
                    { 189, "v1", "OPT0127", null, "IQA0088", null },
                    { 190, "v1", "OPT0033", null, "IQA0088", null },
                    { 191, "v1", "OPT0004", null, "IQA0093", null },
                    { 192, "v1", "OPT0005", null, "IQA0093", null },
                    { 193, "v1", "OPT0004", null, "IQA0063", null },
                    { 194, "v1", "OPT0005", null, "IQA0063", null },
                    { 195, "v1", "OPT0004", null, "IQA0064", null },
                    { 196, "v1", "OPT0005", null, "IQA0064", null },
                    { 197, "v1", "OPT0004", null, "IQA0065", null },
                    { 198, "v1", "OPT0005", null, "IQA0065", null },
                    { 199, "v1", "OPT0128", null, "IQA03273", null },
                    { 200, "v1", "OPT0129", null, "IQA03273", null },
                    { 201, "v1", "OPT0130", null, "IQA03273", null },
                    { 202, "v1", "OPT0131", null, "IQA03273", null },
                    { 203, "v1", "OPT0004", null, "IQA0068", null },
                    { 204, "v1", "OPT0005", null, "IQA0068", null },
                    { 205, "v1", "OPT0004", null, "IQA0070", null },
                    { 206, "v1", "OPT0005", null, "IQA0070", null },
                    { 207, "v1", "OPT0004", null, "IQA0077", null },
                    { 208, "v1", "OPT0005", null, "IQA0077", null },
                    { 209, "v1", "OPT0132", null, "IQA0079", null },
                    { 210, "v1", "OPT0133", null, "IQA0079", null },
                    { 211, "v1", "OPT0134", null, "IQA0096", null },
                    { 212, "v1", "OPT0135", null, "IQA0096", null },
                    { 213, "v1", "OPT0136", null, "IQA0096", null },
                    { 214, "v1", "OPT0004", null, "IQA0095", null },
                    { 215, "v1", "OPT0005", null, "IQA0095", null },
                    { 216, "v1", "OPT0137", null, "IQA0097", null },
                    { 217, "v1", "OPT0138", null, "IQA0097", null },
                    { 218, "v1", "OPT0139", null, "IQA0097", null },
                    { 219, "v1", "OPT0140", null, "IQA0098", null },
                    { 220, "v1", "OPT0141", null, "IQA0098", null },
                    { 221, "v1", "OPT0033", null, "IQA0098", null },
                    { 222, "v1", "OPT0142", null, "IQA0108", null },
                    { 223, "v1", "OPT0143", null, "IQA0108", null },
                    { 224, "v1", "OPT0144", null, "IQA0108", null },
                    { 225, "v1", "OPT0004", null, "IQA0111", null },
                    { 226, "v1", "OPT0005", null, "IQA0111", null },
                    { 227, "v1", "OPT0004", null, "IQA0113", null },
                    { 228, "v1", "OPT0005", null, "IQA0113", null },
                    { 229, "v1", "OPT0145", null, "IQA0114", null },
                    { 230, "v1", "OPT0146", null, "IQA0114", null },
                    { 231, "v1", "OPT0147", null, "IQA0114", null },
                    { 232, "v1", "OPT0148", null, "IQA0114", null },
                    { 233, "v1", "OPT0149", null, "IQA0114", null },
                    { 234, "v1", "OPT0150", null, "IQA0114", null },
                    { 235, "v1", "OPT0151", null, "IQA0114", null },
                    { 236, "v1", "OPT0152", null, "IQA0114", null },
                    { 237, "v1", "OPT0153", null, "IQA0114", null },
                    { 238, "v1", "OPT0154", null, "IQA0114", null },
                    { 239, "v1", "OPT0155", null, "IQA0114", null },
                    { 240, "v1", "OPT0156", null, "IQA0114", null },
                    { 241, "v1", "OPT0157", null, "IQA0114", null },
                    { 242, "v1", "OPT0158", null, "IQA0114", null },
                    { 243, "v1", "OPT0159", null, "IQA0114", null },
                    { 244, "v1", "OPT0160", null, "IQA0114", null },
                    { 245, "v1", "OPT0161", null, "IQA0114", null },
                    { 246, "v1", "OPT0162", null, "IQA0114", null },
                    { 247, "v1", "OPT0163", null, "IQA0114", null },
                    { 248, "v1", "OPT0164", null, "IQA0114", null },
                    { 249, "v1", "OPT0165", null, "IQA0114", null },
                    { 250, "v1", "OPT0166", null, "IQA0114", null },
                    { 251, "v1", "OPT0167", null, "IQA0114", null },
                    { 252, "v1", "OPT0168", null, "IQA0114", null },
                    { 253, "v1", "OPT0169", null, "IQA0114", null },
                    { 254, "v1", "OPT0170", null, "IQA0114", null },
                    { 255, "v1", "OPT0171", null, "IQA0114", null },
                    { 256, "v1", "OPT0172", null, "IQA0114", null },
                    { 257, "v1", "OPT0173", null, "IQA0114", null },
                    { 258, "v1", "OPT0174", null, "IQA0114", null },
                    { 259, "v1", "OPT0175", null, "IQA0114", null },
                    { 260, "v1", "OPT0176", null, "IQA0114", null },
                    { 261, "v1", "OPT0177", null, "IQA0114", null },
                    { 262, "v1", "OPT0178", null, "IQA0114", null },
                    { 263, "v1", "OPT0179", null, "IQA0114", null },
                    { 264, "v1", "OPT0180", null, "IQA0114", null },
                    { 265, "v1", "OPT0181", null, "IQA0114", null },
                    { 266, "v1", "OPT0182", null, "IQA0114", null },
                    { 267, "v1", "OPT0183", null, "IQA0114", null },
                    { 268, "v1", "OPT0184", null, "IQA0114", null },
                    { 269, "v1", "OPT0185", null, "IQA0114", null },
                    { 270, "v1", "OPT0186", null, "IQA0114", null },
                    { 271, "v1", "OPT0187", null, "IQA0114", null },
                    { 272, "v1", "OPT0188", null, "IQA0114", null },
                    { 273, "v1", "OPT0189", null, "IQA0114", null },
                    { 274, "v1", "OPT0190", null, "IQA0114", null },
                    { 275, "v1", "OPT0191", null, "IQA0114", null },
                    { 276, "v1", "OPT0192", null, "IQA0114", null },
                    { 277, "v1", "OPT0193", null, "IQA0114", null },
                    { 278, "v1", "OPT0194", null, "IQA0114", null },
                    { 279, "v1", "OPT0195", null, "IQA0114", null },
                    { 280, "v1", "OPT0196", null, "IQA0114", null },
                    { 281, "v1", "OPT0197", null, "IQA0114", null },
                    { 282, "v1", "OPT0198", null, "IQA0114", null },
                    { 283, "v1", "OPT0199", null, "IQA0114", null },
                    { 284, "v1", "OPT0200", null, "IQA0114", null },
                    { 285, "v1", "OPT0201", null, "IQA0114", null },
                    { 286, "v1", "OPT0202", null, "IQA0114", null },
                    { 287, "v1", "OPT0203", null, "IQA0114", null },
                    { 288, "v1", "OPT0204", null, "IQA0114", null },
                    { 289, "v1", "OPT0205", null, "IQA0114", null },
                    { 290, "v1", "OPT0206", null, "IQA0114", null },
                    { 291, "v1", "OPT0207", null, "IQA0114", null },
                    { 292, "v1", "OPT0208", null, "IQA0114", null },
                    { 293, "v1", "OPT0209", null, "IQA0114", null },
                    { 294, "v1", "OPT0210", null, "IQA0114", null },
                    { 295, "v1", "OPT0211", null, "IQA0114", null },
                    { 296, "v1", "OPT0212", null, "IQA0114", null },
                    { 297, "v1", "OPT0213", null, "IQA0114", null },
                    { 298, "v1", "OPT0214", null, "IQA0114", null },
                    { 299, "v1", "OPT0215", null, "IQA0114", null },
                    { 300, "v1", "OPT0216", null, "IQA0114", null },
                    { 301, "v1", "OPT0217", null, "IQA0114", null },
                    { 302, "v1", "OPT0218", null, "IQA0114", null },
                    { 303, "v1", "OPT0219", null, "IQA0114", null },
                    { 304, "v1", "OPT0220", null, "IQA0114", null },
                    { 305, "v1", "OPT0221", null, "IQA0114", null },
                    { 306, "v1", "OPT0222", null, "IQA0114", null },
                    { 307, "v1", "OPT0223", null, "IQA0114", null },
                    { 308, "v1", "OPT0224", null, "IQA0114", null },
                    { 309, "v1", "OPT0225", null, "IQA0114", null },
                    { 310, "v1", "OPT0226", null, "IQA0114", null },
                    { 311, "v1", "OPT0227", null, "IQA0114", null },
                    { 312, "v1", "OPT0228", null, "IQA0114", null },
                    { 313, "v1", "OPT0229", null, "IQA0114", null },
                    { 314, "v1", "OPT0230", null, "IQA0114", null },
                    { 315, "v1", "OPT0004", null, "IQA0115", null },
                    { 316, "v1", "OPT0005", null, "IQA0115", null },
                    { 317, "v1", "OPT0231", null, "IQA0118", null },
                    { 318, "v1", "OPT0232", null, "IQA0118", null },
                    { 319, "v1", "OPT0233", null, "IQA0118", null },
                    { 320, "v1", "OPT0234", null, "IQA0118", null },
                    { 321, "v1", "OPT0235", null, "IQA0121", null },
                    { 322, "v1", "OPT0236", null, "IQA0121", null },
                    { 323, "v1", "OPT0237", null, "IQA0121", null },
                    { 324, "v1", "OPT0238", null, "IQA0121", null },
                    { 325, "v1", "OPT0239", null, "IQA0121", null },
                    { 326, "v1", "OPT0240", null, "IQA0121", null },
                    { 327, "v1", "OPT0033", null, "IQA0121", null },
                    { 328, "v1", "OPT0241", null, "IQA0124", null },
                    { 329, "v1", "OPT0242", null, "IQA0124", null },
                    { 330, "v1", "OPT0243", null, "IQA0126", null },
                    { 331, "v1", "OPT0244", null, "IQA0126", null },
                    { 332, "v1", "OPT0245", null, "IQA0126", null },
                    { 333, "v1", "OPT0246", null, "IQA0126", null },
                    { 334, "v1", "OPT0247", null, "IQA0126", null },
                    { 335, "v1", "OPT0240", null, "IQA0126", null },
                    { 336, "v1", "OPT0248", null, "IQA0126", null },
                    { 337, "v1", "OPT0249", null, "IQA0126", null },
                    { 338, "v1", "OPT0250", null, "IQA0147", null },
                    { 339, "v1", "OPT0251", null, "IQA0147", null },
                    { 340, "v1", "OPT0252", null, "IQA0147", null },
                    { 341, "v1", "OPT0004", null, "IQA0153", null },
                    { 342, "v1", "OPT0005", null, "IQA0153", null },
                    { 343, "v1", "OPT0004", null, "IQA0155", null },
                    { 344, "v1", "OPT0005", null, "IQA0155", null },
                    { 345, "v1", "OPT0004", null, "IQA0157", null },
                    { 346, "v1", "OPT0005", null, "IQA0157", null },
                    { 347, "v1", "OPT0004", null, "IQA0169", null },
                    { 348, "v1", "OPT0005", null, "IQA0169", null },
                    { 349, "v1", "OPT0253", null, "IQA0165", null },
                    { 350, "v1", "OPT0254", null, "IQA0165", null },
                    { 351, "v1", "OPT0255", null, "IQA0165", null },
                    { 352, "v1", "OPT0256", null, "IQA0167", null },
                    { 353, "v1", "OPT0257", null, "IQA0167", null },
                    { 354, "v1", "OPT0258", null, "IQA0169", null },
                    { 355, "v1", "OPT0259", null, "IQA0169", null },
                    { 356, "v1", "OPT0033", null, "IQA0169", null },
                    { 357, "v1", "OPT0253", null, "IQA0173", null },
                    { 358, "v1", "OPT0254", null, "IQA0173", null },
                    { 359, "v1", "OPT0255", null, "IQA0173", null },
                    { 360, "v1", "OPT0262", null, "IQA0176", null },
                    { 361, "v1", "OPT0263", null, "IQA0176", null },
                    { 362, "v1", "OPT0264", null, "IQA0176", null },
                    { 363, "v1", "OPT0265", null, "IQA0176", null },
                    { 364, "v1", "OPT0266", null, "IQA0176", null },
                    { 365, "v1", "OPT0267", null, "IQA0176", null },
                    { 366, "v1", "OPT0268", null, "IQA0176", null },
                    { 367, "v1", "OPT0269", null, "IQA0176", null },
                    { 368, "v1", "OPT0033", null, "IQA0176", null },
                    { 369, "v1", "OPT0004", null, "IQA0179", null },
                    { 370, "v1", "OPT0005", null, "IQA0179", null },
                    { 371, "v1", "OPT0004", null, "IQA0181", null },
                    { 372, "v1", "OPT0005", null, "IQA0181", null },
                    { 373, "v1", "OPT0004", null, "IQA0182", null },
                    { 374, "v1", "OPT0005", null, "IQA0182", null },
                    { 375, "v1", "OPT0004", null, "IQA0251", null },
                    { 376, "v1", "OPT0005", null, "IQA0251", null },
                    { 377, "v1", "OPT0004", null, "IQA0219", null },
                    { 378, "v1", "OPT0005", null, "IQA0219", null },
                    { 379, "v1", "OPT0270", null, "IQA0222", null },
                    { 380, "v1", "OPT0271", null, "IQA0222", null },
                    { 381, "v1", "OPT0272", null, "IQA0222", null },
                    { 382, "v1", "OPT0273", null, "IQA0223", null },
                    { 383, "v1", "OPT0274", null, "IQA0223", null },
                    { 384, "v1", "OPT0275", null, "IQA0223", null },
                    { 385, "v1", "OPT0004", null, "IQA0224", null },
                    { 386, "v1", "OPT0005", null, "IQA0224", null },
                    { 387, "v1", "OPT0276", null, "IQA0237", null },
                    { 388, "v1", "OPT0277", null, "IQA0237", null },
                    { 389, "v1", "OPT0004", null, "IQA0309", null },
                    { 390, "v1", "OPT0005", null, "IQA0309", null },
                    { 391, "v1", "OPT0278", null, "IQA03010", null },
                    { 392, "v1", "OPT0279", null, "IQA03010", null },
                    { 393, "v1", "OPT0280", null, "IQA03010", null },
                    { 394, "v1", "OPT0281", null, "IQA03010", null },
                    { 395, "v1", "OPT0282", null, "IQA03010", null },
                    { 396, "v1", "OPT0283", null, "IQA03011", null },
                    { 397, "v1", "OPT0284", null, "IQA03011", null },
                    { 398, "v1", "OPT0285", null, "IQA03011", null },
                    { 399, "v1", "OPT0286", null, "IQA03011", null },
                    { 400, "v1", "OPT0287", null, "IQA03011", null },
                    { 401, "v1", "OPT0288", null, "IQA03011", null },
                    { 402, "v1", "OPT0004", null, "IQA03012", null },
                    { 403, "v1", "OPT0005", null, "IQA03012", null },
                    { 404, "v1", "OPT0289", null, "IQA03014", null },
                    { 405, "v1", "OPT0290", null, "IQA03014", null },
                    { 406, "v1", "OPT0289", null, "IQA03015", null },
                    { 407, "v1", "OPT0290", null, "IQA03015", null },
                    { 408, "v1", "OPT0004", null, "IQA03247", null },
                    { 409, "v1", "OPT0005", null, "IQA03247", null },
                    { 410, "v1", "OPT0291", null, "IQA03256", null },
                    { 411, "v1", "OPT0292", null, "IQA03256", null },
                    { 412, "v1", "OPT0293", null, "IQA03256", null },
                    { 413, "v1", "OPT0294", null, "IQA03256", null },
                    { 414, "v1", "OPT0295", null, "IQA03256", null },
                    { 415, "v1", "OPT0004", null, "IQA03257", null },
                    { 416, "v1", "OPT0005", null, "IQA03257", null },
                    { 417, "v1", "OPT0004", null, "IQA03262", null },
                    { 418, "v1", "OPT0005", null, "IQA03262", null },
                    { 419, "v1", "OPT0004", null, "IQA0254", null },
                    { 420, "v1", "OPT0005", null, "IQA0254", null },
                    { 421, "v1", "OPT0004", null, "IQA0255", null },
                    { 422, "v1", "OPT0005", null, "IQA0255", null },
                    { 423, "v1", "OPT0296", null, "IQA0257", null },
                    { 424, "v1", "OPT0297", null, "IQA0257", null },
                    { 425, "v1", "OPT0018", null, "IQA0258", null },
                    { 426, "v1", "OPT0019", null, "IQA0258", null },
                    { 427, "v1", "OPT0020", null, "IQA0258", null },
                    { 428, "v1", "OPT0021", null, "IQA0258", null },
                    { 429, "v1", "OPT0004", null, "IQA0260", null },
                    { 430, "v1", "OPT0005", null, "IQA0260", null },
                    { 431, "v1", "OPT0004", null, "IQA0261", null },
                    { 432, "v1", "OPT0005", null, "IQA0261", null },
                    { 433, "v1", "OPT0004", null, "IQA0262", null },
                    { 434, "v1", "OPT0005", null, "IQA0262", null },
                    { 435, "v1", "OPT0004", null, "IQA0263", null },
                    { 436, "v1", "OPT0005", null, "IQA0263", null },
                    { 437, "v1", "OPT0004", null, "IQA0265", null },
                    { 438, "v1", "OPT0005", null, "IQA0265", null },
                    { 439, "v1", "OPT0298", null, "IQA0267", null },
                    { 440, "v1", "OPT0299", null, "IQA0267", null },
                    { 441, "v1", "OPT0300", null, "IQA0268", null },
                    { 442, "v1", "OPT0301", null, "IQA0268", null },
                    { 443, "v1", "OPT0302", null, "IQA0268", null },
                    { 444, "v1", "OPT0303", null, "IQA0268", null },
                    { 445, "v1", "OPT0304", null, "IQA0268", null },
                    { 446, "v1", "OPT0033", null, "IQA0268", null },
                    { 447, "v1", "OPT0305", null, "IQA0268", null },
                    { 448, "v1", "OPT0004", null, "IQA0271", null },
                    { 449, "v1", "OPT0005", null, "IQA0271", null },
                    { 450, "v1", "OPT0004", null, "IQA0272", null },
                    { 451, "v1", "OPT0005", null, "IQA0272", null },
                    { 452, "v1", "OPT0004", null, "IQA0285", null },
                    { 453, "v1", "OPT0005", null, "IQA0285", null },
                    { 454, "v1", "OPT0306", null, "IQA0293", null },
                    { 455, "v1", "OPT0307", null, "IQA0293", null },
                    { 456, "v1", "OPT0004", null, "IQA0303", null },
                    { 457, "v1", "OPT0005", null, "IQA0303", null },
                    { 458, "v1", "OPT0308", null, "IQA0238", null },
                    { 459, "v1", "OPT0309", null, "IQA0238", null },
                    { 460, "v1", "OPT0310", null, "IQA0238", null },
                    { 461, "v1", "OPT0311", null, "IQA0238", null },
                    { 462, "v1", "OPT0312", null, "IQA0238", null },
                    { 463, "v1", "OPT0313", null, "IQA0238", null },
                    { 464, "v1", "OPT0314", null, "IQA0238", null },
                    { 465, "v1", "OPT0315", null, "IQA0238", null },
                    { 466, "v1", "OPT0316", null, "IQA0239", null },
                    { 467, "v1", "OPT0317", null, "IQA0239", null },
                    { 468, "v1", "OPT0004", null, "IQA0246", null },
                    { 469, "v1", "OPT0005", null, "IQA0246", null }
                });

            migrationBuilder.InsertData(
                table: "QuestionRules",
                columns: new[] { "RuleId", "VersionId", "Conditions", "Description", "Mode", "ParentQuestionId", "QuestionId", "Sequence" },
                values: new object[,]
                {
                    { 3, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Provide a valid email address\"},{\"Mode\":\"AND\",\"Operator\":\"REGEX\",\"Value\":\"^(?=.{6,50}$)[\\\\w\\\\.\\\\-]\\u002B@[a-zA-Z\\\\d\\\\-]\\u002B\\\\.[a-zA-Z]{2,}$\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Should be a valid email address between 6 and 50 characters \"}]", "Answer the following question, if you have answered Yes to Project Details:Q6", "AND", "IQA0005", "IQA0006", 1 },
                    { 4, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\",\"OPT0009\",\"OPT0013\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0014", 1 },
                    { 5, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Answer the following question, if you have answered Yes to Q3 under Project Scope", "AND", "IQA0014", "IQA0015", 1 },
                    { 6, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers Project Scope:Q2, the following question should be answered", "OR", "IQA0061", "IQA0017", 1 },
                    { 7, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", " or if you have answered No to Project Scope:Q3", "OR", "IQA0014", "IQA0017", 2 },
                    { 8, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q4", "AND", "IQA0017", "IQA0018", 1 },
                    { 9, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q4a", "AND", "IQA0018", "IQA03282", 1 },
                    { 10, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0020", 1 },
                    { 11, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", " and if you have answered No to Project Scope:Q3", "AND", "IQA0014", "IQA0020", 2 },
                    { 12, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", " or if you have answered No to Project Scope:Q4", "OR", "IQA0017", "IQA0020", 3 },
                    { 13, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0012\",\"OPT0013\"],\"OptionType\":\"Multiple\",\"Description\":\"Select an option\"},{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\",\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0021", 1 },
                    { 14, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\",\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0022", 1 },
                    { 15, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0024", 1 },
                    { 16, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0025", 1 },
                    { 17, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0026", 1 },
                    { 18, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0017\"],\"OptionType\":\"Single\",\"Description\":\"Select at least one option\"}]", "Answer the following question, if you have answered Multi-national to Research location:Q1", "AND", "IQA0142", "IQA0143", 1 },
                    { 19, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select at least one option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q3", "AND", "IQA0014", "IQA0033", 1 },
                    { 20, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select at least one option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q3", "AND", "IQA0014", "IQA0034", 1 },
                    { 21, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0033\"],\"OptionType\":\"Single\",\"Description\":\"Provide an answer to this question\"},{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,2000\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Should be between 100 and 2000 characters\"}]", "Answer the following question, if you have answered Other to Research Location:Q4", "AND", "IQA0144", "IQA0145", 1 },
                    { 22, "v1", "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select one option\"}]", "Answer the following question, if you have answered No to Project Scope:Q3", "AND", "IQA0014", "IQA0146", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionSections_QuestionCategoryId_VersionId",
                table: "QuestionSections",
                columns: new[] { "QuestionCategoryId", "VersionId" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionSections_VersionId",
                table: "QuestionSections",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionCategoryId_VersionId",
                table: "Questions",
                columns: new[] { "QuestionCategoryId", "VersionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionSectionId_VersionId",
                table: "Questions",
                columns: new[] { "QuestionSectionId", "VersionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_VersionId",
                table: "Questions",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRules_ParentQuestionId_VersionId",
                table: "QuestionRules",
                columns: new[] { "ParentQuestionId", "VersionId" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRules_VersionId",
                table: "QuestionRules",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionCategories_VersionId",
                table: "QuestionCategories",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_AnswerOptionId_VersionId",
                table: "Answers",
                columns: new[] { "AnswerOptionId", "VersionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId_VersionId",
                table: "Answers",
                columns: new[] { "QuestionId", "VersionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_VersionId",
                table: "Answers",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerOptions_VersionId",
                table: "AnswerOptions",
                column: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerOptions_Versions_VersionId",
                table: "AnswerOptions",
                column: "VersionId",
                principalTable: "Versions",
                principalColumn: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_AnswerOptions_AnswerOptionId_VersionId",
                table: "Answers",
                columns: new[] { "AnswerOptionId", "VersionId" },
                principalTable: "AnswerOptions",
                principalColumns: new[] { "OptionId", "VersionId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId_VersionId",
                table: "Answers",
                columns: new[] { "QuestionId", "VersionId" },
                principalTable: "Questions",
                principalColumns: new[] { "QuestionId", "VersionId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Versions_VersionId",
                table: "Answers",
                column: "VersionId",
                principalTable: "Versions",
                principalColumn: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionCategories_Versions_VersionId",
                table: "QuestionCategories",
                column: "VersionId",
                principalTable: "Versions",
                principalColumn: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRules_Questions_ParentQuestionId_VersionId",
                table: "QuestionRules",
                columns: new[] { "ParentQuestionId", "VersionId" },
                principalTable: "Questions",
                principalColumns: new[] { "QuestionId", "VersionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRules_Versions_VersionId",
                table: "QuestionRules",
                column: "VersionId",
                principalTable: "Versions",
                principalColumn: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionCategories_QuestionCategoryId_VersionId",
                table: "Questions",
                columns: new[] { "QuestionCategoryId", "VersionId" },
                principalTable: "QuestionCategories",
                principalColumns: new[] { "CategoryId", "VersionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionSections_QuestionSectionId_VersionId",
                table: "Questions",
                columns: new[] { "QuestionSectionId", "VersionId" },
                principalTable: "QuestionSections",
                principalColumns: new[] { "SectionId", "VersionId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Versions_VersionId",
                table: "Questions",
                column: "VersionId",
                principalTable: "Versions",
                principalColumn: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionSections_QuestionCategories_QuestionCategoryId_VersionId",
                table: "QuestionSections",
                columns: new[] { "QuestionCategoryId", "VersionId" },
                principalTable: "QuestionCategories",
                principalColumns: new[] { "CategoryId", "VersionId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionSections_Versions_VersionId",
                table: "QuestionSections",
                column: "VersionId",
                principalTable: "Versions",
                principalColumn: "VersionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerOptions_Versions_VersionId",
                table: "AnswerOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_AnswerOptions_AnswerOptionId_VersionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId_VersionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Versions_VersionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionCategories_Versions_VersionId",
                table: "QuestionCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRules_Questions_ParentQuestionId_VersionId",
                table: "QuestionRules");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRules_Versions_VersionId",
                table: "QuestionRules");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionCategories_QuestionCategoryId_VersionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionSections_QuestionSectionId_VersionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Versions_VersionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionSections_QuestionCategories_QuestionCategoryId_VersionId",
                table: "QuestionSections");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionSections_Versions_VersionId",
                table: "QuestionSections");

            migrationBuilder.DropTable(
                name: "Versions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionSections",
                table: "QuestionSections");

            migrationBuilder.DropIndex(
                name: "IX_QuestionSections_QuestionCategoryId_VersionId",
                table: "QuestionSections");

            migrationBuilder.DropIndex(
                name: "IX_QuestionSections_VersionId",
                table: "QuestionSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionCategoryId_VersionId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionSectionId_VersionId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_VersionId",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionRules",
                table: "QuestionRules");

            migrationBuilder.DropIndex(
                name: "IX_QuestionRules_ParentQuestionId_VersionId",
                table: "QuestionRules");

            migrationBuilder.DropIndex(
                name: "IX_QuestionRules_VersionId",
                table: "QuestionRules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionCategories",
                table: "QuestionCategories");

            migrationBuilder.DropIndex(
                name: "IX_QuestionCategories_VersionId",
                table: "QuestionCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_AnswerOptionId_VersionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionId_VersionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_VersionId",
                table: "Answers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerOptions",
                table: "AnswerOptions");

            migrationBuilder.DropIndex(
                name: "IX_AnswerOptions_VersionId",
                table: "AnswerOptions");

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0260", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0261", "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 1, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 2, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 3, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 4, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 5, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 6, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 7, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 8, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 9, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 10, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 11, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 12, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 13, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 14, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 15, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 16, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 17, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 18, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 19, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 20, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 21, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 22, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 23, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 24, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 25, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 26, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 27, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 28, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 29, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 30, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 31, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 32, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 33, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 34, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 35, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 36, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 37, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 38, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 39, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 40, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 41, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 42, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 43, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 44, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 45, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 46, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 47, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 48, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 49, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 51, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 52, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 53, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 54, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 55, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 56, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 57, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 58, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 59, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 60, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 61, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 62, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 63, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 64, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 65, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 66, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 67, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 68, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 69, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 70, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 71, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 72, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 73, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 74, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 75, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 76, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 77, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 78, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 79, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 80, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 81, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 82, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 83, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 84, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 85, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 86, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 87, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 88, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 89, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 90, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 91, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 92, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 93, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 94, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 95, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 96, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 97, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 98, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 99, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 100, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 101, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 102, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 103, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 104, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 105, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 106, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 107, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 108, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 109, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 110, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 111, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 112, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 113, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 114, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 115, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 116, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 117, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 118, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 119, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 120, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 121, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 122, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 123, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 124, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 125, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 126, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 127, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 128, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 129, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 130, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 131, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 132, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 133, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 134, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 135, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 136, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 137, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 138, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 139, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 140, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 141, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 142, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 143, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 144, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 145, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 146, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 147, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 148, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 149, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 150, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 151, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 152, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 153, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 154, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 155, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 156, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 157, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 158, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 159, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 160, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 161, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 162, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 163, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 164, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 165, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 166, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 167, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 168, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 169, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 170, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 171, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 172, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 173, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 174, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 175, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 176, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 177, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 178, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 179, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 180, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 181, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 182, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 183, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 184, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 185, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 186, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 187, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 188, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 189, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 190, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 191, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 192, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 193, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 194, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 195, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 196, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 197, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 198, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 199, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 200, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 201, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 202, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 203, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 204, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 205, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 206, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 207, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 208, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 209, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 210, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 211, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 212, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 213, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 214, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 215, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 216, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 217, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 218, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 219, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 220, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 221, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 222, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 223, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 224, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 225, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 226, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 227, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 228, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 229, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 230, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 231, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 232, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 233, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 234, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 235, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 236, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 237, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 238, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 239, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 240, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 241, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 242, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 243, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 244, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 245, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 246, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 247, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 248, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 249, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 250, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 251, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 252, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 253, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 254, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 255, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 256, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 257, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 258, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 259, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 260, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 261, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 262, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 263, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 264, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 265, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 266, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 267, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 268, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 269, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 270, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 271, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 272, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 273, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 274, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 275, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 276, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 277, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 278, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 279, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 280, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 281, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 282, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 283, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 284, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 285, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 286, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 287, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 288, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 289, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 290, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 291, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 292, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 293, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 294, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 295, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 296, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 297, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 298, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 299, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 300, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 301, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 302, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 303, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 304, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 305, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 306, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 307, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 308, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 309, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 310, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 311, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 312, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 313, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 314, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 315, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 316, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 317, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 318, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 319, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 320, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 321, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 322, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 323, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 324, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 325, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 326, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 327, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 328, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 329, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 330, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 331, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 332, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 333, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 334, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 335, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 336, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 337, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 338, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 339, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 340, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 341, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 342, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 343, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 344, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 345, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 346, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 347, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 348, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 349, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 350, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 351, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 352, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 353, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 354, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 355, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 356, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 357, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 358, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 359, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 360, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 361, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 362, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 363, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 364, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 365, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 366, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 367, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 368, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 369, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 370, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 371, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 372, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 373, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 374, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 375, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 376, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 377, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 378, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 379, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 380, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 381, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 382, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 383, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 384, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 385, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 386, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 387, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 388, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 389, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 390, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 391, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 392, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 393, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 394, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 395, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 396, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 397, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 398, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 399, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 400, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 401, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 402, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 403, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 404, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 405, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 406, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 407, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 408, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 409, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 410, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 411, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 412, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 413, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 414, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 415, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 416, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 417, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 418, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 419, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 420, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 421, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 422, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 423, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 424, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 425, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 426, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 427, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 428, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 429, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 430, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 431, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 432, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 433, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 434, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 435, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 436, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 437, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 438, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 439, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 440, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 441, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 442, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 443, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 444, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 445, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 446, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 447, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 448, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 449, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 450, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 451, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 452, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 453, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 454, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 455, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 456, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 457, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 458, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 459, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 460, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 461, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 462, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 463, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 464, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 465, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 466, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 467, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 468, "v1" });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AnswerId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 469, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 1, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 2, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 3, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 4, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 5, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 6, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 7, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 8, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 9, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 10, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 11, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 12, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 13, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 14, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 15, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 16, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 17, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 18, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 19, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 20, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 21, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionRules",
                keyColumns: new[] { "RuleId", "VersionId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 22, "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0054", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0055", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0056", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0002", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0002", "v2" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0003", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0006", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0023", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0036", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0037", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0039", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0040", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0043", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0044", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0046", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0048", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0050", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0052", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0053", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0057", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0058", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0060", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0062", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0066", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0071", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0072", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0073", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0074", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0075", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0076", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0078", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0080", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0081", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0082", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0084", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0085", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0086", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0087", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0089", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0090", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0091", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0092", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0099", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA00D1", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0100", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0102", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0103", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0104", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0105", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0106", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0107", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0109", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0110", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0112", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0116", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0117", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0119", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0120", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0122", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0123", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0125", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0127", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0128", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0129", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0130", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0131", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0132", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0139", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0140", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0143", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0145", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0148", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0149", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0150", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0151", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0152", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0154", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0156", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0158", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0159", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0163", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0166", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0168", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0170", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0171", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0172", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0174", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0175", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0177", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0178", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0180", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0183", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0184", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0185", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0186", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0187", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0188", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0189", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0190", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0191", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0218", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0220", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0221", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0225", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0226", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0227", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0228", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0229", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0230", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0231", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0232", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0233", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0234", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0235", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0236", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0240", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0241", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0242", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0243", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0245", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0247", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0248", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0249", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0250", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0253", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0256", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0259", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0264", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0266", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0269", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0270", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0273", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0278", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0279", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0280", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0281", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0282", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0283", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0284", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0286", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0287", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0288", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0289", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0290", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0291", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0292", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0294", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0295", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0296", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0297", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0298", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0299", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0300", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0301", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03013", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0302", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0304", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0305", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0306", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0307", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0308", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03248", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03249", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03250", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03251", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03252", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03253", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03254", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03255", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03258", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03259", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03260", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03261", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03263", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03264", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03265", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03266", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03274", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03275", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03276", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03279", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03281", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQG0001", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQG0002", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQG0003", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQG0004", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQG0005", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0001", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0002", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0003", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0004", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0005", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0006", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0007", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0008", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0009", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0010", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0011", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0012", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0013", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0014", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0015", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0016", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0017", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0018", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0019", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0020", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0021", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0022", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0023", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0024", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0025", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0026", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0027", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0028", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0029", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0030", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0031", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0032", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0033", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0034", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0035", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0036", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0037", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0038", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0039", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0040", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0041", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0042", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0043", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0044", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0045", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0046", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0047", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0048", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0049", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0050", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0051", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0052", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0053", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0054", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0055", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0056", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0057", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0058", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0059", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0060", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0061", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0062", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0063", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0064", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0065", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0066", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0067", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0068", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0069", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0070", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0071", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0072", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0073", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0074", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0075", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0076", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0077", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0078", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0079", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0080", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0081", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0082", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0083", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0084", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0085", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0086", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0087", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0088", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0089", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0090", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0091", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0092", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0093", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0094", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0095", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0096", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0097", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0098", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0099", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0100", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0101", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0102", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0103", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0104", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0105", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0106", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0107", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0108", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0109", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0110", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0111", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0112", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0113", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0114", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0115", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0116", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0117", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0118", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0119", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0120", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0121", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0122", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0123", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0124", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0125", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0126", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0127", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0128", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0129", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0130", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0131", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0132", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0133", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0134", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0135", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0136", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0137", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0138", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0139", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0140", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0141", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0142", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0143", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0144", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0145", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0146", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0147", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0148", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0149", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0150", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0151", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0152", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0153", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0154", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0155", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0156", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0157", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0158", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0159", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0160", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0161", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0162", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0163", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0164", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0165", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0166", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0167", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0168", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0169", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0170", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0171", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0172", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0173", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0174", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0175", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0176", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0177", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0178", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0179", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0180", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0181", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0182", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0183", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0184", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0185", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0186", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0187", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0188", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0189", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0190", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0191", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0192", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0193", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0194", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0195", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0196", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0197", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0198", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0199", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0200", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0201", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0202", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0203", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0204", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0205", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0206", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0207", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0208", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0209", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0210", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0211", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0212", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0213", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0214", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0215", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0216", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0217", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0218", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0219", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0220", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0221", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0222", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0223", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0224", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0225", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0226", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0227", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0228", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0229", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0230", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0231", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0232", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0233", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0234", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0235", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0236", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0237", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0238", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0239", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0240", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0241", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0242", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0243", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0244", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0245", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0246", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0247", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0248", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0249", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0250", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0251", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0252", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0253", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0254", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0255", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0256", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0257", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0258", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0259", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0262", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0263", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0264", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0265", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0266", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0267", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0268", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0269", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0270", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0271", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0272", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0273", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0274", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0275", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0276", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0277", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0278", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0279", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0280", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0281", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0282", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0283", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0284", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0285", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0286", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0287", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0288", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0289", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0290", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0291", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0292", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0293", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0294", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0295", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0296", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0297", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0298", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0299", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0300", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0301", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0302", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0303", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0304", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0305", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0306", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0307", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0308", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0309", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0310", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0311", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0312", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0313", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0314", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0315", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0316", "v1" });

            migrationBuilder.DeleteData(
                table: "AnswerOptions",
                keyColumns: new[] { "OptionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "OPT0317", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "C2", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "C3", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "C5", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0001", "v2" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0005", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0057", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0001", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0004", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0005", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0012", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0014", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0015", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0017", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0018", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0020", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0021", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0022", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0024", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0025", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0026", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0027", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0028", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0029", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0032", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0033", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0034", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0042", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0045", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0049", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0051", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0054", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0055", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0056", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0061", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0063", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0064", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0065", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0068", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0070", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0077", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0079", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0083", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0088", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0093", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0095", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0096", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0097", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0098", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0108", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0111", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0113", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0114", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0115", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0118", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0121", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0124", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0126", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0142", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0144", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0146", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0147", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0153", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0155", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0157", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0162", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0165", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0167", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0169", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0173", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0176", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0179", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0181", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0182", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0219", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0222", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0223", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0224", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0237", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0238", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0239", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0246", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0251", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0254", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0255", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0257", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0258", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0260", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0261", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0262", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0263", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0265", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0267", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0268", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0271", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0272", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0285", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0293", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03010", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03011", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03012", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03014", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03015", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0303", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA0309", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03247", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03256", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03257", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03262", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03271", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03273", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03277", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03278", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03280", "v1" });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "QuestionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQA03282", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "A", "v2" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "D", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0001", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0003", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0004", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0006", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0007", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0008", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0009", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0010", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0011", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0012", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0013", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0014", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0015", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0019", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0020", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0021", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0022", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0022.3", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0023", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0024", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0025", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionSections",
                keyColumns: new[] { "SectionId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "IQT0053", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "A", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "B", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "C1", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "C4", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "C6", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "C7", "v1" });

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumns: new[] { "CategoryId", "VersionId" },
                keyColumnTypes: new[] { "nvarchar(450)", "nvarchar(450)" },
                keyValues: new object[] { "C8", "v1" });

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "QuestionSections");

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "QuestionRules");

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "QuestionCategories");

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "AnswerOptions");

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "QuestionSections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QuestionId",
                table: "QuestionRules",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "QuestionCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "AnswerOptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionSections",
                table: "QuestionSections",
                column: "SectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionRules",
                table: "QuestionRules",
                column: "RuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionCategories",
                table: "QuestionCategories",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "AnswerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerOptions",
                table: "AnswerOptions",
                column: "OptionId");

            migrationBuilder.InsertData(
                table: "AnswerOptions",
                columns: new[] { "OptionId", "EndDate", "OptionText", "StartDate", "Version" },
                values: new object[,]
                {
                    { "OPT0001", null, "Project deputy", null, null },
                    { "OPT0002", null, "Chief investigator", null, null },
                    { "OPT0003", null, "Sponsor contact", null, null },
                    { "OPT0004", null, "Yes", null, null },
                    { "OPT0005", null, "No", null, null },
                    { "OPT0006", null, "Use of previously collected data about people", null, null },
                    { "OPT0007", null, "Use of previously collected human biological samples", null, null },
                    { "OPT0008", null, "Research involving staff only", null, null },
                    { "OPT0009", null, "Non-clinical activities with staff, such as interviews, questionnaires or observation", null, null },
                    { "OPT0010", null, "Non-clinical activities with people (other than staff), such as interviews or surveys", null, null },
                    { "OPT0011", null, "Non-clinical activities with people, such as non-clinical assessments, observations or care procedures", null, null },
                    { "OPT0012", null, "Clinical activities with people, such as collecting human biological samples, imaging investigations or diagnostics", null, null },
                    { "OPT0013", null, "Treatment, such as medicines, devices, surgery, vaccines or therapies", null, null },
                    { "OPT0014", null, "clinical trial of an investigational medicinal product", null, null },
                    { "OPT0015", null, "combined trial of an investigational medicinal product and an investigational medical device", null, null },
                    { "OPT0016", null, "UK only", null, null },
                    { "OPT0017", null, "Multi-national", null, null },
                    { "OPT0018", null, "England", null, null },
                    { "OPT0019", null, "Northern Ireland", null, null },
                    { "OPT0020", null, "Scotland", null, null },
                    { "OPT0021", null, "Wales", null, null },
                    { "OPT0022", null, "Independent primary care contractors", null, null },
                    { "OPT0023", null, "Independent research units", null, null },
                    { "OPT0024", null, "Local councils", null, null },
                    { "OPT0025", null, "NHS or HSC organisations", null, null },
                    { "OPT0026", null, "Phase 1 trial units (non-NHS or HSC organisation)", null, null },
                    { "OPT0027", null, "Prison or probation setting", null, null },
                    { "OPT0028", null, "Schools or other educational establishments", null, null },
                    { "OPT0029", null, "Social care settings", null, null },
                    { "OPT0030", null, "University", null, null },
                    { "OPT0031", null, "Voluntary sector or private organisations", null, null },
                    { "OPT0032", null, "Community settings", null, null },
                    { "OPT0033", null, "Other", null, null },
                    { "OPT0034", null, "Not applicable", null, null },
                    { "OPT0035", null, "identifying, developing, or prioritising the research question", null, null },
                    { "OPT0036", null, "being a member of a research advisory or reference group", null, null },
                    { "OPT0037", null, "being a member of the Trial Management Group or Data Monitoring Committee", null, null },
                    { "OPT0038", null, "developing the research methods (for example, designing questionnaires, or defining endpoints or outcome measures)", null, null },
                    { "OPT0039", null, "ensuring that the design of the research is feasible from the perspective of the participants (for example, identifying potential emotional or practical obstacles for research participants)", null, null },
                    { "OPT0040", null, "designing the inclusion and exclusion criteria including consideration of the demographic diversity of the study population", null, null },
                    { "OPT0041", null, "developing the risk or benefit analysis (for example, identifying and evaluating the probable risks and burden involved for research participants)", null, null },
                    { "OPT0042", null, "developing the recruitment and consent process (for example, how and when to approach potential participants)", null, null },
                    { "OPT0043", null, "developing participant information sheets, the consent forms, and other documents which are used to communicate with potential research participants", null, null },
                    { "OPT0044", null, "developing plain language research summaries", null, null },
                    { "OPT0045", null, "developing or delivering training to staff", null, null },
                    { "OPT0046", null, "developing the dissemination plan for the research", null, null },
                    { "OPT0047", null, "preparing regulatory submissions", null, null },
                    { "OPT0048", null, "planning to attend the Research Ethics Committee meetings to help explain how and why the research design is likely to be acceptable to research participants", null, null },
                    { "OPT0049", null, "patients, service users or their carers, or members of the public have not been involved", null, null },
                    { "OPT0050", null, "we have existing arrangements in our organisation or team for involving patients, carers, service users or members of the public", null, null },
                    { "OPT0051", null, "we asked an existing patient and public involvement group external to our organisation or team (for example, run by an NHS Trust, university, charity, local councils)", null, null },
                    { "OPT0052", null, "we set up a new arrangement to involve patients, carers, service users or members of the public in our project (for example, posted the opportunity on the People in Research website, local noticeboards, or through a community organisation)", null, null },
                    { "OPT0053", null, "we were approached by some patients, carers, service users, a patient group, or a charity with a suggestion for this research and we have worked with them to develop it", null, null },
                    { "OPT0054", null, "being a member of research advisory or reference group", null, null },
                    { "OPT0055", null, "helping to promote this research", null, null },
                    { "OPT0056", null, "carrying out research activities (for example, facilitating focus groups, interviewing or administering questionnaires)", null, null },
                    { "OPT0057", null, "analysing the research findings", null, null },
                    { "OPT0058", null, "contributing to further regulatory submissions (such as amendments)", null, null },
                    { "OPT0059", null, "sharing research results (for example, by presenting at conferences or disseminating the research findings via social media)", null, null },
                    { "OPT0060", null, "developing plain language summaries of the results", null, null },
                    { "OPT0061", null, "there is no plan to involve public contributors in the remaining stages of the research process", null, null },
                    { "OPT0062", null, "case series or case note review", null, null },
                    { "OPT0063", null, "case control", null, null },
                    { "OPT0064", null, "cohort observation", null, null },
                    { "OPT0065", null, "controlled trial without randomisation", null, null },
                    { "OPT0066", null, "cross-sectional study", null, null },
                    { "OPT0067", null, "database analysis", null, null },
                    { "OPT0068", null, "epidemiology", null, null },
                    { "OPT0069", null, "feasibility or pilot study", null, null },
                    { "OPT0070", null, "laboratory study", null, null },
                    { "OPT0071", null, "metanalysis", null, null },
                    { "OPT0072", null, "qualitative research", null, null },
                    { "OPT0073", null, "questionnaire, interview or observation study", null, null },
                    { "OPT0074", null, "randomised controlled trial", null, null },
                    { "OPT0075", null, "basket trial", null, null },
                    { "OPT0076", null, "bayesian", null, null },
                    { "OPT0077", null, "blinded", null, null },
                    { "OPT0078", null, "cluster-randomised", null, null },
                    { "OPT0079", null, "comparative", null, null },
                    { "OPT0080", null, "cross-over", null, null },
                    { "OPT0081", null, "double-blinded", null, null },
                    { "OPT0082", null, "open", null, null },
                    { "OPT0083", null, "other complex or innovative design", null, null },
                    { "OPT0084", null, "parallel arms", null, null },
                    { "OPT0085", null, "platform trial", null, null },
                    { "OPT0086", null, "real-world", null, null },
                    { "OPT0087", null, "targeted or stratified", null, null },
                    { "OPT0088", null, "umbrella trial", null, null },
                    { "OPT0089", null, "designing, developing or testing an AI product or tool", null, null },
                    { "OPT0090", null, "using an existing AI product or tool for its intended purpose", null, null },
                    { "OPT0091", null, "the project does not involve the use of AI", null, null },
                    { "OPT0092", null, "image analysis", null, null },
                    { "OPT0093", null, "other machine learning applications", null, null },
                    { "OPT0094", null, "natural language processing", null, null },
                    { "OPT0095", null, "generative AI or large language models", null, null },
                    { "OPT0096", null, "robotics", null, null },
                    { "OPT0097", null, "blood", null, null },
                    { "OPT0098", null, "cancer and neoplasms", null, null },
                    { "OPT0099", null, "cardiovascular", null, null },
                    { "OPT0100", null, "congenital disorders", null, null },
                    { "OPT0101", null, "ear", null, null },
                    { "OPT0102", null, "eye", null, null },
                    { "OPT0103", null, "infection", null, null },
                    { "OPT0104", null, "inflammatory and immune system", null, null },
                    { "OPT0105", null, "injuries and accidents", null, null },
                    { "OPT0106", null, "mental health", null, null },
                    { "OPT0107", null, "metabolic and endocrine", null, null },
                    { "OPT0108", null, "musculoskeletal", null, null },
                    { "OPT0109", null, "neurological", null, null },
                    { "OPT0110", null, "oral and gastrointestinal", null, null },
                    { "OPT0111", null, "renal and urogenital", null, null },
                    { "OPT0112", null, "reproductive health and childbirth", null, null },
                    { "OPT0113", null, "respiratory", null, null },
                    { "OPT0114", null, "skin", null, null },
                    { "OPT0115", null, "stroke", null, null },
                    { "OPT0116", null, "generic health relevance", null, null },
                    { "OPT0117", null, "disputed aetiology and other", null, null },
                    { "OPT0118", null, "Carers, parents or legal guardians of patients or participants", null, null },
                    { "OPT0119", null, "Healthy volunteers or controls", null, null },
                    { "OPT0120", null, "Members of the public", null, null },
                    { "OPT0121", null, "Patients or service users of NHS or HSC provided or commissioned services", null, null },
                    { "OPT0122", null, "Patients in nursing homes or independent health care clinics in Northern Ireland", null, null },
                    { "OPT0123", null, "People who are known to be deceased prior to the project starting", null, null },
                    { "OPT0124", null, "Residents in residential care homes in Northern Ireland", null, null },
                    { "OPT0125", null, "Residents in nursing homes, care homes or residential care in England, Scotland or Wales", null, null },
                    { "OPT0126", null, "Service users in other social care settings", null, null },
                    { "OPT0127", null, "Staff working in NHS or HSC provided or commissioned services", null, null },
                    { "OPT0128", null, "use of validated questionnaires within their intended purpose and intended population", null, null },
                    { "OPT0129", null, "use of validated questionnaires outside of their intended purpose and population", null, null },
                    { "OPT0130", null, "use of non-validated questionnaires", null, null },
                    { "OPT0131", null, "no questionnaires included in project", null, null },
                    { "OPT0132", null, "Treatment will continue to be provided once the project has finished", null, null },
                    { "OPT0133", null, "Treatment will not continue to be provided once the project has finished", null, null },
                    { "OPT0134", null, "only adults with capacity to consent for themselves as participants", null, null },
                    { "OPT0135", null, "only adults lacking capacity to consent for themselves", null, null },
                    { "OPT0136", null, "both adults with capacity and lacking capacity to consent for themselves", null, null },
                    { "OPT0137", null, "Consent will be obtained from all participants\n", null, null },
                    { "OPT0138", null, "Consent will not be obtained from any participants", null, null },
                    { "OPT0139", null, "Consent will not be obtained in some situations", null, null },
                    { "OPT0140", null, "Consent will not be obtained for the use of non-identifiable data or samples", null, null },
                    { "OPT0141", null, "Consent will not be obtained for access to data by the usual care team", null, null },
                    { "OPT0142", null, "The participant would be withdrawn from the project. Identifiable data or tissue already collected with consent would be retained and used. No further data or tissue would be collected or any other research procedures carried out on or in relation to the participant.", null, null },
                    { "OPT0143", null, "The participant would continue to be included in the project.", null, null },
                    { "OPT0144", null, "Not applicable - informed consent will not be sought from any participants in this project.", null, null },
                    { "OPT0145", null, "East Midlands - Derby", null, null },
                    { "OPT0146", null, "East Midlands - Leicester Central", null, null },
                    { "OPT0147", null, "East Midlands - Leicester South", null, null },
                    { "OPT0148", null, "East Midlands - Nottingham 1", null, null },
                    { "OPT0149", null, "East Midlands - Nottingham 2", null, null },
                    { "OPT0150", null, "East of England - Cambridgeshire and Hertfordshire", null, null },
                    { "OPT0151", null, "East of England - Essex", null, null },
                    { "OPT0152", null, "East of England - Cambridge Central", null, null },
                    { "OPT0153", null, "East of England - Cambridge East", null, null },
                    { "OPT0154", null, "East of England - Cambridge South", null, null },
                    { "OPT0155", null, "East of Scotland Research Ethics Service REC 1", null, null },
                    { "OPT0156", null, "East of Scotland Research Ethics Service REC 2", null, null },
                    { "OPT0157", null, "Health and Social Care Research Ethics Committee A (HSC REC A)", null, null },
                    { "OPT0158", null, "Health and Social Care Research Ethics Committee B (HSC REC B)", null, null },
                    { "OPT0159", null, "London - Bloomsbury", null, null },
                    { "OPT0160", null, "London - Camden and Kings Cross", null, null },
                    { "OPT0161", null, "London - Central", null, null },
                    { "OPT0162", null, "London - Brent", null, null },
                    { "OPT0163", null, "London - Brighton and Sussex", null, null },
                    { "OPT0164", null, "London - Bromley", null, null },
                    { "OPT0165", null, "London - Camberwell St Giles", null, null },
                    { "OPT0166", null, "London - Chelsea", null, null },
                    { "OPT0167", null, "London - City and East", null, null },
                    { "OPT0168", null, "London - Dulwich", null, null },
                    { "OPT0169", null, "London - Fulham", null, null },
                    { "OPT0170", null, "London - Hampstead", null, null },
                    { "OPT0171", null, "London - Harrow", null, null },
                    { "OPT0172", null, "London - London Bridge", null, null },
                    { "OPT0173", null, "London - Queen Square", null, null },
                    { "OPT0174", null, "London - Riverside", null, null },
                    { "OPT0175", null, "London - South East", null, null },
                    { "OPT0176", null, "London - Stanmore", null, null },
                    { "OPT0177", null, "London - Surrey", null, null },
                    { "OPT0178", null, "London - Surrey Borders", null, null },
                    { "OPT0179", null, "London - West London & GTAC", null, null },
                    { "OPT0180", null, "London - Westminster", null, null },
                    { "OPT0181", null, "Social Care Research Ethics Committee", null, null },
                    { "OPT0182", null, "North East - Newcastle and North Tyneside 1", null, null },
                    { "OPT0183", null, "North East - Newcastle and North Tyneside 2", null, null },
                    { "OPT0184", null, "North East - Tyne & Wear South", null, null },
                    { "OPT0185", null, "North East - York", null, null },
                    { "OPT0186", null, "North of Scotland Research Ethics Committee 1", null, null },
                    { "OPT0187", null, "North of Scotland Research Ethics Committee 2", null, null },
                    { "OPT0188", null, "North West - Greater Manchester (GM) Central", null, null },
                    { "OPT0189", null, "North West - Greater Manchester (GM) East", null, null },
                    { "OPT0190", null, "North West - Greater Manchester (GM) South", null, null },
                    { "OPT0191", null, "North West - Greater Manchester (GM) West", null, null },
                    { "OPT0192", null, "North West - Haydock", null, null },
                    { "OPT0193", null, "North West - Liverpool Central", null, null },
                    { "OPT0194", null, "North West - Liverpool East", null, null },
                    { "OPT0195", null, "North West - Preston", null, null },
                    { "OPT0196", null, "Scotland A Research Ethics Committee", null, null },
                    { "OPT0197", null, "South Central - Berkshire B", null, null },
                    { "OPT0198", null, "South Central - Hampshire A", null, null },
                    { "OPT0199", null, "South Central - Hampshire B", null, null },
                    { "OPT0200", null, "South Central - Berkshire", null, null },
                    { "OPT0201", null, "South Central - Oxford A", null, null },
                    { "OPT0202", null, "South Central - Oxford B", null, null },
                    { "OPT0203", null, "South Central - Oxford C", null, null },
                    { "OPT0204", null, "South East Scotland Research Ethics Committee 1", null, null },
                    { "OPT0205", null, "South East Scotland Research Ethics Committee 2", null, null },
                    { "OPT0206", null, "South West - Central Bristol", null, null },
                    { "OPT0207", null, "South West - Cornwall and Plymouth", null, null },
                    { "OPT0208", null, "South West - Exeter", null, null },
                    { "OPT0209", null, "South West - Frenchay", null, null },
                    { "OPT0210", null, "Wales REC 1", null, null },
                    { "OPT0211", null, "Wales REC 2", null, null },
                    { "OPT0212", null, "Wales REC 3", null, null },
                    { "OPT0213", null, "Wales REC 4", null, null },
                    { "OPT0214", null, "Wales REC 5", null, null },
                    { "OPT0215", null, "Wales REC 6", null, null },
                    { "OPT0216", null, "Wales REC 7", null, null },
                    { "OPT0217", null, "West Midlands - Edgbaston", null, null },
                    { "OPT0218", null, "West Midlands - Coventry and Warwickshire", null, null },
                    { "OPT0219", null, "West Midlands - Solihull", null, null },
                    { "OPT0220", null, "West Midlands - South Birmingham", null, null },
                    { "OPT0221", null, "West Midlands - The Black Country", null, null },
                    { "OPT0222", null, "West of Scotland REC 1", null, null },
                    { "OPT0223", null, "West of Scotland REC 3", null, null },
                    { "OPT0224", null, "West of Scotland REC 4", null, null },
                    { "OPT0225", null, "West of Scotland REC 5", null, null },
                    { "OPT0226", null, "Yorkshire and the Humber - Bradford Leeds", null, null },
                    { "OPT0227", null, "Yorkshire and the Humber - Leeds East", null, null },
                    { "OPT0228", null, "Yorkshire and the Humber - Leeds West", null, null },
                    { "OPT0229", null, "Yorkshire and the Humber - Sheffield", null, null },
                    { "OPT0230", null, "Yorkshire and the Humber - South Yorkshire", null, null },
                    { "OPT0231", null, "has previously received an unfavourable opinion by a REC in the UK", null, null },
                    { "OPT0232", null, "has previously received an unfavourable opinion by a REC in another country", null, null },
                    { "OPT0233", null, "linked to another project", null, null },
                    { "OPT0234", null, "none of the above", null, null },
                    { "OPT0235", null, "Independent external review", null, null },
                    { "OPT0236", null, "Review within a company", null, null },
                    { "OPT0237", null, "Review within a multi−centre research group", null, null },
                    { "OPT0238", null, "Review within the Chief Investigator's institution or host organisation", null, null },
                    { "OPT0239", null, "Review within the research team", null, null },
                    { "OPT0240", null, "Review by educational supervisor", null, null },
                    { "OPT0241", null, "Qualititative", null, null },
                    { "OPT0242", null, "Quantitative", null, null },
                    { "OPT0243", null, "Review by independent statistician commissioned by funder or sponsor", null, null },
                    { "OPT0244", null, "Other review by independent statistician", null, null },
                    { "OPT0245", null, "Review by company statistician", null, null },
                    { "OPT0246", null, "Review by a statistician within the Chief Investigator’s institution", null, null },
                    { "OPT0247", null, "Review by a statistician within the research team or multi−centre group", null, null },
                    { "OPT0248", null, "Other review by individual with relevant statistical expertise", null, null },
                    { "OPT0249", null, "No review necessary as only frequencies and associations will be assessed", null, null },
                    { "OPT0250", null, "Remote monitoring by sponsor or delegate", null, null },
                    { "OPT0251", null, "Self-monitoring by site", null, null },
                    { "OPT0252", null, "On-site monitoring by sponsor or delegate", null, null },
                    { "OPT0253", null, "No deferral requested", null, null },
                    { "OPT0254", null, "I request a deferral of registration and research summary publication - for protection of commercially confidential information", null, null },
                    { "OPT0255", null, "I request a deferral of registration and research summary publication - other reason", null, null },
                    { "OPT0256", null, "The project will be registered in a registry", null, null },
                    { "OPT0257", null, "Other arrangements are in place", null, null },
                    { "OPT0258", null, "ISRCTN", null, null },
                    { "OPT0259", null, "Clinicaltrials.gov", null, null },
                    { "OPT0260", null, "I request a deferral of research summary publication - for protection of commercially confidential information", null, null },
                    { "OPT0261", null, "I request deferral of research summary publication - other reason", null, null },
                    { "OPT0262", null, "Peer reviewed scientific journals", null, null },
                    { "OPT0263", null, "Internal report", null, null },
                    { "OPT0264", null, "Conference presentation", null, null },
                    { "OPT0265", null, "Publication on website", null, null },
                    { "OPT0266", null, "Other publication", null, null },
                    { "OPT0267", null, "Submission to regulatory authorities", null, null },
                    { "OPT0268", null, "Access to raw data and right to publish freely by all investigators in study or by Independent Steering Committee on behalf of all investigators", null, null },
                    { "OPT0269", null, "No plans to report or disseminate the results", null, null },
                    { "OPT0270", null, "Undergraduate or below", null, null },
                    { "OPT0271", null, "Masters or equivalent", null, null },
                    { "OPT0272", null, "Doctoral or equivalent", null, null },
                    { "OPT0273", null, "Eligible and Supplementary Declaration A included", null, null },
                    { "OPT0274", null, "Eligible and Supplementary Declaration B included", null, null },
                    { "OPT0275", null, "Eligible and Supplementary Declaration C included", null, null },
                    { "OPT0276", null, "Academic supervisor\n", null, null },
                    { "OPT0277", null, "Student", null, null },
                    { "OPT0278", null, "Clinical investigation for UKCA/CE UKNI/CE marking purposes (includes investigation of a UKCA/CE UKNI/CE marked device outside its current intended purposes or in modified form)", null, null },
                    { "OPT0279", null, "Combined clinical investigation for UKCA/CE UKNI/CE marking purposes and clinical trial of an investigational medicinal product", null, null },
                    { "OPT0280", null, "Post-market clinical study of one or more UKCA/CE UKNI/CE marked devices within intended purposes, involving a change to standard care or randomisation between groups", null, null },
                    { "OPT0281", null, "Registry of a UKCA/CE UKNI/CE marked device in clinical use, involving no change to standard care or randomisation", null, null },
                    { "OPT0282", null, "Performance evaluation of an in vitro diagnostic device (PEIVDD)", null, null },
                    { "OPT0283", null, "Clinical study of a non-UKCA/CE UKNI/CE marked device", null, null },
                    { "OPT0284", null, "Clinical study of a non-UKCA/CE UKNI/CE marked device for use within the institution, where commercialisation is not intended", null, null },
                    { "OPT0285", null, "Clinical study of one or more UKCA/CE UKNI/CE marked devices for an off-label indication", null, null },
                    { "OPT0286", null, "Clinical study of one or more UKCA/CE UKNI/CE marked devices for a labelled indication, involving a change to standard care or randomisation between groups", null, null },
                    { "OPT0287", null, "Clinical study of one or more UKCA/CE UKNI/CE marked devices for a labelled indication, involving no change to standard care or randomisation between groups", null, null },
                    { "OPT0288", null, "Pre-clinical device development or performance testing", null, null },
                    { "OPT0289", null, "MHRA and REC", null, null },
                    { "OPT0290", null, "REC only", null, null },
                    { "OPT0291", null, "Investigation of a new medical device", null, null },
                    { "OPT0292", null, "Investigation of a new implantable material", null, null },
                    { "OPT0293", null, "Use of an existing product outside the terms of its UKCA/CE marked intended purpose", null, null },
                    { "OPT0294", null, "Use of a modified product", null, null },
                    { "OPT0295", null, "Use of an existing product within its UKCA/CE UKNI/CE intended purpose.", null, null },
                    { "OPT0296", null, "Living", null, null },
                    { "OPT0297", null, "Deceased", null, null },
                    { "OPT0298", null, "Study-specific arrangements", null, null },
                    { "OPT0299", null, "In line with normal clinical arrangements for the organisation", null, null },
                    { "OPT0300", null, "Transfer to research tissue bank", null, null },
                    { "OPT0301", null, "Storage by research team pending ethical approval for use in another project", null, null },
                    { "OPT0302", null, "Storage by research team as part of a new research tissue bank", null, null },
                    { "OPT0303", null, "Storage by research team of biological material which is not “relevant material” for the purposes of the Human Tissue Act", null, null },
                    { "OPT0304", null, "Disposal in accordance with the Human Tissue Authority’s Code of Practice", null, null },
                    { "OPT0305", null, "Not yet known", null, null },
                    { "OPT0306", null, "Potential to benefit the participant without imposing a disproportionate burden", null, null },
                    { "OPT0307", null, "Provide knowledge of the causes of, or treatment or care of others with, the same or a similar condition", null, null },
                    { "OPT0308", null, "In utero", null, null },
                    { "OPT0309", null, "Preterm newborn infants (up to gestational age less than 37 weeks)", null, null },
                    { "OPT0310", null, "Newborn (0 to 27 days)", null, null },
                    { "OPT0311", null, "28 days to 23 months", null, null },
                    { "OPT0312", null, "2 to 11 years", null, null },
                    { "OPT0313", null, "12 to 17 years", null, null },
                    { "OPT0314", null, "12 to 15 years", null, null },
                    { "OPT0315", null, "16 years", null, null },
                    { "OPT0316", null, "Children who will be unable to fully understand", null, null },
                    { "OPT0317", null, "Children who will be able to understand", null, null }
                });

            migrationBuilder.InsertData(
                table: "QuestionCategories",
                columns: new[] { "CategoryId", "CategoryName", "EndDate", "IsActive", "StartDate", "Version" },
                values: new object[,]
                {
                    { "A", "Project Filter", null, true, null, null },
                    { "B", "Project Details", null, true, null, null },
                    { "C1", "Student", null, true, null, null },
                    { "C2", "Research Bioresouces", null, true, null, null },
                    { "C3", "CTIMP", null, true, null, null },
                    { "C4", "Devices", null, true, null, null },
                    { "C5", "Ionising Radiation", null, true, null, null },
                    { "C6", "Tissue", null, true, null, null },
                    { "C7", "Adults lacking capacity (ALC)", null, true, null, null },
                    { "C8", "Children", null, true, null, null },
                    { "D", "Booking", null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "QuestionSections",
                columns: new[] { "SectionId", "EndDate", "IsActive", "QuestionCategoryId", "SectionName", "StartDate", "Version" },
                values: new object[,]
                {
                    { "IQT0001", null, true, "A", "Project Details", null, null },
                    { "IQT0003", null, true, "A", "Project Scope", null, null },
                    { "IQT0004", null, true, "A", "Research Location", null, null },
                    { "IQT0005", null, true, "B", "Project Information", null, null },
                    { "IQT0006", null, true, "B", "Public Involvement", null, null },
                    { "IQT0007", null, true, "B", "Research Design and Methodology", null, null },
                    { "IQT0008", null, true, "B", "Research Activities", null, null },
                    { "IQT0009", null, true, "B", "Participants", null, null },
                    { "IQT0010", null, true, "B", "Consent", null, null },
                    { "IQT0011", null, true, "B", "Risk and Conflicts of Interest", null, null },
                    { "IQT0012", null, true, "B", "Summary Ethical Issues", null, null },
                    { "IQT0013", null, true, "B", "Research Analysis", null, null },
                    { "IQT0014", null, true, "B", "Governance and Management", null, null },
                    { "IQT0015", null, true, "B", "Transparency", null, null },
                    { "IQT0019", null, true, "C1", "Educational Project", null, null },
                    { "IQT0020", null, true, "C8", "Children", null, null },
                    { "IQT0021", null, true, "B", "Confidentiality and Information Governance", null, null },
                    { "IQT0022", null, true, "C6", "Human Biological Samples", null, null },
                    { "IQT0022.3", null, true, "C6", "Health-related findings", null, null },
                    { "IQT0023", null, true, "C7", "Adults Lacking Capacity (CTIMP)", null, null },
                    { "IQT0024", null, true, "C7", "Adults Lacking Capacity (Non CTIMP)", null, null },
                    { "IQT0025", null, true, "C4", "Devices Filter Questions", null, null },
                    { "IQT0053", null, true, "C4", "Device investigations not requiring review by MHRA", null, null },
                    { "IQT0054", null, true, "C2", "Research Bioresource", null, null },
                    { "IQT0055", null, true, "C3", "CTIMP", null, null },
                    { "IQT0056", null, true, "C5", "Ionising Radiation", null, null },
                    { "IQT0057", null, true, "D", "Application Booking", null, null }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Conformance", "DataType", "DeletedAt", "EndDate", "Heading", "IsDeleted", "QuestionCategoryId", "QuestionSectionId", "QuestionText", "QuestionType", "Sequence", "StartDate", "Version" },
                values: new object[,]
                {
                    { "IQA0001", "Mandatory", "TBC", null, null, "2", false, "A", "IQT0001", "Identify your role", "Look-up list", 2, null, null },
                    { "IQA0002", "Mandatory", "Text", null, null, "1", false, "A", "IQT0001", "Short project title", "Text", 1, null, null },
                    { "IQA0003", "Mandatory", "Text", null, null, "3", false, "A", "IQT0001", "Full project title", "Text", 3, null, null },
                    { "IQA0004", "Mandatory", "Boolean", null, null, "4", false, "A", "IQT0001", "Is this project likely to be managed as commercial research?", "Boolean", 4, null, null },
                    { "IQA0005", "Mandatory", "Boolean", null, null, "6", false, "A", "IQT0001", "Do you wish to access one or more of the CPMS services? If you select 'Yes', IRAS will share information with the CPMS once the 'continue' button at the bottom of the page has been pressed.", "Boolean", 7, null, null },
                    { "IQA0006", "Conditional", "Email", null, null, "6a", false, "A", "IQT0001", "Provide the email of the person who will be the initial contact for CPMS.", "Text", 8, null, null },
                    { "IQA0012", "Mandatory", "Boolean", null, null, "1", false, "A", "IQT0003", "Is the research project or any part of it being undertaken as an educational project?", "Boolean", 1, null, null },
                    { "IQA0014", "Conditional", "Boolean", null, null, "3", false, "A", "IQT0003", "Is this application to establis a research bioresource?", "Boolean", 3, null, null },
                    { "IQA0015", "Conditional", "Boolean", null, null, "3a", false, "A", "IQT0003", "Will the bioresource be established within a NHS or HSC diagnostic archive?", "Boolean", 4, null, null },
                    { "IQA0017", "Conditional", "Boolean", null, null, "4", false, "A", "IQT0003", "Is this project a clinical trial of an investigational medicinal product (CTIMP)?", "Boolean", 5, null, null },
                    { "IQA0018", "Conditional", "Boolean", null, null, "4a", false, "A", "IQT0003", "Select the option that applies to your project:", "Boolean", 6, null, null },
                    { "IQA0020", "Conditional", "Boolean", null, null, "5", false, "A", "IQT0003", "Is this project a clinical investigation or other study of a medical device (including digital technology)?", "Boolean", 8, null, null },
                    { "IQA0021", "Conditional", "Boolean", null, null, "6", false, "A", "IQT0003", "Does the project involve exposing participants to any ionising radiation?", "Boolean", 9, null, null },
                    { "IQA0022", "Conditional", "Boolean", null, null, "7", false, "A", "IQT0003", "Will you be taking or using any human biological samples?", "Boolean", 10, null, null },
                    { "IQA0023", "Conditional", "Radio button", null, null, "7a", false, "A", "IQT0003", "Select the option that applies to your project:", "Look-up list", 11, null, null },
                    { "IQA0024", "Conditional", "Boolean", null, null, "8", false, "A", "IQT0003", "Will identifiable patient data be accessed outside the care team without prior consent at any stage of the project (including identification of potential participants)?", "Boolean", 12, null, null },
                    { "IQA0025", "Conditional", "Boolean", null, null, "9", false, "A", "IQT0003", "Do you plan at any stage of the project to undertake research with adults lacking capacity to consent for themselves that would otherwise require consent?", "Boolean", 13, null, null },
                    { "IQA0026", "Conditional", "Boolean", null, null, "10", false, "A", "IQT0003", "Will you include any participants who are children?", "Boolean", 14, null, null },
                    { "IQA0027", "Mandatory", "Boolean", null, null, "11", false, "A", "IQT0003", "Will you include any participants who are prisoners or young offenders in the custody of His Majesty's Prison and Probation Service (HMPPS) or who are offenders supervised by the probation service in England or Wales?", "Boolean", 15, null, null },
                    { "IQA0028", "Mandatory", "Boolean", null, null, "12", false, "A", "IQT0003", "Will this project involve any activity under the responsibility of the Ministry of Defence (MOD)?", "Boolean", 16, null, null },
                    { "IQA0029", "Mandatory", "Boolean", null, null, "13", false, "A", "IQT0003", "Will this project involve activities regulated by the Human Fertilisation and Embryology Authority (HFEA)?", "Boolean", 17, null, null },
                    { "IQA0032", "Mandatory", "Checkbox", null, null, "2", false, "A", "IQT0004", "In which countries of the UK will the project take place? Select all that apply:", "Look-up list", 3, null, null },
                    { "IQA0033", "Conditional", "Checkbox", null, null, "3a", false, "A", "IQT0004", "Where in the UK will the human biologicial samples or data be held? Select all that apply:", "Look-up list", 4, null, null },
                    { "IQA0034", "Conditional", "Checkbox", null, null, "3b", false, "A", "IQT0004", "From where in the UK will human biologicial samples or data be obtained? Select all that apply:", "Look-up list", 5, null, null },
                    { "IQA0036", "Optional", "Text", null, null, "1a", false, "B", "IQT0005", "Provide protocol reference number", "Text", 1, null, null },
                    { "IQA0037", "Conditional", "Text", null, null, "1b", false, "B", "IQT0005", "Provide the EU Clinical Trial (EUCT) number", "Text", 2, null, null },
                    { "IQA0039", "Conditional", "Text", null, null, "2c", false, "B", "IQT0012", "Provide any information about the linked project that will help reviewers to understand the background to this application or the decisions you have made in this application.", "Text", 5, null, null },
                    { "IQA0040", "Mandatory", "Text", null, null, "2", false, "B", "IQT0005", "Research project public summary:\n* explain why the research is being carried out, the questions it seeks to answer, its design and methodology\n* do not reproduce or refer to the protocol \n* complete this section in language understandable to a member of the public (maximum 300 words)\n\nThis summary will be published on the Health Research Authority (HRA) website following approval.", "Text", 3, null, null },
                    { "IQA0042", "Conditional", "Checkbox", null, null, "2", false, "B", "IQT0006", "How did you identify the public contributors that you involved?  Select all that apply", "Look-up list", 4, null, null },
                    { "IQA0043", "Conditional", "Text", null, null, "2a", false, "B", "IQT0006", "Give details how you identified the public contributors to that you involved.", "Text", 5, null, null },
                    { "IQA0044", "Mandatory", "Text", null, null, "2b", false, "B", "IQT0006", "Tell us about the public contributors you worked with: \n• how many of them were there?\n• were the perspectives those of patients, of carers, of service users, of people with experience of being involved in research, or of members of the public?\n• what was relevant about their skills and experience (this might include their demographic information)?", "Text", 6, null, null },
                    { "IQA0045", "Mandatory", "Checkbox", null, null, "1", false, "B", "IQT0006", "In which aspects of the project have you already actively involved patients or their carers, service users or members of the public?\nInclude patient and public involvement from wider programmes that has informed this project. Select all that apply:", "Look-up list", 1, null, null },
                    { "IQA0046", "Conditional", "Text", null, null, "1a", false, "B", "IQT0006", "Give details of how you involved public contributors", "Text", 2, null, null },
                    { "IQA0048", "Conditional", "Text", null, null, "1b", false, "B", "IQT0006", "Insights from patients, carers, services users or members of the public could have helped to ensure that this research reflects the priorities, needs and concerns of both the intended participant population, and of the people the research is intended to benefit. What are your reasons for not involving these people?", "Text", 3, null, null },
                    { "IQA0049", "Mandatory", "Checkbox", null, null, "1", false, "B", "IQT0007", "Select the methodology or methodologies you will be using for this project:", "Look-up list", 1, null, null },
                    { "IQA0050", "Conditional", "Text", null, null, "1a", false, "B", "IQT0007", "Give details of the methodologies you will be using", "Text", 2, null, null },
                    { "IQA0051", "Conditional", " Checkbox", null, null, "2a", false, "B", "IQT0007", "Select the trial methodology", "Look-up list", 3, null, null },
                    { "IQA0052", "Conditional", "Text", null, null, "2b", false, "B", "IQT0007", "Specify the methodology", "Text", 4, null, null },
                    { "IQA0053", "Mandatory", "Text", null, null, "2c", false, "B", "IQT0007", "Give more details of the methodology", "Text", 5, null, null },
                    { "IQA0054", "Conditional", "Boolean", null, null, "3a", false, "B", "IQT0007", "Is your project a clinical trial to study a novel intervention?", "Boolean", 6, null, null },
                    { "IQA0055", "Conditional", "Boolean", null, null, "3b", false, "B", "IQT0007", "Is your project a randomised clinical trial to compare any interventions in clinical practice?", "Boolean", 7, null, null },
                    { "IQA0056", "Conditional", "Boolean", null, null, "3c", false, "B", "IQT0007", "Are all the interventions that you are comparing routine 'gold standard' care options in clinical practice?", "Boolean", 8, null, null },
                    { "IQA0057", "Mandatory", "Text", null, null, "4", false, "B", "IQT0007", "What is the principal research question or objective? Describe this in language understandable to a member of the public.", "Text", 9, null, null },
                    { "IQA0058", "Mandatory", "Text", null, null, "5", false, "B", "IQT0007", "What are the secondary research question or objectives if applicable? Describe this in language understandable to a member of the public.", "Text", 10, null, null },
                    { "IQA0060", "Mandatory", "Text", null, null, "7", false, "B", "IQT0007", "State exactly what will happen to participants, their tissue or data, how many times and in what order:\n* complete this in language understandable to a member of the public", "Text", 16, null, null },
                    { "IQA0061", "Mandatory", "Checkbox", null, null, "2", false, "A", "IQT0003", "Select all the activities that will be involved in this project:", "Look-up list", 2, null, null },
                    { "IQA0062", "Conditional", "Text", null, null, "1", false, "B", "IQT0008", "What is the intervention or treatment being studied? \n* provide the trade name, and brand name where relevant, of any device or medicine. \n* for surgical, psychological or non-clinical interventions briefly describe the nature of the intervention\n* if relevant, include details of any control arm", "Text", 1, null, null },
                    { "IQA0063", "Conditional", "Boolean", null, null, "2", false, "B", "IQT0008", "Is this treatment first-in-human?", "Boolean", 2, null, null },
                    { "IQA0064", "Conditional", "Boolean", null, null, "3", false, "B", "IQT0008", "Does your project involve a change or a delay to patients’ standard treatment or care?", "Boolean", 3, null, null },
                    { "IQA0065", "Conditional", "Boolean", null, null, "4", false, "B", "IQT0008", "Are any of the treatments in this project being compared to standard care?", "Boolean", 4, null, null },
                    { "IQA0066", "Conditional", "Text", null, null, "4a", false, "B", "IQT0008", "Describe what arrangements you will put in place to address any changes in standard care during the project, for example resulting from new guidance from the National Institute for Health and Care Excellence (NICE).", "Text", 5, null, null },
                    { "IQA0068", "Conditional", "Boolean", null, null, "6", false, "B", "IQT0008", "Is it possible that any interviews, questionnaires or group discussions include topics that might be sensitive, embarrassing or upsetting?", "Boolean", 7, null, null },
                    { "IQA0070", "Conditional", "Boolean", null, null, "7", false, "B", "IQT0008", "Is it possible that interviews, questionnaires or group discussions include topics that might result in criminal or other disclosures?", "Boolean", 8, null, null },
                    { "IQA0071", "Conditional", "Text", null, null, "7a", false, "B", "IQT0008", "Explain how any requirement for criminal or other disclosures will be dealt with in line with legal obligations, safeguarding arrangements and professional procedures and guidance.", "Text", 9, null, null },
                    { "IQA0072", "Mandatory", "Text", null, null, "8", false, "B", "IQT0008", "What are the potential benefits for participants and society (including future patients)?", "Text", 10, null, null },
                    { "IQA0073", "n/a", "n/a", null, null, "9", false, "B", "IQT0008", "Describe the potential safety concerns, risks and burdens in the project and how you will minimise these.", "Label", 11, null, null },
                    { "IQA0074", "Conditional", "Text", null, null, "9a", false, "B", "IQT0008", "Any risks, side-effects or burdens of any research activities or monitoring of participants:", "Text", 12, null, null },
                    { "IQA0075", "Conditional", "Text", null, null, "9b", false, "B", "IQT0008", "Any risks due to a change or delay to standard treatment or care:", "Text", 13, null, null },
                    { "IQA0076", "Conditional", "Text", null, null, "9c", false, "B", "IQT0008", "Any risk or burden due to interviews, questionnaires or group discussions that include topics that might be sensitive, embarrassing or upsetting:", "Text", 14, null, null },
                    { "IQA0077", "Conditional", "Boolean", null, null, "10", false, "B", "IQT0008", "Will you inform the participants' General Practitioners (or any other health or care professional responsible for their care) that they are taking part in the study?", "Boolean", 15, null, null },
                    { "IQA0078", "Conditional", "Text", null, null, "10a", false, "B", "IQT0008", "Explain the circumstances when you will contact General Practitioners or other responsible health or care professionals about a participant. What will you tell participants about this?", "Text", 16, null, null },
                    { "IQA0079", "Conditional", "Boolean", null, null, "12", false, "B", "IQT0008", "What will happen with treatment after the project has finished?", "Look-up list", 17, null, null },
                    { "IQA0080", "Conditional", "Text", null, null, "12a", false, "B", "IQT0008", "Describe all the arrangements for continuued provision of treatment after the project has finished, including funding. Give details of the parties that have agreed these arrangements.", "Text", 18, null, null },
                    { "IQA0081", "Conditional", "Text", null, null, "12b", false, "B", "IQT0008", "Describe the care arrangements after the project has finished.  Justify these arrangements", "Text", 19, null, null },
                    { "IQA0082", "Mandatory", "Date", null, null, "13", false, "B", "IQT0008", "When do you plan to finish collecting data for this project in the UK?", "Date", 20, null, null },
                    { "IQA0083", "Mandatory", "Checkbox", null, null, "1", false, "B", "IQT0009", "What are the primary conditions or problems being studied? Select all that apply", "Look-up list", 1, null, null },
                    { "IQA0084", "Mandatory", "Text", null, null, "2", false, "B", "IQT0009", "List the principal inclusion criteria for selection of participants, data or samples", "Text", 2, null, null },
                    { "IQA0085", "Mandatory", "Text", null, null, "3", false, "B", "IQT0009", "List the principal exclusion criteria or selection of participants, data or samples", "Text", 3, null, null },
                    { "IQA0086", "Mandatory", "Text", null, null, "4", false, "B", "IQT0009", "How are you making sure that your study sample reflects the real-world population that the research is for and about? Consider people and communities who are often excluded from research in the field you are studying.\nYou may attach evidence or assessments already agreed with funders or sponsors.", "Text", 4, null, null },
                    { "IQA0087", "Mandatory", "Text", null, null, "5", false, "B", "IQT0009", "How will you ensure that the people you have chosen to include in your project are able to participate fully?  Consider factors such as health, identity, cultural, socioeconomic factors, literacy, accessibility, or other circumstances to facilitate participation in your research.\nYou may attach evidence or assessments already agreed with funders or sponsors.", "Text", 5, null, null },
                    { "IQA0088", "Mandatory", "Checkbox", null, null, "6", false, "B", "IQT0009", "Select which groups will participate or provide data or samples in this project. Select all that apply:", "Look-up list", 6, null, null },
                    { "IQA0089", "Conditional", "Text", null, null, "6a", false, "B", "IQT0009", "Give details of the groups participating or providing data or samples in this project", "Text", 7, null, null },
                    { "IQA0090", "Mandatory", "Date", null, null, "7", false, "B", "IQT0009", "When do you plan to start recruiting participants or collecting samples or data?", "Date", 8, null, null },
                    { "IQA0091", "Conditional", "Text", null, null, "8", false, "B", "IQT0009", "How long do you expect each participant to be in the project in total?", "Text", 9, null, null },
                    { "IQA0092", "Conditional", "Text", null, null, "9", false, "B", "IQT0009", "What arrangements will apply to potential participants who are involved in current research or have recently been involved in any research prior to recruitment?", "Text", 10, null, null },
                    { "IQA0093", "Conditional", "Boolean", null, null, "10", false, "B", "IQT0009", "Could any of the potential participants for the project be considered to be vulnerable at the time of approach?", "Boolean", 11, null, null },
                    { "IQA0095", "Mandatory", "Boolean", null, null, "2", false, "B", "IQT0010", "Will you only include children as participants?", "Boolean", 2, null, null },
                    { "IQA0096", "Conditional", "Checkbox", null, null, "1", false, "B", "IQT0010", "Will you only include adults lacking capacity to consent for themselves as participants?", "Look-up list", 1, null, null },
                    { "IQA0097", "Mandatory", "Boolean", null, null, "3", false, "B", "IQT0010", "Will you seek consent from participants prior to participation in the project?", "Look-up list", 3, null, null },
                    { "IQA0098", "Conditional", "Checkbox", null, null, "3a", false, "B", "IQT0010", "Select the reasons why consent will not be obtained.  Select all that apply:", "Look-up list", 4, null, null },
                    { "IQA0099", "Conditional", "Text", null, null, "3b", false, "B", "IQT0010", "Justify why you will not seek consent:", "Text", 5, null, null },
                    { "IQA00D1", "Mandatory", "Text", null, null, "1", false, "D", "IQT0057", "I agree for this project application information to be used for:", "Text", 1, null, null },
                    { "IQA0100", "Conditional", "Text", null, null, "4", false, "B", "IQT0010", "Describe any arrangements for seeking consent using simplified methods:", "Text", 6, null, null },
                    { "IQA0102", "Conditional", "Text", null, null, "5", false, "B", "IQT0010", "How long will you allow potential participants to decide whether or not to take part?", "Text", 7, null, null },
                    { "IQA0103", "Conditional", "Text", null, null, "6", false, "B", "IQT0010", "Explain any payments, reimbursement of expenses or any other benefits or incentives to participants:", "Text", 8, null, null },
                    { "IQA0104", "Conditional", "Text", null, null, "7", false, "B", "IQT0010", "What arrangements will you make to comply with the principles of the Welsh Language Act in the provision of information to participants in Wales?", "Text", 9, null, null },
                    { "IQA0105", "Conditional", "Text", null, null, "8", false, "B", "IQT0010", "What consent arrangements will you make for persons who:\na) might not hear verbal explanations sufficiently, or \nb) might not be able to read written information in English sufficiently, or \nc) have special communication needs?", "Text", 10, null, null },
                    { "IQA0106", "Conditional", "Text", null, null, "9", false, "B", "IQT0010", "What arrangements will you make for participants who are unable to confirm their consent in writing?", "Text", 11, null, null },
                    { "IQA0107", "Conditional", "Text", null, null, "10", false, "B", "IQT0010", "What arrangements will you make to ensure participants receive any information that becomes available during the course of the project that may be relevant to their continued participation?", "Text", 12, null, null },
                    { "IQA0108", "Conditional", "Boolean", null, null, "11", false, "B", "IQT0010", "What steps would you take if a participant, who has given informed consent, loses capacity to consent during the research project? Select one option only.", "Look-up list", 13, null, null },
                    { "IQA0109", "n/a", "n/a", null, null, "Note", false, "B", "IQT0010", "Proceed to complete Adults Lacking Capacity\n[final wording TBC]", "Label: on-screen instruction", 14, null, null },
                    { "IQA0110", "Mandatory", "Text", null, null, "1", false, "B", "IQT0011", "Describe potential risks to the research team in conducting the project and state how these will be managed", "Text", 1, null, null },
                    { "IQA0111", "Mandatory", "Boolean", null, null, "2", false, "B", "IQT0011", "Does the Chief Investigator or any other investigator or collaborator have any direct personal involvement (for example, financial, share-holding, personal relationship) in the organisations sponsoring or funding the project that may give rise to a possible conflict of interest?", "Boolean", 2, null, null },
                    { "IQA0112", "Conditional", "Text", null, null, "2a", false, "B", "IQT0011", "Give details of any potential relevant conflict of interest.", "Text", 3, null, null },
                    { "IQA0113", "Mandatory", "Boolean", null, null, "3", false, "B", "IQT0011", "Is the Chief Investigator a member of any NHS Research Ethics Committee?", "Boolean", 4, null, null },
                    { "IQA0114", "Conditional", "Checkbox", null, null, "3a", false, "B", "IQT0011", "Select all Research Ethics Committees (REC) the Chief Investigator or any other investigators are a member of.  Select all that apply.", "Look-up list", 5, null, null },
                    { "IQA0115", "Mandatory", "Boolean", null, null, "4", false, "B", "IQT0011", "Will the Chief Investigator or any other investigator receive any personal payment over and above normal salary, or any other benefits or incentives, for taking part in this project?", "Boolean", 6, null, null },
                    { "IQA0116", "Conditional", "Text", null, null, "4a", false, "B", "IQT0011", "Give details of payments, benefits or any other incentives.", "Text", 7, null, null },
                    { "IQA0117", "Mandatory", "Text", null, null, "1", false, "B", "IQT0012", "Summarise the main ethical issues arising from the project. \n* consider risks, burdens and benefits involved\n* include justifications for balancing risks and benefits (such as the involvement of potential participants being vulnerable at time of approach) \n* complete this in language understandable to a member of the public.", "Text", 1, null, null },
                    { "IQA0118", "Mandatory", "Checkbox", null, null, "2", false, "B", "IQT0012", "Is this application any of the following:", "Look-up list", 2, null, null },
                    { "IQA0119", "Conditional", "Text", null, null, "2a", false, "B", "IQT0012", "Provide the IRAS ID of the project that received an unfavourable opinion.", "Text", 3, null, null },
                    { "IQA0120", "Conditional", "Text", null, null, "2b", false, "B", "IQT0012", "Explain how the reasons for the unfavourable opinion have been addressed in this application.", "Text", 4, null, null },
                    { "IQA0121", "Mandatory", "Checkbox", null, null, "1", false, "B", "IQT0013", "How has the quality of the research been assessed?  Select all that apply.", "Look-up list", 1, null, null },
                    { "IQA0122", "Conditional", "Text", null, null, "1a", false, "B", "IQT0013", "Give details of how the quality of the research has been assessed", "Text", 2, null, null },
                    { "IQA0123", "Mandatory", "Text", null, null, "2", false, "B", "IQT0013", "Explain why this review process is appropriate to the nature of the project and if any issues raised by the review have not been addressed.  Give details if the review only relates to part of the project.", "Text", 3, null, null },
                    { "IQA0124", "Mandatory", "Boolean", null, null, "3", false, "B", "IQT0013", "What will the primary form of analysis be?", "Boolean", 4, null, null },
                    { "IQA0125", "Mandatory", "Text", null, null, "3a", false, "B", "IQT0013", "Give details of the methods for analysing the data.", "Text", 5, null, null },
                    { "IQA0126", "Conditional", "Checkbox", null, null, "3b", false, "B", "IQT0013", "How have the statistical aspects of the project been reviewed?  Select all that apply.", "Look-up list", 6, null, null },
                    { "IQA0127", "Conditional", "Text", null, null, "3c", false, "B", "IQT0013", "Give details of the person or organisation who undertook the statistical review, and how you have addressed their recommendations.", "Text", 7, null, null },
                    { "IQA0128", "Conditional", "Text", null, null, "3d", false, "B", "IQT0013", "What is the primary outcome measure for the project?", "Text", 8, null, null },
                    { "IQA0129", "Conditional", "Text", null, null, "3e", false, "B", "IQT0013", "What are the secondary outcome measures (if any)?", "Text", 9, null, null },
                    { "IQA0130", "Conditional", "Text", null, null, "4a", false, "B", "IQT0013", "How many participants, samples, or data records do you plan to study in total? Describe why you chose this number. If there is more than one group, give further details.", "Text", 10, null, null },
                    { "IQA0131", "Conditional", "Text", null, null, "4b", false, "B", "IQT0013", "How was the sample size decided upon? If a formal sample size calculation was used, indicate how this was done, giving sufficient information to justify and reproduce the calculation.", "Text", 11, null, null },
                    { "IQA0132", "Mandatory", "Text", null, null, "5", false, "B", "IQT0013", "What are the criteria for electively stopping the project early?", "Text", 12, null, null },
                    { "IQA0139", "Mandatory", "Text", null, null, "1", false, "B", "IQT0014", "Give details of the source of all funding or materials supplied.", "Text", 1, null, null },
                    { "IQA0140", "Mandatory", "Text", null, null, "2", false, "B", "IQT0014", "Describe any logistical, legal, or management risks relating to your project. State how you are addressing them. Studies that present a minimal risk to participants may still raise complex organisational or legal issues.", "Text", 2, null, null },
                    { "IQA0142", "Mandatory", "Boolean", null, null, "1", false, "A", "IQT0004", "Is this project taking place in any countries other than the UK?", "Boolean", 1, null, null },
                    { "IQA0143", "Conditional", "Checkbox", null, null, "1a", false, "A", "IQT0004", "List the countries outside the UK participating in this project.", "Look-up list", 2, null, null },
                    { "IQA0144", "Mandatory", "Checkbox", null, null, "4", false, "A", "IQT0004", "Where will the project be taking place? Select all that apply:", "Look-up list", 6, null, null },
                    { "IQA0145", "Conditional", "Text", null, null, "4a", false, "A", "IQT0004", "Give details of other organisations responsible for conducting the project.", "Look-up list", 7, null, null },
                    { "IQA0146", "Conditional", "Boolean", null, null, "5", false, "A", "IQT0004", "Will you allow your research sites to use Participant Identification Centres (PICs)?", "Boolean", 8, null, null },
                    { "IQA0147", "Conditional", "Checkbox", null, null, "3", false, "B", "IQT0014", "What arrangements will be put in place for the monitoring and auditing of the conduct of the project?", "Look-up list", 3, null, null },
                    { "IQA0148", "Conditional", "Text", null, null, "4", false, "B", "IQT0014", "What arrangements will be made to review interim safety and efficacy data from the project? Will a formal Data Monitoring Committee or equivalent body be convened?", "Text", 4, null, null },
                    { "IQA0149", "Mandatory", "Text", null, null, "5", false, "B", "IQT0014", "What arrangements will be made for insurance or indemnity to meet the potential legal liability of the sponsors for harm to participants arising from the management of the project? Provide any insurance certificates.", "Text", 5, null, null },
                    { "IQA0150", "Mandatory", "Text", null, null, "6", false, "B", "IQT0014", "What arrangements will be made for insurance or indemnity to meet the potential legal liability of the sponsors or employers for harm to participants arising from the design of the project? Provide any insurance certificates.", "Text", 6, null, null },
                    { "IQA0151", "Mandatory", "Text", null, null, "7", false, "B", "IQT0014", "What arrangements will be made for insurance or indemnity to meet the potential legal liability of investigators or collaborators arising from harm to participants in the conduct of the project? \n* Provide details of any time limits to the cover.  \n* Explain the arrangements that would apply if the insurance ceases.\n* Provide any insurance certificates.", "Text", 7, null, null },
                    { "IQA0152", "Mandatory", "Text", null, null, "8", false, "B", "IQT0014", "Describe and justify which participant groups are excluded from cover under the insurance.", "Text", 8, null, null },
                    { "IQA0153", "Mandatory", "Boolean", null, null, "9", false, "B", "IQT0014", "Have sponsors made arrangements for payment of compensation in the event of harm to the participants where no legal liability arises?", "Boolean", 9, null, null },
                    { "IQA0154", "Conditional", "Text", null, null, "9a", false, "B", "IQT0014", "Give details of the arrangements for compensation.", "Text", 10, null, null },
                    { "IQA0155", "Conditional", "Boolean", null, null, "10", false, "B", "IQT0014", "Have sponsors delegated any site management responsibilities to a Contract Research Organisation or a Clinical Trials Unit?", "Boolean", 11, null, null },
                    { "IQA0156", "Conditional", "Text", null, null, "10a", false, "B", "IQT0014", "Give details of the Contract Research Organisation or Clinical Trials Unit with site management responsibilities.", "Text", 12, null, null },
                    { "IQA0157", "Conditional", "Boolean", null, null, "11", false, "B", "IQT0014", "Has responsibility for any specific research activities or procedures been delegated to a subcontractor? ", "Boolean", 13, null, null },
                    { "IQA0158", "Conditional", "Text", null, null, "11a", false, "B", "IQT0014", "Give details of subcontractors and the proposed oversight arrangements.", "Text", 14, null, null },
                    { "IQA0159", "Mandatory", "Boolean", null, null, "1a", false, "B", "IQT0015", "Is the project already registered elsewhere?", "Boolean", 2, null, null },
                    { "IQA0162", "Mandatory", "Checkbox", null, null, "4", false, "B", "IQT0006", "How do you plan to involve public contributors in the remaining stages of the research process?  Select all that apply:", "Look-up list", 8, null, null },
                    { "IQA0163", "Conditional", "Text", null, null, "4a", false, "B", "IQT0006", "Give details of other aspects public contributors will advise on or contribute to", "Text", 9, null, null },
                    { "IQA0165", "Conditional", "Radio button", null, null, "1b", false, "B", "IQT0015", "Registration and research project public summary publication deferral request. Deferral will only be agreed where a strong justification is provided.", "Look-up list", 3, null, null },
                    { "IQA0166", "Conditional", "Text", null, null, "1c", false, "B", "IQT0015", "Provide clear justification for the deferral request.", "Text", 4, null, null },
                    { "IQA0167", "Conditional", "Checkbox", null, null, "1d", false, "B", "IQT0015", "Confirm the arrangements for registration of this project. Select all that apply:", "Checkbox", 5, null, null },
                    { "IQA0168", "Conditional", "Text", null, null, "1e", false, "B", "IQT0015", "Provide details of other arrangements for project registration.", "Text", 6, null, null },
                    { "IQA0169", "Mandatory", "Checkbox", null, null, "1f", false, "B", "IQT0015", "Confirm the arrangements for registration of this project. Select all that apply.", "Look-up list", 7, null, null },
                    { "IQA0170", "Conditional", "Text", null, null, "1g", false, "B", "IQT0015", "ISRCTN", "Text", 8, null, null },
                    { "IQA0171", "Conditional", "Text", null, null, "1h", false, "B", "IQT0015", "Clinicaltrials.gov", "Text", 9, null, null },
                    { "IQA0172", "Conditional", "Text", null, null, "1i", false, "B", "IQT0015", "Provide the name of any other registries and the reference number", "Text", 10, null, null },
                    { "IQA0173", "Conditional", "Checkbox", null, null, "2", false, "B", "IQT0015", "Project public summary publication deferral request", "Label", 12, null, null },
                    { "IQA0174", "Conditional", "Text", null, null, "2a", false, "B", "IQT0015", "Provide clear justification for the deferral request.", "Text", 13, null, null },
                    { "IQA0175", "Mandatory", "Date", null, null, "3", false, "B", "IQT0015", "You should define the end of your project and notify relevant bodies at the end of the project.  What is the planned end date?", "Date", 14, null, null },
                    { "IQA0176", "Mandatory", "Checkbox", null, null, "4", false, "B", "IQT0015", "A final report should be submitted to the Research Ethics Committee (REC) within 12 months of the end of the project, including a public summary of results. How else do you intend to report and disseminate the results of the project? Select all that apply:", "Look-up list", 15, null, null },
                    { "IQA0177", "Conditional", "Text", null, null, "4a", false, "B", "IQT0015", "Give details of other reporting and dissemination plans", "Text", 16, null, null },
                    { "IQA0178", "Mandatory", "Text", null, null, "5", false, "B", "IQT0015", "Results of the research provide feedback to participants on the outcome and how they have contributed.  This information should be accessible and easy to understand.  \n* explain how and when you will inform participants of the results, or give reasons if there are no arrangements to do this", "Text", 17, null, null },
                    { "IQA0179", "Mandatory", "Boolean", null, null, "6", false, "B", "IQT0015", "You should enable the sharing of study data, with appropriate safeguards in place, to other interested groups and communities. Sharing data maximises and respects the contribution of participants and enables and supports further re-use. Do you plan to share de-identified individual participant-level data?", "Boolean", 18, null, null },
                    { "IQA0180", "Mandatory", "Text", null, null, "7", false, "B", "IQT0015", "Give details of your plans for sharing de-identified individual participant-level data, or describe your alternative plans for making data available for scrutiny or re-use.", "Text", 19, null, null },
                    { "IQA0181", "Conditional", "Boolean", null, null, "8", false, "B", "IQT0015", "Will you have any remaining human biological material at the end of the project?", "Boolean", 20, null, null },
                    { "IQA0182", "Conditional", "Boolean", null, null, "8a", false, "B", "IQT0015", "The UK Clinical Research Collaboration (UKCRC) Tissue Directory and Coordination Centre advises researchers to register sample collections with them, to maximise the use of the samples. Will you be registering any remaining samples with them?", "Boolean", 21, null, null },
                    { "IQA0183", "Conditional", "Text", null, null, "8b", false, "B", "IQT0015", "The Human Tissue Authority and Medical Research Council advise researchers to consider options for maximising use before disposal. You should enable the sharing of tissue samples, with appropriate safeguards in place, to other interested groups and communities. Sharing tissue maximises and respects the contribution of participants and enables and supports further research. Justify the post-study arrangements or destruction of the material.", "Text", 22, null, null },
                    { "IQA0184", "Mandatory", "n/a", null, null, "9", false, "B", "IQT0015", "What is the contact point for public queries about this project? This information will be made public so you should use generic contact details rather than naming an individual person.", "Label", 23, null, null },
                    { "IQA0185", "Mandatory", "Email", null, null, "9a", false, "B", "IQT0015", "Email", "Email", 24, null, null },
                    { "IQA0186", "Mandatory", "Text", null, null, "9b", false, "B", "IQT0015", "Telephone", "Text", 25, null, null },
                    { "IQA0187", "Mandatory", "Text", null, null, "9c", false, "B", "IQT0015", "Postal address", "Text", 26, null, null },
                    { "IQA0188", "n/a", "n/a", null, null, "10", false, "B", "IQT0015", "What is the contact point for scientific queries about this project? This information will be made public so you should use generic contact details rather than naming an individual person.", "Label", 27, null, null },
                    { "IQA0189", "Mandatory", "Email", null, null, "10a", false, "B", "IQT0015", "Email", "Email", 28, null, null },
                    { "IQA0190", "Mandatory", "Text", null, null, "10b", false, "B", "IQT0015", "Telephone", "Text", 29, null, null },
                    { "IQA0191", "Mandatory", "Text", null, null, "10c", false, "B", "IQT0015", "Postal address", "Text", 30, null, null },
                    { "IQA0218", "Mandatory", "Text", null, null, "1", false, "C1", "IQT0019", "Describe the role of the students in the project", "Text", 1, null, null },
                    { "IQA0219", "Mandatory", "Boolean", null, null, "2", false, "C1", "IQT0019", "Is the project being undertaken as a group project?", "Boolean", 2, null, null },
                    { "IQA0220", "Mandatory", "Text", null, null, "4a", false, "C1", "IQT0019", "University name", "Text", 6, null, null },
                    { "IQA0221", "Mandatory", "Text", null, null, "5", false, "C1", "IQT0019", "Course name", "Text", 7, null, null },
                    { "IQA0222", "Mandatory", "Boolean", null, null, "3", false, "C1", "IQT0019", "Level of course ", "Look-up list", 3, null, null },
                    { "IQA0223", "Conditional", "Radio button", null, null, "4", false, "C1", "IQT0019", "You should complete the student research toolkit and confirm whether you are eligible to proceed with your project. You should include the relevant suplementary declaration form from your supervisor or course leader with your IRAS application. If you are not eligible you cannot proceed with your project.  Indicate which declaration is included as part of your project submission:", "Look-up list", 5, null, null },
                    { "IQA0224", "Mandatory", "Boolean", null, null, "6", false, "C1", "IQT0019", "The university is expected to take on the role of sponsor for this project. Is the university the sponsor?", "Boolean", 8, null, null },
                    { "IQA0225", "Conditional", "Text", null, null, "6a", false, "C1", "IQT0019", "Justify why the university is not taking on the role of sponsor. If the project will be in the NHS this is not sufficient reason for the sponsor to be an NHS organisation.", "Text", 9, null, null },
                    { "IQA0226", "Conditional", "n/a", null, null, "7", false, "C1", "IQT0019", "Student name and contact details", "Label", 10, null, null },
                    { "IQA0227", "Conditional", "Text", null, null, "7a", false, "C1", "IQT0019", "First name", "Text", 11, null, null },
                    { "IQA0228", "Conditional", "Text", null, null, "7b", false, "C1", "IQT0019", "Last name", "Text", 12, null, null },
                    { "IQA0229", "Conditional", "Email", null, null, "7c", false, "C1", "IQT0019", "Email", "Text", 13, null, null },
                    { "IQA0230", "Conditional", "n/a", null, null, "Note", false, "C1", "IQT0019", "If your course is masters or equivalent, a supervisor is expected to act as the Chief Investigator", "Label: on-screen instruction", 14, null, null },
                    { "IQA0231", "Mandatory", "n/a", null, null, "9", false, "C1", "IQT0019", "Academic supervisor name and contact details. If you have more than one supervisor, list the supervisor acting as Chief Investigator first.", "Label: on-screen instruction", 16, null, null },
                    { "IQA0232", "Mandatory", "Text", null, null, "9a", false, "C1", "IQT0019", "First name", "Text", 17, null, null },
                    { "IQA0233", "Mandatory", "Text", null, null, "9b", false, "C1", "IQT0019", "Last name", "Text", 18, null, null },
                    { "IQA0234", "Mandatory", "Text", null, null, "9c", false, "C1", "IQT0019", "Job title", "Text", 19, null, null },
                    { "IQA0235", "Mandatory", "Text", null, null, "9d", false, "C1", "IQT0019", "University", "Text", 20, null, null },
                    { "IQA0236", "Mandatory", "Email", null, null, "9e", false, "C1", "IQT0019", "Email", "Text", 21, null, null },
                    { "IQA0237", "Conditional", "Boolean", null, null, "8", false, "C1", "IQT0019", "Who will act as Chief Investigator for this project?", "Look-up list", 15, null, null },
                    { "IQA0238", "Mandatory", "Checkbox", null, null, "1", false, "C8", "IQT0020", "Specify the ages of children who will be participating in this research project. Select all groups that apply:", "Look-up list", 1, null, null },
                    { "IQA0239", "Mandatory", "Checkbox", null, null, "2", false, "C8", "IQT0020", "Will you include children who will be unable to fully understand the details of the project and consequences of their participation? Select all that apply:", "Look-up list", 2, null, null },
                    { "IQA0240", "Conditional", "Text", null, null, "2a", false, "C8", "IQT0020", "Describe the arrangements for obtaining consent from a person who has parental rights and responsibility for children who will not be able to fully understand the details of the project and consequences of their participation.", "Text", 3, null, null },
                    { "IQA0241", "Conditional", "Text", null, null, "2b", false, "C8", "IQT0020", "Describe how you intend to provide children who will not be able to fully understand the details of the project and consequences of their participation, with information about the project. How will you seek their assent, if they are able? Describe how this process will be adapted to their age and level of understanding.", "Text", 4, null, null },
                    { "IQA0242", "Conditional", "Text", null, null, "2c", false, "C8", "IQT0020", "Describe how you intend to seek informed consent from children who will be able to understand the details of the project and the consequences of participation, and willing to give consent on their own behalf, alongside parental agreement. For sites in Scotland, this may include children over the age of 12 years who are willing and able to give consent as the Children (Scotland) Act specifies that a child of 12 years or more should be presumed to be of sufficient age and maturity to form a view.", "Text", 5, null, null },
                    { "IQA0243", "Conditional", "Text", null, null, "2d", false, "C8", "IQT0020", "Describe the arrangements for seeking informed consent from a person with parental responsibility or another legal representative for children under 16 years.", "Text", 6, null, null },
                    { "IQA0245", "Conditional", "Text", null, null, "2e", false, "C8", "IQT0020", "Describe how you intend to provide children under 16 with information about the trial and seek their assent, where they are able. Describe how this process will be adapted to their age and level of understanding.", "Text", 7, null, null },
                    { "IQA0246", "Mandatory", "Boolean", null, null, "3", false, "C8", "IQT0020", "Is it possible that a child might need to be treated urgently as part of the project before it is possible to identify and seek consent from a person with parental rights and responsibility or another legal representative?", "Boolean", 8, null, null },
                    { "IQA0247", "Conditional", "Text", null, null, "3a", false, "C8", "IQT0020", "Justify the need for urgent treatment in this project. What arrangements will be put in place to identify and seek consent from a person with parental rights and responsibility or another legal representative, once urgent actions have been completed?", "Text", 9, null, null },
                    { "IQA0248", "Conditional", "Text", null, null, "4a", false, "C8", "IQT0020", "What arrangements will you make to seek consent to continue in the project when participating children are able to give consent for themselves?", "Text", 10, null, null },
                    { "IQA0249", "Conditional", "Text", null, null, "4b", false, "C8", "IQT0020", "What arrangements will you make to seek consent to continue in the trial when participating children reach the age of 16?", "Text", 11, null, null },
                    { "IQA0250", "Mandatory", "Text", null, null, "5", false, "C8", "IQT0020", "Explain how you have tested the materials and resources for explaining this project with children and adults with parental rights and responsibility.", "Text", 12, null, null },
                    { "IQA0251", "Mandatory", "Boolean", null, null, "1", false, "B", "IQT0021", "Is this study limited to working with data only?", "Boolean", 1, null, null },
                    { "IQA0253", "Mandatory", "Text", null, null, "1", false, "C6", "IQT0022", "Describe this type of materials. Give details of the samples.", "Look-up list", 1, null, null },
                    { "IQA0254", "Mandatory", "Boolean", null, null, "2", false, "C6", "IQT0022", "Will you be collecting new samples from participants? This could be new samples collected from participants for the project, or collecting samples for research at the same time as routine clinical samples.", "Boolean", 2, null, null },
                    { "IQA0255", "Conditional", "Boolean", null, null, "2a", false, "C6", "IQT0022", "Will the samples be provided as extra or surplus taken during a clinically directed procedure with consent?", "Boolean", 3, null, null },
                    { "IQA0256", "Conditional", "Text", null, null, "2b", false, "C6", "IQT0022", "How will the samples be collected? Describe what will happen to participants and how much sample will be collected. ", "text", 4, null, null },
                    { "IQA0257", "Conditional", "Radio button", null, null, "2c", false, "C6", "IQT0022", "Will these participants be living or deceased?", "Look-up list", 5, null, null },
                    { "IQA0258", "Conditional", "Checkbox", null, null, "2d", false, "C6", "IQT0022", "Will the samples be removed from the deceased in England, Northern Ireland, Scotland or Wales?", "Look-up list", 6, null, null },
                    { "IQA0259", "Conditional", "Text", null, null, "2e", false, "C6", "IQT0022", "Give details of any relevant Human Tissue Authority licences covering the premises where samples will be removed from the deceased. If a licence is not yet in place, confirm the arrangements for obtaining a relevant licence.", "Text", 7, null, null },
                    { "IQA0260", "Conditional", "Boolean", null, null, "2f", false, "C6", "IQT0022", "Will the material be identifiable to the research team?", "Boolean", 8, null, null },
                    { "IQA0261", "Conditional", "Boolean", null, null, "2g", false, "C6", "IQT0022", "Does this project come within the scope of the consent for the use of the material in research?", "Boolean", 9, null, null },
                    { "IQA0262", "Mandatory", "Boolean", null, null, "3a", false, "C6", "IQT0022", "The geographical scope of the Human Tissue Act is largely limited to England, Wales and Northern Ireland. Will this material be exported from, or imported into, these nations from another nation outside of the geographical remit of the Human Tissue Act (including to, or from, Scotland)?", "Boolean", 10, null, null },
                    { "IQA0263", "Mandatory", "Boolean", null, null, "3b", false, "C6", "IQT0022", "The Human Tissue Act (Scotland) applies to Scotland. Will this material be exported from, or imported into, Scotland from another nation outside of the geographical remit of the Human Tissue Act (Scotland)?", "Boolean", 11, null, null },
                    { "IQA0264", "Conditional", "Text", null, null, "3c", false, "C6", "IQT0022", "Give reasons for the import or export activity that will take place and clarify whether a Material Transfer Agreement will be in place to manage this activity.", "Text", 12, null, null },
                    { "IQA0265", "Mandatory", "Boolean", null, null, "4", false, "C6", "IQT0022", "What consent arrangements will apply to collection and use of this sample? Where relevant, give details of any prior consent for use of samples from existing collections. If the use of this sample involves the analysis of DNA, or the analysis of RNA with the intention of providing information about DNA, confirm that explicit consent will be in place.", "Boolean", 13, null, null },
                    { "IQA0266", "Mandatory", "Text", null, null, "5", false, "C6", "IQT0022", "Give details of where the sample will be stored, who will have access and the custodial arrangements. ", "Text", 14, null, null },
                    { "IQA0267", "Mandatory", "Radio button", null, null, "6", false, "C6", "IQT0022", "Will the sample be processed or stored under study-specific arrangements or in line with normal clinical arrangements for the organisation?", "Look-up list", 15, null, null },
                    { "IQA0268", "Mandatory", "Checkbox", null, null, "7", false, "C6", "IQT0022", "What will happen to this material following the end of the project?", "Look-up list", 16, null, null },
                    { "IQA0269", "Conditional", "Text", null, null, "7a", false, "C6", "IQT0022", "Explain how destruction of the material will be undertaken. If this relates to relevant material describe how it will comply with the Human Tissue Authority Code of Practice. ", "Text", 17, null, null },
                    { "IQA0270", "Conditional", "Text", null, null, "7b", false, "C6", "IQT0022", "Give further details of the proposed post-study arrangements including whether any relevant material will be rendered acellular.", "Text", 18, null, null },
                    { "IQA0271", "Mandatory", "Boolean", null, null, "1", false, "C6", "IQT0022.3", "Is it possible that the project could produce health related findings of clinical significance for donors or their relatives?", "Boolean", 1, null, null },
                    { "IQA0272", "Conditional", "Boolean", null, null, "1a", false, "C6", "IQT0022.3", "Will arrangements be made to notify the individuals concerned?", "Boolean", 2, null, null },
                    { "IQA0273", "Conditional", "Text", null, null, "1b", false, "C6", "IQT0022.3", "Explain why individuals concerned will not be notified.", "Text", 3, null, null },
                    { "IQA0278", "Mandatory", "Text", null, null, "1", false, "C7", "IQT0023", "The clinical trial must relate directly to a life-threatening or debilitating clinical condition from which the individual suffers.  Describe how your project meets this requirement.", "Text", 1, null, null },
                    { "IQA0279", "Mandatory", "Text", null, null, "2", false, "C7", "IQT0023", "Justify why this project is essential to validate data obtained in other clinical trials involving persons able to consent or obtained by other research methods", "Text", 2, null, null },
                    { "IQA0280", "Mandatory", "Text", null, null, "3", false, "C7", "IQT0023", "Set out the benefits that the administration of the investigational medicinal products is expected to produce for these participants and the grounds for expecting these benefits.  Detail why the inclusion of adults unable to give informed consent produces no risk at all to these participants, including risks to freedom of action or privacy.", "Text", 3, null, null },
                    { "IQA0281", "Mandatory", "Text", null, null, "4", false, "C7", "IQT0023", "Describe how you will ensure that members of the research team who will make decisions on participants' capacity to consent are suitably qualified and experienced to make that decision.", "Text", 4, null, null },
                    { "IQA0282", "Mandatory", "Text", null, null, "5", false, "C7", "IQT0023", "What arrangements will be made to identify and seek informed consent from a personal or professional legal representative?", "Text", 5, null, null },
                    { "IQA0283", "Mandatory", "Text", null, null, "6", false, "C7", "IQT0023", "What arrangements will be made to continue to consult personal or professional legal representatives during the course of the project where necessary?", "Text", 6, null, null },
                    { "IQA0284", "Mandatory", "Text", null, null, "7", false, "C7", "IQT0023", "Where appropriate you should provide information about the trial to participants according to their capacity to understand.  Include in your response:\n* what steps will you take to provide information\n* how will you consider the wishes of participants capable of forming an opinion\n* what arrangements will be put in place where capacity to consent will fluctuate or will be borderline", "Text", 7, null, null },
                    { "IQA0285", "Mandatory", "Boolean", null, null, "8", false, "C7", "IQT0023", "Is it possible that a participant requiring urgent treatment might need to be recruited into the trial before it is possible to identify and seek consent from a personal or professional legal representative?", "Boolean", 8, null, null },
                    { "IQA0286", "Conditional", "Text", null, null, "8a", false, "C7", "IQT0023", "Outline how decisions will be made on the inclusion of such participants and what arrangements will be made to seek consent from the participant (if capacity has been recovered) or from a legal representative as soon as possible.", "Text", 9, null, null },
                    { "IQA0287", "Conditional", "Text", null, null, "8b", false, "C7", "IQT0023", "Describe the arrangements for informing relatives in circumstances where a professional legal representative has to be consulted. If you will not be informing relatives in this circumstance, explain your reasoning.", "Text", 10, null, null },
                    { "IQA0288", "conditionally mandatory", "Text", null, null, "8c", false, "C7", "IQT0023", "Where a participant is recruited prior to consent being obtained, and consent is later withheld or the participant dies before consent can be given, what provisions will apply to the study data collected up to this point?", "Text", 11, null, null },
                    { "IQA0289", "Mandatory", "Text", null, null, "9", false, "C7", "IQT0023", "Describe what steps will be taken to ensure that nothing is done to which participants appear to object (unless it is to protect them from harm or minimise pain or discomfort).", "Text", 12, null, null },
                    { "IQA0290", "Mandatory", "Text", null, null, "10", false, "C7", "IQT0023", "Describe what steps will be taken to ensure that nothing is done which is contrary to any advance decision or statement by the participant", "Text", 13, null, null },
                    { "IQA0291", "Mandatory", "Text", null, null, "1", false, "C7", "IQT0024", "The project must be connected with an impairing condition affecting the participant or their treatment. What impairing conditions will the participants have and how does the project relate to the impairing condition?", "Text", 1, null, null },
                    { "IQA0292", "Mandatory", "Text", null, null, "2", false, "C7", "IQT0024", "Justify why this project could not be carried out as effectively if confined to adults capable of giving consent.", "Text", 2, null, null },
                    { "IQA0293", "Mandatory", "Checkbox", null, null, "3", false, "C7", "IQT0024", "Does the project have the potential to either:\na) benefit the participant without imposing a disproportionate burden, or \nb) provide knowledge of the causes of, or treatment or care of others with, the same or a similar condition? If the project does not meet either requirement you cannot undertake the research with adults lacking capacity.", "Look-up list", 3, null, null },
                    { "IQA0294", "Conditional", "Text", null, null, "3a", false, "C7", "IQT0024", "Describe how the project has the potential to benefit the participant without imposing a disproportionate burden.", "Text", 4, null, null },
                    { "IQA0295", "Conditional", "Text", null, null, "3b", false, "C7", "IQT0024", "Describe how the project will contribute to the knowledge of:\n* causes of the same or simlar condition\n* treatment or care of others with the same or simliar condition", "Text", 5, null, null },
                    { "IQA0296", "Conditional", "Text", null, null, "3c", false, "C7", "IQT0024", "The project must not interfere significantly with participants' freedom of action or privacy.  It also must not be unduly invasive or restrictive.  Describe how the project meets these requirements.", "Text", 6, null, null },
                    { "IQA0297", "Mandatory", "Text", null, null, "4", false, "C7", "IQT0024", "Describe how you will ensure that members of the research team who will make decisions on participant's capacity to consent are suitably qualified and experienced to make that decision.", "Text", 7, null, null },
                    { "IQA0298", "Conditional", "Text", null, null, "5a", false, "C7", "IQT0024", "For participants in England, Wales or Northern Ireland: What arrangements will be made to identify and consult an individual who is able to advise on the inclusion of the participant in the project who are unable to consent for themselves?  Describe how the individual will advise on the participant's presumed wishes and feelings.", "Text", 8, null, null },
                    { "IQA0299", "Conditional", "Text", null, null, "5b", false, "C7", "IQT0024", "For participants in Scotland: what arrangements will be made to consult a Welfare Guardian or Welfare Attorney, or if not appointed the nearest relative able to give consent on behalf of the incapacitated adult?", "Text", 9, null, null },
                    { "IQA0300", "Mandatory", "Text", null, null, "6", false, "C7", "IQT0024", "What arrangements will be made to continue to consult these individuals during the course of the project where necessary?", "Text", 10, null, null },
                    { "IQA0301", "Mandatory", "Text", null, null, "7", false, "C7", "IQT0024", "What will steps you take, if appropriate, to provide information about the trial to participants, according to their capacity of understanding, and to consider the wishes of participants capable of forming an opinion?", "Text", 11, null, null },
                    { "IQA03010", "Conditional", "Boolean", null, null, "1a", false, "C4", "IQT0025", "Select the type of project", "Look-up list", 2, null, null },
                    { "IQA03011", "Conditional", "Boolean", null, null, "1b", false, "C4", "IQT0025", "Select the type of project", "Look-up list", 3, null, null },
                    { "IQA03012", "Mandatory", "Boolean", null, null, "2", false, "C4", "IQT0025", "Will you be conducting this research project in Northern Ireland?", "Boolean", 4, null, null },
                    { "IQA03013", "Mandatory", "n/a", null, null, "3", false, "C4", "IQT0025", "Confirm the review required for your project", "Label", 5, null, null },
                    { "IQA03014", "Conditional", "Boolean", null, null, "3a", false, "C4", "IQT0025", "Based on the information you have provided you are likely to need to apply to the Medicines and Healthcare products Regulatory Agency (MHRA) and Research Ethics Committee (REC). Review the guidance and confirm what review is required.", "Boolean", 6, null, null },
                    { "IQA03015", "Conditional", "Boolean", null, null, "3b", false, "C4", "IQT0025", "Based on the information you have provided you are likely to need to apply to a Research Ethics Committee (REC) but not to the Medicines and Healthcare products Regulatory Agency (MHRA). Review the guidance and confirm what review is required.", "Boolean", 7, null, null },
                    { "IQA0302", "Mandatory", "Text", null, null, "8", false, "C7", "IQT0024", "What arrangements will be put in place where capacity to consent will fluctuate or will be borderline?", "Text", 12, null, null },
                    { "IQA0303", "Mandatory", "Boolean", null, null, "9", false, "C7", "IQT0024", "Is it possible that a participant requiring urgent treatment might need to be recruited into this project before it is possible to identify and consult a person able to advise on the presumed wishes and feelings of participants unable to consent for themselves?", "Boolean", 13, null, null },
                    { "IQA0304", "Conditional", "Text", null, null, "9a", false, "C7", "IQT0024", "Where possible you should seek agreement from a registered practioner before including the participant.  Outline these arrangments.\n* if this is not feasible to seek agreement from a registered practioner, how will decisions be made on inclusion of participants? \n* what arrangements will be made to seek consent from the participant (if capacity has been recovered) or advice from a consultee as soon as possible", "Text", 14, null, null },
                    { "IQA0305", "Conditional", "Text", null, null, "9b", false, "C7", "IQT0024", "Describe the arrangements for informing relatives in circumstances where a nominated consultee has to be approached. If you will not be informing relatives in this circumstance, explain your reasoning.", "Text", 15, null, null },
                    { "IQA0306", "Conditional", "Text", null, null, "9c", false, "C7", "IQT0024", "Where a participant is recruited prior to consent being obtained, and consent is later withheld or the participant dies before consent can be given, what provisions will apply to the study data collected up to this point?", "Text", 16, null, null },
                    { "IQA0307", "Mandatory", "Text", null, null, "10", false, "C7", "IQT0024", "Describe what steps will be taken to ensure that nothing is done to which participants appear to object (unless it is to protect them from harm or minimise pain or discomfort).", "Text", 17, null, null },
                    { "IQA0308", "Mandatory", "Text", null, null, "11", false, "C7", "IQT0024", "Describe what steps will be taken to ensure that nothing is done which is contrary to any advance decision or statement by the participant?", "Text", 18, null, null },
                    { "IQA0309", "Mandatory", "Boolean", null, null, "1", false, "C4", "IQT0025", "Is the study sponsored, funded or supported by a device manufacturer or other commercial company?", "Boolean", 1, null, null },
                    { "IQA03247", "Mandatory", "Boolean", null, null, "1", false, "C4", "IQT0053", "Is the manufacturer (or other organisation responsible for developing the device) the same organisation named as lead sponsor for this study?", "Boolean", 1, null, null },
                    { "IQA03248", "n/a", "n/a", null, null, "2", false, "C4", "IQT0053", "Details of the medical devices to be used in the study", "Label", 2, null, null },
                    { "IQA03249", "Mandatory", "Text", null, null, "2a", false, "C4", "IQT0053", "Name of the manufacturer:", "Text", 3, null, null },
                    { "IQA03250", "Mandatory", "Text", null, null, "2b", false, "C4", "IQT0053", "Manufacturer's trade name for the device:", "Text", 4, null, null },
                    { "IQA03251", "Mandatory", "n/a", null, null, "Note", false, "C4", "IQT0053", "Device identification name and number:", "Label", 5, null, null },
                    { "IQA03252", "Mandatory", "Text", null, null, "2c", false, "C4", "IQT0053", "Name:", "Text", 6, null, null },
                    { "IQA03253", "Mandatory", "Text", null, null, "2d", false, "C4", "IQT0053", "Number:", "Text", 7, null, null },
                    { "IQA03254", "Mandatory", "Text", null, null, "2e", false, "C4", "IQT0053", "Generic name of device and principal intended uses:", "Text", 8, null, null },
                    { "IQA03255", "Mandatory", "Text", null, null, "2f", false, "C4", "IQT0053", "Length of time since device came into use:", "Text", 9, null, null },
                    { "IQA03256", "Mandatory", "Radio button", null, null, "3", false, "C4", "IQT0053", "Select the type of research project. For all products with UKCA/CE UKNI/CE mark, attach instructions for use.", "Look-up list", 10, null, null },
                    { "IQA03257", "Conditional", "Boolean", null, null, "3a", false, "C4", "IQT0053", "Will the device be used within its intended population?", "Boolean", 11, null, null },
                    { "IQA03258", "Conditional", "Text", null, null, "3b", false, "C4", "IQT0053", "Description of any new device, materials, method of use or operation with a summary of the intended purpose.", "Text", 12, null, null },
                    { "IQA03259", "Conditional", "Text", null, null, "3c", false, "C4", "IQT0053", "Composition of any new implantable materials, including summary of biocompatibility findings from studies to date.", "Text", 13, null, null },
                    { "IQA03260", "Conditional", "Text", null, null, "3d", false, "C4", "IQT0053", "A summary of any modifications to UKCA/CE UKNI/CE marked devices.", "Text", 14, null, null },
                    { "IQA03261", "Conditional", "Text", null, null, "3e", false, "C4", "IQT0053", "A summary of any proposed changes to the UKCA/CE UKNI/CE marked intended purpose.", "Text", 15, null, null },
                    { "IQA03262", "Mandatory", "Boolean", null, null, "4", false, "C4", "IQT0053", "Are the procedures involved non-invasive or minimally invasive?", "Boolean", 16, null, null },
                    { "IQA03263", "Conditional", "Text", null, null, "5", false, "C4", "IQT0053", "Describe the arrangements for manufacture of the investigational device. Include details of the quality assurance system in place within the legal entity. Give details of any collaboration with a commercial manufacturer or other sub- contractor. Enclose a copy of the contract.", "Text", 17, null, null },
                    { "IQA03264", "Conditional", "Text", null, null, "6", false, "C4", "IQT0053", "What safety and performance testing has been undertaken on the investigational device and its constituents? Give summarised details of appropriate tests (including outcome such as pass or fail), for example mechanical, electrical, biological, toxicological, sterilisation.", "Text", 18, null, null },
                    { "IQA03265", "Conditional", "Text", null, null, "7", false, "C4", "IQT0053", "Describe the sponsor’s plans for further development and use of the device. Indicate whether the plans include making it available (whether for a fee or not) to other legal entities or working with a device manufacturer or other company to commercialise the product.", "Text", 19, null, null },
                    { "IQA03266", "Conditional", "Text", null, null, "8", false, "C4", "IQT0053", "Give details of the arrangements for ensuring that the device has been manufactured to the standards expected of an equivalent UKCA/CE UKNI/CE marked device, and that all relevant testing to demonstrate compliance with these standards has been undertaken.", "Text", 20, null, null },
                    { "IQA03271", "Mandatory", "Boolean", null, null, "5", false, "A", "IQT0001", "Are you seeking NIHR funding for this project?", "Boolean", 5, null, null },
                    { "IQA03273", "Mandatory", "Checkbox", null, null, "5", false, "B", "IQT0008", "What type of questionnaires are you using in this project? Select all that apply:", "Look-up list", 6, null, null },
                    { "IQA03274", "Conditional", "Text", null, null, "3", false, "B", "IQT0006", "What did your public contributors say was important to them about how this research is done?", "Text", 7, null, null },
                    { "IQA03275", "Conditional", "Text", null, null, "4b", false, "B", "IQT0006", "Justify your approach and describe the benefits and challenges of involving public contributors", "Text", 10, null, null },
                    { "IQA03276", "Conditional", "Text", null, null, "4c", false, "B", "IQT0006", "Justify the approach and  absence of public involvement", "Text", 11, null, null },
                    { "IQA03277", "Mandatory", "Checkbox", null, null, "6", false, "B", "IQT0007", "Does your project use AI (artificial intelligence)?", "Look-up list", 11, null, null },
                    { "IQA03278", "Conditional", "Checkbox", null, null, "6a", false, "B", "IQT0007", "In relation to designing, developing or testing an AI product or tool, what best describes the type of AI? Select all that apply:", "Look-up list", 12, null, null },
                    { "IQA03279", "Conditional", "Text", null, null, "6a 1", false, "B", "IQT0007", "Describe the type of AI being used in your project.", "Text", 13, null, null },
                    { "IQA03280", "Conditional", "Checkbox", null, null, "6b", false, "B", "IQT0007", "In relation to using an existing AI product or tool for its intended purpose, what best describes the type of AI? Select all that apply:", "Look-up list", 14, null, null },
                    { "IQA03281", "Conditional", "Text", null, null, "6b 1", false, "B", "IQT0007", "Describe the type of AI being used in your project.", "Text", 15, null, null },
                    { "IQA03282", "Conditional", "Boolean", null, null, "4b", false, "A", "IQT0003", "Does any investigational medicinal product contain genetically modified organisms?", "Boolean", 7, null, null },
                    { "IQG0001", "Mandatory", "n/a", null, null, "Note", false, "A", "IQT0001", "The following services to support researchers are available via the Central Portfolio Management System (CPMS)\n• creation of a Schedule of Events Cost Attribution Template (SoECAT) to support non-commercial funding applications and the set-up of studies in the NHS or HSC\n• creation of an interactive costing tool (for commercial sponsors) for set up of studies in the NHS or HSC \n• access to feasibility services\n• access to clinical research network support", "Label: on-screen instruction", 6, null, null },
                    { "IQG0002", "Conditional", "n/a", null, null, "Note", false, "A", "IQT0001", "The person identified will be able to access CPMS [link to CPMS SIM Homepage Link].", "Label: on-screen instruction", 9, null, null },
                    { "IQG0003", "n/a", "n/a", null, null, "Note", false, "B", "IQT0015", "Most research should be registered in a publicly accessible registry and it is expected that all researchers, research sponsors and others meet this fundamental best practice standard. ", "Label: on-screen instruction", 1, null, null },
                    { "IQG0004", "Conditional", "n/a", null, null, "Note", false, "B", "IQT0015", "The Health Research Authority will publish a summary of the project, once approved unless a deferral is requested and agreed. Deferral will only be agreed where a strong justification is provided.", "Label/On-screen Instructions", 11, null, null },
                    { "IQG0005", "Conditional", "n/a", null, null, "Note", false, "C1", "IQT0019", "You cannot proceed with your project if it is at undergraduate level or below and not a group project led by a supervisor.", "Label: on-screen instruction", 4, null, null }
                });

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Answers",
                type: "int",
                nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerOptionId", "EndDate", "QuestionId", "StartDate", "Version" },
                values: new object[,]
                {
                    { 1, "OPT0001", null, "IQA0001", null, null },
                    { 2, "OPT0002", null, "IQA0001", null, null },
                    { 3, "OPT0003", null, "IQA0001", null, null },
                    { 4, "OPT0004", null, "IQA0004", null, null },
                    { 5, "OPT0005", null, "IQA0004", null, null },
                    { 6, "OPT0004", null, "IQA03271", null, null },
                    { 7, "OPT0005", null, "IQA03271", null, null },
                    { 8, "OPT0004", null, "IQA0005", null, null },
                    { 9, "OPT0005", null, "IQA0005", null, null },
                    { 10, "OPT0004", null, "IQA0012", null, null },
                    { 11, "OPT0005", null, "IQA0012", null, null },
                    { 12, "OPT0006", null, "IQA0061", null, null },
                    { 13, "OPT0007", null, "IQA0061", null, null },
                    { 14, "OPT0008", null, "IQA0061", null, null },
                    { 15, "OPT0009", null, "IQA0061", null, null },
                    { 16, "OPT0010", null, "IQA0061", null, null },
                    { 17, "OPT0011", null, "IQA0061", null, null },
                    { 18, "OPT0012", null, "IQA0061", null, null },
                    { 19, "OPT0013", null, "IQA0061", null, null },
                    { 20, "OPT0004", null, "IQA0014", null, null },
                    { 21, "OPT0005", null, "IQA0014", null, null },
                    { 22, "OPT0004", null, "IQA0015", null, null },
                    { 23, "OPT0005", null, "IQA0015", null, null },
                    { 24, "OPT0004", null, "IQA0017", null, null },
                    { 25, "OPT0005", null, "IQA0017", null, null },
                    { 26, "OPT0014", null, "IQA0018", null, null },
                    { 27, "OPT0015", null, "IQA0018", null, null },
                    { 28, "OPT0004", null, "IQA03282", null, null },
                    { 29, "OPT0005", null, "IQA03282", null, null },
                    { 30, "OPT0004", null, "IQA0020", null, null },
                    { 31, "OPT0005", null, "IQA0020", null, null },
                    { 32, "OPT0004", null, "IQA0021", null, null },
                    { 33, "OPT0005", null, "IQA0021", null, null },
                    { 34, "OPT0004", null, "IQA0022", null, null },
                    { 35, "OPT0005", null, "IQA0022", null, null },
                    { 36, "OPT0004", null, "IQA0024", null, null },
                    { 37, "OPT0005", null, "IQA0024", null, null },
                    { 38, "OPT0004", null, "IQA0025", null, null },
                    { 39, "OPT0005", null, "IQA0025", null, null },
                    { 40, "OPT0004", null, "IQA0026", null, null },
                    { 41, "OPT0005", null, "IQA0026", null, null },
                    { 42, "OPT0004", null, "IQA0027", null, null },
                    { 43, "OPT0005", null, "IQA0027", null, null },
                    { 44, "OPT0004", null, "IQA0028", null, null },
                    { 45, "OPT0005", null, "IQA0028", null, null },
                    { 46, "OPT0004", null, "IQA0029", null, null },
                    { 47, "OPT0005", null, "IQA0029", null, null },
                    { 48, "OPT0016", null, "IQA0142", null, null },
                    { 49, "OPT0017", null, "IQA0142", null, null },
                    { 51, "OPT0018", null, "IQA0032", null, null },
                    { 52, "OPT0019", null, "IQA0032", null, null },
                    { 53, "OPT0020", null, "IQA0032", null, null },
                    { 54, "OPT0021", null, "IQA0032", null, null },
                    { 55, "OPT0018", null, "IQA0033", null, null },
                    { 56, "OPT0019", null, "IQA0033", null, null },
                    { 57, "OPT0020", null, "IQA0033", null, null },
                    { 58, "OPT0021", null, "IQA0033", null, null },
                    { 59, "OPT0018", null, "IQA0034", null, null },
                    { 60, "OPT0019", null, "IQA0034", null, null },
                    { 61, "OPT0020", null, "IQA0034", null, null },
                    { 62, "OPT0021", null, "IQA0034", null, null },
                    { 63, "OPT0022", null, "IQA0144", null, null },
                    { 64, "OPT0023", null, "IQA0144", null, null },
                    { 65, "OPT0024", null, "IQA0144", null, null },
                    { 66, "OPT0025", null, "IQA0144", null, null },
                    { 67, "OPT0026", null, "IQA0144", null, null },
                    { 68, "OPT0027", null, "IQA0144", null, null },
                    { 69, "OPT0028", null, "IQA0144", null, null },
                    { 70, "OPT0029", null, "IQA0144", null, null },
                    { 71, "OPT0030", null, "IQA0144", null, null },
                    { 72, "OPT0031", null, "IQA0144", null, null },
                    { 73, "OPT0032", null, "IQA0144", null, null },
                    { 74, "OPT0033", null, "IQA0144", null, null },
                    { 75, "OPT0004", null, "IQA0146", null, null },
                    { 76, "OPT0005", null, "IQA0146", null, null },
                    { 77, "OPT0034", null, "IQA0146", null, null },
                    { 78, "OPT0035", null, "IQA0045", null, null },
                    { 79, "OPT0036", null, "IQA0045", null, null },
                    { 80, "OPT0037", null, "IQA0045", null, null },
                    { 81, "OPT0038", null, "IQA0045", null, null },
                    { 82, "OPT0039", null, "IQA0045", null, null },
                    { 83, "OPT0040", null, "IQA0045", null, null },
                    { 84, "OPT0041", null, "IQA0045", null, null },
                    { 85, "OPT0042", null, "IQA0045", null, null },
                    { 86, "OPT0043", null, "IQA0045", null, null },
                    { 87, "OPT0044", null, "IQA0045", null, null },
                    { 88, "OPT0045", null, "IQA0045", null, null },
                    { 89, "OPT0046", null, "IQA0045", null, null },
                    { 90, "OPT0047", null, "IQA0045", null, null },
                    { 91, "OPT0048", null, "IQA0045", null, null },
                    { 92, "OPT0033", null, "IQA0045", null, null },
                    { 93, "OPT0049", null, "IQA0045", null, null },
                    { 94, "OPT0050", null, "IQA0042", null, null },
                    { 95, "OPT0051", null, "IQA0042", null, null },
                    { 96, "OPT0052", null, "IQA0042", null, null },
                    { 97, "OPT0053", null, "IQA0042", null, null },
                    { 98, "OPT0033", null, "IQA0042", null, null },
                    { 99, "OPT0054", null, "IQA0162", null, null },
                    { 100, "OPT0037", null, "IQA0162", null, null },
                    { 101, "OPT0045", null, "IQA0162", null, null },
                    { 102, "OPT0055", null, "IQA0162", null, null },
                    { 103, "OPT0056", null, "IQA0162", null, null },
                    { 104, "OPT0057", null, "IQA0162", null, null },
                    { 105, "OPT0058", null, "IQA0162", null, null },
                    { 106, "OPT0059", null, "IQA0162", null, null },
                    { 107, "OPT0060", null, "IQA0162", null, null },
                    { 108, "OPT0061", null, "IQA0162", null, null },
                    { 109, "OPT0033", null, "IQA0162", null, null },
                    { 110, "OPT0062", null, "IQA0049", null, null },
                    { 111, "OPT0063", null, "IQA0049", null, null },
                    { 112, "OPT0064", null, "IQA0049", null, null },
                    { 113, "OPT0065", null, "IQA0049", null, null },
                    { 114, "OPT0066", null, "IQA0049", null, null },
                    { 115, "OPT0067", null, "IQA0049", null, null },
                    { 116, "OPT0068", null, "IQA0049", null, null },
                    { 117, "OPT0069", null, "IQA0049", null, null },
                    { 118, "OPT0070", null, "IQA0049", null, null },
                    { 119, "OPT0071", null, "IQA0049", null, null },
                    { 120, "OPT0072", null, "IQA0049", null, null },
                    { 121, "OPT0073", null, "IQA0049", null, null },
                    { 122, "OPT0074", null, "IQA0049", null, null },
                    { 123, "OPT0033", null, "IQA0049", null, null },
                    { 124, "OPT0075", null, "IQA0051", null, null },
                    { 125, "OPT0076", null, "IQA0051", null, null },
                    { 126, "OPT0077", null, "IQA0051", null, null },
                    { 127, "OPT0078", null, "IQA0051", null, null },
                    { 128, "OPT0079", null, "IQA0051", null, null },
                    { 129, "OPT0080", null, "IQA0051", null, null },
                    { 130, "OPT0081", null, "IQA0051", null, null },
                    { 131, "OPT0082", null, "IQA0051", null, null },
                    { 132, "OPT0083", null, "IQA0051", null, null },
                    { 133, "OPT0084", null, "IQA0051", null, null },
                    { 134, "OPT0085", null, "IQA0051", null, null },
                    { 135, "OPT0086", null, "IQA0051", null, null },
                    { 136, "OPT0087", null, "IQA0051", null, null },
                    { 137, "OPT0088", null, "IQA0051", null, null },
                    { 138, "OPT0004", null, "IQA0054", null, null },
                    { 139, "OPT0005", null, "IQA0054", null, null },
                    { 140, "OPT0004", null, "IQA0055", null, null },
                    { 141, "OPT0005", null, "IQA0055", null, null },
                    { 142, "OPT0004", null, "IQA0056", null, null },
                    { 143, "OPT0005", null, "IQA0056", null, null },
                    { 144, "OPT0089", null, "IQA03277", null, null },
                    { 145, "OPT0090", null, "IQA03277", null, null },
                    { 146, "OPT0091", null, "IQA03277", null, null },
                    { 147, "OPT0092", null, "IQA03278", null, null },
                    { 148, "OPT0093", null, "IQA03278", null, null },
                    { 149, "OPT0094", null, "IQA03278", null, null },
                    { 150, "OPT0095", null, "IQA03278", null, null },
                    { 151, "OPT0096", null, "IQA03278", null, null },
                    { 152, "OPT0033", null, "IQA03278", null, null },
                    { 153, "OPT0092", null, "IQA03280", null, null },
                    { 154, "OPT0093", null, "IQA03280", null, null },
                    { 155, "OPT0094", null, "IQA03280", null, null },
                    { 156, "OPT0095", null, "IQA03280", null, null },
                    { 157, "OPT0096", null, "IQA03280", null, null },
                    { 158, "OPT0033", null, "IQA03280", null, null },
                    { 159, "OPT0097", null, "IQA0083", null, null },
                    { 160, "OPT0098", null, "IQA0083", null, null },
                    { 161, "OPT0099", null, "IQA0083", null, null },
                    { 162, "OPT0100", null, "IQA0083", null, null },
                    { 163, "OPT0101", null, "IQA0083", null, null },
                    { 164, "OPT0102", null, "IQA0083", null, null },
                    { 165, "OPT0103", null, "IQA0083", null, null },
                    { 166, "OPT0104", null, "IQA0083", null, null },
                    { 167, "OPT0105", null, "IQA0083", null, null },
                    { 168, "OPT0106", null, "IQA0083", null, null },
                    { 169, "OPT0107", null, "IQA0083", null, null },
                    { 170, "OPT0108", null, "IQA0083", null, null },
                    { 171, "OPT0109", null, "IQA0083", null, null },
                    { 172, "OPT0110", null, "IQA0083", null, null },
                    { 173, "OPT0111", null, "IQA0083", null, null },
                    { 174, "OPT0112", null, "IQA0083", null, null },
                    { 175, "OPT0113", null, "IQA0083", null, null },
                    { 176, "OPT0114", null, "IQA0083", null, null },
                    { 177, "OPT0115", null, "IQA0083", null, null },
                    { 178, "OPT0116", null, "IQA0083", null, null },
                    { 179, "OPT0117", null, "IQA0083", null, null },
                    { 180, "OPT0118", null, "IQA0088", null, null },
                    { 181, "OPT0119", null, "IQA0088", null, null },
                    { 182, "OPT0120", null, "IQA0088", null, null },
                    { 183, "OPT0121", null, "IQA0088", null, null },
                    { 184, "OPT0122", null, "IQA0088", null, null },
                    { 185, "OPT0123", null, "IQA0088", null, null },
                    { 186, "OPT0124", null, "IQA0088", null, null },
                    { 187, "OPT0125", null, "IQA0088", null, null },
                    { 188, "OPT0126", null, "IQA0088", null, null },
                    { 189, "OPT0127", null, "IQA0088", null, null },
                    { 190, "OPT0033", null, "IQA0088", null, null },
                    { 191, "OPT0004", null, "IQA0093", null, null },
                    { 192, "OPT0005", null, "IQA0093", null, null },
                    { 193, "OPT0004", null, "IQA0063", null, null },
                    { 194, "OPT0005", null, "IQA0063", null, null },
                    { 195, "OPT0004", null, "IQA0064", null, null },
                    { 196, "OPT0005", null, "IQA0064", null, null },
                    { 197, "OPT0004", null, "IQA0065", null, null },
                    { 198, "OPT0005", null, "IQA0065", null, null },
                    { 199, "OPT0128", null, "IQA03273", null, null },
                    { 200, "OPT0129", null, "IQA03273", null, null },
                    { 201, "OPT0130", null, "IQA03273", null, null },
                    { 202, "OPT0131", null, "IQA03273", null, null },
                    { 203, "OPT0004", null, "IQA0068", null, null },
                    { 204, "OPT0005", null, "IQA0068", null, null },
                    { 205, "OPT0004", null, "IQA0070", null, null },
                    { 206, "OPT0005", null, "IQA0070", null, null },
                    { 207, "OPT0004", null, "IQA0077", null, null },
                    { 208, "OPT0005", null, "IQA0077", null, null },
                    { 209, "OPT0132", null, "IQA0079", null, null },
                    { 210, "OPT0133", null, "IQA0079", null, null },
                    { 211, "OPT0134", null, "IQA0096", null, null },
                    { 212, "OPT0135", null, "IQA0096", null, null },
                    { 213, "OPT0136", null, "IQA0096", null, null },
                    { 214, "OPT0004", null, "IQA0095", null, null },
                    { 215, "OPT0005", null, "IQA0095", null, null },
                    { 216, "OPT0137", null, "IQA0097", null, null },
                    { 217, "OPT0138", null, "IQA0097", null, null },
                    { 218, "OPT0139", null, "IQA0097", null, null },
                    { 219, "OPT0140", null, "IQA0098", null, null },
                    { 220, "OPT0141", null, "IQA0098", null, null },
                    { 221, "OPT0033", null, "IQA0098", null, null },
                    { 222, "OPT0142", null, "IQA0108", null, null },
                    { 223, "OPT0143", null, "IQA0108", null, null },
                    { 224, "OPT0144", null, "IQA0108", null, null },
                    { 225, "OPT0004", null, "IQA0111", null, null },
                    { 226, "OPT0005", null, "IQA0111", null, null },
                    { 227, "OPT0004", null, "IQA0113", null, null },
                    { 228, "OPT0005", null, "IQA0113", null, null },
                    { 229, "OPT0145", null, "IQA0114", null, null },
                    { 230, "OPT0146", null, "IQA0114", null, null },
                    { 231, "OPT0147", null, "IQA0114", null, null },
                    { 232, "OPT0148", null, "IQA0114", null, null },
                    { 233, "OPT0149", null, "IQA0114", null, null },
                    { 234, "OPT0150", null, "IQA0114", null, null },
                    { 235, "OPT0151", null, "IQA0114", null, null },
                    { 236, "OPT0152", null, "IQA0114", null, null },
                    { 237, "OPT0153", null, "IQA0114", null, null },
                    { 238, "OPT0154", null, "IQA0114", null, null },
                    { 239, "OPT0155", null, "IQA0114", null, null },
                    { 240, "OPT0156", null, "IQA0114", null, null },
                    { 241, "OPT0157", null, "IQA0114", null, null },
                    { 242, "OPT0158", null, "IQA0114", null, null },
                    { 243, "OPT0159", null, "IQA0114", null, null },
                    { 244, "OPT0160", null, "IQA0114", null, null },
                    { 245, "OPT0161", null, "IQA0114", null, null },
                    { 246, "OPT0162", null, "IQA0114", null, null },
                    { 247, "OPT0163", null, "IQA0114", null, null },
                    { 248, "OPT0164", null, "IQA0114", null, null },
                    { 249, "OPT0165", null, "IQA0114", null, null },
                    { 250, "OPT0166", null, "IQA0114", null, null },
                    { 251, "OPT0167", null, "IQA0114", null, null },
                    { 252, "OPT0168", null, "IQA0114", null, null },
                    { 253, "OPT0169", null, "IQA0114", null, null },
                    { 254, "OPT0170", null, "IQA0114", null, null },
                    { 255, "OPT0171", null, "IQA0114", null, null },
                    { 256, "OPT0172", null, "IQA0114", null, null },
                    { 257, "OPT0173", null, "IQA0114", null, null },
                    { 258, "OPT0174", null, "IQA0114", null, null },
                    { 259, "OPT0175", null, "IQA0114", null, null },
                    { 260, "OPT0176", null, "IQA0114", null, null },
                    { 261, "OPT0177", null, "IQA0114", null, null },
                    { 262, "OPT0178", null, "IQA0114", null, null },
                    { 263, "OPT0179", null, "IQA0114", null, null },
                    { 264, "OPT0180", null, "IQA0114", null, null },
                    { 265, "OPT0181", null, "IQA0114", null, null },
                    { 266, "OPT0182", null, "IQA0114", null, null },
                    { 267, "OPT0183", null, "IQA0114", null, null },
                    { 268, "OPT0184", null, "IQA0114", null, null },
                    { 269, "OPT0185", null, "IQA0114", null, null },
                    { 270, "OPT0186", null, "IQA0114", null, null },
                    { 271, "OPT0187", null, "IQA0114", null, null },
                    { 272, "OPT0188", null, "IQA0114", null, null },
                    { 273, "OPT0189", null, "IQA0114", null, null },
                    { 274, "OPT0190", null, "IQA0114", null, null },
                    { 275, "OPT0191", null, "IQA0114", null, null },
                    { 276, "OPT0192", null, "IQA0114", null, null },
                    { 277, "OPT0193", null, "IQA0114", null, null },
                    { 278, "OPT0194", null, "IQA0114", null, null },
                    { 279, "OPT0195", null, "IQA0114", null, null },
                    { 280, "OPT0196", null, "IQA0114", null, null },
                    { 281, "OPT0197", null, "IQA0114", null, null },
                    { 282, "OPT0198", null, "IQA0114", null, null },
                    { 283, "OPT0199", null, "IQA0114", null, null },
                    { 284, "OPT0200", null, "IQA0114", null, null },
                    { 285, "OPT0201", null, "IQA0114", null, null },
                    { 286, "OPT0202", null, "IQA0114", null, null },
                    { 287, "OPT0203", null, "IQA0114", null, null },
                    { 288, "OPT0204", null, "IQA0114", null, null },
                    { 289, "OPT0205", null, "IQA0114", null, null },
                    { 290, "OPT0206", null, "IQA0114", null, null },
                    { 291, "OPT0207", null, "IQA0114", null, null },
                    { 292, "OPT0208", null, "IQA0114", null, null },
                    { 293, "OPT0209", null, "IQA0114", null, null },
                    { 294, "OPT0210", null, "IQA0114", null, null },
                    { 295, "OPT0211", null, "IQA0114", null, null },
                    { 296, "OPT0212", null, "IQA0114", null, null },
                    { 297, "OPT0213", null, "IQA0114", null, null },
                    { 298, "OPT0214", null, "IQA0114", null, null },
                    { 299, "OPT0215", null, "IQA0114", null, null },
                    { 300, "OPT0216", null, "IQA0114", null, null },
                    { 301, "OPT0217", null, "IQA0114", null, null },
                    { 302, "OPT0218", null, "IQA0114", null, null },
                    { 303, "OPT0219", null, "IQA0114", null, null },
                    { 304, "OPT0220", null, "IQA0114", null, null },
                    { 305, "OPT0221", null, "IQA0114", null, null },
                    { 306, "OPT0222", null, "IQA0114", null, null },
                    { 307, "OPT0223", null, "IQA0114", null, null },
                    { 308, "OPT0224", null, "IQA0114", null, null },
                    { 309, "OPT0225", null, "IQA0114", null, null },
                    { 310, "OPT0226", null, "IQA0114", null, null },
                    { 311, "OPT0227", null, "IQA0114", null, null },
                    { 312, "OPT0228", null, "IQA0114", null, null },
                    { 313, "OPT0229", null, "IQA0114", null, null },
                    { 314, "OPT0230", null, "IQA0114", null, null },
                    { 315, "OPT0004", null, "IQA0115", null, null },
                    { 316, "OPT0005", null, "IQA0115", null, null },
                    { 317, "OPT0231", null, "IQA0118", null, null },
                    { 318, "OPT0232", null, "IQA0118", null, null },
                    { 319, "OPT0233", null, "IQA0118", null, null },
                    { 320, "OPT0234", null, "IQA0118", null, null },
                    { 321, "OPT0235", null, "IQA0121", null, null },
                    { 322, "OPT0236", null, "IQA0121", null, null },
                    { 323, "OPT0237", null, "IQA0121", null, null },
                    { 324, "OPT0238", null, "IQA0121", null, null },
                    { 325, "OPT0239", null, "IQA0121", null, null },
                    { 326, "OPT0240", null, "IQA0121", null, null },
                    { 327, "OPT0033", null, "IQA0121", null, null },
                    { 328, "OPT0241", null, "IQA0124", null, null },
                    { 329, "OPT0242", null, "IQA0124", null, null },
                    { 330, "OPT0243", null, "IQA0126", null, null },
                    { 331, "OPT0244", null, "IQA0126", null, null },
                    { 332, "OPT0245", null, "IQA0126", null, null },
                    { 333, "OPT0246", null, "IQA0126", null, null },
                    { 334, "OPT0247", null, "IQA0126", null, null },
                    { 335, "OPT0240", null, "IQA0126", null, null },
                    { 336, "OPT0248", null, "IQA0126", null, null },
                    { 337, "OPT0249", null, "IQA0126", null, null },
                    { 338, "OPT0250", null, "IQA0147", null, null },
                    { 339, "OPT0251", null, "IQA0147", null, null },
                    { 340, "OPT0252", null, "IQA0147", null, null },
                    { 341, "OPT0004", null, "IQA0153", null, null },
                    { 342, "OPT0005", null, "IQA0153", null, null },
                    { 343, "OPT0004", null, "IQA0155", null, null },
                    { 344, "OPT0005", null, "IQA0155", null, null },
                    { 345, "OPT0004", null, "IQA0157", null, null },
                    { 346, "OPT0005", null, "IQA0157", null, null },
                    { 347, "OPT0004", null, "IQA0169", null, null },
                    { 348, "OPT0005", null, "IQA0169", null, null },
                    { 349, "OPT0253", null, "IQA0165", null, null },
                    { 350, "OPT0254", null, "IQA0165", null, null },
                    { 351, "OPT0255", null, "IQA0165", null, null },
                    { 352, "OPT0256", null, "IQA0167", null, null },
                    { 353, "OPT0257", null, "IQA0167", null, null },
                    { 354, "OPT0258", null, "IQA0169", null, null },
                    { 355, "OPT0259", null, "IQA0169", null, null },
                    { 356, "OPT0033", null, "IQA0169", null, null },
                    { 357, "OPT0253", null, "IQA0173", null, null },
                    { 358, "OPT0254", null, "IQA0173", null, null },
                    { 359, "OPT0255", null, "IQA0173", null, null },
                    { 360, "OPT0262", null, "IQA0176", null, null },
                    { 361, "OPT0263", null, "IQA0176", null, null },
                    { 362, "OPT0264", null, "IQA0176", null, null },
                    { 363, "OPT0265", null, "IQA0176", null, null },
                    { 364, "OPT0266", null, "IQA0176", null, null },
                    { 365, "OPT0267", null, "IQA0176", null, null },
                    { 366, "OPT0268", null, "IQA0176", null, null },
                    { 367, "OPT0269", null, "IQA0176", null, null },
                    { 368, "OPT0033", null, "IQA0176", null, null },
                    { 369, "OPT0004", null, "IQA0179", null, null },
                    { 370, "OPT0005", null, "IQA0179", null, null },
                    { 371, "OPT0004", null, "IQA0181", null, null },
                    { 372, "OPT0005", null, "IQA0181", null, null },
                    { 373, "OPT0004", null, "IQA0182", null, null },
                    { 374, "OPT0005", null, "IQA0182", null, null },
                    { 375, "OPT0004", null, "IQA0251", null, null },
                    { 376, "OPT0005", null, "IQA0251", null, null },
                    { 377, "OPT0004", null, "IQA0219", null, null },
                    { 378, "OPT0005", null, "IQA0219", null, null },
                    { 379, "OPT0270", null, "IQA0222", null, null },
                    { 380, "OPT0271", null, "IQA0222", null, null },
                    { 381, "OPT0272", null, "IQA0222", null, null },
                    { 382, "OPT0273", null, "IQA0223", null, null },
                    { 383, "OPT0274", null, "IQA0223", null, null },
                    { 384, "OPT0275", null, "IQA0223", null, null },
                    { 385, "OPT0004", null, "IQA0224", null, null },
                    { 386, "OPT0005", null, "IQA0224", null, null },
                    { 387, "OPT0276", null, "IQA0237", null, null },
                    { 388, "OPT0277", null, "IQA0237", null, null },
                    { 389, "OPT0004", null, "IQA0309", null, null },
                    { 390, "OPT0005", null, "IQA0309", null, null },
                    { 391, "OPT0278", null, "IQA03010", null, null },
                    { 392, "OPT0279", null, "IQA03010", null, null },
                    { 393, "OPT0280", null, "IQA03010", null, null },
                    { 394, "OPT0281", null, "IQA03010", null, null },
                    { 395, "OPT0282", null, "IQA03010", null, null },
                    { 396, "OPT0283", null, "IQA03011", null, null },
                    { 397, "OPT0284", null, "IQA03011", null, null },
                    { 398, "OPT0285", null, "IQA03011", null, null },
                    { 399, "OPT0286", null, "IQA03011", null, null },
                    { 400, "OPT0287", null, "IQA03011", null, null },
                    { 401, "OPT0288", null, "IQA03011", null, null },
                    { 402, "OPT0004", null, "IQA03012", null, null },
                    { 403, "OPT0005", null, "IQA03012", null, null },
                    { 404, "OPT0289", null, "IQA03014", null, null },
                    { 405, "OPT0290", null, "IQA03014", null, null },
                    { 406, "OPT0289", null, "IQA03015", null, null },
                    { 407, "OPT0290", null, "IQA03015", null, null },
                    { 408, "OPT0004", null, "IQA03247", null, null },
                    { 409, "OPT0005", null, "IQA03247", null, null },
                    { 410, "OPT0291", null, "IQA03256", null, null },
                    { 411, "OPT0292", null, "IQA03256", null, null },
                    { 412, "OPT0293", null, "IQA03256", null, null },
                    { 413, "OPT0294", null, "IQA03256", null, null },
                    { 414, "OPT0295", null, "IQA03256", null, null },
                    { 415, "OPT0004", null, "IQA03257", null, null },
                    { 416, "OPT0005", null, "IQA03257", null, null },
                    { 417, "OPT0004", null, "IQA03262", null, null },
                    { 418, "OPT0005", null, "IQA03262", null, null },
                    { 419, "OPT0004", null, "IQA0254", null, null },
                    { 420, "OPT0005", null, "IQA0254", null, null },
                    { 421, "OPT0004", null, "IQA0255", null, null },
                    { 422, "OPT0005", null, "IQA0255", null, null },
                    { 423, "OPT0296", null, "IQA0257", null, null },
                    { 424, "OPT0297", null, "IQA0257", null, null },
                    { 425, "OPT0018", null, "IQA0258", null, null },
                    { 426, "OPT0019", null, "IQA0258", null, null },
                    { 427, "OPT0020", null, "IQA0258", null, null },
                    { 428, "OPT0021", null, "IQA0258", null, null },
                    { 429, "OPT0004", null, "IQA0260", null, null },
                    { 430, "OPT0005", null, "IQA0260", null, null },
                    { 431, "OPT0004", null, "IQA0261", null, null },
                    { 432, "OPT0005", null, "IQA0261", null, null },
                    { 433, "OPT0004", null, "IQA0262", null, null },
                    { 434, "OPT0005", null, "IQA0262", null, null },
                    { 435, "OPT0004", null, "IQA0263", null, null },
                    { 436, "OPT0005", null, "IQA0263", null, null },
                    { 437, "OPT0004", null, "IQA0265", null, null },
                    { 438, "OPT0005", null, "IQA0265", null, null },
                    { 439, "OPT0298", null, "IQA0267", null, null },
                    { 440, "OPT0299", null, "IQA0267", null, null },
                    { 441, "OPT0300", null, "IQA0268", null, null },
                    { 442, "OPT0301", null, "IQA0268", null, null },
                    { 443, "OPT0302", null, "IQA0268", null, null },
                    { 444, "OPT0303", null, "IQA0268", null, null },
                    { 445, "OPT0304", null, "IQA0268", null, null },
                    { 446, "OPT0033", null, "IQA0268", null, null },
                    { 447, "OPT0305", null, "IQA0268", null, null },
                    { 448, "OPT0004", null, "IQA0271", null, null },
                    { 449, "OPT0005", null, "IQA0271", null, null },
                    { 450, "OPT0004", null, "IQA0272", null, null },
                    { 451, "OPT0005", null, "IQA0272", null, null },
                    { 452, "OPT0004", null, "IQA0285", null, null },
                    { 453, "OPT0005", null, "IQA0285", null, null },
                    { 454, "OPT0306", null, "IQA0293", null, null },
                    { 455, "OPT0307", null, "IQA0293", null, null },
                    { 456, "OPT0004", null, "IQA0303", null, null },
                    { 457, "OPT0005", null, "IQA0303", null, null },
                    { 458, "OPT0308", null, "IQA0238", null, null },
                    { 459, "OPT0309", null, "IQA0238", null, null },
                    { 460, "OPT0310", null, "IQA0238", null, null },
                    { 461, "OPT0311", null, "IQA0238", null, null },
                    { 462, "OPT0312", null, "IQA0238", null, null },
                    { 463, "OPT0313", null, "IQA0238", null, null },
                    { 464, "OPT0314", null, "IQA0238", null, null },
                    { 465, "OPT0315", null, "IQA0238", null, null },
                    { 466, "OPT0316", null, "IQA0239", null, null },
                    { 467, "OPT0317", null, "IQA0239", null, null },
                    { 468, "OPT0004", null, "IQA0246", null, null },
                    { 469, "OPT0005", null, "IQA0246", null, null }
                });

            migrationBuilder.DropColumn(
                name: "RuleId",
                table: "QuestionRules");

            migrationBuilder.AddColumn<int>(
                name: "RuleId",
                table: "QuestionRules",
                type: "int",
                nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "QuestionRules",
                columns: new[] { "RuleId", "Conditions", "Description", "Mode", "ParentQuestionId", "QuestionId", "Sequence" },
                values: new object[,]
                {
                    { 1, "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,100\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Short project title should be between the specified characters limit\"}]", "Provide project title between 15 and 100 characters", "AND", null, "IQA0002", 1 },
                    { 2, "[{\"Mode\":\"AND\",\"Operator\":\"LENGTH\",\"Value\":\"15,2000\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Full project title should be between the specified characters limit\"}]", "Provide full project title between 15 and 2000 characters", "AND", null, "IQA0003", 1 },
                    { 3, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Provide a valid email address\"},{\"Mode\":\"AND\",\"Operator\":\"REGEX\",\"Value\":\"^(?=.{6,50}$)[\\\\w\\\\.\\\\-]\\u002B@[a-zA-Z\\\\d\\\\-]\\u002B\\\\.[a-zA-Z]{2,}$\",\"Negate\":false,\"ParentOptions\":[],\"OptionType\":null,\"Description\":\"Should be a valid email address between 6 and 50 characters \"}]", "Answer the following question, if you have answered Yes to Project Details:Q6", "AND", "IQA0005", "IQA0006", 1 },
                    { 4, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0008\",\"OPT0009\",\"OPT0013\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0014", 1 },
                    { 5, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Answer the following question, if you have answered Yes to Q3 under Project Scope", "AND", "IQA0014", "IQA0015", 1 },
                    { 6, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers Project Scope:Q2, the following question should be answered", "OR", "IQA0061", "IQA0017", 1 },
                    { 7, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", " or if you have answered No to Project Scope:Q3", "OR", "IQA0014", "IQA0017", 2 },
                    { 8, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q4", "AND", "IQA0017", "IQA0018", 1 },
                    { 9, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":false,\"ParentOptions\":[\"OPT0004\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Answer the following question, if you have answered Yes to Project Scope:Q4a", "AND", "IQA0018", "IQA03282", 1 },
                    { 10, "[{\"Mode\":\"AND\",\"Operator\":\"IN\",\"Value\":null,\"Negate\":true,\"ParentOptions\":[\"OPT0009\"],\"OptionType\":\"Single\",\"Description\":\"Select an option\"}]", "Based on your answers to Project Scope:Q2, the following question should be answered", "AND", "IQA0061", "IQA0020", 1 },
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

            migrationBuilder.CreateIndex(
                name: "IX_QuestionSections_QuestionCategoryId",
                table: "QuestionSections",
                column: "QuestionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionCategoryId",
                table: "Questions",
                column: "QuestionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionSectionId",
                table: "Questions",
                column: "QuestionSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRules_ParentQuestionId",
                table: "QuestionRules",
                column: "ParentQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRules_QuestionId",
                table: "QuestionRules",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_AnswerOptionId",
                table: "Answers",
                column: "AnswerOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_AnswerOptions_AnswerOptionId",
                table: "Answers",
                column: "AnswerOptionId",
                principalTable: "AnswerOptions",
                principalColumn: "OptionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRules_Questions_ParentQuestionId",
                table: "QuestionRules",
                column: "ParentQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRules_Questions_QuestionId",
                table: "QuestionRules",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionCategories_QuestionCategoryId",
                table: "Questions",
                column: "QuestionCategoryId",
                principalTable: "QuestionCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionSections_QuestionSectionId",
                table: "Questions",
                column: "QuestionSectionId",
                principalTable: "QuestionSections",
                principalColumn: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionSections_QuestionCategories_QuestionCategoryId",
                table: "QuestionSections",
                column: "QuestionCategoryId",
                principalTable: "QuestionCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

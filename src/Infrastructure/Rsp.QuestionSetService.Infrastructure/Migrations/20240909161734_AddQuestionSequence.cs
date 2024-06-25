using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rsp.QuestionSetService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddQuestionSequence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sequence",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0001",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0002",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0003",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0004",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0005",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0006",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0012",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0014",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0015",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0017",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0018",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0020",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0021",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0022",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0023",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0024",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0025",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0026",
                column: "Sequence",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0027",
                column: "Sequence",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0028",
                column: "Sequence",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0029",
                column: "Sequence",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0032",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0033",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0034",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0036",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0037",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0039",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0040",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0042",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0043",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0044",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0045",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0046",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0048",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0049",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0050",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0051",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0052",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0053",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0054",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0055",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0056",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0057",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0058",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0060",
                column: "Sequence",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0061",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0062",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0063",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0064",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0065",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0066",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0068",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0070",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0071",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0072",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0073",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0074",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0075",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0076",
                column: "Sequence",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0077",
                column: "Sequence",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0078",
                column: "Sequence",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0079",
                column: "Sequence",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0080",
                column: "Sequence",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0081",
                column: "Sequence",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0082",
                column: "Sequence",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0083",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0084",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0085",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0086",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0087",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0088",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0089",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0090",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0091",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0092",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0093",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0095",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0096",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0097",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0098",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0099",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA00D1",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0100",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0102",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0103",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0104",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0105",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0106",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0107",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0108",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0109",
                columns: ["Heading", "Sequence"],
                values: ["Note", 14]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0110",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0111",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0112",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0113",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0114",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0115",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0116",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0117",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0118",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0119",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0120",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0121",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0122",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0123",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0124",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0125",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0126",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0127",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0128",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0129",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0130",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0131",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0132",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0139",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0140",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0142",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0143",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0144",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0145",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0146",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0147",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0148",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0149",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0150",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0151",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0152",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0153",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0154",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0155",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0156",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0157",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0158",
                column: "Sequence",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0159",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0162",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0163",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0165",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0166",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0167",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0168",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0169",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0170",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0171",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0172",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0173",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0174",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0175",
                column: "Sequence",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0176",
                column: "Sequence",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0177",
                column: "Sequence",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0178",
                column: "Sequence",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0179",
                column: "Sequence",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0180",
                column: "Sequence",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0181",
                column: "Sequence",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0182",
                columns: ["Heading", "Sequence"],
                values: ["8a", 21]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0183",
                column: "Sequence",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0184",
                column: "Sequence",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0185",
                column: "Sequence",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0186",
                column: "Sequence",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0187",
                column: "Sequence",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0188",
                column: "Sequence",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0189",
                column: "Sequence",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0190",
                column: "Sequence",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0191",
                column: "Sequence",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0218",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0219",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0220",
                columns: ["Heading", "QuestionText", "QuestionType", "Sequence"],
                values: ["4a", "University name", "Text", 6]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0221",
                columns: ["QuestionText", "Sequence"],
                values: ["Course name", 7]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0222",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0223",
                columns: ["Heading", "Sequence"],
                values: ["4", 5]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0224",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0225",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0226",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0227",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0228",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0229",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0230",
                columns: ["Heading", "Sequence"],
                values: ["Note", 14]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0231",
                column: "Sequence",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0232",
                column: "Sequence",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0233",
                column: "Sequence",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0234",
                column: "Sequence",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0235",
                column: "Sequence",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0236",
                column: "Sequence",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0237",
                column: "Sequence",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0238",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0239",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0240",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0241",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0242",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0243",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0245",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0246",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0247",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0248",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0249",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0250",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0251",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0253",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0254",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0255",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0256",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0257",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0258",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0259",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0260",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0261",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0262",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0263",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0264",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0265",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0266",
                column: "Sequence",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0267",
                column: "Sequence",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0268",
                column: "Sequence",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0269",
                column: "Sequence",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0270",
                column: "Sequence",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0271",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0272",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0273",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0278",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0279",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0280",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0281",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0282",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0283",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0284",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0285",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0286",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0287",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0288",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0289",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0290",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0291",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0292",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0293",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0294",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0295",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0296",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0297",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0298",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0299",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0300",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0301",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03010",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03011",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03012",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03013",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03014",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03015",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0302",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0303",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0304",
                column: "Sequence",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0305",
                column: "Sequence",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0306",
                column: "Sequence",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0307",
                column: "Sequence",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0308",
                column: "Sequence",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0309",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03247",
                column: "Sequence",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03248",
                column: "Sequence",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03249",
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03250",
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03251",
                columns: ["Conformance", "Heading", "Sequence"],
                values: ["Mandatory", "Note", 5]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03252",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03253",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03254",
                column: "Sequence",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03255",
                column: "Sequence",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03256",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03257",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03258",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03259",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03260",
                column: "Sequence",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03261",
                column: "Sequence",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03262",
                column: "Sequence",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03263",
                column: "Sequence",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03264",
                column: "Sequence",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03265",
                column: "Sequence",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03266",
                column: "Sequence",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03271",
                column: "Sequence",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03273",
                column: "Sequence",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03274",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03275",
                column: "Sequence",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03276",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03277",
                column: "Sequence",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03278",
                column: "Sequence",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03279",
                column: "Sequence",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03280",
                column: "Sequence",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03281",
                column: "Sequence",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03282",
                column: "Sequence",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0001",
                columns: ["Heading", "Sequence"],
                values: ["Note", 6]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0002",
                columns: ["Heading", "Sequence"],
                values: ["Note", 9]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0003",
                columns: ["Heading", "Sequence"],
                values: ["Note", 1]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0004",
                columns: ["Heading", "Sequence"],
                values: ["Note", 11]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0005",
                columns: ["Heading", "Sequence"],
                values: ["Note", 4]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0109",
                column: "Heading",
                value: "n/a");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0182",
                column: "Heading",
                value: " 8a");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0220",
                columns: ["Heading", "QuestionText", "QuestionType"],
                values: ["4", "University name ", "Label"]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0221",
                column: "QuestionText",
                value: "Course name ");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0223",
                column: "Heading",
                value: "n/a");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA0230",
                column: "Heading",
                value: "n/a");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQA03251",
                columns: ["Conformance", "Heading"],
                values: ["n/a", "n/a"]);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0001",
                column: "Heading",
                value: "n/a");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0002",
                column: "Heading",
                value: "n/a");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0003",
                column: "Heading",
                value: "n/a");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0004",
                column: "Heading",
                value: "n/a");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: "IQG0005",
                column: "Heading",
                value: "n/a");
        }
    }
}
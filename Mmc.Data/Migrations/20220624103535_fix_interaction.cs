using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class fix_interaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$pK6lNaZCcum9ZF1wjbo7W.XXzb3utK2xrlHp7HaIGdhUToMVoFqjy");

            migrationBuilder.UpdateData(
                table: "user_picture",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 24, 16, 20, 34, 274, DateTimeKind.Local).AddTicks(9346));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$r5Ze3T5TXpkJE9jd/9Ulre5pm/ylNYAmAWJQE5u7Pw9wtpzVUyr.e");

            migrationBuilder.UpdateData(
                table: "user_picture",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 24, 16, 16, 38, 583, DateTimeKind.Local).AddTicks(8172));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class fixedInteraction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "old_value",
                table: "interaction_log",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "location", "uploaded_date" },
                values: new object[] { "/Assets/Account/Profiles/SuperAdmin.jpg", new DateTime(2022, 6, 24, 16, 16, 38, 583, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.CreateIndex(
                name: "IX_interaction_log_user_id",
                table: "interaction_log",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_interaction_log_user_user_id",
                table: "interaction_log",
                column: "user_id",
                principalTable: "user",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_interaction_log_user_user_id",
                table: "interaction_log");

            migrationBuilder.DropIndex(
                name: "IX_interaction_log_user_id",
                table: "interaction_log");

            migrationBuilder.UpdateData(
                table: "interaction_log",
                keyColumn: "old_value",
                keyValue: null,
                column: "old_value",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "old_value",
                table: "interaction_log",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$zjmIEd0kY24L0e4NHLV94u7p7J7LcD.dLTQepKY6Y7NkalbNW5pR6");

            migrationBuilder.UpdateData(
                table: "user_picture",
                keyColumn: "picture_id",
                keyValue: 1L,
                columns: new[] { "location", "uploaded_date" },
                values: new object[] { "/Assets/Account/Profile/SuperAdmin.jpg", new DateTime(2022, 6, 24, 9, 56, 44, 296, DateTimeKind.Local).AddTicks(5713) });
        }
    }
}

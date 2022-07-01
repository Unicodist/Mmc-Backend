using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class NullableUserinnotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_notification_user_user_id",
                table: "notification");

            migrationBuilder.AlterColumn<long>(
                name: "user_id",
                table: "notification",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 2L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 3L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 4L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 5L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 6L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 7L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 8L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 9L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 10L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 11L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 12L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 13L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 14L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 15L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 16L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 17, 55, 219, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$s5fdypG0naeU0Er6TCaZ4.K2XWEXWy8ITItVZB5Y7C5xn8Yf.GECm");

            migrationBuilder.AddForeignKey(
                name: "FK_notification_user_user_id",
                table: "notification",
                column: "user_id",
                principalTable: "user",
                principalColumn: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_notification_user_user_id",
                table: "notification");

            migrationBuilder.AlterColumn<long>(
                name: "user_id",
                table: "notification",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 2L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 3L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 4L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 5L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 6L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 7L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 8L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 9L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 10L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 11L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 12L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 13L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 14L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 15L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 16L,
                column: "uploaded_date",
                value: new DateTime(2022, 7, 1, 8, 11, 17, 807, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$piKZ4IgkeEiR7h6Mn2dVI.7BBu0jz5BxufeHUpReReFAHBxf6LXwe");

            migrationBuilder.AddForeignKey(
                name: "FK_notification_user_user_id",
                table: "notification",
                column: "user_id",
                principalTable: "user",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

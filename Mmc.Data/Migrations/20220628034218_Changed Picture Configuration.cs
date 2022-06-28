using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class ChangedPictureConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_user_UserModelId",
                table: "images");

            migrationBuilder.DropIndex(
                name: "IX_images_UserModelId",
                table: "images");

            migrationBuilder.DropColumn(
                name: "IsProfilePicture",
                table: "images");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "images");

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                columns: new[] { "type", "uploaded_date" },
                values: new object[] { "Profile", new DateTime(2022, 6, 28, 9, 27, 17, 361, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$iHervb9/1Fs5AQLY6j2TgOQ4fgEW/hRDD7jNbDMtwa49kjYO57ewe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsProfilePicture",
                table: "images",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UserModelId",
                table: "images",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                columns: new[] { "type", "uploaded_date" },
                values: new object[] { "Avatar", new DateTime(2022, 6, 28, 9, 12, 29, 214, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$3s1GIt2NsybyACjZFzvWd.nC42doIlThtc3cMvbWuhNA7jOWMw92G");

            migrationBuilder.CreateIndex(
                name: "IX_images_UserModelId",
                table: "images",
                column: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_images_user_UserModelId",
                table: "images",
                column: "UserModelId",
                principalTable: "user",
                principalColumn: "user_id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class AddedUserInPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "severity",
                table: "notice",
                type: "varchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "user_id",
                table: "images",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                columns: new[] { "user_id", "uploaded_date" },
                values: new object[] { 1L, new DateTime(2022, 6, 26, 8, 14, 55, 225, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$1Z.ydu1YCH8mh0DUWGS33uADexoZf72nPzQOUbxK8SLH6f.WtArwG");

            migrationBuilder.CreateIndex(
                name: "IX_images_user_id",
                table: "images",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_images_user_user_id",
                table: "images",
                column: "user_id",
                principalTable: "user",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_user_user_id",
                table: "images");

            migrationBuilder.DropIndex(
                name: "IX_images_user_id",
                table: "images");

            migrationBuilder.DropColumn(
                name: "severity",
                table: "notice");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "images");

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 25, 9, 10, 28, 64, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$HGDX1lRv8uqKa5Xp1bFz5OzMRsrfnCACm4DtUJ2SM7A0eOc.jIlaO");
        }
    }
}

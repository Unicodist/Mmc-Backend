using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class Fixedupvoteconfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_upvote_blog_posts_ArticleModelId",
                table: "upvote");

            migrationBuilder.DropIndex(
                name: "IX_upvote_ArticleModelId",
                table: "upvote");

            migrationBuilder.DropColumn(
                name: "ArticleModelId",
                table: "upvote");

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 26, 13, 1, 1, 365, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$XPbMDvfOb..TVr7HaM6/ru4oivPPVDVHcfOkENuv8VGP3YFmPnw4S");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ArticleModelId",
                table: "upvote",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 26, 8, 14, 55, 225, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$1Z.ydu1YCH8mh0DUWGS33uADexoZf72nPzQOUbxK8SLH6f.WtArwG");

            migrationBuilder.CreateIndex(
                name: "IX_upvote_ArticleModelId",
                table: "upvote",
                column: "ArticleModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_upvote_blog_posts_ArticleModelId",
                table: "upvote",
                column: "ArticleModelId",
                principalTable: "blog_posts",
                principalColumn: "blog_id");
        }
    }
}

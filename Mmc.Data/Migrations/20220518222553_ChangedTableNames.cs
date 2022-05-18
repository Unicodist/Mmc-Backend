using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class ChangedTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blog_master_User_Master_AdminId",
                table: "blog_master");

            migrationBuilder.DropForeignKey(
                name: "FK_notice_master_User_Master_NoticeMasterAuthorId",
                table: "notice_master");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Master",
                table: "User_Master");

            migrationBuilder.DropPrimaryKey(
                name: "PK_notice_master",
                table: "notice_master");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blog_master",
                table: "blog_master");

            migrationBuilder.RenameTable(
                name: "User_Master",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "notice_master",
                newName: "notice");

            migrationBuilder.RenameTable(
                name: "blog_master",
                newName: "blog_posts");

            migrationBuilder.RenameIndex(
                name: "IX_notice_master_NoticeMasterAuthorId",
                table: "notice",
                newName: "IX_notice_NoticeMasterAuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_blog_master_AdminId",
                table: "blog_posts",
                newName: "IX_blog_posts_AdminId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "notice",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 19, 4, 10, 53, 846, DateTimeKind.Local).AddTicks(8762),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 19, 4, 5, 10, 47, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedDate",
                table: "blog_posts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 19, 4, 10, 53, 846, DateTimeKind.Local).AddTicks(5462),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 19, 4, 5, 10, 47, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_notice",
                table: "notice",
                column: "NoticeMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blog_posts",
                table: "blog_posts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_blog_posts_user_AdminId",
                table: "blog_posts",
                column: "AdminId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_notice_user_NoticeMasterAuthorId",
                table: "notice",
                column: "NoticeMasterAuthorId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blog_posts_user_AdminId",
                table: "blog_posts");

            migrationBuilder.DropForeignKey(
                name: "FK_notice_user_NoticeMasterAuthorId",
                table: "notice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_notice",
                table: "notice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blog_posts",
                table: "blog_posts");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "User_Master");

            migrationBuilder.RenameTable(
                name: "notice",
                newName: "notice_master");

            migrationBuilder.RenameTable(
                name: "blog_posts",
                newName: "blog_master");

            migrationBuilder.RenameIndex(
                name: "IX_notice_NoticeMasterAuthorId",
                table: "notice_master",
                newName: "IX_notice_master_NoticeMasterAuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_blog_posts_AdminId",
                table: "blog_master",
                newName: "IX_blog_master_AdminId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "notice_master",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 19, 4, 5, 10, 47, DateTimeKind.Local).AddTicks(6969),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 19, 4, 10, 53, 846, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedDate",
                table: "blog_master",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 19, 4, 5, 10, 47, DateTimeKind.Local).AddTicks(3976),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 19, 4, 10, 53, 846, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Master",
                table: "User_Master",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_notice_master",
                table: "notice_master",
                column: "NoticeMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blog_master",
                table: "blog_master",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_blog_master_User_Master_AdminId",
                table: "blog_master",
                column: "AdminId",
                principalTable: "User_Master",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_notice_master_User_Master_NoticeMasterAuthorId",
                table: "notice_master",
                column: "NoticeMasterAuthorId",
                principalTable: "User_Master",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

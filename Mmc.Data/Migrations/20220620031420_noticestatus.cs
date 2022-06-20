using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class noticestatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_comment_parent_id",
                table: "comment");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "notice",
                type: "varchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "parent_id",
                table: "comment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "blog_posts",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldMaxLength: 40)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$yjoqvvZUVh1Q3i2XIoQPI.R7ULSsitOWZwa.jNA/keCqWQ/cNWBPa");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_comment_parent_id",
                table: "comment",
                column: "parent_id",
                principalTable: "comment",
                principalColumn: "comment_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_comment_parent_id",
                table: "comment");

            migrationBuilder.DropColumn(
                name: "status",
                table: "notice");

            migrationBuilder.AlterColumn<long>(
                name: "parent_id",
                table: "comment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "blog_posts",
                type: "varchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$3wgYemx/QAvSA/ep8zEj3OtRpRWUDxalggtE9Y5NQBKQzdKZahNd2");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_comment_parent_id",
                table: "comment",
                column: "parent_id",
                principalTable: "comment",
                principalColumn: "comment_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class RemovedCommentNesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_comment_parent_id",
                table: "comment");

            migrationBuilder.DropIndex(
                name: "IX_comment_parent_id",
                table: "comment");

            migrationBuilder.DropColumn(
                name: "parent_id",
                table: "comment");

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$ksB3zSkRHGXRJ196bJ0hXu3o.GIhbWOiQcwUQppd3rqjRsr14Uqi.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "parent_id",
                table: "comment",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$yjoqvvZUVh1Q3i2XIoQPI.R7ULSsitOWZwa.jNA/keCqWQ/cNWBPa");

            migrationBuilder.CreateIndex(
                name: "IX_comment_parent_id",
                table: "comment",
                column: "parent_id");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_comment_parent_id",
                table: "comment",
                column: "parent_id",
                principalTable: "comment",
                principalColumn: "comment_id");
        }
    }
}

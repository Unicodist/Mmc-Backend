using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class Toxiccommentmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "toxic_comment",
                columns: table => new
                {
                    toxic_comment_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    comment_id = table.Column<long>(type: "bigint", nullable: false),
                    status = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toxic_comment", x => x.toxic_comment_id);
                    table.ForeignKey(
                        name: "FK_toxic_comment_comment_comment_id",
                        column: x => x.comment_id,
                        principalTable: "comment",
                        principalColumn: "comment_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 26, 13, 37, 30, 939, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$NpbZc7eyoCrU0cVLr2eaNuTWllFomf5gezUFiIDQOZEdQ3YcupPwi");

            migrationBuilder.CreateIndex(
                name: "IX_toxic_comment_comment_id",
                table: "toxic_comment",
                column: "comment_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "toxic_comment");

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
    }
}

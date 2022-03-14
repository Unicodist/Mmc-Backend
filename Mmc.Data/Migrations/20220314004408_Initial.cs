using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User_Master",
                columns: table => new
                {
                    user_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_credentials = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Master", x => x.user_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "blog_master",
                columns: table => new
                {
                    blog_master_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    blog_master_title = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    blog_master_author_id = table.Column<long>(type: "bigint", nullable: false),
                    blog_master_body = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    blog_master_posted_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    blog_master_author_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blog_master", x => x.blog_master_id);
                    table.ForeignKey(
                        name: "FK_blog_master_User_Master_blog_master_author_id",
                        column: x => x.blog_master_author_id,
                        principalTable: "User_Master",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "notice_master",
                columns: table => new
                {
                    notice_master_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    notice_master_title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    notice_master_body = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    notice_master_picture = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NoticeMasterAuthorUserMasterId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notice_master", x => x.notice_master_id);
                    table.ForeignKey(
                        name: "FK_notice_master_User_Master_NoticeMasterAuthorUserMasterId",
                        column: x => x.NoticeMasterAuthorUserMasterId,
                        principalTable: "User_Master",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User_Credentials",
                columns: table => new
                {
                    user_credentials_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_credentials_email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_credentials_password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserCredentialsUserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Credentials", x => x.user_credentials_id);
                    table.ForeignKey(
                        name: "FK_User_Credentials_User_Master_UserCredentialsUserId",
                        column: x => x.UserCredentialsUserId,
                        principalTable: "User_Master",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_blog_master_blog_master_author_id",
                table: "blog_master",
                column: "blog_master_author_id");

            migrationBuilder.CreateIndex(
                name: "IX_notice_master_NoticeMasterAuthorUserMasterId",
                table: "notice_master",
                column: "NoticeMasterAuthorUserMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Credentials_UserCredentialsUserId",
                table: "User_Credentials",
                column: "UserCredentialsUserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blog_master");

            migrationBuilder.DropTable(
                name: "notice_master");

            migrationBuilder.DropTable(
                name: "User_Credentials");

            migrationBuilder.DropTable(
                name: "User_Master");
        }
    }
}

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
                    BlogMasterId = table.Column<int>(type: "INT(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BlogMasterTitle = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogMasterAuthorAdminId = table.Column<int>(type: "INT(11)", nullable: false),
                    BlogMasterBody = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogMasterPostedDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    BlogMasterAuthorName = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogMasterAuthorAdminUserMasterId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blog_master", x => x.BlogMasterId);
                    table.ForeignKey(
                        name: "FK_blog_master_User_Master_BlogMasterAuthorAdminUserMasterId",
                        column: x => x.BlogMasterAuthorAdminUserMasterId,
                        principalTable: "User_Master",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User_Credentials",
                columns: table => new
                {
                    UserCredentialsId = table.Column<int>(type: "INT(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserCredentialsEmail = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserCredentialsPassword = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserCredentialsUserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Credentials", x => x.UserCredentialsId);
                    table.ForeignKey(
                        name: "FK_User_Credentials_User_Master_UserCredentialsUserId",
                        column: x => x.UserCredentialsUserId,
                        principalTable: "User_Master",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_blog_master_BlogMasterAuthorAdminUserMasterId",
                table: "blog_master",
                column: "BlogMasterAuthorAdminUserMasterId");

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
                name: "User_Credentials");

            migrationBuilder.DropTable(
                name: "User_Master");
        }
    }
}

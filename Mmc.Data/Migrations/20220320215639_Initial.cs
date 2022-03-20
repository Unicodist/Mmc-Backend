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
                    UserMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserMasterName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserMasterCredentialId = table.Column<int>(type: "int", nullable: false),
                    UserType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Master", x => x.UserMasterId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "blog_master",
                columns: table => new
                {
                    BlogMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BlogMasterTitle = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogMasterAuthorAdminId = table.Column<long>(type: "bigint", nullable: false),
                    BlogMasterBody = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogMasterPostedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2022, 3, 21, 3, 41, 39, 243, DateTimeKind.Local).AddTicks(1684)),
                    BlogMasterAuthorName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogMasterEntityAuthorAdminUserMasterId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blog_master", x => x.BlogMasterId);
                    table.ForeignKey(
                        name: "FK_blog_master_User_Master_BlogMasterEntityAuthorAdminUserMaste~",
                        column: x => x.BlogMasterEntityAuthorAdminUserMasterId,
                        principalTable: "User_Master",
                        principalColumn: "UserMasterId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "notice_master",
                columns: table => new
                {
                    NoticeMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NoticeMasterTitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NoticeMasterBody = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2022, 3, 21, 3, 41, 39, 243, DateTimeKind.Local).AddTicks(3578)),
                    NoticeMasterNoticePicture = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NoticeMasterAuthorId = table.Column<long>(type: "bigint", nullable: false),
                    NoticeMasterEntityAuthorUserMasterId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notice_master", x => x.NoticeMasterId);
                    table.ForeignKey(
                        name: "FK_notice_master_User_Master_NoticeMasterEntityAuthorUserMaster~",
                        column: x => x.NoticeMasterEntityAuthorUserMasterId,
                        principalTable: "User_Master",
                        principalColumn: "UserMasterId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_blog_master_BlogMasterEntityAuthorAdminUserMasterId",
                table: "blog_master",
                column: "BlogMasterEntityAuthorAdminUserMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_notice_master_NoticeMasterEntityAuthorUserMasterId",
                table: "notice_master",
                column: "NoticeMasterEntityAuthorUserMasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blog_master");

            migrationBuilder.DropTable(
                name: "notice_master");

            migrationBuilder.DropTable(
                name: "User_Master");
        }
    }
}

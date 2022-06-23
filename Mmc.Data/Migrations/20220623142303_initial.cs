using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    category_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.category_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    country_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_code = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    abr = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.country_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "keyValue",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", maxLength: 50, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    key = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    value = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    group = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keyValue", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "notification_template",
                columns: table => new
                {
                    notificatoin_template_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    body = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notification_template", x => x.notificatoin_template_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user_picture",
                columns: table => new
                {
                    picture_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    guid = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    location = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    uploaded_date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_picture", x => x.picture_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    state_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country_id = table.Column<long>(type: "bigint", nullable: false),
                    description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.state_id);
                    table.ForeignKey(
                        name: "FK_state_country_country_id",
                        column: x => x.country_id,
                        principalTable: "country",
                        principalColumn: "country_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    user_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    picture_id = table.Column<long>(type: "bigint", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_user_user_picture_picture_id",
                        column: x => x.picture_id,
                        principalTable: "user_picture",
                        principalColumn: "picture_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vdc",
                columns: table => new
                {
                    vdc_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vdc", x => x.vdc_id);
                    table.ForeignKey(
                        name: "FK_vdc_state_state_id",
                        column: x => x.state_id,
                        principalTable: "state",
                        principalColumn: "state_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "blog_posts",
                columns: table => new
                {
                    blog_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    posted_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    thumbnail = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    admin_id = table.Column<long>(type: "bigint", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    posted_date = table.Column<DateOnly>(type: "date", nullable: false),
                    category_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blog_posts", x => x.blog_id);
                    table.ForeignKey(
                        name: "FK_blog_posts_category_category_id",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_blog_posts_user_admin_id",
                        column: x => x.admin_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "category_subscription",
                columns: table => new
                {
                    category_id = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_subscription", x => x.category_id);
                    table.ForeignKey(
                        name: "FK_category_subscription_category_category_id",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_category_subscription_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "notice",
                columns: table => new
                {
                    notice_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    body = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    picture = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    admin_id = table.Column<long>(type: "bigint", nullable: false),
                    guid = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notice", x => x.notice_id);
                    table.ForeignKey(
                        name: "FK_notice_user_admin_id",
                        column: x => x.admin_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "notification",
                columns: table => new
                {
                    notification_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    time = table.Column<TimeOnly>(type: "time", nullable: false),
                    template_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notification", x => x.notification_id);
                    table.ForeignKey(
                        name: "FK_notification_notification_template_template_id",
                        column: x => x.template_id,
                        principalTable: "notification_template",
                        principalColumn: "notificatoin_template_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_notification_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "comment",
                columns: table => new
                {
                    comment_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    body = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    article_id = table.Column<long>(type: "bigint", nullable: false),
                    status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comment", x => x.comment_id);
                    table.ForeignKey(
                        name: "FK_comment_blog_posts_article_id",
                        column: x => x.article_id,
                        principalTable: "blog_posts",
                        principalColumn: "blog_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comment_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "upvote",
                columns: table => new
                {
                    upvoteId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    blog_id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_upvote", x => x.upvoteId);
                    table.ForeignKey(
                        name: "FK_upvote_blog_posts_blog_id",
                        column: x => x.blog_id,
                        principalTable: "blog_posts",
                        principalColumn: "blog_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_upvote_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "interaction_log",
                columns: table => new
                {
                    log_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    old_value = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    new_value = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    action = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    article_id = table.Column<long>(type: "bigint", nullable: true),
                    comment_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interaction_log", x => x.log_id);
                    table.ForeignKey(
                        name: "FK_interaction_log_blog_posts_article_id",
                        column: x => x.article_id,
                        principalTable: "blog_posts",
                        principalColumn: "blog_id");
                    table.ForeignKey(
                        name: "FK_interaction_log_comment_comment_id",
                        column: x => x.comment_id,
                        principalTable: "comment",
                        principalColumn: "comment_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "user_picture",
                columns: new[] { "picture_id", "guid", "location", "type", "uploaded_date" },
                values: new object[] { 1L, "GodGuid", "Images/SuperAdmin", "Avatar", new DateTime(2022, 6, 23, 20, 8, 2, 618, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "user_id", "email", "name", "password", "picture_id", "user_name", "user_type" },
                values: new object[] { 1L, "ashishneupane999@gmail.com", "Ashish Neupane", "$2a$11$ltXtvb3r3mDUrR1Rfc/cgeP3zXt4E8uNxrmTArAVo4Xxa9qdYSkdW", 1L, "AshuraNep", "Superuser" });

            migrationBuilder.CreateIndex(
                name: "IX_blog_posts_admin_id",
                table: "blog_posts",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_blog_posts_category_id",
                table: "blog_posts",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_category_subscription_user_id",
                table: "category_subscription",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_comment_article_id",
                table: "comment",
                column: "article_id");

            migrationBuilder.CreateIndex(
                name: "IX_comment_user_id",
                table: "comment",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_interaction_log_article_id",
                table: "interaction_log",
                column: "article_id");

            migrationBuilder.CreateIndex(
                name: "IX_interaction_log_comment_id",
                table: "interaction_log",
                column: "comment_id");

            migrationBuilder.CreateIndex(
                name: "IX_notice_admin_id",
                table: "notice",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_notification_template_id",
                table: "notification",
                column: "template_id");

            migrationBuilder.CreateIndex(
                name: "IX_notification_user_id",
                table: "notification",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_state_country_id",
                table: "state",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_upvote_blog_id",
                table: "upvote",
                column: "blog_id");

            migrationBuilder.CreateIndex(
                name: "IX_upvote_user_id",
                table: "upvote",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_picture_id",
                table: "user",
                column: "picture_id");

            migrationBuilder.CreateIndex(
                name: "IX_vdc_state_id",
                table: "vdc",
                column: "state_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "category_subscription");

            migrationBuilder.DropTable(
                name: "interaction_log");

            migrationBuilder.DropTable(
                name: "keyValue");

            migrationBuilder.DropTable(
                name: "notice");

            migrationBuilder.DropTable(
                name: "notification");

            migrationBuilder.DropTable(
                name: "upvote");

            migrationBuilder.DropTable(
                name: "vdc");

            migrationBuilder.DropTable(
                name: "comment");

            migrationBuilder.DropTable(
                name: "notification_template");

            migrationBuilder.DropTable(
                name: "state");

            migrationBuilder.DropTable(
                name: "blog_posts");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "user_picture");
        }
    }
}

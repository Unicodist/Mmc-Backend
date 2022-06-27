using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class AddedEnrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "student_enrollment_detail",
                columns: table => new
                {
                    enrollment_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    guid = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_id = table.Column<long>(type: "bigint", nullable: false),
                    semester = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    status = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student_enrollment_detail", x => x.enrollment_id);
                    table.ForeignKey(
                        name: "FK_student_enrollment_detail_course_course_id",
                        column: x => x.course_id,
                        principalTable: "course",
                        principalColumn: "course_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_student_enrollment_detail_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 27, 20, 52, 24, 805, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$w/9lIpzN6gMDihwjZbQ5seJayOmRxPC1dJV1un0DeC3r3f1TpPihW");

            migrationBuilder.CreateIndex(
                name: "IX_student_enrollment_detail_course_id",
                table: "student_enrollment_detail",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_student_enrollment_detail_user_id",
                table: "student_enrollment_detail",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "student_enrollment_detail");

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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class IterationI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "notice_master",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 23, 15, 13, 44, DateTimeKind.Local).AddTicks(4335),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 3, 22, 9, 7, 7, 416, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogMasterPostedDate",
                table: "blog_master",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 23, 15, 13, 44, DateTimeKind.Local).AddTicks(866),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 3, 22, 9, 7, 7, 415, DateTimeKind.Local).AddTicks(6112));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "notice_master",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 9, 7, 7, 416, DateTimeKind.Local).AddTicks(1595),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 3, 26, 23, 15, 13, 44, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogMasterPostedDate",
                table: "blog_master",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 9, 7, 7, 415, DateTimeKind.Local).AddTicks(6112),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 3, 26, 23, 15, 13, 44, DateTimeKind.Local).AddTicks(866));
        }
    }
}

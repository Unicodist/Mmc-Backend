using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class BetterAddressModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 27, 21, 26, 20, 354, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$H5vh/2Nfva/28RLrrg3MpehSGPbKBDVU1SojREDqD9K2Y/Kurdlmq");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

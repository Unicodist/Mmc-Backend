using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class Ondeleterestrictuserorganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_OrganizationModel_organization_id",
                table: "user");

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 28, 8, 51, 14, 29, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$SxaLWe2PKgZntTzzQ5rljexTfpEHexJZ.Je0wkwnKk/3WXln/pyOS");

            migrationBuilder.AddForeignKey(
                name: "FK_user_OrganizationModel_organization_id",
                table: "user",
                column: "organization_id",
                principalTable: "OrganizationModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_OrganizationModel_organization_id",
                table: "user");

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 28, 8, 49, 47, 226, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$MbpjtGLcAHdcbvT.9uF2V.LH4pGJs6.Vt5dEhBPMQ54ac1D6h4c7C");

            migrationBuilder.AddForeignKey(
                name: "FK_user_OrganizationModel_organization_id",
                table: "user",
                column: "organization_id",
                principalTable: "OrganizationModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

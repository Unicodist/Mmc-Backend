using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mmc.Data.Migrations
{
    public partial class AddedPictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "picture_id", "guid", "location", "type", "uploaded_date" },
                values: new object[,]
                {
                    { 2L, "Avatar1", "/Assets/Account/Profiles/Avatar1.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8068) },
                    { 3L, "Avatar2", "/Assets/Account/Profiles/Avatar2.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8069) },
                    { 4L, "Avatar3", "/Assets/Account/Profiles/Avatar3.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8070) },
                    { 5L, "Avatar4", "/Assets/Account/Profiles/Avatar4.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8071) },
                    { 6L, "Avatar5", "/Assets/Account/Profiles/Avatar5.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8073) },
                    { 7L, "Avatar6", "/Assets/Account/Profiles/Avatar6.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8074) },
                    { 8L, "Avatar7", "/Assets/Account/Profiles/Avatar7.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8075) },
                    { 9L, "Avatar8", "/Assets/Account/Profiles/Avatar8.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8075) },
                    { 10L, "Avatar9", "/Assets/Account/Profiles/Avatar9.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8077) },
                    { 11L, "Avatar10", "/Assets/Account/Profiles/Avatar10.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8078) },
                    { 12L, "Avatar11", "/Assets/Account/Profiles/Avatar11.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8079) },
                    { 13L, "Avatar12", "/Assets/Account/Profiles/Avatar12.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8080) },
                    { 14L, "Avatar13", "/Assets/Account/Profiles/Avatar13.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8081) },
                    { 15L, "Avatar14", "/Assets/Account/Profiles/Avatar14.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8082) },
                    { 16L, "Avatar15", "/Assets/Account/Profiles/Avatar15.jpg", "Avatar", new DateTime(2022, 6, 30, 9, 46, 47, 963, DateTimeKind.Local).AddTicks(8083) }
                });

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$QXKUsOGdVZ0EREbLsbsOj.8qzMpq3Dx5kaqfTsF204vU7sru2Enry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 16L);

            migrationBuilder.UpdateData(
                table: "images",
                keyColumn: "picture_id",
                keyValue: 1L,
                column: "uploaded_date",
                value: new DateTime(2022, 6, 29, 19, 44, 3, 622, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "user_id",
                keyValue: 1L,
                column: "password",
                value: "$2a$11$Is2GOSFOEszizydEt4TLGOvnXK3WJRHXQ9vcY77Ho35qdDsW.ZsJW");
        }
    }
}

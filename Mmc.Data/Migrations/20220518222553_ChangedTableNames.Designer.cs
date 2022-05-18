﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmc.Data;

#nullable disable

namespace Mmc.Data.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20220518222553_ChangedTableNames")]
    partial class ChangedTableNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mmc.Data.Model.Blog.BlogPostModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AdminId")
                        .HasColumnType("bigint");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PostedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2022, 5, 19, 4, 10, 53, 846, DateTimeKind.Local).AddTicks(5462));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("blog_posts", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Notice.NoticeModel", b =>
                {
                    b.Property<long>("NoticeMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("NoticeMasterAuthorId")
                        .HasColumnType("bigint");

                    b.Property<string>("NoticeMasterBody")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NoticeMasterNoticePicture")
                        .HasColumnType("longtext");

                    b.Property<string>("NoticeMasterTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PostedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2022, 5, 19, 4, 10, 53, 846, DateTimeKind.Local).AddTicks(8762));

                    b.HasKey("NoticeMasterId");

                    b.HasIndex("NoticeMasterAuthorId");

                    b.ToTable("notice", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.User.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("user_type");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.BlogPostModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.User.UserModel", "AuthorAdmin")
                        .WithMany("BlogPosts")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuthorAdmin");
                });

            modelBuilder.Entity("Mmc.Data.Model.Notice.NoticeModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.User.UserModel", "NoticeMasterEntityAuthor")
                        .WithMany("Notices")
                        .HasForeignKey("NoticeMasterAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NoticeMasterEntityAuthor");
                });

            modelBuilder.Entity("Mmc.Data.Model.User.UserModel", b =>
                {
                    b.Navigation("BlogPosts");

                    b.Navigation("Notices");
                });
#pragma warning restore 612, 618
        }
    }
}
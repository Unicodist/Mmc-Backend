﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmc.Data;

#nullable disable

namespace Mmc.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mmc.Data.Model.Address.CountryModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("country_id");

                    b.Property<string>("Abr")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("abr");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneCode")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("phone_code");

                    b.HasKey("Id");

                    b.ToTable("country", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Address.StateModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("state_id");

                    b.Property<long>("CountryId")
                        .HasColumnType("bigint")
                        .HasColumnName("country_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("state", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Address.VdcModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("vdc_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<long>("StateId")
                        .HasColumnType("bigint")
                        .HasColumnName("state_id");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("vdc", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.BlogPostModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("blog_id");

                    b.Property<long>("AdminId")
                        .HasColumnType("bigint")
                        .HasColumnName("admin_id");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("PostedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2022, 5, 21, 22, 56, 25, 327, DateTimeKind.Local).AddTicks(1830))
                        .HasColumnName("posted_date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("CategoryId");

                    b.ToTable("blog_posts", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.CategoryModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("category_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Notice.NoticeModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AdminId")
                        .HasColumnType("bigint");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Picture")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PostedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2022, 5, 21, 22, 56, 25, 327, DateTimeKind.Local).AddTicks(7518));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("notice", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.User.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("user_name");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("user_type");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "ashishneupane999@gmail.com",
                            Name = "Ashish Neupane",
                            Password = "$2a$11$bR2IuGJGPljyO0ux5eCdG.Ua8ks4iQ42MhxbCsgzNhsfAzPuF6me6",
                            UserName = "AshuraNep",
                            UserType = "Superuser"
                        });
                });

            modelBuilder.Entity("Mmc.Data.Model.Address.StateModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Address.CountryModel", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Mmc.Data.Model.Address.VdcModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Address.StateModel", "State")
                        .WithMany("Vdcs")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.BlogPostModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.User.UserModel", "AuthorAdmin")
                        .WithMany("BlogPosts")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mmc.Data.Model.Blog.CategoryModel", "Category")
                        .WithMany("BlogPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuthorAdmin");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Mmc.Data.Model.Notice.NoticeModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.User.UserModel", "Author")
                        .WithMany("Notices")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Mmc.Data.Model.Address.CountryModel", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Mmc.Data.Model.Address.StateModel", b =>
                {
                    b.Navigation("Vdcs");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.CategoryModel", b =>
                {
                    b.Navigation("BlogPosts");
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

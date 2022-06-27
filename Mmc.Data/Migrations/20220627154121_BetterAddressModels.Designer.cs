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
    [DbContext(typeof(AppDbContext))]
    [Migration("20220627154121_BetterAddressModels")]
    partial class BetterAddressModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mmc.Core.Entity.KeyVal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("group");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("key");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("keyValue", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Address.CountryModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("country_id");

                    b.Property<string>("Abbreviation")
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

            modelBuilder.Entity("Mmc.Data.Model.Blog.ArticleModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("blog_id");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Body");

                    b.Property<long?>("CategoryId")
                        .HasColumnType("bigint")
                        .HasColumnName("category_id");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("guid");

                    b.Property<DateOnly>("PostedDate")
                        .HasColumnType("date")
                        .HasColumnName("posted_date");

                    b.Property<TimeOnly>("PostedTime")
                        .HasColumnType("time")
                        .HasColumnName("posted_time");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("thumbnail");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("title");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("admin_id");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

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

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("guid");

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

            modelBuilder.Entity("Mmc.Data.Model.Blog.CategorySubscriptionModel", b =>
                {
                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint")
                        .HasColumnName("category_id");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("status");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("category_subscription", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.CommentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("comment_id");

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint")
                        .HasColumnName("article_id");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("body");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("guid");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("status");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("comment", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.HeartModel", b =>
                {
                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint")
                        .HasColumnName("blog_id");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("ArticleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("upvote", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.InteractionLogModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("log_id");

                    b.Property<long?>("ArticleId")
                        .HasColumnType("bigint")
                        .HasColumnName("article_id");

                    b.Property<long?>("CommentId")
                        .HasColumnType("bigint")
                        .HasColumnName("comment_id");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("InteractionType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("type");

                    b.Property<string>("NewValue")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("new_value");

                    b.Property<string>("OldValue")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("old_value");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("interaction_log", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.ToxicCommentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("toxic_comment_id");

                    b.Property<long>("CommentId")
                        .HasColumnType("bigint")
                        .HasColumnName("comment_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("toxic_comment", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Core.CourseModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("course_id");

                    b.Property<long>("FacultyId")
                        .HasColumnType("bigint")
                        .HasColumnName("faculty_id");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("guid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("course", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Core.FacultyModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("faculty_id");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("guid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("faculty", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Core.StudentEnrollmentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("enrollment_id");

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint")
                        .HasColumnName("course_id");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("guid");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("semester");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("status");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("student_enrollment_detail", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.Notice.NoticeModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("notice_id");

                    b.Property<long>("AdminId")
                        .HasColumnType("bigint")
                        .HasColumnName("admin_id");

                    b.Property<string>("Body")
                        .HasColumnType("text")
                        .HasColumnName("body");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("guid");

                    b.Property<string>("Picture")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("picture");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("Severity")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("severity");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("notice", (string)null);
                });

            modelBuilder.Entity("Mmc.Data.Model.PictureModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("picture_id");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("guid");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("location");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("type");

                    b.Property<long>("UploadedById")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.Property<DateTime>("UploadedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("uploaded_date");

                    b.HasKey("Id");

                    b.HasIndex("UploadedById");

                    b.ToTable("images", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Guid = "GodGuid",
                            Location = "/Assets/Account/Profiles/SuperAdmin.jpg",
                            Type = "Avatar",
                            UploadedById = 1L,
                            UploadedDate = new DateTime(2022, 6, 27, 21, 26, 20, 354, DateTimeKind.Local).AddTicks(9473)
                        });
                });

            modelBuilder.Entity("Mmc.Data.Model.User.NotificationModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("notification_id");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("status");

                    b.Property<long>("TemplateId")
                        .HasColumnType("bigint")
                        .HasColumnName("template_id");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time")
                        .HasColumnName("time");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.HasIndex("UserId");

                    b.ToTable("notification", (string)null);
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

                    b.Property<long>("PictureId")
                        .HasMaxLength(50)
                        .HasColumnType("bigint")
                        .HasColumnName("picture_id");

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

                    b.HasIndex("PictureId");

                    b.ToTable("user", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "ashishneupane999@gmail.com",
                            Name = "Ashish Neupane",
                            Password = "$2a$11$H5vh/2Nfva/28RLrrg3MpehSGPbKBDVU1SojREDqD9K2Y/Kurdlmq",
                            PictureId = 1L,
                            UserName = "AshuraNep",
                            UserType = "Superuser"
                        });
                });

            modelBuilder.Entity("Mmc.User.Entity.NotificationTemplate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("notificatoin_template_id");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("body");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("notification_template", (string)null);
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
                    b.HasOne("Mmc.Data.Model.Address.StateModel", "StateModel")
                        .WithMany("Vdcs")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StateModel");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.ArticleModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Blog.CategoryModel", "Category")
                        .WithMany("BlogPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mmc.Data.Model.User.UserModel", "AuthorAdmin")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuthorAdmin");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.CategorySubscriptionModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Blog.CategoryModel", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mmc.Data.Model.User.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.CommentModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Blog.ArticleModel", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mmc.Data.Model.User.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.HeartModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Blog.ArticleModel", "Article")
                        .WithMany("Likes")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mmc.Data.Model.User.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.InteractionLogModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Blog.ArticleModel", "Article")
                        .WithMany("Interactions")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mmc.Data.Model.Blog.CommentModel", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId");

                    b.HasOne("Mmc.Data.Model.User.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.ToxicCommentModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Blog.CommentModel", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("Mmc.Data.Model.Core.CourseModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Core.FacultyModel", "Faculty")
                        .WithMany("Courses")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Mmc.Data.Model.Core.StudentEnrollmentModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.Core.CourseModel", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mmc.Data.Model.User.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mmc.Data.Model.Notice.NoticeModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.User.UserModel", "Author")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Mmc.Data.Model.PictureModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.User.UserModel", "UploadedBy")
                        .WithMany()
                        .HasForeignKey("UploadedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UploadedBy");
                });

            modelBuilder.Entity("Mmc.Data.Model.User.NotificationModel", b =>
                {
                    b.HasOne("Mmc.User.Entity.NotificationTemplate", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mmc.Data.Model.User.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Template");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mmc.Data.Model.User.UserModel", b =>
                {
                    b.HasOne("Mmc.Data.Model.PictureModel", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("Mmc.Data.Model.Address.CountryModel", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Mmc.Data.Model.Address.StateModel", b =>
                {
                    b.Navigation("Vdcs");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.ArticleModel", b =>
                {
                    b.Navigation("Interactions");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("Mmc.Data.Model.Blog.CategoryModel", b =>
                {
                    b.Navigation("BlogPosts");
                });

            modelBuilder.Entity("Mmc.Data.Model.Core.FacultyModel", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}

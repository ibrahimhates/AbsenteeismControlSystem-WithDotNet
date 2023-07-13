﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Layer;

#nullable disable

namespace Repositories.Layer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230614175939_new_mig1")]
    partial class new_mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Layer.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HardDeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Matematik",
                            CreatedDate = new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1749),
                            UserId = 1,
                            isActive = true,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Turkce",
                            CreatedDate = new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1751),
                            UserId = 1,
                            isActive = true,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Entities.Layer.Models.CourseCalendar", b =>
                {
                    b.Property<byte>("DayId")
                        .HasColumnType("tinyint");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<DateTime?>("HardDeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("DayId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseCalendars");

                    b.HasData(
                        new
                        {
                            DayId = (byte)1,
                            CourseId = 1,
                            CreatedDate = new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1399),
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 8, 0, 0, 0),
                            isActive = true,
                            isDeleted = false
                        },
                        new
                        {
                            DayId = (byte)2,
                            CourseId = 2,
                            CreatedDate = new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1413),
                            EndTime = new TimeSpan(0, 11, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0),
                            isActive = true,
                            isDeleted = false
                        },
                        new
                        {
                            DayId = (byte)3,
                            CourseId = 2,
                            CreatedDate = new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1414),
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            isActive = true,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Entities.Layer.Models.CourseDetail", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<byte>("AbsenceLimit")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("CurrentAbsence")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("ExamTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HardDeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("CourseId");

                    b.ToTable("CourseDetails");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            AbsenceLimit = (byte)4,
                            CreatedDate = new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1674),
                            CurrentAbsence = (byte)0,
                            Description = "My favorite course 1",
                            ExamTime = new DateTime(2023, 6, 21, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1653),
                            isActive = true,
                            isDeleted = false
                        },
                        new
                        {
                            CourseId = 2,
                            AbsenceLimit = (byte)4,
                            CreatedDate = new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1676),
                            CurrentAbsence = (byte)1,
                            Description = "My favorite course 2",
                            isActive = true,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Entities.Layer.Models.Day", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Days");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            DayName = "Pazartesi"
                        },
                        new
                        {
                            Id = (byte)2,
                            DayName = "Salı"
                        },
                        new
                        {
                            Id = (byte)3,
                            DayName = "Çarşamba"
                        },
                        new
                        {
                            Id = (byte)4,
                            DayName = "Perşembe"
                        },
                        new
                        {
                            Id = (byte)5,
                            DayName = "Cuma"
                        },
                        new
                        {
                            Id = (byte)6,
                            DayName = "Cumartesi"
                        },
                        new
                        {
                            Id = (byte)7,
                            DayName = "Pazar"
                        });
                });

            modelBuilder.Entity("Entities.Layer.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "99670b3e-368f-4b26-b2a8-df928bcab9dd",
                            CreatedDate = new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1991),
                            Email = "admin1@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin1@GMAIL.COM",
                            NormalizedUserName = "ADMİN1",
                            PasswordHash = "AQAAAAEAACcQAAAAENpxPLpM31AsSVoCHyRg9egjK+58lPlSAJvlIWGExaC8Lv2oU0K/DgzivnE0zp8uhw==",
                            PhoneNumber = "+9053399999991",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "f2cc0580-e68d-45b1-83e1-71ad6d903e21",
                            TwoFactorEnabled = false,
                            UserName = "admin1",
                            isActive = true,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entities.Layer.Models.Course", b =>
                {
                    b.HasOne("Entities.Layer.Models.User", "User")
                        .WithMany("Courses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Layer.Models.CourseCalendar", b =>
                {
                    b.HasOne("Entities.Layer.Models.Course", "Course")
                        .WithMany("CourseCalendars")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Layer.Models.Day", "Day")
                        .WithMany("CourseCalendars")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Day");
                });

            modelBuilder.Entity("Entities.Layer.Models.CourseDetail", b =>
                {
                    b.HasOne("Entities.Layer.Models.Course", "Course")
                        .WithOne("CourseDetail")
                        .HasForeignKey("Entities.Layer.Models.CourseDetail", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Entities.Layer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Entities.Layer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Layer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Entities.Layer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Layer.Models.Course", b =>
                {
                    b.Navigation("CourseCalendars");

                    b.Navigation("CourseDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Layer.Models.Day", b =>
                {
                    b.Navigation("CourseCalendars");
                });

            modelBuilder.Entity("Entities.Layer.Models.User", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
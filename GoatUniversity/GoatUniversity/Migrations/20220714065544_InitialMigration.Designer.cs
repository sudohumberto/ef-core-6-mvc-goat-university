﻿// <auto-generated />
using System;
using GoatUniversity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoatUniversity.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20220714065544_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GoatUniversity.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.ToTable("Course", (string)null);

                    b.HasData(
                        new
                        {
                            CourseID = 1050,
                            Credits = 3,
                            Title = "Chemistry"
                        },
                        new
                        {
                            CourseID = 4022,
                            Credits = 3,
                            Title = "Microeconomics"
                        },
                        new
                        {
                            CourseID = 4041,
                            Credits = 3,
                            Title = "Macroeconomics"
                        },
                        new
                        {
                            CourseID = 1045,
                            Credits = 4,
                            Title = "Calculus"
                        },
                        new
                        {
                            CourseID = 3141,
                            Credits = 4,
                            Title = "Trigonometry"
                        },
                        new
                        {
                            CourseID = 2021,
                            Credits = 3,
                            Title = "Composition"
                        },
                        new
                        {
                            CourseID = 2042,
                            Credits = 4,
                            Title = "Literature"
                        });
                });

            modelBuilder.Entity("GoatUniversity.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentID"), 1L, 1);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollment", (string)null);

                    b.HasData(
                        new
                        {
                            EnrollmentID = 1,
                            CourseID = 1050,
                            Grade = 0,
                            StudentID = 1
                        },
                        new
                        {
                            EnrollmentID = 2,
                            CourseID = 4022,
                            Grade = 2,
                            StudentID = 1
                        },
                        new
                        {
                            EnrollmentID = 3,
                            CourseID = 4041,
                            Grade = 1,
                            StudentID = 1
                        },
                        new
                        {
                            EnrollmentID = 4,
                            CourseID = 1045,
                            Grade = 1,
                            StudentID = 2
                        },
                        new
                        {
                            EnrollmentID = 5,
                            CourseID = 3141,
                            Grade = 4,
                            StudentID = 2
                        },
                        new
                        {
                            EnrollmentID = 6,
                            CourseID = 2021,
                            Grade = 4,
                            StudentID = 2
                        },
                        new
                        {
                            EnrollmentID = 7,
                            CourseID = 1050,
                            StudentID = 3
                        },
                        new
                        {
                            EnrollmentID = 8,
                            CourseID = 1050,
                            StudentID = 4
                        },
                        new
                        {
                            EnrollmentID = 9,
                            CourseID = 4022,
                            Grade = 4,
                            StudentID = 4
                        },
                        new
                        {
                            EnrollmentID = 10,
                            CourseID = 4041,
                            Grade = 2,
                            StudentID = 5
                        },
                        new
                        {
                            EnrollmentID = 11,
                            CourseID = 1045,
                            StudentID = 6
                        },
                        new
                        {
                            EnrollmentID = 12,
                            CourseID = 3141,
                            Grade = 0,
                            StudentID = 7
                        });
                });

            modelBuilder.Entity("GoatUniversity.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Student", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            EnrollmentDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Carson",
                            LastName = "Alexander"
                        },
                        new
                        {
                            ID = 2,
                            EnrollmentDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Meredith",
                            LastName = "Alonso"
                        },
                        new
                        {
                            ID = 3,
                            EnrollmentDate = new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Arturo",
                            LastName = "Anand"
                        },
                        new
                        {
                            ID = 4,
                            EnrollmentDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Gytis",
                            LastName = "Barzdukas"
                        },
                        new
                        {
                            ID = 5,
                            EnrollmentDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Yan",
                            LastName = "Li"
                        },
                        new
                        {
                            ID = 6,
                            EnrollmentDate = new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Peggy",
                            LastName = "Justice"
                        },
                        new
                        {
                            ID = 7,
                            EnrollmentDate = new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Laura",
                            LastName = "Norman"
                        },
                        new
                        {
                            ID = 8,
                            EnrollmentDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Nino",
                            LastName = "Olivetto"
                        });
                });

            modelBuilder.Entity("GoatUniversity.Models.Enrollment", b =>
                {
                    b.HasOne("GoatUniversity.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoatUniversity.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("GoatUniversity.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("GoatUniversity.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}

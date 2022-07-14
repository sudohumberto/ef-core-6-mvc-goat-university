﻿using GoatUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace GoatUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");

            // seed students 
            modelBuilder.Entity<Student>().HasData(new Student { ID = 1, FirstName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01") });
            modelBuilder.Entity<Student>().HasData(new Student { ID = 2, FirstName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2002-09-01") });
            modelBuilder.Entity<Student>().HasData(new Student { ID = 3, FirstName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2003-09-01") });
            modelBuilder.Entity<Student>().HasData(new Student { ID = 4, FirstName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01") });
            modelBuilder.Entity<Student>().HasData(new Student { ID = 5, FirstName = "Yan", LastName = "Li", EnrollmentDate = DateTime.Parse("2002-09-01") });
            modelBuilder.Entity<Student>().HasData(new Student { ID = 6, FirstName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.Parse("2001-09-01") });
            modelBuilder.Entity<Student>().HasData(new Student { ID = 7, FirstName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2003-09-01") });
            modelBuilder.Entity<Student>().HasData(new Student { ID = 8, FirstName = "Nino", LastName = "Olivetto", EnrollmentDate = DateTime.Parse("2005-09-01") });

            // seed courses
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 1050, Title = "Chemistry", Credits = 3 });
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 4022, Title = "Microeconomics", Credits = 3 });
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 4041, Title = "Macroeconomics", Credits = 3 });
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 1045, Title = "Calculus", Credits = 4 });
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 3141, Title = "Trigonometry", Credits = 4 });
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 2021, Title = "Composition", Credits = 3 });
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 2042, Title = "Literature", Credits = 4 });

            // seed enrollments
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 1, StudentID = 1, CourseID = 1050, Grade = Grade.A });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 2, StudentID = 1, CourseID = 4022, Grade = Grade.C });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 3, StudentID = 1, CourseID = 4041, Grade = Grade.B });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 4, StudentID = 2, CourseID = 1045, Grade = Grade.B });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 5, StudentID = 2, CourseID = 3141, Grade = Grade.F });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 6, StudentID = 2, CourseID = 2021, Grade = Grade.F });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 7, StudentID = 3, CourseID = 1050 });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 8, StudentID = 4, CourseID = 1050 });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 9, StudentID = 4, CourseID = 4022, Grade = Grade.F });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 10, StudentID = 5, CourseID = 4041, Grade = Grade.C });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 11, StudentID = 6, CourseID = 1045 });
            modelBuilder.Entity<Enrollment>().HasData(new Enrollment { EnrollmentID = 12, StudentID = 7, CourseID = 3141, Grade = Grade.A });

        }
    }
}

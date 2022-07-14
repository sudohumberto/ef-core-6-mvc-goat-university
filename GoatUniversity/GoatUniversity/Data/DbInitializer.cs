using GoatUniversity.Models;

namespace GoatUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return; // DB has been seeded
            }

            SeedStudents(context);
            SeedInstructors(context);
            SeedDepartments(context);
            SeedCourses(context);
            SeedOfficeAssignments(context);
            SeedCourseAssignment(context);

            SeedEnrollments(context);

        }

        private static void SeedStudents(SchoolContext context)
        {
            var students = new Student[]
            {
                new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }

        private static void SeedInstructors(SchoolContext context)
        {
            var instructors = new Instructor[]
            {
                new Instructor { FirstName = "Kim", LastName = "Abercrombie", HireDate = DateTime.Parse("1995-03-11") },
                new Instructor { FirstName = "Fadi", LastName = "Fakhouri", HireDate = DateTime.Parse("2002-07-06") },
                new Instructor { FirstName = "Roger", LastName = "Harui", HireDate = DateTime.Parse("1998-07-01") },
                new Instructor { FirstName = "Candace", LastName = "Kapoor", HireDate = DateTime.Parse("2001-01-15") },
                new Instructor { FirstName = "Roger", LastName = "Zheng", HireDate = DateTime.Parse("2004-02-12") }
            };

            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }
            context.SaveChanges();
        }

        private static void SeedDepartments(SchoolContext context)
        {
            var departments = new Department[]
            {
                new Department { Name = "English", Budget = 350000, StartDate = DateTime.Parse("2007-09-01"), InstructorID  = context.Instructors.Single( i => i.LastName == "Abercrombie").ID },
                new Department { Name = "Mathematics", Budget = 100000, StartDate = DateTime.Parse("2007-09-01"), InstructorID  = context.Instructors.Single( i => i.LastName == "Fakhouri").ID },
                new Department { Name = "Engineering", Budget = 350000, StartDate = DateTime.Parse("2007-09-01"), InstructorID  = context.Instructors.Single( i => i.LastName == "Harui").ID },
                new Department { Name = "Economics",   Budget = 100000, StartDate = DateTime.Parse("2007-09-01"), InstructorID  = context.Instructors.Single( i => i.LastName == "Kapoor").ID }
            };

            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();
        }

        private static void SeedCourses(SchoolContext context)
        {
            var courses = new Course[]
            {
                new Course {CourseID = 1050, Title = "Chemistry", Credits = 3, DepartmentID = context.Departments.Single( s => s.Name == "Engineering").DepartmentID},
                new Course {CourseID = 4022, Title = "Microeconomics", Credits = 3, DepartmentID = context.Departments.Single( s => s.Name == "Economics").DepartmentID},
                new Course {CourseID = 4041, Title = "Macroeconomics", Credits = 3, DepartmentID = context.Departments.Single( s => s.Name == "Economics").DepartmentID},
                new Course {CourseID = 1045, Title = "Calculus", Credits = 4, DepartmentID = context.Departments.Single( s => s.Name == "Mathematics").DepartmentID},
                new Course {CourseID = 3141, Title = "Trigonometry", Credits = 4, DepartmentID = context.Departments.Single( s => s.Name == "Mathematics").DepartmentID},
                new Course {CourseID = 2021, Title = "Composition", Credits = 3, DepartmentID = context.Departments.Single( s => s.Name == "English").DepartmentID},
                new Course {CourseID = 2042, Title = "Literature", Credits = 4, DepartmentID = context.Departments.Single( s => s.Name == "English").DepartmentID},
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();
        }

        private static void SeedOfficeAssignments(SchoolContext context)
        {
            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {InstructorID = context.Instructors.Single( i => i.LastName == "Fakhouri").ID, Location = "Smith 17" },
                new OfficeAssignment {InstructorID = context.Instructors.Single( i => i.LastName == "Harui").ID, Location = "Gowan 27" },
                new OfficeAssignment {InstructorID = context.Instructors.Single( i => i.LastName == "Kapoor").ID, Location = "Thompson 304" },
            };

            foreach (OfficeAssignment o in officeAssignments)
            {
                context.OfficeAssignments.Add(o);
            }
            context.SaveChanges();
        }

        private static void SeedCourseAssignment(SchoolContext context)
        {
            var courseInstructors = new CourseAssignment[]
            {
                new CourseAssignment {CourseID = context.Courses.Single(c => c.Title == "Chemistry" ).CourseID, InstructorID = context.Instructors.Single(i => i.LastName == "Kapoor").ID},
                new CourseAssignment {CourseID = context.Courses.Single(c => c.Title == "Chemistry" ).CourseID, InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID},
                new CourseAssignment {CourseID = context.Courses.Single(c => c.Title == "Microeconomics" ).CourseID, InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").ID},
                new CourseAssignment {CourseID = context.Courses.Single(c => c.Title == "Macroeconomics" ).CourseID, InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").ID},
                new CourseAssignment {CourseID = context.Courses.Single(c => c.Title == "Calculus" ).CourseID, InstructorID = context.Instructors.Single(i => i.LastName == "Fakhouri").ID},
                new CourseAssignment {CourseID = context.Courses.Single(c => c.Title == "Trigonometry" ).CourseID, InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID},
                new CourseAssignment {CourseID = context.Courses.Single(c => c.Title == "Composition" ).CourseID, InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").ID},
                new CourseAssignment {CourseID = context.Courses.Single(c => c.Title == "Literature" ).CourseID, InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").ID},
            };

            foreach (CourseAssignment ci in courseInstructors)
            {
                context.CourseAssignments.Add(ci);
            }
            context.SaveChanges();
        }

        private static void SeedEnrollments(SchoolContext context)
        {
            var enrollments = new Enrollment[]
            {
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Alexander").ID, CourseID = context.Courses.Single(c => c.Title == "Chemistry" ).CourseID, Grade = Grade.A},
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Alexander").ID, CourseID = context.Courses.Single(c => c.Title == "Microeconomics" ).CourseID, Grade = Grade.C},
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Alexander").ID, CourseID = context.Courses.Single(c => c.Title == "Macroeconomics" ).CourseID, Grade = Grade.B},
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Alonso").ID, CourseID = context.Courses.Single(c => c.Title == "Calculus" ).CourseID, Grade = Grade.B},
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Alonso").ID, CourseID = context.Courses.Single(c => c.Title == "Trigonometry" ).CourseID, Grade = Grade.B},
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Alonso").ID, CourseID = context.Courses.Single(c => c.Title == "Composition" ).CourseID, Grade = Grade.B},
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Anand").ID, CourseID = context.Courses.Single(c => c.Title == "Chemistry" ).CourseID },
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Anand").ID, CourseID = context.Courses.Single(c => c.Title == "Microeconomics").CourseID, Grade = Grade.B},
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Barzdukas").ID, CourseID = context.Courses.Single(c => c.Title == "Chemistry").CourseID, Grade = Grade.B},
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Li").ID, CourseID = context.Courses.Single(c => c.Title == "Composition").CourseID, Grade = Grade.B},
                new Enrollment {StudentID = context.Students.Single(s => s.LastName == "Justice").ID, CourseID = context.Courses.Single(c => c.Title == "Literature").CourseID, Grade = Grade.B}
            };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s =>
                            s.Student.ID == e.StudentID &&
                            s.Course.CourseID == e.CourseID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}

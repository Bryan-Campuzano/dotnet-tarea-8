using ContosoUniversity.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
                new Course{CourseID=1045,Title="Calculus",Credits=4},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4},
                new Course{CourseID=2021,Title="Composition",Credits=3},
                new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=students[0].ID,CourseID=courses[0].CourseID,Grade=Grade.A, Course=courses[0], Student=students[0]},
                new Enrollment{StudentID=students[0].ID,CourseID=courses[1].CourseID,Grade=Grade.C, Course=courses[1], Student=students[0]},
                new Enrollment{StudentID=students[0].ID,CourseID=courses[2].CourseID,Grade=Grade.B, Course=courses[2], Student=students[0]},
                new Enrollment{StudentID=students[1].ID,CourseID=courses[3].CourseID,Grade=Grade.B, Course=courses[3], Student=students[1]},
                new Enrollment{StudentID=students[1].ID,CourseID=courses[4].CourseID,Grade=Grade.F, Course=courses[4], Student=students[1]},
                new Enrollment{StudentID=students[1].ID,CourseID=courses[5].CourseID,Grade=Grade.F, Course=courses[5], Student=students[1]},
                new Enrollment{StudentID=students[2].ID,CourseID=courses[0].CourseID, Course=courses[0], Student=students[2]},
                new Enrollment{StudentID=students[3].ID,CourseID=courses[0].CourseID, Course=courses[0], Student=students[3]},
                new Enrollment{StudentID=students[3].ID,CourseID=courses[1].CourseID,Grade=Grade.F, Course=courses[1], Student=students[3]},
                new Enrollment{StudentID=students[4].ID,CourseID=courses[2].CourseID,Grade=Grade.C, Course=courses[2], Student=students[4]},
                new Enrollment{StudentID=students[5].ID,CourseID=courses[3].CourseID, Course=courses[3], Student=students[5]},
                new Enrollment{StudentID=students[6].ID,CourseID=courses[4].CourseID,Grade=Grade.A, Course=courses[4], Student=students[6]},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}

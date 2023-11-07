namespace UserLoginExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ModelBindingDemo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelBindingDemo.Models.SchoolContextDemo>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ModelBindingDemo.Models.SchoolContextDemo context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            context.Students.AddOrUpdate(
new Student
{
    FirstName = "M. Irfan",
    LastName = "Khan",
    Email = "irfan@example.com",
    Year = AcademicYear.Freshman
},
new Student
{
    FirstName = "Arvind",
    LastName = "Kumar",
    Email = "Arvind@example.com",
    Year = AcademicYear.Freshman
},
new Student
{
    FirstName = "Arturo",
    LastName = "Anand",
    Email = "Anand@example.com",
    Year = AcademicYear.Sophomore
},
new Student
{
    FirstName = "Moris",
    LastName = "Mano",
    Email = "moris@example.com",
    Year = AcademicYear.Sophomore
},
new Student
{
    FirstName = "Roman",
    LastName = "Sigh",
    Email = "roman@example.com",
    Year = AcademicYear.Junior
},
new Student
{
    FirstName = "Jimmi",
    LastName = "Seth",
    Email = "jimmi@example.com",
    Year = AcademicYear.Junior
},
new Student
{
    FirstName = "Shayam",
    LastName = "Rana",
    Email = "Shayam@example.com",
    Year = AcademicYear.Senior
},
new Student
{
    FirstName = "Jecub",
    LastName = "Cunto",
    Email = "Nino@example.com",
    Year = AcademicYear.Senior
}
                 );
            context.SaveChanges();
            context.Courses.AddOrUpdate(
new Course { Title = "Chemistry", Credits = 3 },
new Course { Title = "Microeconomics", Credits = 3 },
new Course { Title = "Macroeconomics", Credits = 3 },
new Course { Title = "Calculus", Credits = 4 },
new Course { Title = "Trigonometry", Credits = 4 },
new Course { Title = "Composition", Credits = 3 },
new Course { Title = "Literature", Credits = 4 }
                );
            context.SaveChanges();
            context.Enrollments.AddOrUpdate(
new Enrollment { StudentID = 1, CourseID = 1, Grade = 1 },
new Enrollment { StudentID = 1, CourseID = 2, Grade = 3 },
new Enrollment { StudentID = 1, CourseID = 3, Grade = 1 },
new Enrollment { StudentID = 2, CourseID = 4, Grade = 2 },
new Enrollment { StudentID = 2, CourseID = 5, Grade = 4 },
new Enrollment { StudentID = 2, CourseID = 6, Grade = 4 },
new Enrollment { StudentID = 3, CourseID = 1 },
new Enrollment { StudentID = 4, CourseID = 1 },
new Enrollment { StudentID = 4, CourseID = 2, Grade = 4 },
new Enrollment { StudentID = 5, CourseID = 3, Grade = 3 },
new Enrollment { StudentID = 6, CourseID = 4 },
new Enrollment { StudentID = 7, CourseID = 5, Grade = 2 }
                );
            context.SaveChanges();
        }
    }
}  

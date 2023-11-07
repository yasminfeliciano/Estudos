using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ModelBindingDemo.Models
{
    public class SchoolContextDemo : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
    public class Student
    {
        [Key, Display(Name = "Email ID")]
        [ScaffoldColumn(false)]
        public int StudentID { get; set; }
        [Required, StringLength(40), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, StringLength(20), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(50), Display(Name = "Email ID")]
        public string Email { get; set; }
        [EnumDataType(typeof(AcademicYear)), Display(Name = "Academic Year")]
        public AcademicYear Year { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }
        public virtualCourse Course { get; set; }
        public virtualStudent Student { get; set; }
    }
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
    public enum AcademicYear
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }  
}
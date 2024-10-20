using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet_Assignment_2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }

        public static List<Course> GetCourses() { 
            List<Course> list = new List<Course>();
            Course course = new Course();
            course.Id = 1;
            course.CourseName = "Asp DotNet core web api";
            course.CourseDescription = "Build dot net core app...";
            list.Add(course);



            return list;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet_Assignment_2.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }

        public static List<Teacher> GetTeacher() {
            List<Teacher> tl = new List<Teacher>();
            Teacher teacher = new Teacher();
            teacher.Id = 0;
            teacher.Name = "Nafiur Rahman Protik";
            teacher.CourseName = "Asp DotNet core web api";
            tl.Add(teacher);




            return tl;
        }
    }
}
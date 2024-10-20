using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet_Assignment_2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string TeacherName { get; set; }

        public static List<Student> GetStudent() {
            List<Student> studentList = new List<Student>();
            Student student = new Student();
            student.Id = 01;
            student.Name = "Nur Hossain";
            student.Course = "DotNet core";
            student.TeacherName = "Nafiur Rahman Protik";
            studentList.Add(student);

            student.Id = 02;
            student.Name = "Nur Hossain Repon";
            student.Course = "Asp DotNet core web api";
            student.TeacherName = "Nafiur Rahman Protik";
            studentList.Add(student);


            return studentList;

        }

        
    }
}
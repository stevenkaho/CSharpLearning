using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqtoXMLDemo
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int TotalMarks { get; set; }

        public static Student[] GetAllStudents()
        {
            Student[] students = new Student[4];

            students[0] = new Student { Id = 101, Name = "Mark", Gender = "Male", TotalMarks = 800 };
            students[1] = new Student { Id = 102, Name = "Mary", Gender = "Female", TotalMarks = 900};
            students[2] = new Student { Id = 103, Name = "Peter", Gender = "Male", TotalMarks = 700 };
            students[3] = new Student { Id = 104, Name = "Paul", Gender = "Male", TotalMarks = 780 };
            return students;
        }
    }
}

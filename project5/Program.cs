using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolData schoolData = SchoolData.GetInstance();

            // Fill up the data with dummy values
            Student student1 = DataFactory.CreateStudent("Dhana", "10th", "A");
            Student student2 = DataFactory.CreateStudent("Lakshmi", "10th", "B");
            schoolData.Students.Add(student1);
            schoolData.Students.Add(student2);

            Teacher teacher1 = DataFactory.CreateTeacher("Dhana", "10th", "A");
            Teacher teacher2 = DataFactory.CreateTeacher("Lakshmi", "10th", "B");
            schoolData.Teachers.Add(teacher1);
            schoolData.Teachers.Add(teacher2);

            Subject subject1 = DataFactory.CreateSubject("Mathematics", "MATH101", teacher1);
            Subject subject2 = DataFactory.CreateSubject("Science", "SCI101", teacher2);
            schoolData.Subjects.Add(subject1);
            schoolData.Subjects.Add(subject2);

            // Display the lists
            Console.WriteLine("Students in the class:");
            foreach (var student in schoolData.Students)
            {
                Console.WriteLine($"Name: {student.Name}, Class: {student.Class}, Section: {student.Section}");
            }

            Console.WriteLine("\nSubjects taught by a teacher:");
            foreach (var subject in schoolData.Subjects)
            {
                Console.WriteLine($"Name: {subject.Name}, Subject Code: {subject.SubjectCode}, Teacher: {subject.Teacher.Name}");
            }

            Console.ReadLine();
        }
    }
    }


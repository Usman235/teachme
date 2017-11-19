using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ConsoleDbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            BCS7REntities entityObject = new BCS7REntities();
            var student1 = entityObject.Students.First(s => s.StudentId == 1);

            entityObject.Students.Remove(student1);
            entityObject.SaveChanges();
            Console.WriteLine("Record remove" + student1.StudentId);
            //student1.StudentName = "New Name";
            //entityObject.SaveChanges();
            /* Create Record
            Student newStudent = new Student();
            newStudent.StudentName = "I'm new";
            newStudent.StudentRegNo = "Fa11-bcs-070";
            entityObject.Students.Add(newStudent);
            entityObject.SaveChanges();
            */



            /*
            Console.WriteLine("Student Name" + student1.StudentName);
            Console.WriteLine("Student Registration number" + student1.StudentRegNo);*/
            Console.ReadKey();
        }
    }
}

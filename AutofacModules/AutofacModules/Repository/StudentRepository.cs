using AutofacModules.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacModules.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public void Print(Student student)
        {
            Console.WriteLine("Student Info: ");
            Console.WriteLine(string.Format("Id: {0}", student.Id));
            Console.WriteLine(string.Format("Name: {0}", student.Name));
            Console.WriteLine(string.Format("Roll Number: {0}",student.RollNumber));
        }
    }
}

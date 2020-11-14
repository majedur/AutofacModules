using AutofacModules.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacModules.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        public void Print(Teacher teacher)
        {
            Console.WriteLine("Student Info: ");
            Console.WriteLine(string.Format("Id: {0}", teacher.Id));
            Console.WriteLine(string.Format("Name: {0}", teacher.Name));
            Console.WriteLine(string.Format("Card Number: {0}", teacher.CardNumber));
        }
    }
}

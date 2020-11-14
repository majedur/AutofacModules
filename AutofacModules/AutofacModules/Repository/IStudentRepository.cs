using AutofacModules.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacModules.Repository
{
    public interface IStudentRepository
    {
        void Print(Student student);
    }
}

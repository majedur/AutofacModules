using Autofac;
using AutofacModules.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using AutofacModules.Repository;

namespace AutofacModules.Module
{
    public class StudentModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IStudentRepository>();
            base.Load(builder);
        }
    }
}

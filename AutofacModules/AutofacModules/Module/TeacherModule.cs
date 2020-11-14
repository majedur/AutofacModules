using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using AutofacModules.Repository;

namespace AutofacModules.Module
{
    public class TeacherModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TeacherRepository>().As<ITeacherRepository>();
            base.Load(builder);
        }
    }
}

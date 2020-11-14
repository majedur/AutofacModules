using Autofac;
using AutofacModules.Model;
using AutofacModules.Module;
using AutofacModules.Repository;
using System;

namespace AutofacModules
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetStudent getStudent = new GetStudent(new StudentRepository());
            //getStudent.PrintStudent();

            //GetTeacher getTeacher = new GetTeacher(new TeacherRepository());
            //getTeacher.PrintTeacher();

            var containder = BuildMyContainer();

            Student student = new Student()
            {
                Id = 400,
                Name = "Abdur Rahim",
                RollNumber=900
            };

            var studentRepository = containder.Resolve<IStudentRepository>();
            studentRepository.Print(student);

            Teacher teacher = new Teacher()
            {
                Id = 500,
                Name = "Abdur Karim",
                CardNumber = 800433
            };

            Console.WriteLine();
            var teacherRepository = containder.Resolve<ITeacherRepository>();
            teacherRepository.Print(teacher);
        }

        static IContainer BuildMyContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<StudentModule>();
            builder.RegisterModule<TeacherModule>();
            return builder.Build();
        }

        public class GetStudent
        {
            private IStudentRepository _studentRepository;
            public  GetStudent(IStudentRepository studentRepository)
            {
                this._studentRepository = studentRepository;
            }

            public void PrintStudent()
            {
                Student student = new Student()
                {
                    Id = 10,
                    Name = "Arham Abid",
                    RollNumber = 100
                };
                _studentRepository.Print(student);
            }
        }

        public class GetTeacher
        {
            private ITeacherRepository _teacherRepository;
            public GetTeacher(ITeacherRepository teacherRepository)
            {
                this._teacherRepository = teacherRepository;
            }

            public void PrintTeacher()
            {
                Teacher teacher = new Teacher()
                {
                    Id = 100,
                    Name = "Majedur Rahman",
                    CardNumber = 1000
                };
                _teacherRepository.Print(teacher);
            }
        }
    }
}
 
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITMO.ASPNet.ExamTask.Models
{
    public class StudentsDbInitializer : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            context.Students.Add(new Student { FirstName = "Олег", LastName = "Петров", CourseID = 2, Grade = 4 });
            context.Students.Add(new Student { FirstName = "Василий", LastName = "Соколов", CourseID = 4, Grade = 5 });
            context.Students.Add(new Student { FirstName = "Глеб", LastName = "Калинин", CourseID = 2, Grade = 3 });
            context.Students.Add(new Student { FirstName = "Иннокентий", LastName = "Медведев", CourseID = 3, Grade = 5 });
            context.Students.Add(new Student { FirstName = "Денис", LastName = "Васильев", CourseID = 3, Grade = 4 });
            context.Courses.Add(new Course { Title = "Курс1", DepartmentNumber = 1 });
            context.Courses.Add(new Course { Title = "Курс2", DepartmentNumber = 2 });
            context.Courses.Add(new Course { Title = "Курс3", DepartmentNumber = 3 });
            context.Courses.Add(new Course { Title = "Курс4", DepartmentNumber = 4 });
            context.Courses.Add(new Course { Title = "Курс5", DepartmentNumber = 5 });
            base.Seed(context);
        }
    }
}
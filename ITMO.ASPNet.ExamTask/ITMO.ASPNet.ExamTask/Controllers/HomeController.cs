using ITMO.ASPNet.ExamTask.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPNet.ExamTask.Controllers
{
    public class HomeController : Controller
    {
        private MyContext db = new MyContext();

        public ActionResult Index()
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.Students = allStudents;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetSum()
        {
            ViewBag.Sum = db.Students.Sum(s => s.Grade);
            return View();
        }

        public FileResult GetFile()
        {
            var list = db.Students.OrderByDescending(s => s.Grade).Take(5);
            
            string writing = list.ToString();

            string file_path = Server.MapPath("~/Files/Список лучших.txt");

            using (StreamWriter sw = new StreamWriter(file_path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Список лучших 5 студентов:\n");
                foreach (Student students in list)
                {
                     sw.WriteLine(students.FirstName + " " + students.LastName + " курс " + students.CourseID + " оценка " + students.Grade);
                }
            }

            string file_type = "application/txt";
            
            string file_name = "Список лучших.txt";

            return File(file_path, file_type, file_name);
        }

        public FileResult GetStream()
        {
            var list2 = db.Students.OrderBy(s => s.Grade).Take(5);

            string writing2 = list2.ToString();

            string path = Server.MapPath("~/Files/Список худших.txt");

            using (StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                writer.WriteLine("Список худших 5 студентов:\n");
                foreach (Student students in list2)
                {
                    writer.WriteLine(students.FirstName + " " + students.LastName + " курс " + students.CourseID + " оценка " + students.Grade);
                }
            }

            FileStream fs = new FileStream(path, FileMode.Open);
            string file_type = "application/txt";
            string file_name = "Список худших.txt";
            return File(fs, file_type, file_name);
        }

    }
}

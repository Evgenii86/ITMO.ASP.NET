using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.ASPNet.ExamTask.Models
{
    public class Course
    {
        [DisplayName("Номер курса")]
        public int CourseID { get; set; }
        [Required]
        public string Title { get; set; }
        public int DepartmentNumber { get; set; }
        public List<Student> Students { get; set; }
    }
}
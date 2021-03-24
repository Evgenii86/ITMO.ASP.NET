using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.ASPNet.ExamTask.Models
{
    public class Student
    {
        [Required]
        public int StudentID { get; set; }
        [Required, MaxLength(50)]
        [DisplayName("Имя")]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Номер курса")]
        public short CourseID { get; set; }
        [DisplayName("Оценка")]
        [Required]
        public byte Grade { get; set; }
        public Course Course { get; set; }
    }
}
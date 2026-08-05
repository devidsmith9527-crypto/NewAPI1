using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NewAPI1.Models
{
    public class Teacher
    {
        [Key]
        [Column("TeacherId")]
        public int TeacherId { get; set;}
        [Column("TeacherName")]
        public string TeacherName { get; set;}
        public List<TeacherSubject> TeacherSubjects { get; set;} = new List<TeacherSubject>();
    }
}
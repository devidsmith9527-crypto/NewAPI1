using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NewAPI1.Models
{
    public class Subject
    {
        [Key]
        [Column("SubjectId")]
        public int SubjectId { get; set;}
        [Column("SubjectName")]
        public string SubjectName { get; set;}
        public List<TeacherSubject> TeacherSubjects { get; set;} = new List<TeacherSubject>();
    }
}
using SchoolDiaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class GradeViewModel
    {
        public int Id { get; set; }
        public RatingEnum Rating{ get; set; }
        public DateTime Date { get; set; }
        public int LessonId { get; set; }
        public LessonTypeEnum LessonType { get; set; }
        public string TeacherEmail { get; set; }
        public string StudentId { get; set; }
        public string StudentEmail { get; set; }
        public bool IsFinalGrade { get; set; }
    }
}

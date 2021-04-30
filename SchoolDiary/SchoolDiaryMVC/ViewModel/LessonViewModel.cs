using SchoolDiaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class LessonViewModel
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public LessonTypeEnum LessonType { get; set; }
        public DateTime Date { get; set; }
        public int ClassGroupId { get; set; }
        public string ClassGroupTeacherEmail { get; set; }
        public int SubjectNameId { get; set; }
        public SubjectNameEnum SubjectName { get; set; }
    }
}

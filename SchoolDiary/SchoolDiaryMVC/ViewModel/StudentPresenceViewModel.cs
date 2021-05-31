using SchoolDiaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class StudentPresenceViewModel
    {
        public string StudentId { get; set; }
        public int LessonId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public SubjectNameEnum SubjectName { get; set; }
        public bool IsPresent { get; set; }
    }
}

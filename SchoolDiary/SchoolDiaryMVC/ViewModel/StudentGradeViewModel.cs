using SchoolDiaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class StudentGradeViewModel
    {
        public string  Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public int? Index { get; set; }
        public CourseEnum Course{ get; set; }
        public bool IsAccepted { get; set; }
        public UserTypeEnum UserType { get; set; }
        public SubjectNameEnum SubjectName { get; set; }
        public List<GradeViewModel> Grades = new List<GradeViewModel>();
        public List<NoteViewModel> Notes = new List<NoteViewModel>();
        public string Role { get; set; }

    }
}

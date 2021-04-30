using SchoolDiaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class ClassGroupViewModel
    {
        public int Id { get; set; }
        public CourseEnum Course { get; set; }
        public int SizeGroup { get; set; }
        public string ClassTeacherId { get; set; }
        public string TeacherEmail { get; set; }

    }
}

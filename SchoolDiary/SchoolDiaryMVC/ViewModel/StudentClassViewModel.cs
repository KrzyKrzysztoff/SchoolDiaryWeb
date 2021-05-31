using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class StudentClassViewModel
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public string ClassMark { get; set; }
        public string TeacherEmail { get; set; }
        public int SizeGroup { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public class ClassGroup
    {
        public int Id { get; set; }
        public CourseEnum Course { get; set; }
        public int SizeGroup { get; set; }

        public List<ApplicationUser> Students { get; set; }

        public string ClassTeacherId { get; set; }
        [ForeignKey("ClassTeacherId")]
        public ApplicationUser ClassGroupTeacher { get; set; }
    }
}

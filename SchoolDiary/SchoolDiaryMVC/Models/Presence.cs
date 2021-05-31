using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public class Presence
    {
        public int Id { get; set; }
        public bool IsPresent { get; set; }
        [ForeignKey("LessonId")]
        public int LessonId { get; set; }
        public Lesson Lesson{ get; set; }

        [ForeignKey("StudentId")]
        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; }
    }
}

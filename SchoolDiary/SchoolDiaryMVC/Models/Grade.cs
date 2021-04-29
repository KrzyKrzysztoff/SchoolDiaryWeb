using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public RatingEnum Rating { get; set; }
        public DateTime Date { get; set; }

        public int? LessonId { get; set; }
        [ForeignKey("LessonId")]
        public Lesson Lesson { get; set; }
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public ApplicationUser Student { get; set; }

    }
}

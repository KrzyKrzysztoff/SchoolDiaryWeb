using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public class FinalGrade
    {
        public int Id { get; set; }
        public int? SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public ApplicationUser Student { get; set; }
        public RatingEnum Rating { get; set; }
        public DateTime Date { get; set; }
    }
}

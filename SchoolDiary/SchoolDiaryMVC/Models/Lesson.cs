using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public LessonTypeEnum LessonType { get; set; }
        public DateTime Date { get; set; }
        public int Test { get; set; }
        public int Test2 { get; set; }

        public int? ClassGroupId { get; set; }
        [ForeignKey("ClassGroupId")]
        public ClassGroup ClassGroup { get; set; }
        public int? SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
    }
}

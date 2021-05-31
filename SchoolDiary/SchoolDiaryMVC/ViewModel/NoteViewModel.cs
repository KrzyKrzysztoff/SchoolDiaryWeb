using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class NoteViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Opis jest wymagany")]
        public string Desc { get; set; }
        [Required(ErrorMessage = "Numer Id jest wymagany")]
        public int LessonId { get; set; }
        [Required(ErrorMessage = "Numer Id jest wymagany")]
        public string StudentId { get; set; }
        public bool IsPositive { get; set; }
        public DateTime Date { get; set; }
        public string LessonName { get; set; }
    }
}

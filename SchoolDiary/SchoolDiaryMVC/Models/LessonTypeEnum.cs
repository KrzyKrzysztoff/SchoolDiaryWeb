using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public enum LessonTypeEnum
    {
        [Display(Name = "Brak")]
        None,
        [Display(Name = "Wykład")]
        Lecture,
        [Display(Name = "Laboratorium")]
        Laboratory
    }
}

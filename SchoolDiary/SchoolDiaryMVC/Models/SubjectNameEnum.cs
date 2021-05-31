using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public enum SubjectNameEnum
    {
        [Display(Name = "Brak")]
        None,
        [Display(Name = "Plastyka")]
        Art,
        [Display(Name = "Geografia")]
        Geography,
        [Display(Name = "Język Angielski")]
        English,
        [Display(Name = "Literatorua")]
        Literacy,
        [Display(Name = "Muzyka")]
        Music,
        
      

    }
}

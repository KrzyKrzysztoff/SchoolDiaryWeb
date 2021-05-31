using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public enum CourseEnum
    {
        [Display(Name = "Brak")]
        None,
        [Display(Name = "Biznes")]
        Business,
        [Display(Name = "Finanse")]
        Finance,
        [Display(Name = "Informatyka")]
        ComputerScience,
        
    }
}

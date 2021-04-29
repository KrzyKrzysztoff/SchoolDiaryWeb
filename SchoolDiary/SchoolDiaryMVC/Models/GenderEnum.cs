using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public enum GenderEnum
    {
        [Display(Name = "Mężczyzna")]
        Male,
        [Display(Name = "Kobieta")]
        Female
    }
}

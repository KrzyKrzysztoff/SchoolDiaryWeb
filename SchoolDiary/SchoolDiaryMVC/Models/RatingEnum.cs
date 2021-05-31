using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public enum RatingEnum
    {
        [Display(Name ="Brak oceny")]
        None,
        [Display(Name = "2")]
        Two,
        [Display(Name = "2+")]
        TwoPlus,
        [Display(Name = "3")]
        Three,
        [Display(Name = "3+")]
        ThreePlus,
        [Display(Name = "4")]
        Four,
        [Display(Name = "4+")]
        FourPlus,
        [Display(Name = "5")]
        Five
    }
}

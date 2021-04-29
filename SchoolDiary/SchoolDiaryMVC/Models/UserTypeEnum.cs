using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public enum UserTypeEnum
    {
        [Display(Name = "Uczeń")]
        Student,
        [Display(Name = "Nauczyciel")]
        Teacher
    }
}

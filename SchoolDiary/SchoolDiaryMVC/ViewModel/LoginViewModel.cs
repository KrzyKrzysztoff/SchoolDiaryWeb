using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Nazwa użytkownika lub adres email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

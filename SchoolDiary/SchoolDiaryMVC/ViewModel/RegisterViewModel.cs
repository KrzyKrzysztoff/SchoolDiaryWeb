using SchoolDiaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Pesel { get; set; }
        public UserTypeEnum UserType { get; set; }
        public bool RememberMe { get; set; }
    }
}

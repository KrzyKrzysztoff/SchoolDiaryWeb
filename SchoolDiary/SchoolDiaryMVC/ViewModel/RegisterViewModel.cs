using SchoolDiaryMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email jest wymagany")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Nieprawidłowy adres email")]
        [MinLength(5, ErrorMessage = "Minimalna długość maila to 5 znaków!")]
        [MaxLength(50, ErrorMessage = "Maksymalna długość hasła to 50 znaków!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [MinLength(7, ErrorMessage = "Minimalna długość hasła to 7 znaków!")]
        [MaxLength(21, ErrorMessage = "Maksymalna długość hasła to 21 znaków!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        [MinLength(3, ErrorMessage = "Minimalna długość imienia to 3 znaki!")]
        [MaxLength(50, ErrorMessage = "Maksymalna długość imienia to 50 znaków!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Numer pesel jest wymagany")]
        [MinLength(11, ErrorMessage = "Błędny numer pesel")]
        [MaxLength(11, ErrorMessage = "Błędny numer pesel")]
        public string Pesel { get; set; }
        public UserTypeEnum UserType { get; set; }
        public bool RememberMe { get; set; }
    }
}

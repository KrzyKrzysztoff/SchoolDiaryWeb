using SchoolDiaryMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class UserAddressViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        [MinLength(2, ErrorMessage = "Imię jest zbyt krótkie")]
        [MaxLength(55, ErrorMessage = "Imię jest zbyt długie")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [MinLength(2, ErrorMessage = "Nazwisko jest zbyt krótkie")]
        [MaxLength(55, ErrorMessage = "Nazwisko jest zbyt długie")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Numer pesel jest wymagany")]
        [MinLength(11, ErrorMessage = "Błędny numer pesel")]
        [MaxLength(11, ErrorMessage = "Błędny numer pesel")]
        public string Pesel { get; set; }
        public GenderEnum Gender { get; set; }

        public int? WorkedHours { get; set; }

        public int? SalaryPerHour { get; set; }
        public DateTime? BirthDate { get; set; }
        [Required(ErrorMessage = "Index Jest wymagany")]
        public int? Index { get; set; }
        public CourseEnum Course { get; set; }
        public UserTypeEnum UserType { get; set; }
        [Required(ErrorMessage = "Kraj jest wymagany")]
        [MinLength(2, ErrorMessage = "Nazwa kraju jest zbyt króka")]
        [MaxLength(55, ErrorMessage = "Nazwa kraju jest zbyt długa")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Pole miasto jest wymagane")]
        [MinLength(2, ErrorMessage = "Pole miasto jest zbyt krótkie")]
        [MaxLength(55, ErrorMessage = "Pole miasto jest zbyt długie")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pole miasto jest wymagane")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Ulica jest wymagana")]
        [MinLength(2, ErrorMessage = "Nazwa ulicy jest zbyt krótkia")]
        [MaxLength(55, ErrorMessage = "Nazwa ulicy jest zbyt długa")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Numer domu jest wymagany")]
        public int? HouseNumber { get; set; }
        [Required(ErrorMessage = "Email jest wymagany")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Nieprawidłowy adres email")]
        [MinLength(5, ErrorMessage = "Minimalna długość maila to 5 znaków!")]
        [MaxLength(50, ErrorMessage = "Maksymalna długość hasła to 50 znaków!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [MinLength(7, ErrorMessage = "Minimalna długość hasła to 7 znaków!")]
        [MaxLength(21, ErrorMessage = "Maksymalna długość hasła to 21 znaków!")]
        public string Password { get; set; }
        public bool Accepted { get; set; }
    }
}

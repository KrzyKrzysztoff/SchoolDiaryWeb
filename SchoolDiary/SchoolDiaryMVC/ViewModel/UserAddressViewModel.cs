using SchoolDiaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.ViewModel
{
    public class UserAddressViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public GenderEnum Gender { get; set; }
        public decimal WorkedHours { get; set; }
        public decimal SalaryPerHour { get; set; }
        public DateTime BirthDate { get; set; }
        public int Index { get; set; }
        public CourseEnum Course { get; set; }
        public UserTypeEnum UserType { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Accepted { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public GenderEnum Gender { get; set; }
        public int? WorkedHours { get; set; }
        public int? SalaryPerHour { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Index { get; set; }
        public CourseEnum Course { get; set; }
        public UserTypeEnum UserType { get; set; }
        public bool Accepted { get; set; }
        public int ClassGroupId { get; set; }
        [ForeignKey("ClassGroupId")]
        public ClassGroup ClassGroup { get; set; }
        public IList<StudentAddress> StudentAddresses { get; set; }
        public IList<TeacherAddress> TeacherAddresses { get; set; }
    }
}

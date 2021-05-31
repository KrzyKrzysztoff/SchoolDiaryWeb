using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public int? HouseNumber { get; set; }
        public IList<StudentAddress> StudentAddresses { get; set; }
        public IList<TeacherAddress> TeacherAddreses { get; set; }
    }
}

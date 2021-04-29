using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public SubjectNameEnum SubjectName { get; set; }
        public string TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public ApplicationUser Teacher { get; set; }
    }
}

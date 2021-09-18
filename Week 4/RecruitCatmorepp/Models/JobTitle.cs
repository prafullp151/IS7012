using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatmorepp.Models
{
    public class JobTitle
    {
        [Required(ErrorMessage = "Job Title is a mandatory field")]
        [DisplayName("Job Title")]
        [StringLength(100)]
        public string Title { get; set; }
        [DisplayName("Minimum Salary")]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }
        [DisplayName("Job Title Id")]
        public int JobTitleId { get; set; }
        [DisplayName("Candidates List")]
        public List<Candidate> Candidates { get; set; }
        [DisplayName("Skills")]
        [Required(ErrorMessage = "Skills is a mandatory field")]
        public string Skills { get; set; }
        [DisplayName("Travel Percentage")]
        public int PercentTravelRequired { get; set; }
        [DisplayName("Work hrs per day")]
        [Required(ErrorMessage = "Work hrs per day is a mandatory field")]
        public string WorkHrsPerDay { get; set; }
    }

}

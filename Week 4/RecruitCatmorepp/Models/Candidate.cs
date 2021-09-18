using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatmorepp.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "First Name is a mandatory field")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is a mandatory field")]
        public string LastName { get; set; }
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DisplayName("Candidate Id")]
        public int CandidateId { get; set; }
        [DisplayName("Company Name")]
        public Company Company { get; set; }
        [DisplayName("Company Id")]
        public int? CompanyId { get; set; }
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        [DisplayName("Job Title Id")]
        public int JobTitleId { get; set; }
        [DisplayName("Industry")]
        public Industry Industry { get; set; }
        [DisplayName("Industry Id")]
        public int IndustryId { get; set; }
        [DisplayName("Preferred Location")]
        [Required(ErrorMessage = "Preferred Location is a mandatory field")]
        public string PreferredLocation { get; set; }
        [DisplayName("I am open for Relocation")]
        public Boolean OpenForRelocation { get; set; }
    }

}

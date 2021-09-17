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
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DisplayName]
        public int CandidateId { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public string PreferredLocation { get; set; }
        public Boolean OpenForRelocation { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RecruitCatmorepp.Models
{
    public class Company
    {
        [DisplayName("Company Name")]
        [Required(ErrorMessage ="Company Name is a mandatory field")]
        [StringLength(100)]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Job Title is a mandatory field")]
        [DisplayName("Job Title")]
        [StringLength(100)]
        public string JobPosition { get; set; }
        [DisplayName("Minimum Salary")]
        [DataType(DataType.Currency)]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [DataType(DataType.Currency)]
        public decimal MaxSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DisplayName("Job Location")]
        [Required(ErrorMessage = "Job Location is a mandatory field")]
        [StringLength(50)]
        public string JobLocation { get; set; }
        [DisplayName("Company Id")]
        public int CompanyId { get; set; }
        [DisplayName("Candidates Applied")]
        public List<Candidate> Candidates { get; set; }
        [DisplayName("Industry")]
        public Industry Industry { get; set; }
        [DisplayName("Industry Id")]
        public int IndustryId { get; set; }
        [DisplayName("Company Address")]
        [Required(ErrorMessage = "Company Address is a mandatory field")]
        public string CompanyAddress { get; set; }
        [DisplayName("Annual Revenue")]
        [DataType(DataType.Currency)]
        public decimal AnnualRevenue { get; set; }

    }

}

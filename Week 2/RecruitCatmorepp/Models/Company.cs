using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatmorepp.Models
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string JobPosition { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string JobLocation { get; set; }
        public int CompanyId { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public string CompanyAddress { get; set; }
        public decimal AnnualRevenue { get; set; }

    }

}

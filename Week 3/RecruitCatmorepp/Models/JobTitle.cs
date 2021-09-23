using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatmorepp.Models
{
    public class JobTitle
    {
        public string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public int JobTitleId { get; set; }
        public List<Candidate> Candidates { get; set; }
        public string Skills { get; set; }
        public int PercentTravelRequired { get; set; }
        public string WorkHrsPerDay { get; set; }
    }

}

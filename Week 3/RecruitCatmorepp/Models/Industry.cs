using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatmorepp.Models
{
    public class Industry
    {
        public string IndustryName { get; set; }
        public int IndustryId { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }

}

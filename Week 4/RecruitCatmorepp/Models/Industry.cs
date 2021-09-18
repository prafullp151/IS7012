using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatmorepp.Models
{
    public class Industry
    {
        [DisplayName("Industry Name")]
        public string IndustryName { get; set; }
        [DisplayName("Industry Id")]
        public int IndustryId { get; set; }
        [DisplayName("Candidates List")]
        public List<Candidate> Candidates { get; set; }
        [DisplayName("Companies list")]
        public List<Company> Companies { get; set; }
    }

}

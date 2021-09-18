﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatmorepp.Models
{
    public class JobTitle
    {
        [DisplayName("Job Title")]
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
        public string Skills { get; set; }
        [DisplayName("Travel Percentage")]
        public int PercentTravelRequired { get; set; }
        [DisplayName("Work hrs per day")]
        public string WorkHrsPerDay { get; set; }
    }

}
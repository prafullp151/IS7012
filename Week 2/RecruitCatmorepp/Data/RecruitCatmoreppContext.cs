using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatmorepp.Models;

namespace RecruitCatmorepp.Data
{
    public class RecruitCatmoreppContext : DbContext
    {
        public RecruitCatmoreppContext (DbContextOptions<RecruitCatmoreppContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatmorepp.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatmorepp.Models.JobTitle> JobTitle { get; set; }

        public DbSet<RecruitCatmorepp.Models.Company> Company { get; set; }

        public DbSet<RecruitCatmorepp.Models.Industry> Industry { get; set; }
    }
}

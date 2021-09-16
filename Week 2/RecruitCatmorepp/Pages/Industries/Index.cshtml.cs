using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatmorepp.Data;
using RecruitCatmorepp.Models;

namespace RecruitCatmorepp.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatmorepp.Data.RecruitCatmoreppContext _context;

        public IndexModel(RecruitCatmorepp.Data.RecruitCatmoreppContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; }

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}

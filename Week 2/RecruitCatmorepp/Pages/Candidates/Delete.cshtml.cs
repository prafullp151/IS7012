﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatmorepp.Data;
using RecruitCatmorepp.Models;

namespace RecruitCatmorepp.Pages.Candidates
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatmorepp.Data.RecruitCatmoreppContext _context;

        public DeleteModel(RecruitCatmorepp.Data.RecruitCatmoreppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).FirstOrDefaultAsync(m => m.CandidateId == id);

            if (Candidate == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidate.FindAsync(id);

            if (Candidate != null)
            {
                _context.Candidate.Remove(Candidate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

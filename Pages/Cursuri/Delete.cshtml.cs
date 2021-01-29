﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using gurzo_timea_tunde_project.Data;
using gurzo_timea_tunde_project.Models;

namespace gurzo_timea_tunde_project.Pages.Cursuri
{
    public class DeleteModel : PageModel
    {
        private readonly gurzo_timea_tunde_project.Data.gurzo_timea_tunde_projectContext _context;

        public DeleteModel(gurzo_timea_tunde_project.Data.gurzo_timea_tunde_projectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Curs Curs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Curs = await _context.Curs.FirstOrDefaultAsync(m => m.ID == id);

            if (Curs == null)
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

            Curs = await _context.Curs.FindAsync(id);

            if (Curs != null)
            {
                _context.Curs.Remove(Curs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

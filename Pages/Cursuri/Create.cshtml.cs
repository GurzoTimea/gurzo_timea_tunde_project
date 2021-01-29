using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using gurzo_timea_tunde_project.Data;
using gurzo_timea_tunde_project.Models;

namespace gurzo_timea_tunde_project.Pages.Cursuri
{
    public class CreateModel : PageModel
    {
        private readonly gurzo_timea_tunde_project.Data.gurzo_timea_tunde_projectContext _context;

        public CreateModel(gurzo_timea_tunde_project.Data.gurzo_timea_tunde_projectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Curs Curs { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Curs.Add(Curs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

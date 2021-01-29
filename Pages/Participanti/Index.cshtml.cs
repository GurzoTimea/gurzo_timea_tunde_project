using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using gurzo_timea_tunde_project.Data;
using gurzo_timea_tunde_project.Models;

namespace gurzo_timea_tunde_project.Pages.Participanti
{
    public class IndexModel : PageModel
    {
        private readonly gurzo_timea_tunde_project.Data.gurzo_timea_tunde_projectContext _context;

        public IndexModel(gurzo_timea_tunde_project.Data.gurzo_timea_tunde_projectContext context)
        {
            _context = context;
        }

        public IList<Participant> Participant { get;set; }

        public async Task OnGetAsync()
        {
            Participant = await _context.Participant
                .Include(p => p.Training).ToListAsync();
        }
    }
}

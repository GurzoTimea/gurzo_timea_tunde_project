using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gurzo_timea_tunde_project.Models;

namespace gurzo_timea_tunde_project.Data
{
    public class gurzo_timea_tunde_projectContext : DbContext
    {
        public gurzo_timea_tunde_projectContext (DbContextOptions<gurzo_timea_tunde_projectContext> options)
            : base(options)
        {
        }

        public DbSet<gurzo_timea_tunde_project.Models.Curs> Curs { get; set; }

        public DbSet<gurzo_timea_tunde_project.Models.Trainer> Trainer { get; set; }

        public DbSet<gurzo_timea_tunde_project.Models.Participant> Participant { get; set; }
    }
}

using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTiaraju.Infrastructure
{
    public class LabTiarajuDbContext : DbContext
    {
        public LabTiarajuDbContext(DbContextOptions<LabTiarajuDbContext> options) : base(options)
        {

        }

        public DbSet<CalendarioCQ> Calendarios { get; set; }
    }
}

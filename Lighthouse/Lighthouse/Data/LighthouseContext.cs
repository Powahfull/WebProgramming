using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lighthouse.Models;

namespace Lighthouse.Data
{
    public class LighthouseContext : DbContext
    {
        public LighthouseContext (DbContextOptions<LighthouseContext> options)
            : base(options)
        {
        }

        public DbSet<Lighthouse.Models.Events> Events { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MarvelMonitors.Models;

namespace MarvelMonitors.Data
{
    public class MarvelMonitorsContext : DbContext
    {
        public MarvelMonitorsContext(DbContextOptions<MarvelMonitorsContext> options)
            : base(options)
        {
        }

        public DbSet<MarvelMonitors.Models.Monitor> Monitor { get; set; }
    }
}

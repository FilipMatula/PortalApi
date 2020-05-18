using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using PortalApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Description> Description { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {
           //Database.EnsureCreated();
        }
    }
}

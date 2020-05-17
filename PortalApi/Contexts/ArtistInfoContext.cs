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
    public class ArtistInfoContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Description> Description { get; set; }

        public ArtistInfoContext(DbContextOptions<ArtistInfoContext> options)
            :base(options)
        {
           // Database.EnsureCreated();
        }
    }
}

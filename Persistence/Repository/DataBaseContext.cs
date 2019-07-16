using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace Persistence.Repository
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<ResourceProfile> ResourceProfiles { get; set; }
    }
}

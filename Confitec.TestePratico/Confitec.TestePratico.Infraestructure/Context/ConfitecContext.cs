using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Infra.Data.Context.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Confitec.TestePratico.Infra.Data.Context
{
    public class ConfitecContext : DbContext
    {
        public ConfitecContext(DbContextOptions<ConfitecContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.SeedDatabase();
        }
    }
}

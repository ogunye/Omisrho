using Microsoft.EntityFrameworkCore;
using Omisrho.Domain.Entities;
using Omisrho.Infrastrucutre.EntityFrameworkCore.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omisrho.Infrastrucutre.EntityFrameworkCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FaultConfiguration());
        }

        public DbSet<Fault_Notification>? Fault_Notifications { get; set; }
    }
}

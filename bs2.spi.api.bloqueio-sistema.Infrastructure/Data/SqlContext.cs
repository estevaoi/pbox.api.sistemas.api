using pbox.api.sistemas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace pbox.api.sistemas.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Sistema> Sistemas { get; set; }
        public DbSet<SistemaLog> SistemasLog { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataHoraCriacao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataHoraCriacao").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataHoraCriacao").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccessLayer.Models
{
    public partial class MatrimonyContext : DbContext
    {
        public virtual DbSet<TestTable> TestTable { get; set; }

        public MatrimonyContext(DbContextOptions<MatrimonyContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccessLayer.User;

namespace DataAccessLayer.Models
{
    public partial class MatrimonyContext : DbContext
    {
        public virtual DbSet<Users> TestTable { get; set; }

        public MatrimonyContext(DbContextOptions<MatrimonyContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
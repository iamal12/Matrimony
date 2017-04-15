using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccessLayer.User;

namespace DataAccessLayer.Models
{
    public partial class MatrimonyContext : DbContext
    {
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ProfileAccess> AccessRequest { get; set; }
        public virtual DbSet<Favourite> Favourite { get; set; }
        public virtual DbSet<Block> Block { get; set; }
        public virtual DbSet<UserEducation> UserEducation { get; set; }

        public MatrimonyContext(DbContextOptions<MatrimonyContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
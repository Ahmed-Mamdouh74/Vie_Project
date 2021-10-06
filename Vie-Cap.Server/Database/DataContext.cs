using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vie_Cap.Shared;

namespace Vie_Cap.Server.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasOne(b => b.User)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);


        }

        public virtual DbSet<User> Users { set; get; }
        public virtual DbSet<Country> Countries { set; get; }
        public virtual DbSet<Activity> Activities { set; get; }

        public virtual DbSet<Company> Companies { set; get; }


    }

}

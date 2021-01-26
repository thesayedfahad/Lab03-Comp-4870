using System;
using System.Collections.Generic;
using System.Text;
using Province.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Province.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<Provinces>().ToTable("Provinces");
            builder.Entity<City>().ToTable("City");

            builder.Seed();
        }

        public DbSet<Provinces> Province { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}

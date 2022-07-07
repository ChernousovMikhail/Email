using System;
using Email.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


    public class DbContext : IdentityDbContext
    {
        public DbSet<EmailModel>? Email { get; set; }

        public DbContext(DbContextOptions options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbContext(DbContextOptions<DbContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VVUUKNK;Database=Pr;Trusted_Connection=True;");
        }
    }


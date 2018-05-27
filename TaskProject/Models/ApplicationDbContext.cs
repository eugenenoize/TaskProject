﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskProject.Models;

namespace TaskProject.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Complication> Complications { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Atribute> Atributes { get; set; }
        public DbSet<Repeat> Repeats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Aligment> Aligments { get; set; }
        public DbSet<Mood> Moods { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //builder.Entity<ApplicationUser>(entity =>
            //{
            //    entity.ToTable(name: "AspNetUser", schema: "Security");
            //    entity.Property(e => e.Id).HasColumnName("UserId");
            //});
        }

        public DbSet<TaskProject.Models.Note> Note { get; set; }
    }
}

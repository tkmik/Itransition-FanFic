using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataAccess.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Capability> Capability { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<FanFic> FanFic { get; set; }
        public DbSet<FanFicTopic> FanFicTopic { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserCapability> UserCapability { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {   }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

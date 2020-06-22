using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ContactBook.Domain.Entities;

namespace ContactBook.Domain.Context
{
    public class AppContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupContact> ContactGroups { get; set; }

        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupContact>().HasKey(cg => new { cg.ContactId, cg.GroupId });
            base.OnModelCreating(modelBuilder);
        }
    }
}

﻿using HKQTravellingAuthenication.Models;
using HKQTravellingAuthenication.Models.Blog;
using HKQTravellingAuthenication.Models.Contact;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HKQTravellingAuthenication.Data
{
    //HKQTravellingAuthenication.Data.ApplicationDbContext
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            // Bỏ tiền tố AspNet của các bảng: mặc định
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            // Tạo Index cho cột Slug bảng Category
            builder.Entity<Category>(entity =>
            {
                entity.HasIndex(p => p.Slug);
            });
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { set; get; }
    }
}

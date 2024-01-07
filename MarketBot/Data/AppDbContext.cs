﻿using Microsoft.EntityFrameworkCore;
using ProductManagerBot.Data.Entities;

namespace ProductManagerBot.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<FavoriteProduct> FavoriteProducts => Set<FavoriteProduct>();
        public DbSet<Manufacture> Manufactures => Set<Manufacture>();
        public DbSet<Product> Products => Set<Product>();
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            base.OnConfiguring(opt);
            opt.UseSqlite("Data Source=../../../medb.db");
        }
    }
}

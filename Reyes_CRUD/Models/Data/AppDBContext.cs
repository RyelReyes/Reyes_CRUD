using Microsoft.EntityFrameworkCore;
using System;
using Reyes_CRUD.Models.Domain;

namespace Reyes_CRUD.Models.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Product> Product => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}
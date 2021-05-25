using BackNexos.Infrastructure.Entities;
using BackNexos.Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackNexos.Infrastructure
{
    public class DBContext: DbContext, IDBContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<AuthorEntity> author { get; set; }
        public DbSet<EditorialEntity> editorial { get; set; }
        public DbSet<BookEntity> book { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AuthorEntityConfig.SetEntityBuilder(modelBuilder.Entity<AuthorEntity>());
            BookEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookEntity>());
            EditorialEntityConfig.SetEntityBuilder(modelBuilder.Entity<EditorialEntity>());
            base.OnModelCreating(modelBuilder);
        }
    }
}

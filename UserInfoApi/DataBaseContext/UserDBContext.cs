using System;
using Microsoft.EntityFrameworkCore;
using UserInfoApi.Models;

namespace UserInfoApi.DataBaseContext
{
    public class UserDBContext:DbContext
    {
        public UserDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
        }

        public DbSet<UserDetails> UserInfoDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetDefaultTableName());
            }
        }
    }
}

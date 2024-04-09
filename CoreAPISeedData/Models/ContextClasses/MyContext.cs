using CoreAPISeedData.Extensions;
using CoreAPISeedData.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAPISeedData.Models.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public DbSet<Category> Categories { get; set; }
    }
}

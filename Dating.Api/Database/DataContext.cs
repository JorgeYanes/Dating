using System.Reflection;
using Dating.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dating.Api.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
using System.Reflection;
using FifthExamSimulationFiruz.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace FifthExamSimulationFiruz.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Event> Events { get; set; }

        public DbSet<Location>Locations { get; set; }
    }
}

using Dresses.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dresses.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Dress> Dresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Dresses");
        }
    }
}

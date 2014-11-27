using Poetry.DomainModels;
using System.Data.Entity;

namespace Mvc4WebApplication.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Poet> Poets { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
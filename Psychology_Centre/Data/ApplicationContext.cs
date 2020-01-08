using Microsoft.EntityFrameworkCore;
using Psychology_Centre.Models;

namespace Psychology_Centre.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}

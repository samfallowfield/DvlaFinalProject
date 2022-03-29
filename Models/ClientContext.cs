using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace DvlaProject.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; } = null!;
    }
}
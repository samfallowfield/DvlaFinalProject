using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System;
using DvlaProject.Models;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;



namespace DvlaProject.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options) {}
        public DbSet<Client> Clients => Set<Client>();
        

        
    }
}
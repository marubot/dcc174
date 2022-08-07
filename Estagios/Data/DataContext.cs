using Estagios.Models;
using Microsoft.EntityFrameworkCore;

namespace Estagios.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Estagio> Estagios { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

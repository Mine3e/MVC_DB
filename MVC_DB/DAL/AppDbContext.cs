using Microsoft.EntityFrameworkCore;
using MVC_DB.Models;

namespace MVC_DB.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<CS> Cses { get; set; }
        public DbSet<Works> Works { get; set; }
    }
}

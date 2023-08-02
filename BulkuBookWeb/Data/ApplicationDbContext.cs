using BulkuBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkuBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category>  Categories { get; set; }
    }
}

using AspGoat.Models;
using Microsoft.EntityFrameworkCore;

namespace AspGoat.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<EmailId> EmailIds { get; set; }
        public DbSet<User> Users { get; set; }   
    }
}

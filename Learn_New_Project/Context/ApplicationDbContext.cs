using Learn_New_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Learn_New_Project.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}

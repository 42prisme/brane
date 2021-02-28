using Microsoft.EntityFrameworkCore;
using brane.Models;

namespace brane
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {   
        }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
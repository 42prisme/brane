using Microsoft.EntityFrameworkCore;
using brane.Models;

namespace brane
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }
 
        public DbSet<TaskItem> TaskItems { get; set; }
        
        public DbSet<ExigenceItem> ExigenceItems { get; set; }
        
        public DbSet<JalonItem> JalonItems { get; set; }
        
        public DbSet<ProjectItem> ProjectItems { get; set; }
        
        public DbSet<User> Users { get; set; }
        
    }
}
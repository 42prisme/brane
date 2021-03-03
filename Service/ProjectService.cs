using System.Collections.Generic;
using System.Linq;
using brane.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace brane.Service
{
    public class ProjectService : IProjectService
    {
        private readonly ILogger<ProjectService> _logger;
        private readonly MyDbContext _context;
        
        public ProjectService(MyDbContext context, ILogger<ProjectService> logger)
        {
            _logger = logger;
            _context = context;
        }

        public ProjectItem GetOne(int id)
        {
            // throw new System.NotImplementedException();
            return _context.ProjectItems.Find(id);
        }

        public List<ProjectItem> GetIn()
        {
            throw new System.NotImplementedException();
        }

        public List<ProjectItem> GetAll()
        {
            // _logger.Log(LogLevel.Warning,"add project Item Man");
            return _context.ProjectItems.ToList();
        }

        public void Add(ProjectItem item)
        {
            _context.ProjectItems.Add(item);
            _context.SaveChanges();
        }

        public void Edit(ProjectItem item)
        {
            _context.ProjectItems.Update(item);
            _context.SaveChanges();
        }

        public void Delete(ProjectItem item)
        {
            _context.ProjectItems.Remove(item);
            _context.SaveChanges();
        }
    }
}
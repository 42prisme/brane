using System;
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
            
            //DEBUG
            // seeder sed = new seeder(_context);
            // sed.populate_One();
        }

        public ProjectItem GetOne(int id)
        {
            return _context.ProjectItems.Find(id);
        }

        public List<ProjectItem> GetIn()
        {
            throw new System.NotImplementedException();
        }

        public List<ProjectItem> GetAll(int id)
        {
            return _context.ProjectItems.ToList();
        }

        public void Add(ProjectItem item)
        {
            _logger.Log(LogLevel.Information, "Add ProjectItem");
            _context.ProjectItems.Add(item);
            _context.SaveChanges();
        }

        public void Edit(ProjectItem item)
        {
            //check if exists with id
            if (_context.ProjectItems.Find(item.Id).Id != item.Id) return;
            _context.ProjectItems.Update(item);
            _context.SaveChanges();
        }

        public void Delete(ProjectItem item)
        {
            //remove if exists
            if (_context.ProjectItems.Find(item.Id).Id != item.Id) return;
            //cascade delete Jalon
            var jal_list = _context.JalonItems.Where(jalonItem => jalonItem.ProjectId == item.Id);
            foreach (var jalon in jal_list)
            {
                _context.JalonItems.Remove(jalon);
            }
            _context.ProjectItems.Remove(item);
            _context.SaveChanges();
        }
    }
}
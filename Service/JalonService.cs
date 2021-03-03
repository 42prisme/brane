using System.Collections.Generic;
using System.Linq;
using brane.Models;
using Microsoft.Extensions.Logging;

namespace brane.Service
{
    public class JalonService : IJalonService
    {
        private readonly ILogger<JalonService> _logger;
        private readonly MyDbContext _context;
        public JalonService(MyDbContext context, ILogger<JalonService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public JalonItem GetOne(int id)
        {
            return _context.JalonItems.Find(id);
        }

        public List<JalonItem> GetIn()
        {
            throw new System.NotImplementedException();
        }

        public List<JalonItem> GetAll(int projectId)
        {
            return _context.JalonItems.Where(project => project.ProjectId == projectId).ToList();
        }

        public void Add(JalonItem item)
        {
            if (item.Assignee.Id == 0) return;
            if (_context.ProjectItems.Find(item.ProjectId).GetType() == typeof(ProjectItem)) return;

            item.AssigneeId = item.Assignee.Id;

            _context.JalonItems.Add(item);
            _context.SaveChanges();
        }

        public void Edit(JalonItem item)
        {
            if(_context.JalonItems.Find(item.Id).GetType() != typeof(JalonItem)) return;
            
            _context.JalonItems.Update(item);
            _context.SaveChanges();
        }

        public void Delete(JalonItem item)
        {
            //if exists
            if(_context.JalonItems.Find(item.Id).GetType() != typeof(JalonItem)) return;
            //cascade delete
            var tsk_list = _context.TaskItems.Where(tsk => tsk.JalonId == item.Id);
            foreach (var task in tsk_list)
            {
                _context.TaskItems.Remove(task);
            }

            var exigenceLst = _context.ExigenceItems.Where(exi => exi.ProjectId == item.Id);
            foreach (var exi in exigenceLst)
            {
                _context.ExigenceItems.Remove(exi);
            }
            _context.JalonItems.Remove(item);
            _context.SaveChanges();
        }
    }
}
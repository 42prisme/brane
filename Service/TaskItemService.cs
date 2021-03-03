using System.Collections.Generic;
using System.Linq;
using brane.Models;
using Microsoft.Extensions.Logging;

namespace brane.Service
{
    public class TaskItemService : ITaskItemService
    {
        private readonly ILogger<TaskItemService> _logger;
        private readonly MyDbContext _context;
        public TaskItemService(MyDbContext context, ILogger<TaskItemService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public TaskItem GetOne(int id)
        {
            return _context.TaskItems.Find(id);
        }

        public List<TaskItem> GetIn()
        {
            throw new System.NotImplementedException();
        }

        public List<TaskItem> GetAll(int jalonId)
        {
            return _context.TaskItems.Where(taskItem => taskItem.JalonId == jalonId).ToList();
        }

        public void Add(TaskItem item)
        {
            //exigence + jalon exist
            if (_context.ExigenceItems.Find(item.ExigencesId).GetType() != typeof(ExigenceItem))
            {
                _logger.Log(LogLevel.Information, "man that is not an exigence ");
                // return;  // maybe you don't nee exigence to make a jalon
            }
            
            if (_context.JalonItems.Find(item.JalonId).GetType() != typeof(JalonItem))
            {
                _logger.Log(LogLevel.Information, "man that is not a Jalon ");
                return;
            }
            
            _context.TaskItems.Add(item);
            _context.SaveChanges();
        }

        public void Edit(TaskItem item)
        {
            _context.TaskItems.Update(item);
            _context.SaveChanges();
        }

        public void Delete(TaskItem item)
        {
            _context.TaskItems.Remove(item);
            _context.SaveChanges();
        }
    }
}
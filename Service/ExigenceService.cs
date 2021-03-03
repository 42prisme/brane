using System.Collections.Generic;
using System.Linq;
using brane.Models;
using Microsoft.Extensions.Logging;

namespace brane.Service
{
    public class ExigenceService : IExigenceService
    {
        private readonly ILogger<ExigenceService> _logger;
        private readonly MyDbContext _context;

        public ExigenceService(MyDbContext context, ILogger<ExigenceService> logger)
        {
            _logger = logger;
            _context = context;
        }

        public ExigenceItem GetOne(int id)
        {
            return _context.ExigenceItems.Find(id);
        }

        public List<ExigenceItem> GetIn()
        {
            throw new System.NotImplementedException();
        }

        public List<ExigenceItem> GetAll()
        {
            return _context.ExigenceItems.ToList();
        }

        public void Add(ExigenceItem item)
        {
            _context.ExigenceItems.Add(item);
            _context.SaveChanges();
        }

        public void Edit(ExigenceItem item)
        {
            _context.ExigenceItems.Update(item);
            _context.SaveChanges();
        }

        public void Delete(ExigenceItem item)
        {
            _context.ExigenceItems.Remove(item);
            _context.SaveChanges();
        }
    }
}
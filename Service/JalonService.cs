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

        public List<JalonItem> GetAll()
        {
            return _context.JalonItems.ToList();
        }

        public void Add(JalonItem item)
        {
            _context.JalonItems.Add(item);
            _context.SaveChanges();
        }

        public void Edit(JalonItem item)
        {
            _context.JalonItems.Update(item);
            _context.SaveChanges();
        }

        public void Delete(JalonItem item)
        {
            _context.JalonItems.Remove(item);
            _context.SaveChanges();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using brane.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace brane.Controllers
{
    public class ExigenceItemController : Controller
    {
        private readonly ILogger<ExigenceItemController> _logger;
        
        private readonly MyDbContext _context;

        public ExigenceItemController(ILogger<ExigenceItemController> logger)
        {
            _logger = logger;
            // _context = context;
        }
        
        // GET
        // public Task<ActionResult<IEnumerable<TaskItem>>> Index()
        // {
        //     return await;
        // }
    }
}
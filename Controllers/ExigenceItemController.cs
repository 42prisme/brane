using System.Collections.Generic;
using System.Threading.Tasks;
using brane.Models;
using brane.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace brane.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExigenceItemController : Controller
    {
        private readonly ILogger<ExigenceItemController> _logger;
        private readonly IExigenceService _service;

        public ExigenceItemController(ILogger<ExigenceItemController> logger, IExigenceService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("all")]
        public List<ExigenceItem> GetAll()
        {
            return _service.GetAll();
        }
    }
}
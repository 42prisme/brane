using System.Collections.Generic;
using brane.Models;
using brane.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace brane.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JalonItemController : Controller
    {
        private readonly ILogger<ExigenceItemController> _logger;
        private readonly IJalonService _JalonService;
        
        public JalonItemController(ILogger<ExigenceItemController> logger, IJalonService JalonService)
        {
            _logger = logger;
            _JalonService = JalonService;
        }

        [HttpGet("all")]
        public List<JalonItem> GetAll()
        {
            return _JalonService.GetAll();
        }
    }
}
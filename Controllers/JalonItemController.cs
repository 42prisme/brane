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
        
        [HttpGet("{id}")]
        public JalonItem Get(int id)
        {
            return _JalonService.GetOne(id);
        }

        [HttpGet("all/{projectId}")]
        public List<JalonItem> GetAll(int projectId)
        {
            return _JalonService.GetAll(projectId);
        }
        
        [HttpPost("add")]
        public void Add(JalonItem item)
        {
            _JalonService.Add(item);
        }

        [HttpPost("update")]
        public void Update(JalonItem item)
        {
            _JalonService.Edit(item);
        }

        [HttpDelete]
        public void Delete(JalonItem item)
        {
            _JalonService.Delete(item);
        }
    }
}
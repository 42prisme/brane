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
    public class ProjectItemController : Controller
    {
        
        private readonly ILogger<ProjectItemController> _logger;
        private readonly IProjectService _projectService;
        
        public ProjectItemController(ILogger<ProjectItemController> logger, IProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }

        [HttpGet("all")]
        public List<ProjectItem> GetAll()
        {
            return _projectService.GetAll();
        }
    }
}
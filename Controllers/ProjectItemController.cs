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

        [HttpGet("{id}")]
        public ProjectItem Get(int id)
        {
            return _projectService.GetOne(id);
        }
        
        [HttpGet("all")]
        public List<ProjectItem> GetAll()
        {
            return _projectService.GetAll();
        }
        
        [HttpPost("add")]
        public void Add(ProjectItem item)
        {
            _projectService.Add(item);
        }

        [HttpPost("update")]
        public void Update(ProjectItem item)
        {
            _projectService.Edit(item);
        }

        [HttpDelete]
        public void Delete(ProjectItem item)
        {
            _projectService.Delete(item);
        }
    }
}
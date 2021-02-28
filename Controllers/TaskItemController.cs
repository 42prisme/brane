using System.Collections.Generic;
using brane.Models;
using brane.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace brane.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskItemController : Controller
    {
        private readonly ILogger<TaskItemController> _logger;
        private readonly ITaskItemService _TaskService;

        public TaskItemController(ILogger<TaskItemController> logger, ITaskItemService taskService)
        {
            _logger = logger;
            _TaskService = taskService;
        }

        [HttpGet("all")]
        public List<TaskItem> GetAll()
        {
            return _TaskService.GetAll();
        }
    }
}
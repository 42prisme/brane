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
        
        [HttpGet("{id}")]
        public TaskItem Get(int id)
        {
            return _TaskService.GetOne(id);
        }
        
        [HttpGet("all")]
        public List<TaskItem> GetAll()
        {
            return _TaskService.GetAll();
        }
        
        [HttpPost("add")]
        public void Add(TaskItem item)
        {
            _TaskService.Add(item);
        }

        [HttpPost("update")]
        public void Update(TaskItem item)
        {
            _TaskService.Edit(item);
        }

        [HttpDelete]
        public void Delete(TaskItem item)
        {
            _TaskService.Delete(item);
        }
    }
}
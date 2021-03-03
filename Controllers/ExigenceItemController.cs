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

        [HttpGet("{id}")]
        public ExigenceItem Get(int id)
        {
            return _service.GetOne(id);
        }

        //get amongst
        
        [HttpGet("all")]
        public List<ExigenceItem> GetAll()
        {
            return _service.GetAll();
        }

        [HttpPost("add")]
        public void Add(ExigenceItem item)
        {
            _service.Add(item);
        }

        [HttpPost("update")]
        public void Update(ExigenceItem item)
        {
            _service.Edit(item);
        }

        [HttpDelete]
        public void Delete(ExigenceItem item)
        {
            _service.Delete(item);
        }
    }
}
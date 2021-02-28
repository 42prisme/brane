using System.Collections.Generic;
using brane.Models;
using brane.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace brane.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserItemController : Controller
    {
        private readonly ILogger<UserItemController> _logger;
        private readonly IUserService _UserService;
        
        public UserItemController(ILogger<UserItemController> logger, IUserService projectService)
        {
            _logger = logger;
            _UserService = projectService;
        }

        [HttpGet("all")]
        public List<User> GetAll()
        {
            return _UserService.GetAll();
        }
    }
}
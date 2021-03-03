using System;
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
        private readonly IUserService _userService;
        
        public UserItemController(ILogger<UserItemController> logger, IUserService projectService)
        {
            _logger = logger;
            _userService = projectService;
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetOne(id);
        }

        //get amongst
        
        [HttpGet("all")]
        public List<User> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpPost("add")]
        public void Add(User user)
        {
            _userService.Add(user);
        }

        [HttpPost("update")]
        public void Update(User user)
        {
            _userService.Edit(user);
        }

        [HttpDelete]
        public void Delete(User user)
        {
            _userService.Delete(user);
        }
    }
}
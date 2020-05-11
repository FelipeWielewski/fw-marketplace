using FW.Marketplace.Interfaces;
using FW.Marketplace.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FW.Marketplace.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        readonly IUserService _userService;
                
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.GetAsync();   
            return Ok(users);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetById([FromQuery] Guid userId)
        {
            var user = await _userService.GetByIdAsync(userId);
            return Ok(user);
        }


        [HttpPut("{userId}")]
        public async Task<IActionResult> Update([FromQuery] Guid userId, [FromBody]UserViewModel model)
        {
            await _userService.UpdateAsync(userId, model);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateUserViewModel model)
        {
            var user = await _userService.CreateAsync(model);
            return Ok(user);
        }
        
        [HttpPut("{userId}/changepassword")]
        public async Task<IActionResult> UpdatePassword([FromQuery] Guid userId, [FromQuery] string newPassword)
        {
            await _userService.UpdatePasswordAsync(userId, newPassword);
            return Ok();
        }

    }
}

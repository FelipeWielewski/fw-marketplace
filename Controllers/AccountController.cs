using FW.Marketplace.Interfaces;
using FW.Marketplace.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FW.Marketplace.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]LoginViewModel model)
        {
            var result = await _accountService.LoginAsync(model);
            return Ok(result);
        }
    }
}

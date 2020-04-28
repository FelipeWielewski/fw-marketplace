using FW.Marketplace.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FW.Marketplace.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {

        //TO-DO: Injetar serviços
        public AccountController()
        {
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginViewModel model)
        {
            //TO-DO: codigo para implementar login
            return Ok();
        }
    }
}

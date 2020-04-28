using FW.Marketplace.Model;
using FW.Marketplace.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FW.Marketplace.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {

        //TO-DO: Injetar serviços
        public UserController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            //TO-DO: codigo para obter lista de usuarios
            return Ok();
        }

        [HttpGet("{userId}")]
        public IActionResult GetById([FromQuery] string userId)
        {
            //TO-DO: codigo para obter usuario especifico
            return Ok(userId);
        }

        [HttpPut("{buyerId}")]
        public IActionResult Update([FromQuery] string userId, [FromBody]UserViewModel model)
        {
            //TO-DO: codigo para atualizar usuario
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody]CreateUserViewModel model)
        {
            //TO-DO: codigo para criar usuario
            return Ok(model);
        }

        [HttpPut("{buyerid}/changepassword")]
        public IActionResult UpdatePassword([FromQuery] string userId, [FromQuery] string newPassword)
        {
            //TO-DO: codigo para alterar a senha do usuario
            return Ok();
        }

    }
}

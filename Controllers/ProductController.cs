using FW.Marketplace.Model;
using FW.Marketplace.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FW.Marketplace.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        //TO-DO: Injetar serviços
        public ProductController()
        {
        }
        
        [HttpGet("{productId}")]
        public IActionResult GetById([FromQuery] string productId)
        {
            //TO-DO: codigo para obter um produto especifico
            return Ok(productId);
        }

        //ALERTA PARA GETS IGUAIS
        [HttpGet("user/{userId}")]
        public IActionResult GetByUserId([FromQuery] string userId)
        {
            //TO-DO: codigo para obter produtos de um usuario
            return Ok(userId);
        }

        [HttpPut("{productId}")]
        public IActionResult Update([FromQuery] string productId, [FromBody]ProductViewModel model)
        {
            //TO-DO: codigo para atualizar produto
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody]ProductViewModel model)
        {
            //TO-DO: codigo para criar produto
            return Ok(model);
        }

    }
}

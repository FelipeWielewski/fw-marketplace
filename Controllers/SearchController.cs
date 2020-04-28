using FW.Marketplace.Model;
using FW.Marketplace.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FW.Marketplace.Controllers
{
    [Route("[controller]")]
    public class SearchController : Controller
    {

        //TO-DO: Injetar serviços
        public SearchController()
        {
        }

        [HttpGet("fromquery")]
        public IActionResult SearchByQuery([FromQuery]string text, [FromQuery]int page, [FromQuery]int size)
        {
            //TO-DO: codigo para obter lista de produtos com base em uma query
            return Ok();
        }
    }
}

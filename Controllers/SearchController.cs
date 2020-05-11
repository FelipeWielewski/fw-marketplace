using FW.Marketplace.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FW.Marketplace.Controllers
{
    [Route("[controller]")]
    public class SearchController : Controller
    {
        ISearchService _searchService;
        
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("fromquery")]
        public async Task<IActionResult> SearchByQuery([FromQuery]string text, [FromQuery]int page, [FromQuery]int size)
        {
            var result = await _searchService.SearchByQueryAsync(text, page, size);
            return Ok(result);
        }
    }
}

using FW.Marketplace.Interfaces;
using FW.Marketplace.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FW.Marketplace.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById([FromQuery] Guid productId)
        {
            var product = await _productService.GetByIdAsync(productId);
            return Ok(product);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUserId([FromQuery] Guid userId)
        {
            var products = await _productService.GetByUserIdAsync(userId);
            return Ok(products);
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> Update([FromQuery] Guid productId, [FromBody]ProductViewModel model)
        {
            await _productService.UpdateAsync(productId, model);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ProductViewModel model)
        {
            var product = await _productService.CreateAsync(model);
            return Ok(product);
        }

    }
}

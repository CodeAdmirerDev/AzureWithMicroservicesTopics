using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new[]
            {
                      new { Id = 1, Name = "Dell Laptop" },
                      new { Id = 2, Name = "Oneplus SmartPhone" }
                  };
            return Ok(products);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                    new { Id = 1, Name = "Suri" },
                    new { Id = 2, Name = "Mouni" }
                };
            return Ok(users);
        }
    }
}

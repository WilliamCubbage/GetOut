using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var result = new { Name = "Your Name" }; // Replace "Your Name" with your actual name
            return Ok(result);
        }
    }
}

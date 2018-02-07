using Microsoft.AspNetCore.Mvc;

namespace HttpPostExceptionTest.Controllers
{
    [Route("api/[controller]")]
    public class DebugController : Controller
    {
        
        
        [HttpGet("error")]
        [HttpPost("error")]
        [HttpDelete("error")]
        [HttpOptions("error")]
        public IActionResult Index()
        {
            return StatusCode(500,"Hello, World! From debug controller");
        }
    }
}
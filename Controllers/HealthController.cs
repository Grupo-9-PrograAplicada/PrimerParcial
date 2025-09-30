using Microsoft.AspNetCore.Mvc;

namespace ExamenParcialAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet("/ping")]
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}
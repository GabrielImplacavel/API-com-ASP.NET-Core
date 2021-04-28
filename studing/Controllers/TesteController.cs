using Microsoft.AspNetCore.Mvc;

namespace studing.Controllers
{
    public class TesteController : Controller
    {
        [HttpGet("testing")]
        public IActionResult Teste()
        {
            return Ok("This API is working");
        }
    }
}
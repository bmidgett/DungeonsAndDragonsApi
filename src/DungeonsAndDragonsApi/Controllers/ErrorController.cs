using Microsoft.AspNetCore.Mvc;

namespace DungeonsAndDragonsApi.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        [Route("/error")]
        public IActionResult Error() => Problem();
    }
}

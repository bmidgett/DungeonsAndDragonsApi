using DungeonsAndDragonsApi.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DungeonsAndDragonsApi.Controllers
{
    [ApiController]
    [Route("api/v1/classes")]
    public class ClassController : ControllerBase
    {
        private readonly ILogger<ClassController> _logger;
        private readonly I5eDataService _service;

        public ClassController(I5eDataService service, ILogger<ClassController> logger)
        {
            (_logger, _service) = (logger, service);
        }

        [HttpGet]
        public async Task<ActionResult> GetClasses()
        {
            _logger.LogInformation("Getting classes");

            var results = await _service.GetClasses();

            return Ok(results);
        }
    }
}

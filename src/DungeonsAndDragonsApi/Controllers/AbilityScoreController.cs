using DungeonsAndDragonsApi.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DungeonsAndDragonsApi.Controllers
{
    [ApiController]
    [Route("api/v1/ability-scores")]
    public class AbilityScoreController : ControllerBase
    {
        private readonly ILogger<AbilityScoreController> _logger;
        private readonly I5eDataService _service;

        public AbilityScoreController(I5eDataService service, ILogger<AbilityScoreController> logger)
        {
            (_logger, _service) = (logger, service);
        }

        [HttpGet("{index}")]
        public async Task<ActionResult> GetAbilityScore(string index)
        {
            _logger.LogInformation("Getting ability score");

            var results = await _service.GetAbilityScore(index);

            return Ok(results);
        }

        [HttpGet]
        public async Task<ActionResult> GetAbilityScores()
        {
            _logger.LogInformation("Getting ability scores");

            var results = await _service.GetAbilityScores();

            return Ok(results);
        }
    }
}

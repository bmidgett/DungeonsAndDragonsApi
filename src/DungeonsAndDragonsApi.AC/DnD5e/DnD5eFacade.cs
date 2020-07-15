using DungeonsAndDragonsApi.AC.DnD5e.DTOs;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace DungeonsAndDragonsApi.AC.DnD5e
{
    public class DnD5eFacade : IDnD5eFacade
    {
        private readonly ILogger<DnD5eFacade> _logger;
        private readonly HttpClient _httpClient;

        public DnD5eFacade(ILogger<DnD5eFacade> logger, HttpClient httpClient)
        {

            (_httpClient, _logger) = (httpClient, logger);
        }

        public async Task<DnD5eAbilityScore> GetAbilityScore(string index)
        {
            var uri = URIs.GetAbilityScore(index);

            var response = await _httpClient.GetAsync(uri);

            _logger.LogInformation("HTTP response: {@Response}", response.Content);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<DnD5eAbilityScore>();
        }

        public async Task<DnD5eResponseDto<DnD5eNamedApiResourceDto>> GetAbilityScores()
        {
            var uri = URIs.AbilityScoreEndpoint;

            var response = await _httpClient.GetAsync(uri);

            _logger.LogInformation("HTTP response: {@Response}", response.Content);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<DnD5eResponseDto<DnD5eNamedApiResourceDto>>();
        }

        public async Task<DnD5eResponseDto<DnD5eNamedApiResourceDto>> GetClasses()
        {
            var uri = URIs.ClassEndpoint;

            var response = await _httpClient.GetAsync(uri);

            _logger.LogInformation("HTTP response: {@Response}", response.Content);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<DnD5eResponseDto<DnD5eNamedApiResourceDto>>();
        }
    }
}

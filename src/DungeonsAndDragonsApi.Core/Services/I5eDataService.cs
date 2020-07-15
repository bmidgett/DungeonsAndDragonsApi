using DungeonsAndDragonsApi.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DungeonsAndDragonsApi.Core.Services
{
    public interface I5eDataService
    {
        Task<AbilityScoreDto> GetAbilityScore(string index);
        Task<IEnumerable<NamedApiResourceDto>> GetAbilityScores();
        Task<IEnumerable<NamedApiResourceDto>> GetClasses();
    }
}

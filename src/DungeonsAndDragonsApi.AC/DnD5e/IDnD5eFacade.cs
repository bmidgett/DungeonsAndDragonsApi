using DungeonsAndDragonsApi.AC.DnD5e.DTOs;
using System.Threading.Tasks;

namespace DungeonsAndDragonsApi.AC.DnD5e
{
    public interface IDnD5eFacade
    {
        Task<DnD5eResponseDto<DnD5eNamedApiResourceDto>> GetAbilityScores();
        Task<DnD5eAbilityScore> GetAbilityScore(string index);
        Task<DnD5eResponseDto<DnD5eNamedApiResourceDto>> GetClasses();
    }
}

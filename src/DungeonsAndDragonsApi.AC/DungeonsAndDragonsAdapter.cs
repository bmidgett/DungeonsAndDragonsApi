using DungeonsAndDragonsApi.AC.DnD5e;
using DungeonsAndDragonsApi.AC.DnD5e.DTOs;
using DungeonsAndDragonsApi.Core.DTOs;
using DungeonsAndDragonsApi.Core.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonsAndDragonsApi.AC
{
    public class DungeonsAndDragonsAdapter : I5eDataService
    {
        private readonly IDnD5eFacade _dnD5EFacade;

        public DungeonsAndDragonsAdapter(IDnD5eFacade dnD5EFacade)
        {
            _dnD5EFacade = dnD5EFacade;
        }

        public async Task<AbilityScoreDto> GetAbilityScore(string index)
        {
            var response = await _dnD5EFacade.GetAbilityScore(index);

            return MapAbilityScore(response);
        }

        public async Task<IEnumerable<NamedApiResourceDto>> GetAbilityScores()
        {
            var response = await _dnD5EFacade.GetAbilityScores();

            return (from result in response.results
                    select MapResourceDto(result));
        }

        public async Task<IEnumerable<NamedApiResourceDto>> GetClasses()
        {
            var response = await _dnD5EFacade.GetClasses();

            return (from result in response.results
                    select MapResourceDto(result));
        }

        private AbilityScoreDto MapAbilityScore(DnD5eAbilityScore dto)
        {
            return new AbilityScoreDto()
            {
                Desc = dto.desc,
                FullName = dto.full_name,
                Index = dto.index,
                Skills = (from skill in dto.skills 
                          select MapResourceDto(skill)),
                Url = dto.url
            };
        }

        private NamedApiResourceDto MapResourceDto(DnD5eNamedApiResourceDto dto)
        {
            return new NamedApiResourceDto()
            {
                Index = dto.index,
                Name = dto.name,
                Url = dto.url
            };
        }
    }
}

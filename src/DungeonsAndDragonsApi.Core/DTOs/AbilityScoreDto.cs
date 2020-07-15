using System.Collections.Generic;

namespace DungeonsAndDragonsApi.Core.DTOs
{
    public class AbilityScoreDto
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public IEnumerable<string> Desc { get; set; }
        public IEnumerable<NamedApiResourceDto> Skills { get; set; }
        public string Url { get; set; }
    }
}

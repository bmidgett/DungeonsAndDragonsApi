using System.Collections.Generic;

namespace DungeonsAndDragonsApi.AC.DnD5e.DTOs
{
    public class DnD5eAbilityScore
    {
        public string index { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public IEnumerable<string> desc { get; set; }
        public IEnumerable<DnD5eNamedApiResourceDto> skills { get; set; }
        public string url { get; set; }
    }
}

using System.Collections.Generic;

namespace DungeonsAndDragonsApi.AC.DnD5e.DTOs
{
    public class DnD5eResponseDto<T>
    {
        public int count { get; set; }
        public IEnumerable<T> results { get; set; }
    }
}

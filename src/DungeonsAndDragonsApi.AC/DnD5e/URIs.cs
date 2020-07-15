namespace DungeonsAndDragonsApi.AC.DnD5e
{
    public static class URIs
    {
        public const string AbilityScoreEndpoint = "ability-scores";
        public const string ClassEndpoint = "classes";

        public static string GetAbilityScore(string index)
        {
            return $"{AbilityScoreEndpoint}/{index}";
        }
    }
}

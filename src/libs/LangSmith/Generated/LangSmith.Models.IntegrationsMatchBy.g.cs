
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationsMatchBy
    {
        /// <summary>
        /// 
        /// </summary>
        MatchByID,
        /// <summary>
        /// 
        /// </summary>
        MatchByKind,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationsMatchByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationsMatchBy value)
        {
            return value switch
            {
                IntegrationsMatchBy.MatchByID => "id",
                IntegrationsMatchBy.MatchByKind => "kind",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationsMatchBy? ToEnum(string value)
        {
            return value switch
            {
                "id" => IntegrationsMatchBy.MatchByID,
                "kind" => IntegrationsMatchBy.MatchByKind,
                _ => null,
            };
        }
    }
}
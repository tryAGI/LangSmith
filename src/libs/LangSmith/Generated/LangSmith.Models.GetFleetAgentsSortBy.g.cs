
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: updated_at
    /// </summary>
    public enum GetFleetAgentsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFleetAgentsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFleetAgentsSortBy value)
        {
            return value switch
            {
                GetFleetAgentsSortBy.CreatedAt => "created_at",
                GetFleetAgentsSortBy.Name => "name",
                GetFleetAgentsSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFleetAgentsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetFleetAgentsSortBy.CreatedAt,
                "name" => GetFleetAgentsSortBy.Name,
                "updated_at" => GetFleetAgentsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}
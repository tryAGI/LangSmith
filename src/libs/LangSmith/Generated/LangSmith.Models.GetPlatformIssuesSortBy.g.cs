
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPlatformIssuesSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        LastSeen,
        /// <summary>
        ///
        /// </summary>
        LastUpdated,
        /// <summary>
        ///
        /// </summary>
        Severity,
        /// <summary>
        ///
        /// </summary>
        TraceCount,
        /// <summary>
        ///
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPlatformIssuesSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlatformIssuesSortBy value)
        {
            return value switch
            {
                GetPlatformIssuesSortBy.CreatedAt => "created_at",
                GetPlatformIssuesSortBy.Default => "default",
                GetPlatformIssuesSortBy.LastSeen => "last_seen",
                GetPlatformIssuesSortBy.LastUpdated => "last_updated",
                GetPlatformIssuesSortBy.Severity => "severity",
                GetPlatformIssuesSortBy.TraceCount => "trace_count",
                GetPlatformIssuesSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlatformIssuesSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetPlatformIssuesSortBy.CreatedAt,
                "default" => GetPlatformIssuesSortBy.Default,
                "last_seen" => GetPlatformIssuesSortBy.LastSeen,
                "last_updated" => GetPlatformIssuesSortBy.LastUpdated,
                "severity" => GetPlatformIssuesSortBy.Severity,
                "trace_count" => GetPlatformIssuesSortBy.TraceCount,
                "updated_at" => GetPlatformIssuesSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}
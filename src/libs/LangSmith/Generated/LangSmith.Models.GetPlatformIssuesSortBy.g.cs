
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
        Severity,
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
                GetPlatformIssuesSortBy.Severity => "severity",
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
                "severity" => GetPlatformIssuesSortBy.Severity,
                "updated_at" => GetPlatformIssuesSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}
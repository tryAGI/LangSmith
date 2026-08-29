
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPlatformIssuesStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Fixing,
        /// <summary>
        ///
        /// </summary>
        Ignored,
        /// <summary>
        ///
        /// </summary>
        Open,
        /// <summary>
        ///
        /// </summary>
        Watching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPlatformIssuesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlatformIssuesStatus value)
        {
            return value switch
            {
                GetPlatformIssuesStatus.Completed => "completed",
                GetPlatformIssuesStatus.Fixing => "fixing",
                GetPlatformIssuesStatus.Ignored => "ignored",
                GetPlatformIssuesStatus.Open => "open",
                GetPlatformIssuesStatus.Watching => "watching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlatformIssuesStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetPlatformIssuesStatus.Completed,
                "fixing" => GetPlatformIssuesStatus.Fixing,
                "ignored" => GetPlatformIssuesStatus.Ignored,
                "open" => GetPlatformIssuesStatus.Open,
                "watching" => GetPlatformIssuesStatus.Watching,
                _ => null,
            };
        }
    }
}
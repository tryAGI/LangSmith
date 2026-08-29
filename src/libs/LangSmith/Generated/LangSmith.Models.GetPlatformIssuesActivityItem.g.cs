
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPlatformIssuesActivityItem
    {
        /// <summary>
        ///
        /// </summary>
        Fixing,
        /// <summary>
        ///
        /// </summary>
        Recurred,
        /// <summary>
        ///
        /// </summary>
        Watching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPlatformIssuesActivityItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlatformIssuesActivityItem value)
        {
            return value switch
            {
                GetPlatformIssuesActivityItem.Fixing => "fixing",
                GetPlatformIssuesActivityItem.Recurred => "recurred",
                GetPlatformIssuesActivityItem.Watching => "watching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlatformIssuesActivityItem? ToEnum(string value)
        {
            return value switch
            {
                "fixing" => GetPlatformIssuesActivityItem.Fixing,
                "recurred" => GetPlatformIssuesActivityItem.Recurred,
                "watching" => GetPlatformIssuesActivityItem.Watching,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesStatus
    {
        /// <summary>
        ///
        /// </summary>
        StatusCompleted,
        /// <summary>
        ///
        /// </summary>
        StatusFixing,
        /// <summary>
        ///
        /// </summary>
        StatusIgnored,
        /// <summary>
        ///
        /// </summary>
        StatusOpen,
        /// <summary>
        ///
        /// </summary>
        StatusWatching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesStatus value)
        {
            return value switch
            {
                IssuesStatus.StatusCompleted => "completed",
                IssuesStatus.StatusFixing => "fixing",
                IssuesStatus.StatusIgnored => "ignored",
                IssuesStatus.StatusOpen => "open",
                IssuesStatus.StatusWatching => "watching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => IssuesStatus.StatusCompleted,
                "fixing" => IssuesStatus.StatusFixing,
                "ignored" => IssuesStatus.StatusIgnored,
                "open" => IssuesStatus.StatusOpen,
                "watching" => IssuesStatus.StatusWatching,
                _ => null,
            };
        }
    }
}
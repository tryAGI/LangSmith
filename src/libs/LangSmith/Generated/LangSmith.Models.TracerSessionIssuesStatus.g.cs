
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum TracerSessionIssuesStatus
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
    public static class TracerSessionIssuesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionIssuesStatus value)
        {
            return value switch
            {
                TracerSessionIssuesStatus.StatusCompleted => "completed",
                TracerSessionIssuesStatus.StatusFixing => "fixing",
                TracerSessionIssuesStatus.StatusIgnored => "ignored",
                TracerSessionIssuesStatus.StatusOpen => "open",
                TracerSessionIssuesStatus.StatusWatching => "watching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionIssuesStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TracerSessionIssuesStatus.StatusCompleted,
                "fixing" => TracerSessionIssuesStatus.StatusFixing,
                "ignored" => TracerSessionIssuesStatus.StatusIgnored,
                "open" => TracerSessionIssuesStatus.StatusOpen,
                "watching" => TracerSessionIssuesStatus.StatusWatching,
                _ => null,
            };
        }
    }
}
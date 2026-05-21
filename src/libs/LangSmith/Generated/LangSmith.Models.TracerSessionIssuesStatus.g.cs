
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
        StatusIgnored,
        /// <summary>
        /// 
        /// </summary>
        StatusOpen,
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
                TracerSessionIssuesStatus.StatusIgnored => "ignored",
                TracerSessionIssuesStatus.StatusOpen => "open",
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
                "ignored" => TracerSessionIssuesStatus.StatusIgnored,
                "open" => TracerSessionIssuesStatus.StatusOpen,
                _ => null,
            };
        }
    }
}
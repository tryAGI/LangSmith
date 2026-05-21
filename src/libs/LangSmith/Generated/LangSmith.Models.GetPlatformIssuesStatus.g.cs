
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
        Ignored,
        /// <summary>
        /// 
        /// </summary>
        Open,
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
                GetPlatformIssuesStatus.Ignored => "ignored",
                GetPlatformIssuesStatus.Open => "open",
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
                "ignored" => GetPlatformIssuesStatus.Ignored,
                "open" => GetPlatformIssuesStatus.Open,
                _ => null,
            };
        }
    }
}
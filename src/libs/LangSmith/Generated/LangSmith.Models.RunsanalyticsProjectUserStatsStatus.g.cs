
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// StatsStatus is pending when no statistics group is available, or ready when<br/>
    /// statistics were returned. Ready statistics may still lag recent activity.<br/>
    /// Query again to retrieve statistics that were pending.
    /// </summary>
    public enum RunsanalyticsProjectUserStatsStatus
    {
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunsanalyticsProjectUserStatsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsanalyticsProjectUserStatsStatus value)
        {
            return value switch
            {
                RunsanalyticsProjectUserStatsStatus.Pending => "pending",
                RunsanalyticsProjectUserStatsStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsanalyticsProjectUserStatsStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => RunsanalyticsProjectUserStatsStatus.Pending,
                "ready" => RunsanalyticsProjectUserStatsStatus.Ready,
                _ => null,
            };
        }
    }
}
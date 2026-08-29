
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesLinearSyncState
    {
        /// <summary>
        ///
        /// </summary>
        AuthRequired,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Paused,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Synced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesLinearSyncStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesLinearSyncState value)
        {
            return value switch
            {
                IssuesLinearSyncState.AuthRequired => "auth_required",
                IssuesLinearSyncState.Failed => "failed",
                IssuesLinearSyncState.Paused => "paused",
                IssuesLinearSyncState.Pending => "pending",
                IssuesLinearSyncState.Synced => "synced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesLinearSyncState? ToEnum(string value)
        {
            return value switch
            {
                "auth_required" => IssuesLinearSyncState.AuthRequired,
                "failed" => IssuesLinearSyncState.Failed,
                "paused" => IssuesLinearSyncState.Paused,
                "pending" => IssuesLinearSyncState.Pending,
                "synced" => IssuesLinearSyncState.Synced,
                _ => null,
            };
        }
    }
}
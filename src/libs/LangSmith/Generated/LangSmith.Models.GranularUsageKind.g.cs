
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Which billable usage domain a granular-usage query targets.<br/>
    /// - `traces`: trace counts.<br/>
    /// - `langsmith_deployments`: LangSmith Deployment metrics (nodes executed,<br/>
    ///   agent runs, agent uptime).<br/>
    /// Default is `traces` for backward compatibility — existing callers of<br/>
    /// `GET /granular-usage` without a `kind` query param get the same<br/>
    /// response shape they always did.
    /// </summary>
    public enum GranularUsageKind
    {
        /// <summary>
        /// LangSmith Deployment metrics (nodes executed,
        /// </summary>
        LangsmithDeployments,
        /// <summary>
        /// trace counts.
        /// </summary>
        Traces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GranularUsageKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GranularUsageKind value)
        {
            return value switch
            {
                GranularUsageKind.LangsmithDeployments => "langsmith_deployments",
                GranularUsageKind.Traces => "traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GranularUsageKind? ToEnum(string value)
        {
            return value switch
            {
                "langsmith_deployments" => GranularUsageKind.LangsmithDeployments,
                "traces" => GranularUsageKind.Traces,
                _ => null,
            };
        }
    }
}
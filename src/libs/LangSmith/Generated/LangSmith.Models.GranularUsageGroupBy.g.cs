
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Dimensions for grouping granular usage data.
    /// </summary>
    public enum GranularUsageGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GranularUsageGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GranularUsageGroupBy value)
        {
            return value switch
            {
                GranularUsageGroupBy.ApiKey => "api_key",
                GranularUsageGroupBy.Project => "project",
                GranularUsageGroupBy.User => "user",
                GranularUsageGroupBy.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GranularUsageGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => GranularUsageGroupBy.ApiKey,
                "project" => GranularUsageGroupBy.Project,
                "user" => GranularUsageGroupBy.User,
                "workspace" => GranularUsageGroupBy.Workspace,
                _ => null,
            };
        }
    }
}
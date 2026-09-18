
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: HOUR
    /// </summary>
    public enum GetSandboxesUsageCostsGranularity
    {
        /// <summary>
        ///
        /// </summary>
        Hour,
        /// <summary>
        ///
        /// </summary>
        Resource,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSandboxesUsageCostsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesUsageCostsGranularity value)
        {
            return value switch
            {
                GetSandboxesUsageCostsGranularity.Hour => "HOUR",
                GetSandboxesUsageCostsGranularity.Resource => "RESOURCE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesUsageCostsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "HOUR" => GetSandboxesUsageCostsGranularity.Hour,
                "RESOURCE" => GetSandboxesUsageCostsGranularity.Resource,
                _ => null,
            };
        }
    }
}
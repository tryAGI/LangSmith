
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesUsageCostResourceType
    {
        /// <summary>
        ///
        /// </summary>
        UsageCostResourceSandbox,
        /// <summary>
        ///
        /// </summary>
        UsageCostResourceSnapshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesUsageCostResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesUsageCostResourceType value)
        {
            return value switch
            {
                SandboxesUsageCostResourceType.UsageCostResourceSandbox => "SANDBOX",
                SandboxesUsageCostResourceType.UsageCostResourceSnapshot => "SNAPSHOT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesUsageCostResourceType? ToEnum(string value)
        {
            return value switch
            {
                "SANDBOX" => SandboxesUsageCostResourceType.UsageCostResourceSandbox,
                "SNAPSHOT" => SandboxesUsageCostResourceType.UsageCostResourceSnapshot,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSandboxesUsageCostsResourceType
    {
        /// <summary>
        ///
        /// </summary>
        Sandbox,
        /// <summary>
        ///
        /// </summary>
        Snapshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSandboxesUsageCostsResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesUsageCostsResourceType value)
        {
            return value switch
            {
                GetSandboxesUsageCostsResourceType.Sandbox => "SANDBOX",
                GetSandboxesUsageCostsResourceType.Snapshot => "SNAPSHOT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesUsageCostsResourceType? ToEnum(string value)
        {
            return value switch
            {
                "SANDBOX" => GetSandboxesUsageCostsResourceType.Sandbox,
                "SNAPSHOT" => GetSandboxesUsageCostsResourceType.Snapshot,
                _ => null,
            };
        }
    }
}
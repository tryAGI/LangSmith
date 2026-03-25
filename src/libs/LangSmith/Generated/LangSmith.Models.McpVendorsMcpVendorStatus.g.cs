
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpVendorsMcpVendorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        McpVendorStatusDisabled,
        /// <summary>
        /// 
        /// </summary>
        McpVendorStatusEnabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpVendorsMcpVendorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpVendorsMcpVendorStatus value)
        {
            return value switch
            {
                McpVendorsMcpVendorStatus.McpVendorStatusDisabled => "disabled",
                McpVendorsMcpVendorStatus.McpVendorStatusEnabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpVendorsMcpVendorStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => McpVendorsMcpVendorStatus.McpVendorStatusDisabled,
                "enabled" => McpVendorsMcpVendorStatus.McpVendorStatusEnabled,
                _ => null,
            };
        }
    }
}
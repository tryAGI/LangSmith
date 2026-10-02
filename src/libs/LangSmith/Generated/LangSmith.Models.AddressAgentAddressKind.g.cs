
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AddressAgentAddressKind
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddressAgentAddressKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddressAgentAddressKind value)
        {
            return value switch
            {
                AddressAgentAddressKind.Agent => "AGENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddressAgentAddressKind? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => AddressAgentAddressKind.Agent,
                _ => null,
            };
        }
    }
}
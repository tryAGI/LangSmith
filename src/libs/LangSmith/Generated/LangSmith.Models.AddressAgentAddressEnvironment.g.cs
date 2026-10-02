
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// `environment` is the Agent environment.<br/>
    /// Example: PRODUCTION
    /// </summary>
    public enum AddressAgentAddressEnvironment
    {
        /// <summary>
        ///
        /// </summary>
        Development,
        /// <summary>
        ///
        /// </summary>
        Local,
        /// <summary>
        ///
        /// </summary>
        Production,
        /// <summary>
        ///
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddressAgentAddressEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddressAgentAddressEnvironment value)
        {
            return value switch
            {
                AddressAgentAddressEnvironment.Development => "DEVELOPMENT",
                AddressAgentAddressEnvironment.Local => "LOCAL",
                AddressAgentAddressEnvironment.Production => "PRODUCTION",
                AddressAgentAddressEnvironment.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddressAgentAddressEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "DEVELOPMENT" => AddressAgentAddressEnvironment.Development,
                "LOCAL" => AddressAgentAddressEnvironment.Local,
                "PRODUCTION" => AddressAgentAddressEnvironment.Production,
                "STAGING" => AddressAgentAddressEnvironment.Staging,
                _ => null,
            };
        }
    }
}
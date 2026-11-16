
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentplatformAgentSourceType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSourceExternal,
        /// <summary>
        ///
        /// </summary>
        AgentSourceFleet,
        /// <summary>
        ///
        /// </summary>
        AgentSourceLSD,
        /// <summary>
        ///
        /// </summary>
        AgentSourceMDA,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentplatformAgentSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentplatformAgentSourceType value)
        {
            return value switch
            {
                AgentplatformAgentSourceType.AgentSourceExternal => "EXTERNAL",
                AgentplatformAgentSourceType.AgentSourceFleet => "FLEET",
                AgentplatformAgentSourceType.AgentSourceLSD => "LSD",
                AgentplatformAgentSourceType.AgentSourceMDA => "MDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentplatformAgentSourceType? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => AgentplatformAgentSourceType.AgentSourceExternal,
                "FLEET" => AgentplatformAgentSourceType.AgentSourceFleet,
                "LSD" => AgentplatformAgentSourceType.AgentSourceLSD,
                "MDA" => AgentplatformAgentSourceType.AgentSourceMDA,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentplatformAgentSourceType2
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
    public static class AgentplatformAgentSourceType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentplatformAgentSourceType2 value)
        {
            return value switch
            {
                AgentplatformAgentSourceType2.AgentSourceExternal => "EXTERNAL",
                AgentplatformAgentSourceType2.AgentSourceFleet => "FLEET",
                AgentplatformAgentSourceType2.AgentSourceLSD => "LSD",
                AgentplatformAgentSourceType2.AgentSourceMDA => "MDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentplatformAgentSourceType2? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => AgentplatformAgentSourceType2.AgentSourceExternal,
                "FLEET" => AgentplatformAgentSourceType2.AgentSourceFleet,
                "LSD" => AgentplatformAgentSourceType2.AgentSourceLSD,
                "MDA" => AgentplatformAgentSourceType2.AgentSourceMDA,
                _ => null,
            };
        }
    }
}
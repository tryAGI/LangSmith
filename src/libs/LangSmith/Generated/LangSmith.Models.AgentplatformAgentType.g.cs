
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentplatformAgentType
    {
        /// <summary>
        ///
        /// </summary>
        AgentTypeCoding,
        /// <summary>
        ///
        /// </summary>
        AgentTypeCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentplatformAgentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentplatformAgentType value)
        {
            return value switch
            {
                AgentplatformAgentType.AgentTypeCoding => "CODING",
                AgentplatformAgentType.AgentTypeCustom => "CUSTOM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentplatformAgentType? ToEnum(string value)
        {
            return value switch
            {
                "CODING" => AgentplatformAgentType.AgentTypeCoding,
                "CUSTOM" => AgentplatformAgentType.AgentTypeCustom,
                _ => null,
            };
        }
    }
}
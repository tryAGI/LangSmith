
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentplatformAgentEnvironmentName
    {
        /// <summary>
        ///
        /// </summary>
        EnvironmentDevelopment,
        /// <summary>
        ///
        /// </summary>
        EnvironmentLocal,
        /// <summary>
        ///
        /// </summary>
        EnvironmentProduction,
        /// <summary>
        ///
        /// </summary>
        EnvironmentStaging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentplatformAgentEnvironmentNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentplatformAgentEnvironmentName value)
        {
            return value switch
            {
                AgentplatformAgentEnvironmentName.EnvironmentDevelopment => "DEVELOPMENT",
                AgentplatformAgentEnvironmentName.EnvironmentLocal => "LOCAL",
                AgentplatformAgentEnvironmentName.EnvironmentProduction => "PRODUCTION",
                AgentplatformAgentEnvironmentName.EnvironmentStaging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentplatformAgentEnvironmentName? ToEnum(string value)
        {
            return value switch
            {
                "DEVELOPMENT" => AgentplatformAgentEnvironmentName.EnvironmentDevelopment,
                "LOCAL" => AgentplatformAgentEnvironmentName.EnvironmentLocal,
                "PRODUCTION" => AgentplatformAgentEnvironmentName.EnvironmentProduction,
                "STAGING" => AgentplatformAgentEnvironmentName.EnvironmentStaging,
                _ => null,
            };
        }
    }
}
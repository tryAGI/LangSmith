
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Kind is the protocol the endpoint speaks. Defaults to a2a.
    /// </summary>
    public enum AgentRedTeamTargetInputKind
    {
        /// <summary>
        ///
        /// </summary>
        A2a,
        /// <summary>
        ///
        /// </summary>
        Openapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRedTeamTargetInputKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRedTeamTargetInputKind value)
        {
            return value switch
            {
                AgentRedTeamTargetInputKind.A2a => "a2a",
                AgentRedTeamTargetInputKind.Openapi => "openapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRedTeamTargetInputKind? ToEnum(string value)
        {
            return value switch
            {
                "a2a" => AgentRedTeamTargetInputKind.A2a,
                "openapi" => AgentRedTeamTargetInputKind.Openapi,
                _ => null,
            };
        }
    }
}
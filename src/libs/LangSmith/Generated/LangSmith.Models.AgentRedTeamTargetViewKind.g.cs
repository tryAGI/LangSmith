
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Kind is the protocol the endpoint speaks: an A2A agent, or an HTTP API<br/>
    /// described by an OpenAPI spec.
    /// </summary>
    public enum AgentRedTeamTargetViewKind
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
    public static class AgentRedTeamTargetViewKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRedTeamTargetViewKind value)
        {
            return value switch
            {
                AgentRedTeamTargetViewKind.A2a => "a2a",
                AgentRedTeamTargetViewKind.Openapi => "openapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRedTeamTargetViewKind? ToEnum(string value)
        {
            return value switch
            {
                "a2a" => AgentRedTeamTargetViewKind.A2a,
                "openapi" => AgentRedTeamTargetViewKind.Openapi,
                _ => null,
            };
        }
    }
}
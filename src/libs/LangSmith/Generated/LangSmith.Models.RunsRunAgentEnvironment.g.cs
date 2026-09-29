
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Experimental. The Agent environment the run belongs to, case-insensitive;<br/>
    /// requires agent_id. Only workspaces enabled for Agent addressing accept it;<br/>
    /// others get a 403.
    /// </summary>
    public enum RunsRunAgentEnvironment
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
    public static class RunsRunAgentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsRunAgentEnvironment value)
        {
            return value switch
            {
                RunsRunAgentEnvironment.Development => "DEVELOPMENT",
                RunsRunAgentEnvironment.Local => "LOCAL",
                RunsRunAgentEnvironment.Production => "PRODUCTION",
                RunsRunAgentEnvironment.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsRunAgentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "DEVELOPMENT" => RunsRunAgentEnvironment.Development,
                "LOCAL" => RunsRunAgentEnvironment.Local,
                "PRODUCTION" => RunsRunAgentEnvironment.Production,
                "STAGING" => RunsRunAgentEnvironment.Staging,
                _ => null,
            };
        }
    }
}
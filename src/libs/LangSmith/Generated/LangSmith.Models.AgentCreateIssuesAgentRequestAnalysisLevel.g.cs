
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// AnalysisLevel is how thoroughly Engine monitors the project: "standard"<br/>
    /// (the default), "reduced" (fewer traces at lower cost), or "expanded" (more<br/>
    /// traces per run, for projects with enough tracing volume). Omit for<br/>
    /// "standard".
    /// </summary>
    public enum AgentCreateIssuesAgentRequestAnalysisLevel
    {
        /// <summary>
        ///
        /// </summary>
        Expanded,
        /// <summary>
        ///
        /// </summary>
        Reduced,
        /// <summary>
        /// "standard"
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCreateIssuesAgentRequestAnalysisLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateIssuesAgentRequestAnalysisLevel value)
        {
            return value switch
            {
                AgentCreateIssuesAgentRequestAnalysisLevel.Expanded => "expanded",
                AgentCreateIssuesAgentRequestAnalysisLevel.Reduced => "reduced",
                AgentCreateIssuesAgentRequestAnalysisLevel.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateIssuesAgentRequestAnalysisLevel? ToEnum(string value)
        {
            return value switch
            {
                "expanded" => AgentCreateIssuesAgentRequestAnalysisLevel.Expanded,
                "reduced" => AgentCreateIssuesAgentRequestAnalysisLevel.Reduced,
                "standard" => AgentCreateIssuesAgentRequestAnalysisLevel.Standard,
                _ => null,
            };
        }
    }
}
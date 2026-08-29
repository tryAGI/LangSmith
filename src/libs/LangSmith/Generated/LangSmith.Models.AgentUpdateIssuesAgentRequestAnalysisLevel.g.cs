
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// AnalysisLevel: "standard", "reduced", or "expanded". Switching to or from<br/>
    /// "reduced" also resets the scan cadence. nil = don't change.
    /// </summary>
    public enum AgentUpdateIssuesAgentRequestAnalysisLevel
    {
        /// <summary>
        /// "standard", "reduced", or "expanded". Switching to or from
        /// </summary>
        Expanded,
        /// <summary>
        /// "standard", "reduced", or "expanded". Switching to or from
        /// </summary>
        Reduced,
        /// <summary>
        /// "standard", "reduced", or "expanded". Switching to or from
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentUpdateIssuesAgentRequestAnalysisLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateIssuesAgentRequestAnalysisLevel value)
        {
            return value switch
            {
                AgentUpdateIssuesAgentRequestAnalysisLevel.Expanded => "expanded",
                AgentUpdateIssuesAgentRequestAnalysisLevel.Reduced => "reduced",
                AgentUpdateIssuesAgentRequestAnalysisLevel.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateIssuesAgentRequestAnalysisLevel? ToEnum(string value)
        {
            return value switch
            {
                "expanded" => AgentUpdateIssuesAgentRequestAnalysisLevel.Expanded,
                "reduced" => AgentUpdateIssuesAgentRequestAnalysisLevel.Reduced,
                "standard" => AgentUpdateIssuesAgentRequestAnalysisLevel.Standard,
                _ => null,
            };
        }
    }
}
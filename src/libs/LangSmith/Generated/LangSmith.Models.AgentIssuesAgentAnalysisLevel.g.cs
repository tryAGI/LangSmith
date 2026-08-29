
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// AnalysisLevel controls coverage vs cost: "standard" (default), "reduced"<br/>
    /// (one scan a day, fewer traces per scan), or "expanded" (2x traces per<br/>
    /// run). Stored NULL in the DB means standard; reads always return a<br/>
    /// concrete value.
    /// </summary>
    public enum AgentIssuesAgentAnalysisLevel
    {
        /// <summary>
        ///
        /// </summary>
        Expanded,
        /// <summary>
        /// "standard" (default), "reduced"
        /// </summary>
        Reduced,
        /// <summary>
        /// "standard" (default), "reduced"
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentIssuesAgentAnalysisLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentIssuesAgentAnalysisLevel value)
        {
            return value switch
            {
                AgentIssuesAgentAnalysisLevel.Expanded => "expanded",
                AgentIssuesAgentAnalysisLevel.Reduced => "reduced",
                AgentIssuesAgentAnalysisLevel.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentIssuesAgentAnalysisLevel? ToEnum(string value)
        {
            return value switch
            {
                "expanded" => AgentIssuesAgentAnalysisLevel.Expanded,
                "reduced" => AgentIssuesAgentAnalysisLevel.Reduced,
                "standard" => AgentIssuesAgentAnalysisLevel.Standard,
                _ => null,
            };
        }
    }
}
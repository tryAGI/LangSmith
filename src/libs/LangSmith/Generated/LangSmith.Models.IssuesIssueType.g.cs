
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// "actionable" (there is something to do; it may carry PRs or LangSmith<br/>
    /// assets) or "finding" (an observation only). Defaults to "actionable".
    /// </summary>
    public enum IssuesIssueType
    {
        /// <summary>
        ///
        /// </summary>
        Actionable,
        /// <summary>
        ///
        /// </summary>
        Finding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesIssueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesIssueType value)
        {
            return value switch
            {
                IssuesIssueType.Actionable => "actionable",
                IssuesIssueType.Finding => "finding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesIssueType? ToEnum(string value)
        {
            return value switch
            {
                "actionable" => IssuesIssueType.Actionable,
                "finding" => IssuesIssueType.Finding,
                _ => null,
            };
        }
    }
}
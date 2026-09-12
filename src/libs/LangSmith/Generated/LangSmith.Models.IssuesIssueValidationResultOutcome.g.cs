
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesIssueValidationResultOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Inconclusive,
        /// <summary>
        ///
        /// </summary>
        NotReproduced,
        /// <summary>
        ///
        /// </summary>
        Reproduced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesIssueValidationResultOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesIssueValidationResultOutcome value)
        {
            return value switch
            {
                IssuesIssueValidationResultOutcome.Error => "error",
                IssuesIssueValidationResultOutcome.Inconclusive => "inconclusive",
                IssuesIssueValidationResultOutcome.NotReproduced => "not_reproduced",
                IssuesIssueValidationResultOutcome.Reproduced => "reproduced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesIssueValidationResultOutcome? ToEnum(string value)
        {
            return value switch
            {
                "error" => IssuesIssueValidationResultOutcome.Error,
                "inconclusive" => IssuesIssueValidationResultOutcome.Inconclusive,
                "not_reproduced" => IssuesIssueValidationResultOutcome.NotReproduced,
                "reproduced" => IssuesIssueValidationResultOutcome.Reproduced,
                _ => null,
            };
        }
    }
}
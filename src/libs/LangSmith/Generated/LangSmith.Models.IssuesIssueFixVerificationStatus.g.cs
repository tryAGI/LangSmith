
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesIssueFixVerificationStatus
    {
        /// <summary>
        ///
        /// </summary>
        AwaitingPreview,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Inconclusive,
        /// <summary>
        ///
        /// </summary>
        Passed,
        /// <summary>
        ///
        /// </summary>
        Timeout,
        /// <summary>
        ///
        /// </summary>
        Verifying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesIssueFixVerificationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesIssueFixVerificationStatus value)
        {
            return value switch
            {
                IssuesIssueFixVerificationStatus.AwaitingPreview => "awaiting_preview",
                IssuesIssueFixVerificationStatus.Error => "error",
                IssuesIssueFixVerificationStatus.Failed => "failed",
                IssuesIssueFixVerificationStatus.Inconclusive => "inconclusive",
                IssuesIssueFixVerificationStatus.Passed => "passed",
                IssuesIssueFixVerificationStatus.Timeout => "timeout",
                IssuesIssueFixVerificationStatus.Verifying => "verifying",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesIssueFixVerificationStatus? ToEnum(string value)
        {
            return value switch
            {
                "awaiting_preview" => IssuesIssueFixVerificationStatus.AwaitingPreview,
                "error" => IssuesIssueFixVerificationStatus.Error,
                "failed" => IssuesIssueFixVerificationStatus.Failed,
                "inconclusive" => IssuesIssueFixVerificationStatus.Inconclusive,
                "passed" => IssuesIssueFixVerificationStatus.Passed,
                "timeout" => IssuesIssueFixVerificationStatus.Timeout,
                "verifying" => IssuesIssueFixVerificationStatus.Verifying,
                _ => null,
            };
        }
    }
}
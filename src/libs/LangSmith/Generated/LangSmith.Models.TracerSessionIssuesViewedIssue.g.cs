
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionIssuesViewedIssue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_id")]
        public string? IssueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewed_at")]
        public string? ViewedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesViewedIssue" /> class.
        /// </summary>
        /// <param name="issueId"></param>
        /// <param name="viewedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesViewedIssue(
            string? issueId,
            string? viewedAt)
        {
            this.IssueId = issueId;
            this.ViewedAt = viewedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesViewedIssue" /> class.
        /// </summary>
        public TracerSessionIssuesViewedIssue()
        {
        }

    }
}
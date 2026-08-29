
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesLinearSync
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_id")]
        public string? IssueId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_attempted_at")]
        public global::System.DateTime? LastAttemptedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        public string? LastError { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_synced_at")]
        public global::System.DateTime? LastSyncedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linear_issue_id")]
        public string? LinearIssueId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.IssuesLinearSyncStateJsonConverter))]
        public global::LangSmith.IssuesLinearSyncState? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesLinearSync" /> class.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="issueId"></param>
        /// <param name="lastAttemptedAt"></param>
        /// <param name="lastError"></param>
        /// <param name="lastSyncedAt"></param>
        /// <param name="linearIssueId"></param>
        /// <param name="state"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesLinearSync(
            string? identifier,
            string? issueId,
            global::System.DateTime? lastAttemptedAt,
            string? lastError,
            global::System.DateTime? lastSyncedAt,
            string? linearIssueId,
            global::LangSmith.IssuesLinearSyncState? state,
            string? url)
        {
            this.Identifier = identifier;
            this.IssueId = issueId;
            this.LastAttemptedAt = lastAttemptedAt;
            this.LastError = lastError;
            this.LastSyncedAt = lastSyncedAt;
            this.LinearIssueId = linearIssueId;
            this.State = state;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesLinearSync" /> class.
        /// </summary>
        public IssuesLinearSync()
        {
        }

    }
}
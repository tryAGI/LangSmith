
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionIssuesFixVerification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        public int? Attempt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_sha")]
        public string? CommitSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deadline_at")]
        public string? DeadlineAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public object? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix_branch")]
        public string? FixBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_id")]
        public string? IssueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pr_number")]
        public int? PrNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready_check")]
        public string? ReadyCheck { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesFixVerification" /> class.
        /// </summary>
        /// <param name="attempt"></param>
        /// <param name="commitSha"></param>
        /// <param name="createdAt"></param>
        /// <param name="deadlineAt"></param>
        /// <param name="detail"></param>
        /// <param name="fixBranch"></param>
        /// <param name="id"></param>
        /// <param name="issueId"></param>
        /// <param name="prNumber"></param>
        /// <param name="previewUrl"></param>
        /// <param name="readyCheck"></param>
        /// <param name="runId"></param>
        /// <param name="sessionId"></param>
        /// <param name="status"></param>
        /// <param name="tenantId"></param>
        /// <param name="threadId"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesFixVerification(
            int? attempt,
            string? commitSha,
            string? createdAt,
            string? deadlineAt,
            object? detail,
            string? fixBranch,
            string? id,
            string? issueId,
            int? prNumber,
            string? previewUrl,
            string? readyCheck,
            string? runId,
            string? sessionId,
            string? status,
            string? tenantId,
            string? threadId,
            string? updatedAt)
        {
            this.Attempt = attempt;
            this.CommitSha = commitSha;
            this.CreatedAt = createdAt;
            this.DeadlineAt = deadlineAt;
            this.Detail = detail;
            this.FixBranch = fixBranch;
            this.Id = id;
            this.IssueId = issueId;
            this.PrNumber = prNumber;
            this.PreviewUrl = previewUrl;
            this.ReadyCheck = readyCheck;
            this.RunId = runId;
            this.SessionId = sessionId;
            this.Status = status;
            this.TenantId = tenantId;
            this.ThreadId = threadId;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesFixVerification" /> class.
        /// </summary>
        public TracerSessionIssuesFixVerification()
        {
        }

    }
}

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionIssuesIssue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public object? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen_at")]
        public string? FirstSeenAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix_branch")]
        public string? FixBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix_dispatched_at")]
        public string? FixDispatchedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix_pr_number")]
        public int? FixPrNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix_prompt")]
        public string? FixPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen_at")]
        public string? LastSeenAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proposed_context_fixes")]
        public global::System.Collections.Generic.IList<object>? ProposedContextFixes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proposed_examples")]
        public global::System.Collections.Generic.IList<object>? ProposedExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proposed_fix")]
        public string? ProposedFix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proposed_prompt_fixes")]
        public global::System.Collections.Generic.IList<object>? ProposedPromptFixes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        public int? Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.TracerSessionIssuesStatusJsonConverter))]
        public global::LangSmith.TracerSessionIssuesStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        public object? Traces { get; set; }

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
        /// Initializes a new instance of the <see cref="TracerSessionIssuesIssue" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="firstSeenAt"></param>
        /// <param name="fixBranch"></param>
        /// <param name="fixDispatchedAt"></param>
        /// <param name="fixPrNumber"></param>
        /// <param name="fixPrompt"></param>
        /// <param name="id"></param>
        /// <param name="lastSeenAt"></param>
        /// <param name="name"></param>
        /// <param name="proposedContextFixes"></param>
        /// <param name="proposedExamples"></param>
        /// <param name="proposedFix"></param>
        /// <param name="proposedPromptFixes"></param>
        /// <param name="sessionId"></param>
        /// <param name="severity"></param>
        /// <param name="status"></param>
        /// <param name="tags"></param>
        /// <param name="tenantId"></param>
        /// <param name="traces"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesIssue(
            object? actions,
            string? createdAt,
            string? description,
            string? firstSeenAt,
            string? fixBranch,
            string? fixDispatchedAt,
            int? fixPrNumber,
            string? fixPrompt,
            string? id,
            string? lastSeenAt,
            string? name,
            global::System.Collections.Generic.IList<object>? proposedContextFixes,
            global::System.Collections.Generic.IList<object>? proposedExamples,
            string? proposedFix,
            global::System.Collections.Generic.IList<object>? proposedPromptFixes,
            string? sessionId,
            int? severity,
            global::LangSmith.TracerSessionIssuesStatus? status,
            global::System.Collections.Generic.IList<string>? tags,
            string? tenantId,
            object? traces,
            string? updatedAt)
        {
            this.Actions = actions;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.FirstSeenAt = firstSeenAt;
            this.FixBranch = fixBranch;
            this.FixDispatchedAt = fixDispatchedAt;
            this.FixPrNumber = fixPrNumber;
            this.FixPrompt = fixPrompt;
            this.Id = id;
            this.LastSeenAt = lastSeenAt;
            this.Name = name;
            this.ProposedContextFixes = proposedContextFixes;
            this.ProposedExamples = proposedExamples;
            this.ProposedFix = proposedFix;
            this.ProposedPromptFixes = proposedPromptFixes;
            this.SessionId = sessionId;
            this.Severity = severity;
            this.Status = status;
            this.Tags = tags;
            this.TenantId = tenantId;
            this.Traces = traces;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesIssue" /> class.
        /// </summary>
        public TracerSessionIssuesIssue()
        {
        }

    }
}
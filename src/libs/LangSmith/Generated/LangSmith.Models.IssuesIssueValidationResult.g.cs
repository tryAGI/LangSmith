
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesIssueValidationResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_revision_id")]
        public global::System.Guid? ActiveRevisionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        public global::System.Guid? DeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.IssuesIssueValidationResultOutcomeJsonConverter))]
        public global::LangSmith.IssuesIssueValidationResultOutcome? Outcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_trace_ids")]
        public global::System.Collections.Generic.IList<string>? RootTraceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesIssueValidationResult" /> class.
        /// </summary>
        /// <param name="activeRevisionId"></param>
        /// <param name="completedAt"></param>
        /// <param name="deploymentId"></param>
        /// <param name="outcome"></param>
        /// <param name="reason"></param>
        /// <param name="rootTraceIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesIssueValidationResult(
            global::System.Guid? activeRevisionId,
            global::System.DateTime? completedAt,
            global::System.Guid? deploymentId,
            global::LangSmith.IssuesIssueValidationResultOutcome? outcome,
            string? reason,
            global::System.Collections.Generic.IList<string>? rootTraceIds)
        {
            this.ActiveRevisionId = activeRevisionId;
            this.CompletedAt = completedAt;
            this.DeploymentId = deploymentId;
            this.Outcome = outcome;
            this.Reason = reason;
            this.RootTraceIds = rootTraceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesIssueValidationResult" /> class.
        /// </summary>
        public IssuesIssueValidationResult()
        {
        }

    }
}
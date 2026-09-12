
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesIssueFixVerification
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        public int? Attempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_deployment_id")]
        public global::System.Guid? ParentDeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_deployment_id")]
        public global::System.Guid? PreviewDeploymentId { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.IssuesIssueFixVerificationStatusJsonConverter))]
        public global::LangSmith.IssuesIssueFixVerificationStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesIssueFixVerification" /> class.
        /// </summary>
        /// <param name="attempt"></param>
        /// <param name="parentDeploymentId"></param>
        /// <param name="previewDeploymentId"></param>
        /// <param name="reason"></param>
        /// <param name="rootTraceIds"></param>
        /// <param name="status"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesIssueFixVerification(
            int? attempt,
            global::System.Guid? parentDeploymentId,
            global::System.Guid? previewDeploymentId,
            string? reason,
            global::System.Collections.Generic.IList<string>? rootTraceIds,
            global::LangSmith.IssuesIssueFixVerificationStatus? status,
            global::System.DateTime? updatedAt)
        {
            this.Attempt = attempt;
            this.ParentDeploymentId = parentDeploymentId;
            this.PreviewDeploymentId = previewDeploymentId;
            this.Reason = reason;
            this.RootTraceIds = rootTraceIds;
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesIssueFixVerification" /> class.
        /// </summary>
        public IssuesIssueFixVerification()
        {
        }

    }
}

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Add a single run to AQ (CH path) with an optional back-pointer to the<br/>
    /// issues-agent proposal that seeded this add. Use when bulk-adding runs<br/>
    /// that come from different proposals — each row carries its own<br/>
    /// source_proposed_example_id. For unrelated bulk adds, prefer plain<br/>
    /// List[UUID] on the same endpoint.
    /// </summary>
    public sealed partial class AddRunToQueueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_proposed_example_id")]
        public global::System.Guid? SourceProposedExampleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRunToQueueRequest" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="sourceProposedExampleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddRunToQueueRequest(
            global::System.Guid runId,
            global::System.Guid? sourceProposedExampleId)
        {
            this.RunId = runId;
            this.SourceProposedExampleId = sourceProposedExampleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRunToQueueRequest" /> class.
        /// </summary>
        public AddRunToQueueRequest()
        {
        }
    }
}